using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {

                // read the radius from text box
                double SphereRadius = double.Parse(textBox1.Text);
                // calculate the area and circumfrence
                double SphereArea = SphereRadius * Math.PI;
                double SphereVolume = 4 / 3 * Math.PI * SphereRadius * SphereRadius * SphereRadius;
                label2.Text = "Surface area = " + SphereArea;
                label3.Text = " Volume = " + SphereVolume;
            }
            catch
            {
                MessageBox.Show("Error Sphere");
            }






        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
          try
            {
                //Reads what text is in the force and angle textboxes
                double Height = double.Parse(textBox2.Text);
                //
                double Volume = Height  * Height * Height;
                double SurfaceArea = 2 * (Height  * Height  + Height * Height  + Height * Height);
                //
                label4.Text = "Volume = " + Volume;
                label5.Text = "Surface Area ="  + SurfaceArea;
            } 
            catch
            {
                MessageBox.Show("your numbers are wrong, check again");

            }


        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)

        {
            try
            {
                //Reads what text is in the force and angle textboxes
                double Height = double.Parse(textBox3.Text);
                double Lentgh = double.Parse(textBox4.Text);
                double Width  = double.Parse(textBox5.Text);
                //
                double Volume = Width * Lentgh * Height;
                double SurfaceArea = 2 * (Width * Lentgh + Height * Lentgh + Height * Width);
                //
                label6.Text = "Volume = " + Volume;
                label7.Text = "Surface Area =" + SurfaceArea;
            }
            catch
            {
                MessageBox.Show("your numbers are wrong, check again");
            }

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }
    }

}
