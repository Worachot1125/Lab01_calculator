using System.Drawing.Text;
using System.Security.Cryptography;

namespace Lab01
{
    public partial class Form1 : Form
    {
        //class variable
        double input1 = 0;
        String operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        // ปุ่ม 0
        private void button10_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "0";
            this.process.Text = this.process.Text + "0";

        }

        // ปุ่ม 1
        private void button7_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "1";
            this.process.Text = this.process.Text + "1";
        }

        // ปุ่ม 2
        private void button8_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "2";
            this.process.Text = this.process.Text + "2";
        }

        // ปุ่ม 3
        private void button9_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "3";
            this.process.Text = this.process.Text + "3";
        }

        // ปุ่ม 4
        private void button4_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "4";
            this.process.Text = this.process.Text + "4";
        }

        // ปุ่ม 5
        private void button5_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "5";
            this.process.Text = this.process.Text + "5";
        }

        // ปุ่ม 6
        private void button6_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "6";
            this.process.Text = this.process.Text + "6";
        }

        // ปุ่ม 7
        private void button1_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "7";
            this.process.Text = this.process.Text + "7";
        }

        // ปุ่ม 8
        private void button2_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "8";
            this.process.Text = this.process.Text + "8";
        }

        // ปุ่ม 9
        private void button3_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + "9";
            this.process.Text = this.process.Text + "9";
        }

        // ปุ่ม +
        private void button12_Click(object sender, EventArgs e)
        {
            //assign value to class variable
            this.input1 = Double.Parse(this.tb_Input.Text);
            //clear input text
            this.tb_Input.Text = "";
            this.operation = "+";
            this.process.Text = this.process.Text + "+";
        }

        // ปุ่ม -
        private void button13_Click(object sender, EventArgs e)
        {
            //assign value to class variable
            this.input1 = Double.Parse(this.tb_Input.Text);
            //clear input text
            this.tb_Input.Text = "";
            this.operation = "-";
            this.process.Text = this.process.Text + "-";
        }

        // ปุ่ม *
        private void button14_Click(object sender, EventArgs e)
        {
            //assign value to class variable
            this.input1 = Double.Parse(this.tb_Input.Text);
            //clear input text
            this.tb_Input.Text = "";
            this.operation = "*";
            this.process.Text = this.process.Text + "*";
        }

        // ปุ่ม /
        private void button15_Click(object sender, EventArgs e)
        {
            //assign value to class variable
            this.input1 = Double.Parse(this.tb_Input.Text);
            //clear input text
            this.tb_Input.Text = "";
            this.operation = "/";
            this.process.Text = this.process.Text + "/";

        }

        // ปู่ม .
        private void button17_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = this.tb_Input.Text + ".";
            this.process.Text = this.process.Text + ".";
        }

        // ปุ่ม =
        private void button11_Click(object sender, EventArgs e)
        {
            double input2 = Double.Parse(this.tb_Input.Text);
            double result = 0;
            if (this.operation == "+")
            {
                result = input1 + input2;
            }
            else if (this.operation == "-")
            {
                result = input1 - input2;
            }
            else if (this.operation == "*")
            {
                result = input1 * input2;
            }
            else if (this.operation == "/")
            {
                result = input1 / input2;
            }
            this.tb_Input.Text = result.ToString("#,##0");
            this.process.Text = this.process.Text + "=";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.tb_Input.Text = "";
            this.process.Text = "";
        }
    }
}