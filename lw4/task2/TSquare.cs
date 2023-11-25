namespace lw4.task2;

public class TSquare<T> : IEquatable<TSquare<T>> where T : struct, IComparable<T>, IEquatable<T>
{
    protected T size;

    public TSquare()
    {
        this.size = default(T);
    }

    public TSquare(T size)
    {
        this.size = size;
    }

    public TSquare(TSquare<T> square)
    {
        this.size = square.size;
    }

    public T Size
    {
        get => size;
        set => size = value;
    }

    public virtual double CulcPerimeter()
    {
        if (typeof(T) == typeof(double))
        {
            return 4 * Convert.ToDouble(size);
        }

        throw new InvalidOperationException("Operation not supported for non-numeric types.");
    }

    public virtual double CulcArea()
    {
        if (typeof(T) == typeof(double))
        {
            return Convert.ToDouble(size) * Convert.ToDouble(size);
        }

        throw new InvalidOperationException("Operation not supported for non-numeric types.");
    }

    public bool Equals(TSquare<T>? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return size.Equals(other.size);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((TSquare<T>)obj);
    }

    public override int GetHashCode()
    {
        return size.GetHashCode();
    }

    public static TSquare<T> operator +(TSquare<T> s1, TSquare<T> s2)
    {
        return new TSquare<T>((dynamic)s1.size + (dynamic)s2.size);
    }

    public static TSquare<T> operator -(TSquare<T> s1, TSquare<T> s2)
    {
        return new TSquare<T>((dynamic)s1.size - (dynamic)s2.size);
    }

    public static TSquare<T> operator *(TSquare<T> s1, double k)
    {
        return new TSquare<T>((dynamic)s1.size * k);
    }
}