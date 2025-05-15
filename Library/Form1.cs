namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void buttonfirst_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();  
            form4.Show();
        }
    }
}
