namespace laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "";
            button2.Text = "";

            button1.MouseEnter += (s, e) =>
            {
                button1.Text = "Пришел";
                button2.Text = "Ушел";
            };

            button1.MouseLeave += (s, e) =>
            {
                button1.Text = "";
                button2.Text = "";
            };

            button2.MouseEnter += (s, e) =>
            {
                button2.Text = "Пришел";
                button1.Text = "Ушел";
            };

            button2.MouseLeave += (s, e) =>
            {
                button2.Text = "";
                button1.Text = "";
            };

            button1.Click += OpenForm2;
            button2.Click += OpenForm2;
        }

        public void OpenForm2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
