namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);
            double answer = 0;

            if (comboBox1.Text == "+")
            {
                answer = number1 + number2;
            }
            else if (comboBox1.Text == "-")
            {
                answer = number1 - number2;
            }
            else if (comboBox1.Text == "*")
            {
                answer = number1 * number2;
            }
            else if (comboBox1.Text == "/")
            {
                answer = number1 / number2;
            }


            label4.Text = answer.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            comboBox1.SelectedIndex = -1;
            label4.Text = "0";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
