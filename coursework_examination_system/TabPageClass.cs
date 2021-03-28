using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework_examination_system
{
    class TabPageClass : TabPage
    {
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox textBox9;
        public System.Windows.Forms.TextBox textBox10;
        public System.Windows.Forms.CheckBox checkBox7;
        public System.Windows.Forms.CheckBox checkBox8;
        public System.Windows.Forms.CheckBox checkBox9;
        public System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.CheckBox checkBox4;
        public System.Windows.Forms.CheckBox checkBox5;
        public System.Windows.Forms.CheckBox checkBox6;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.CheckBox checkBox3;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public String filePath = "";
        public TextBox textBoxQuestion = new TextBox();
        public bool textBoxCreate = false;
        public PictureBox pictureBox = new PictureBox();

        public List<ObjectAnswersClass> objectAnswers = new List<ObjectAnswersClass>();

        public TabPageClass(ConstructorTestForm constr)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConstructorTestForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(5, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(/*190*/613, 225);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вопрос";
            this.groupBox2.BackColor = Color.White;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Controls.Add(this.checkBox9);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Варианты ответов";
            this.groupBox3.BackColor = Color.White;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 123);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(28, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 7;
            this.textBox4.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(216, 123);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(216, 74);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(216, 20);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(237, 120);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(144, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(237, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 20);
            this.textBox6.TabIndex = 12;
            this.textBox6.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(237, 17);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.Visible = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(421, 123);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Visible = false;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(421, 74);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Visible = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(421, 20);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 16;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(442, 120);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(144, 20);
            this.textBox10.TabIndex = 17;
            this.textBox10.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(442, 71);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(144, 20);
            this.textBox9.TabIndex = 18;
            this.textBox9.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(442, 17);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(144, 20);
            this.textBox8.TabIndex = 19;
            this.textBox8.Visible = false;
            // 
            // button7
            // 
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button7.Location = new System.Drawing.Point(179, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 20);
            this.button7.TabIndex = 20;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button8.Location = new System.Drawing.Point(178, 71);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 20);
            this.button8.TabIndex = 21;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button9.Location = new System.Drawing.Point(178, 120);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(21, 20);
            this.button9.TabIndex = 22;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // button10
            // 
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button10.Location = new System.Drawing.Point(387, 17);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(21, 20);
            this.button10.TabIndex = 23;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // button11
            // 
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button11.Location = new System.Drawing.Point(387, 71);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(21, 20);
            this.button11.TabIndex = 24;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Visible = false;
            this.button11.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // button12
            // 
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button12.Location = new System.Drawing.Point(387, 120);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(21, 20);
            this.button12.TabIndex = 25;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // button13
            // 
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button13.Location = new System.Drawing.Point(591, 17);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(21, 20);
            this.button13.TabIndex = 26;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Visible = false;
            this.button13.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // button14
            // 
            this.button14.Image = ((System.Drawing.Image)(resources.GetObject("button14.Image")));
            this.button14.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button14.Location = new System.Drawing.Point(591, 71);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(21, 20);
            this.button14.TabIndex = 27;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Visible = false;
            this.button14.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // button15
            // 
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.BackgroundImage = Image.FromFile("../../resources/delete.png");
            this.button15.Location = new System.Drawing.Point(591, 120);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(21, 20);
            this.button15.TabIndex = 28;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Visible = false;
            this.button15.Click += new System.EventHandler(constr.deleteButton_Click);
            // 
            // ConstructorTestForm
            // 
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox3);

            this.BackColor = Color.White;
            reloadElementAnswer();
        }

        private void reloadElementAnswer()
        {
            ObjectAnswersClass objectA = new ObjectAnswersClass();
            //////////////////////1//////////////////////////
            objectA.checkBox = checkBox1;
            objectA.textBox = textBox2;
            objectA.delButton = button7;
            objectAnswers.Add(objectA);
            //////////////////////2//////////////////////////
            objectA = new ObjectAnswersClass();
            objectA.checkBox = checkBox2;
            objectA.textBox = textBox3;
            objectA.delButton = button8;
            objectAnswers.Add(objectA);
            //////////////////////3//////////////////////////
            objectA = new ObjectAnswersClass();
            objectA.checkBox = checkBox3;
            objectA.textBox = textBox4;
            objectA.delButton = button9;
            objectAnswers.Add(objectA);
            ///////////////////////4/////////////////////////
            objectA = new ObjectAnswersClass();
            objectA.checkBox = checkBox4;
            objectA.textBox = textBox5;
            objectA.delButton = button10;
            objectAnswers.Add(objectA);
            ///////////////////////5/////////////////////////
            objectA = new ObjectAnswersClass();
            objectA.checkBox = checkBox5;
            objectA.textBox = textBox6;
            objectA.delButton = button11;
            objectAnswers.Add(objectA);
            ///////////////////////6/////////////////////////
            objectA = new ObjectAnswersClass();
            objectA.checkBox = checkBox6;
            objectA.textBox = textBox7;
            objectA.delButton = button12;
            objectAnswers.Add(objectA);
            ///////////////////////7/////////////////////////
            objectA = new ObjectAnswersClass();
            objectA.checkBox = checkBox7;
            objectA.textBox = textBox8;
            objectA.delButton = button13;
            objectAnswers.Add(objectA);
            ///////////////////////8/////////////////////////
            objectA = new ObjectAnswersClass();
            objectA.checkBox = checkBox8;
            objectA.textBox = textBox9;
            objectA.delButton = button14;
            objectAnswers.Add(objectA);
            ///////////////////////9/////////////////////////
            objectA = new ObjectAnswersClass();
            objectA.checkBox = checkBox9;
            objectA.textBox = textBox10;
            objectA.delButton = button15;
            objectAnswers.Add(objectA);
        }

        public bool isValidTab()
        {
            if (textBox2.Visible && textBox2.Text.Trim().Length == 0)
            {
                return false;
            }
            if (textBox3.Visible && textBox3.Text.Trim().Length == 0)
            {
                return false;
            }
            if (textBox4.Visible && textBox4.Text.Trim().Length == 0)
            {
                return false;
            }
            if (textBox5.Visible && textBox5.Text.Trim().Length == 0)
            {
                return false;
            }
            if (textBox6.Visible && textBox6.Text.Trim().Length == 0)
            {
                return false;
            }
            if (textBox7.Visible && textBox7.Text.Trim().Length == 0)
            {
                return false;
            }
            if (textBox8.Visible && textBox8.Text.Trim().Length == 0)
            {
                return false;
            }
            if (textBox9.Visible && textBox9.Text.Trim().Length == 0)
            {
                return false;
            }
            if (textBox10.Visible && textBox10.Text.Trim().Length == 0)
            {
                return false;
            }
            if(filePath.Length==0 && textBoxQuestion.Text.Trim().Length == 0)
            {
                return false;
            }
            foreach (Control control in groupBox3.Controls)
            {
                if(control is CheckBox && ((CheckBox)control).Checked)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
