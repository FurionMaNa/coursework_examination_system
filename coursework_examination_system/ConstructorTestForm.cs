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
    public partial class ConstructorTestForm : Form
    {

        struct objectAnswer
        {
            public CheckBox checkBox;
            public TextBox textBox;
            public Button delButton;
        }

        private List<objectAnswer> objectAnswers = new List<objectAnswer>();

        public ConstructorTestForm()
        {
            InitializeComponent();
            objectAnswer objectA;
            //////////////////////1//////////////////////////
            objectA.checkBox = checkBox1;
            objectA.textBox = textBox2;
            objectA.delButton = button7;
            objectAnswers.Add(objectA);
            //////////////////////2//////////////////////////
            objectA.checkBox = checkBox2;
            objectA.textBox = textBox3;
            objectA.delButton = button8;
            objectAnswers.Add(objectA);
            //////////////////////3//////////////////////////
            objectA.checkBox = checkBox3;
            objectA.textBox = textBox4;
            objectA.delButton = button9;
            objectAnswers.Add(objectA);
            ///////////////////////4/////////////////////////
            objectA.checkBox = checkBox4;
            objectA.textBox = textBox5;
            objectA.delButton = button10;
            objectAnswers.Add(objectA);
            ///////////////////////5/////////////////////////
            objectA.checkBox = checkBox5;
            objectA.textBox = textBox6;
            objectA.delButton = button11;
            objectAnswers.Add(objectA);
            ///////////////////////6/////////////////////////
            objectA.checkBox = checkBox6;
            objectA.textBox = textBox7;
            objectA.delButton = button12;
            objectAnswers.Add(objectA);
            ///////////////////////7/////////////////////////
            objectA.checkBox = checkBox7;
            objectA.textBox = textBox8;
            objectA.delButton = button13;
            objectAnswers.Add(objectA);
            ///////////////////////8/////////////////////////
            objectA.checkBox = checkBox8;
            objectA.textBox = textBox9;
            objectA.delButton = button14;
            objectAnswers.Add(objectA);
            ///////////////////////9/////////////////////////
            objectA.checkBox = checkBox9;
            objectA.textBox = textBox10;
            objectA.delButton = button15;
            objectAnswers.Add(objectA);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objectAnswers.Count; i++)
            {
                if (!objectAnswers[i].checkBox.Visible)
                {
                    objectAnswers[i].checkBox.Visible = true;
                    objectAnswers[i].textBox.Visible = true;
                    objectAnswers[i].delButton.Visible = true;
                    break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private objectAnswer findBlock(String nameButton)
        {
            objectAnswer resultObject = new objectAnswer();
            objectAnswers.ForEach(delegate (objectAnswer objectA)
            {
                if (objectA.delButton.Name.Equals(nameButton))
                {
                    resultObject = objectA;
                }
            });
            return resultObject;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                objectAnswer answer = findBlock(button.Name);
                answer.checkBox.Visible = false;
                answer.textBox.Visible = false;
                answer.delButton.Visible = false;
            } 
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
