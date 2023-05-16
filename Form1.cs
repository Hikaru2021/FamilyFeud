namespace FamilyFeud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of the new form you want to navigate to
            Form2 form2 = new Form2();

            // Set the owner of the new form to be the current form
            form2.Owner = this;

            // Show the new form
            form2.Show();
        }
    }
}