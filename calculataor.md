# Calculator:-
```
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorByYash
{
    public partial class Form1 : Form
    {
        int count;
        float ans, num1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9 ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        private void compute(int count)
        {
            switch(count)
            {
                case 1:
                        ans  = num1 + float.Parse(textBox1.Text);
                        textBox1.Text = ans.ToString();
                        break;
                case 2:
                        ans  = num1 - float.Parse(textBox1.Text);
                        textBox1.Text = ans.ToString();
                        break;
                case 3:
                        ans = num1 * float.Parse(textBox1.Text);
                        textBox1.Text = ans.ToString();
                        break;
                case 4:
                        ans = num1 / float.Parse(textBox1.Text);
                        textBox1.Text = ans.ToString();
                        break;
                default :
                        break;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                compute(count);
            }
            else
            {
                MessageBox.Show("Please Insert Value !!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0 + 0;
        }
    }
}


```

## Output:-
![calc](https://user-images.githubusercontent.com/112624754/222042250-4d4ab41f-2dc3-4df7-a9cd-80ef154edf4b.png)



