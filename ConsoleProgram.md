# 1) Print Hello World
```
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello , I Am  Yash Mandaliya !!");
            Console.ReadKey();
        }
    }
}

```

## Output:-

![1](https://user-images.githubusercontent.com/112624754/217141477-26d531b7-8d75-4995-81f4-36a887af99e7.png)

# 2) Execute Rectangle 
```
namespace RectangleApplication
{
    class Rectangle
    {
        double len;
        double wid;
        public void AcceptDetail()
        {
            len = 4.5;
            wid = 3.6;
        }
        public double GetArea()
        {
            return len * wid;
        }

        public void Display()
        {
            Console.WriteLine("Length {0} :" + len);
            Console.WriteLine("Width {0} :" + wid);
            Console.WriteLine("Area :" + GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.AcceptDetail();
            r1.Display();
            Console.ReadLine();
        }
    }
}
```
## Output:-
![2](https://user-images.githubusercontent.com/112624754/217141787-e636b8b5-137f-42fb-b2f3-c1f9766ade1a.png)

# 3) Size Of
```

namespace SizeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size Of Integer Is:-       " + sizeof(int));
            Console.WriteLine("Size Of Integer-16 Is:-    " + sizeof(Int16));
            Console.WriteLine("Size Of Integer-32 Is:-    " + sizeof(Int32));
            Console.WriteLine("Size Of Integer-64 Is:-    " + sizeof(Int64));
            Console.WriteLine("Size Of Integer-Float Is:- " + sizeof(float));
            Console.WriteLine("Size Of Integer-Double Is:-" + sizeof(double));
            Console.WriteLine("Size Of Integer-Char Is:-  " + sizeof(char));
            Console.ReadLine();
        }
    }
}

```
## Output:-
![3](https://user-images.githubusercontent.com/112624754/217142776-fbcb23c7-d470-4fc3-9aac-23e3b3b5008d.png)

# 4) Get Value From The User And Sum Of Two Value
```


namespace GetValueFromTheUser
{     
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum;
            Console.Write("Enter First Value:-");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Value:-");
            j = Convert.ToInt32(Console.ReadLine());
            sum = i+j;
            Console.WriteLine("Sum :-" + sum);
            Console.ReadKey();
        }
    }
}

```


## Output:-
![4](https://user-images.githubusercontent.com/112624754/217144972-a7e53a1b-a23b-4bb5-b530-fa9b745cbd0b.png)


