namespace lw4.task2;

public class TCube<T> : TSquare<T> where T : struct, IComparable<T>, IEquatable<T>
{
    public TCube() : base()
    { }
    
    public TCube(T size) : base(size)
    { }
    
    public TCube(TCube<T> cube) : base(cube.Size)
    { }

    public override double CulcPerimeter()
    {
        return 12 * Convert.ToDouble(size);
    }
    
    public override double CulcArea()
    {
        return Convert.ToDouble(size) * Convert.ToDouble(size) * 6;
    }

    public double CulcVolume()
    {
        return Convert.ToDouble(size) * Convert.ToDouble(size) * Convert.ToDouble(size);
    }

    public static TCube<T> operator +(TCube<T> s1, TCube<T> s2)
    {
        return new TCube<T>((dynamic)s1.size + (dynamic)s2.size);
    }

    public static TCube<T> operator -(TCube<T> s1, TCube<T> s2)
    {
        return new TCube<T>((dynamic)s1.size - (dynamic)s2.size);
    }

    public static TCube<T> operator *(TCube<T> s1, double k)
    {
        return new TCube<T>((dynamic)s1.size * k);
    }
}