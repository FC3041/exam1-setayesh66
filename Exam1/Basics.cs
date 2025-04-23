namespace Exam1;

public class Q1_Add
{
    public int a{get; set;}
    public int b{get; set;}
    
    public Q1_Add(int A, int B)
    {
        a=A;
        b=B;
    }

    public static int Add(int a, int b)
    {
        return a+b;
    }
}

public class Basics
{
    public int x{get; set;}
    public int y{get; set;}
    
    public Basics(int X, int Y)
    {
        x=X;
        y=Y;
    }
    

    public static Basics Q2MultiplyAndReset(ref int x, ref int y)
    {
        x*=y;
        if (y!=1)
        {
            y=1;
        }   
        return new Basics(x,y);
    }

    public static void Q5TryCatchFinally(bool shouldThrow, List<string> strs, bool shcatch)
    {
        if (shouldThrow==true)
        {
            throw new InvalidOperationException();
        }

    }

    // public static void Q5TryCatchFinally(bool shouldThrow, List<string> strs, bool shcatch)
    // {
    //     // List<string> strss= new List<string>();
    //     if (shouldThrow==true)
    //     {
    //         throw new InvalidOperationException();
    //     }
    //     try
    //     {
    //         strs.Add("Try");
    //         strs.Add("AfterTry");
    //         strs.Add("Finally");

    //     }
    //     catch (System.Exception)
    //     {
            
    //         throw;
    //     }

    // }

}

public struct Type1
{
    public int Count;
}

public class Type2
{
    public int Count;
}

public class Q4Person
{
    public string Name{get; set;}
    public int Age{get; set;}
    public Q4Person(string name, int age)
    {
        Name=name;
        Age=age;
    }

    public string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old.";
    }
 

}


public class Q6Temperature
{
    // public double Celsius;  
    // public double Fahrenheit;

    private double celsius;
    private double fahrenheit;
    public double Celsius
    {
        get{
            return celsius;}
        set
        {
            celsius=value;
            fahrenheit = 32 + ((9/5)*value);
        }
    }


    public double Fahrenheit
    {
        get{ 
            return fahrenheit;}
        set
        {
            // celsius = (5/9) * (fahrenheit-32);
            fahrenheit=value;
            celsius = (5/9) * (value-32);

        }
    }




    // public Q6Temperature()
    // {
    //     Celsius = (5/9) * (Fahrenheit-32);
    //     Fahrenheit=32 + ((9/5)*Celsius);
    // }
    // public Q6Temperature(double celsius, double fahrenheit)
    // {
    //     Celsius = (5/9) * (fahrenheit-32);
    //     Fahrenheit = 32 + ((9/5)*celsius);
    // }
    
}

public interface IShape
{
    public double GetArea();
    public double GetPerimeter();
    
}
public class Q7Circle: IShape
{
    public double radius{get; set;}
    public Q7Circle(double Radius)
    {
        radius=Radius;
    }

    public double GetArea()
    {
        return radius*radius*Math.PI;
    }

    public double GetPerimeter()
    {
        return radius*2*Math.PI;
    }
}

public class Q7Rectangle: IShape
{
    public double width{get; set;}
    public double height{get; set;}
    public Q7Rectangle(double Width, double Height)
    {
        width=Width;
        height=Height;
    }

    public double GetArea()
    {
        return width*height;
    }

    public double GetPerimeter()
    {
        return (width+height)*2;
    }
}

public class ShapeUtils
// <T> where T:IShape
{
    public List<double> shapesU= new List<double>();
    public static double Q7TotalArea(IShape[] shapes)
    {
        double sum=0;
        // shapesU.Add(shape.GetArea());
        foreach (var item in shapes)
        {
            sum+= item.GetArea();
        }
        return sum;
    }

    
}




