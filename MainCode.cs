//Quiz_Application (in Turkish)
//I made this little quiz app because I'm a newbie coder. Here's my code, feel free to use it for personal purposes.
//Variables and texts are in Turkish but don't worry I have added English explanations next to them. Have fun coding!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //soruno means "number of questions"
        //dogru means "correct"
        //yanlis means "incorrect" 
        int soruno = 0, dogru = 0, yanlis = 0;
        private void buttonD_Click(object sender, EventArgs e)
        {
            if (soruno == 1)
            {
                pictureBox1.Visible = true;  //Speaking of pictureboxes, I have downloaded 2 gifs and added them to the pictureboxes so either of them plays according to user's answer.
                dogru++; //An integer and '++' means add one to the referring variable.
                labelDogru.Text = dogru.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 2)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 3)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 4)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 5)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
        
    }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (soruno == 1)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 2)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 3)
            {
                pictureBox1.Visible = true;
                dogru++;
                labelDogru.Text = dogru.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 4)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 5)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if (soruno == 1)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 2)
            {
                pictureBox1.Visible = true;
                labelDogru.Text = dogru.ToString();
                dogru++;
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 3)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 4)
            {
                pictureBox2.Visible = true;
                dogru++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 5)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (soruno == 1)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 2)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 3)
            {
                pictureBox2.Visible = true;
                yanlis++;
                labelYanlis.Text = yanlis.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 4)
            {
                pictureBox1.Visible = true;
                dogru++;
                labelDogru.Text = dogru.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
            if (soruno == 5)
            {
                pictureBox1.Visible = true;
                dogru++;
                labelDogru.Text = dogru.ToString();
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
        }
        private void buttonIlerle_Click(object sender, EventArgs e)
        {
            soruno++;
            labelSoru.Text = soruno.ToString();
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            
            //Those are questions and the options. Feel free to change them to your own.

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edildi?";
                buttonA.Text = "1920";
                buttonB.Text = "1921";
                buttonC.Text = "1922";
                buttonD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgesinde değildir?";
                buttonA.Text = "İzmir";
                buttonB.Text = "Balıkesir";
                buttonC.Text = "Aydın";
                buttonD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazara aittir?";
                buttonA.Text = "Sait Faik";
                buttonB.Text = "Cemal Süreya";
                buttonC.Text = "Attila İlhan";
                buttonD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Bogota hangi ülkenin başkentidir?";
                buttonA.Text = "Meksika";
                buttonB.Text = "Küba";
                buttonC.Text = "Kolombiya";
                buttonD.Text = "Finlandiya";
                label4.Text = "Kolombiya";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Atatürk hangi yılda doğmuştur?";
                buttonA.Text = "2012";
                buttonB.Text = "1954";
                buttonC.Text = "1881";
                buttonD.Text = "1453";
            }
            if (soruno >= 6 )
            {
                soruno = 5;
                labelSoru.Text = soruno.ToString();
                richTextBox1.Text = "Testi tamamladınız! Teşekkür ederiz."; //This one's saying "You've completed the test. Thank you."
                buttonA.Text = "";
                buttonB.Text = "";
                buttonC.Text = "";
                buttonD.Text = "";
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
            }

        }
    }
}


