using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba1
{
    public partial class Form2 : Form
    {
        private bool mouseOnImage = false;
        private int margin = 10;
        private bool followMouse = false;
        public Form2()
        {
            InitializeComponent();
            button1.Text = "+1";

            button1.Click += PlusButton_Click;

            pictureBox1.Image = Image.FromFile("C:\\Users\\LOQ\\Desktop\\Работе время, а потехе час\\ghotam.jpg");

            // Плавное следование
            this.MouseMove += (s, e) =>
            {
                int targetX = e.X - pictureBox1.Width / 2;
                int targetY = e.Y - pictureBox1.Height / 2;

                // Ограничение по форме
                targetX = Math.Max(
                    margin,
                    Math.Min(targetX, this.ClientSize.Width - pictureBox1.Width - margin)
                );

                targetY = Math.Max(
                    margin,
                    Math.Min(targetY, this.ClientSize.Height - pictureBox1.Height - margin)
                );

                // Плавность
                pictureBox1.Left += (targetX - pictureBox1.Left) / 50;
                pictureBox1.Top += (targetY - pictureBox1.Top) / 50;
            };
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            double value;

            if (!double.TryParse(textBox1.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
            {
                MessageBox.Show("Введите число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            value += 1;
            textBox1.Text = value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
