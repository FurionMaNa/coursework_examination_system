using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    class SendRequestClass
    {

        public static SystemClass LoadSystem()
        {
            using (StreamReader r = new StreamReader("../../resources/system.json"))
            {
                string json = r.ReadToEnd();
                SystemClass system = JsonConvert.DeserializeObject<SystemClass>(json);
                return system;
            }
        }

        public class SystemClass
        {
            public String server;
        }

        public static async Task<String> PostRequestAsync(String method, String data)
        {
            WebRequest request = WebRequest.Create(LoadSystem().server+method+".php");
            request.Method = "POST"; 
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;

            using (Stream dataStream = request.GetRequestStream())
            {
                Console.WriteLine("Запрос отправляется");
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            Console.WriteLine("Запрос отправлен");
            String responseReturn;
            WebResponse response = await request.GetResponseAsync().ConfigureAwait(false);
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    responseReturn  = reader.ReadToEnd();
                }
            }
            response.Close();
            Console.WriteLine(responseReturn);
            return responseReturn;
        }

    }
}
