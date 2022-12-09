using System.Diagnostics;
using System.Security.Policy;

namespace EnterYourNumber
{
    public partial class Form1 : Form
    {
        private long i = 1;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = i.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new();
            ToolTip1.SetToolTip(this.button6, "Copy to Clipboard");
            ToolTip1.SetToolTip(this.button7, "Visit My GitHub Account");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            textBox1.Text = i.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            i -= 1;
            textBox1.Text = i.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            i = i * 2;
            textBox1.Text = i.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            i += rand.Next();
            textBox1.Text = i.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            i = 0;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { Clipboard.SetText(textBox1.Text); }
            else MessageBox.Show("Enter something!");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://github.com/Br41nfck",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}