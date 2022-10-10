using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asansör_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        Point nesne = new Point();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a<b)
            {
                b--;
                if (b == a)
                {
                    timer1.Stop();
                }
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 40);
            }
            else if (a>b)
            {
                b++;
                if (b == a)
                {
                    timer1.Stop();
                    
                }
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 40);
            }
            if (b==-1)
            {
                button7.BackColor = Color.Green;
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
            }
            else if (b==0)
            {
                button7.BackColor = Color.Silver;
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Green;
            }
            else if (b == 1)
            {
                button7.BackColor = Color.Silver;
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Green;
                button6.BackColor = Color.Silver;
            }
            else if (b == 2)
            {
                button7.BackColor = Color.Silver;
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;
                button4.BackColor = Color.Green;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
            }
            else if (b == 3)
            {
                button7.BackColor = Color.Silver;
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Green;
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
            }
            else if (b == 4)
            {
                button7.BackColor = Color.Silver;
                button1.BackColor = Color.Silver;
                button2.BackColor = Color.Green;
                button3.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
            }
            else if (b == 5)
            {
                button7.BackColor = Color.Silver;
                button1.BackColor = Color.Green;
                button2.BackColor = Color.Silver;
                button3.BackColor = Color.Silver;
                button4.BackColor = Color.Silver;
                button5.BackColor = Color.Silver;
                button6.BackColor = Color.Silver;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(comboBox1.Text);
            timer1.Start();
        }
    }
}
