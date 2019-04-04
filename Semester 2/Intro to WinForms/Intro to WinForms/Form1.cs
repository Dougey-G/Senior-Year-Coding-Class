using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_to_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button_DoSomething.MouseLeave += (o, e) => ChangeColor(Color.Red);
            Button_DoSomething.MouseEnter += (o, e) => ChangeColor(Color.RoyalBlue);
        }

        public void ChangeColor(Color c)
        {
            Button_DoSomething.BackColor = c;
        }

        private void Button_DoSomething_Click(object sender, EventArgs e)
        {
            if(CheckBox_FailSafe.Checked && DateTime_Picker.Value < DateTime.Now)
            {
                Environment.Exit(0);
            }
            if (CheckforMarioMaker2Hype.Checked)
            {
                Bitmap b = new Bitmap(PictureBox.Width, PictureBox.Height);
                Random rand = new Random();

                for (int x = 0; x < PictureBox.Width; x++)
                {
                    for (int y = 0; y < PictureBox.Height; y++)
                    {
                        b.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.Red : Color.SkyBlue);
                    }
                }
                PictureBox.Image = b;
            }

            //else
            //{
            //    Bitmap b = new Bitmap(PictureBox.Width, PictureBox.Height);
            //    Random rand = new Random();

            //    for (int x = 0; x < PictureBox.Width; x++)
            //    {
            //        for (int y = 0; y < PictureBox.Height; y++)
            //        {
            //            b.SetPixel(x, y, rand.Next(0, 2) == 0 ? Color.Plum : Color.SkyBlue);
            //        }
            //    }
            //    PictureBox.Image = b;
            //}
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBox.Text == "All toasters toast toast")
            {
                Environment.Exit(0);
            }
        }


    }
}
