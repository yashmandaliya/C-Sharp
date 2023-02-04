# 1. Program To Sum Two Numbers
```
namespace Sun_Two_Number
{
    class Program
    {
        public int sum(int a, int b)
        {
            return (a + b);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine("Enter Two Value :-");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum :-" + p1.sum(a,b));
            Console.ReadKey();
        }
    }
}
```
## Output :-

![sum](https://user-images.githubusercontent.com/112624754/215943209-a0215430-9650-424e-97f7-d9ead2059d37.png)


# 2. Program To Boxing And Unboxing

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            object obj = a;   // Boxing
            a = 100;
            Console.WriteLine("1)");
            Console.WriteLine("Value Type Value Of a iS :" + a);
            Console.WriteLine("Object Type  Value Of Obj Is:" + obj);
            int n =50 ;
            object obj1 = n;
            int i = (int)obj1; // Unboxing
            Console.WriteLine("2)");
            Console.WriteLine("N Value:" + n);
            Console.WriteLine("Value Type Value Of I Is :" + i);
            Console.WriteLine("Object Type Value Of Obj Is:" + obj1);
            Console.Read();
        }
    }
}

```

## Output:-

![third](https://user-images.githubusercontent.com/112624754/215942392-268b18cd-96f9-445a-badc-0dacd76832b5.png)



# 3. Program To Change Bg Color And Foreground Color

```
namespace BgColor_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("Enter A Name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter A Age:");
            String ag = Console.ReadLine();
            Console.WriteLine("Name : " + name + "   " +  "Age : " + ag);
            Console.Read();
        }
    }
}
```

## Output 

![first](https://user-images.githubusercontent.com/112624754/215940665-251ba994-66a7-43df-bb52-57d5520a3256.png)

# 3. Add Image In Form...
```
namespace Demo
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                DialogResult dialogResult = MessageBox.Show("Can You Change The Image ??", "Picture Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OpenFileDialog open1 = new OpenFileDialog();
                    open1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                    if (open1.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox1.Image = new Bitmap(open1.FileName);
                    }
                }   
                else 
                {
                    MessageBox.Show("Thank You !!");
                }

            }

        }
    }
}
```
## Output:-

![File1](https://user-images.githubusercontent.com/112624754/216746545-ad5549e3-1dc2-45da-8329-e1997260b74c.png)




