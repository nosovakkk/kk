namespace Новокшанов__Носова
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Итог: " + sum);  
           
        }
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 299;
            int z;
            z = (int)numericUpDown1.Value;
           listBox1.Items.Add  ("Smoky BLT Double " + a*z + "p.");
            sum += a * z;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = 199;
            int z;
            z = (int)numericUpDown2.Value;
            listBox1.Items.Add("Spicy Deluxe Crispy " + b * z + "p.");
            sum += b * z;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = 99;
            int z;
            z = (int)numericUpDown3.Value;
            listBox1.Items.Add("McDouble " + c * z + "p.");
            sum += c * z;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int d = 79;
            int z;
            z = (int)numericUpDown4.Value;
            listBox1.Items.Add("Dr Pepper " + d * z + "p.");
            sum += d * z;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int f = 89;
            int z;
            z = (int)numericUpDown5.Value;
            listBox1.Items.Add("Hot Chocolate " + f * z + "p.");
            sum += f * z;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int g = 49;
            int z;
            z = (int)numericUpDown6.Value;
            listBox1.Items.Add("Hot Tea " + g * z + "p.");
            sum += g * z;
        }
    }
}