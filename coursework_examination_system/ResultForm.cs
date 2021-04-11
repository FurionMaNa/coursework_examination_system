using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_examination_system
{
    public partial class ResultForm : Form
    {

        public List<ResultClass> resultClasses = new List<ResultClass>();

        public ResultForm()
        {
            InitializeComponent();
            Column1.Width = this.Width / 2 - 160;
            Column2.Width = this.Width / 2 - 160;
            Column3.Width = 80;
            Column4.Width = 50;
            Column5.Width = 130;
            Form1.refresEventClass.eventsResult += new RefreshClass.EventRefreshResultHandler(loadResult);
            loadResult(this, new EventArgs());
        }

        private void loadResult(object source, EventArgs eventArg)
        {
            try
            {
                String response = SendRequestClass.PostRequestAsync("getResult", "").Result;
                resultClasses = JsonConvert.DeserializeObject<List<ResultClass>>(response);
                do
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        try
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dataGridView1.Rows.Count > 1);
                resultClasses.ForEach(delegate (ResultClass r)
                {
                    int rowNumber = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowNumber].Cells["Column1"].Value = r.userName;
                    dataGridView1.Rows[rowNumber].Cells["Column2"].Value = r.examTopic;
                    dataGridView1.Rows[rowNumber].Cells["Column3"].Value = r.score;
                    dataGridView1.Rows[rowNumber].Cells["Column4"].Value = r.mark;
                    dataGridView1.Rows[rowNumber].Cells["Column5"].Value = r.dateT;
                });
            }
            catch (Exception e)
            {
                MessageBox.Show("Проверьте соединение с интернетом!", "Ошибка соединения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResultForm_Resize(object sender, EventArgs e)
        {
            if (this.Width < 776)
            {
                this.Width = 776;
            }
            if (this.Height < 476)
            {
                this.Height = 476;
            }
            Column1.Width = this.Width / 2 - 160;
            Column2.Width = this.Width / 2 - 160;
            Column3.Width = 80;
            Column4.Width = 50;
            Column5.Width = 130;
        }
    }
}
