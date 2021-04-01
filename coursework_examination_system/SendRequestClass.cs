using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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

        private static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static async Task<string> Upload(String method, String id, System.Drawing.Image image)
        {
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, LoadSystem().server + method + ".php?" + id);
            var content = new MultipartFormDataContent();

            byte[] byteArray = ImageToByteArray(image);
            content.Add(new ByteArrayContent(byteArray), "file", "file.jpg");
            request.Content = content;
            Console.WriteLine("Запрос с картинкой отправляется");
            var response = client.SendAsync(request).Result;
            response.EnsureSuccessStatusCode();
            string res = await response.Content.ReadAsStringAsync(); ;
            Console.WriteLine(res);
            return res;
        }

    }
}
