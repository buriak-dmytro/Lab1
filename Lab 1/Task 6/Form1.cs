namespace Task_6
{
    public delegate void MyDelegate();

    public partial class Form1 : Form
    {
        private double opacityValue = 0.2;
        private Color[] colors = { Color.Aqua, Color.Pink, Color.BlueViolet, Color.White };
        private int colorIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += opacityValue;
            }
            else
            {
                this.Opacity = opacityValue;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = colors[colorIndex];
            colorIndex++;
            colorIndex %= colors.Length;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"Super Button\" was clicked");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button4.Click += this.button1_Click;
            }
            else
            {
                button4.Click -= this.button1_Click;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button4.Click += this.button2_Click;
            }
            else
            {
                button4.Click -= this.button2_Click;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                button4.Click += this.button3_Click;
            }
            else
            {
                button4.Click -= this.button3_Click;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
