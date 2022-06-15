namespace LAB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x, a, b, y;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out x);

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox2.Text, out a);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBox3.Text, out b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        string message = "are you sure you want to exit?";
        string caption = "?";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result;

        result = MessageBox.Show(this, message, caption, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button3, 
            MessageBoxOptions.RightAlign);

        if(result == DialogResult.Yes)
        {

            this.Close();
        }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        
        private void button1_Click(object sender, EventArgs e)
        {
            y = 1 / (Math.Pow(x, 3) - Math.Pow(b, 3)) - 2 * Math.Sqrt(2*x);
            Random rand = new Random();
            switch (rand.Next(0, 12))
            {
                case 0: button2.BackColor = Color.Red; break;
                case 1: button2.BackColor = Color.Green; break;
                case 2: button2.BackColor = Color.Yellow; break;
                case 3: button2.BackColor = Color.White; break;
                case 4: button2.BackColor = Color.Gray; break;
                case 5: button2.BackColor = Color.Blue; break;
                case 6: button2.BackColor = Color.Cyan; break;
                case 7: button2.BackColor = Color.DarkBlue; break;
                case 8: button2.BackColor = Color.DarkCyan; break;
                case 9: button2.BackColor = Color.DarkGray; break;
                case 10: button2.BackColor = Color.DarkRed; break;
                case 11: button2.BackColor = Color.DarkOrange; break;

            }
            if (button2.BackColor == Color.Cyan)
            {
                
                    label2.Text = "y = " + y.ToString();
                
            }
            else
            {
                label2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            y = Math.Log2(x - 4) + Math.Pow(Math.E, (2 * a - x));
            Random rand = new Random();
            switch (rand.Next(0, 12))
            {
                case 0: button1.BackColor = Color.Red; break;
                case 1: button1.BackColor = Color.Green; break;
                case 2: button1.BackColor = Color.Yellow; break;
                case 3: button1.BackColor = Color.White; break;
                case 4: button1.BackColor = Color.Gray; break;
                case 5: button1.BackColor = Color.Blue; break;
                case 6: button1.BackColor = Color.Cyan; break;
                case 7: button1.BackColor = Color.DarkBlue; break;
                case 8: button1.BackColor = Color.DarkCyan; break;
                case 9: button1.BackColor = Color.DarkGray; break;
                case 10: button1.BackColor = Color.DarkRed; break;
                case 11: button1.BackColor = Color.DarkOrange; break;

            }
            if (button1.BackColor == Color.Blue)
            {

                label2.Text = "y = " + y.ToString();

            }
            else
            {
                label2.Text = "";
            }
        }
    }
}