using System;

public class Vector
{
    public double x = 0;
    public double y = 0;

    public Vector(double x_, double y_)
    {
       x = x_;
       y = y_;
    }

    public void WriteVector()
    {
        Console.Write("(" + x + ", ");
        Console.Write(y + ")");
    }
}
