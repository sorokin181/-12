using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кликер_2
{
    public partial class Form1 : Form
    {

        public int money = 0;
        public int upgred = 10;
        public int multi = 1;
        public int count = 0;
        public int plus = 1;
        public Form1()
        {
            InitializeComponent();
            
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == 0x201)
            {
                base.Capture = false;
                message = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            }
            base.WndProc(ref message);
        }

        private Cursor cur;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = new Cursor(@"C:\Users\Lenovo\Desktop\проэкты\Кликер 2\фотки\курсоры\axe.Cur");

            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            label1.Visible = false;

            
            //this.BackgroundImage = Properties.Resources.старт1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money += multi;
            button3.Text = $"      Очки: {money} ";

            //label4.Visible = true;

            Random rnd = new Random();
            int a = rnd.Next();

            label1.Visible = true;
            label1.Left = rnd.Next(button1.Width, 550) - button1.Width;
            label1.Top = rnd.Next(button1.Height, 500) - button1.Height;

            button1.Cursor = new Cursor(@"C:\Users\Lenovo\Desktop\проэкты\Кликер 2\фотки\курсоры\axe.Cur");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money >= upgred)
            {
                money -= upgred;
                button3.Text = $"      Очки: {money}";
                multi++;
                upgred = upgred * 2;
                button4.Text = $"Стоимость \n улутшеня: {upgred}";
                count++;
                button5.Text = $"количество \n улучшений: {count}";
                plus++;
                label1.Text = $"+{Convert.ToString(plus)}";
                
            }

            if (count >= 2)
            {
                BackgroundImage = Image.FromFile("C:\\Users\\Lenovo\\Desktop\\проэкты\\Кликер 2\\Кликер 2\\Resources\\горы1.png");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Image.FromFile("C:\\Users\\Lenovo\\Desktop\\проэкты\\Кликер 2\\Кликер 2\\Resources\\дерево2.1.png");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Image.FromFile("C:\\Users\\Lenovo\\Desktop\\проэкты\\Кликер 2\\Кликер 2\\Resources\\дерево2.png");
        }

        private void button1_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Cursor = new Cursor(@"C:\Users\Lenovo\Desktop\проэкты\Кликер 2\фотки\курсоры\axe.Cur");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool x = true;
        private void button7_Click(object sender, EventArgs e)
        {
            
                if (x == true) 
                {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
                x = false;
                }
                else 
                {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                x = true;
                }
  
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }
    }
}
