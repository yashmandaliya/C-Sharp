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


