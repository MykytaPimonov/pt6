namespace lw4.task14;

public class TFraction<T> where T : struct
{
    protected T numerator;
    protected T denominator;

    public TFraction()
    {
        numerator = default;
        denominator = default;
    }

    public TFraction(T numerator, T denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public TFraction(TFraction<T> fraction)
    {
        this.numerator = fraction.numerator;
        this.denominator = fraction.denominator;
    }

    public T Numerator
    {
        get => numerator;
        set => numerator = value;
    }

    public T Denominator
    {
        get => denominator;
        set => denominator = value;
    }

    public virtual TFraction<T> Reduce()
    {
        dynamic num = numerator;
        dynamic denom = denominator;
        dynamic d = Gcd(num, denom);
        this.denominator = denom / d;
        this.numerator = num / d;
        return this;
    }

    public static TFraction<T> operator +(TFraction<T> a, TFraction<T> b)
    {
        dynamic numA = a.numerator;
        dynamic denomA = a.denominator;
        dynamic numB = b.numerator;
        dynamic denomB = b.denominator;

        TFraction<T> res = new TFraction<T>(
            numA * denomB + denomA * numB,
            denomA * denomB);

        return res.Reduce();
    }

    public static TFraction<T> operator -(TFraction<T> a, TFraction<T> b)
    {
        dynamic numA = a.numerator;
        dynamic denomA = a.denominator;
        dynamic numB = b.numerator;
        dynamic denomB = b.denominator;

        TFraction<T> res = new TFraction<T>(
            numA * denomB - denomA * numB,
            denomA * denomB);

        return res.Reduce();
    }

    public static TFraction<T> operator *(TFraction<T> a, TFraction<T> b)
    {
        dynamic numA = a.numerator;
        dynamic denomA = a.denominator;
        dynamic numB = b.numerator;
        dynamic denomB = b.denominator;

        TFraction<T> res = new TFraction<T>(
            numA * numB,
            denomA * denomB);

        return res.Reduce();
    }

    public static TFraction<T> operator /(TFraction<T> a, TFraction<T> b)
    {
        dynamic numA = a.numerator;
        dynamic denomA = a.denominator;
        dynamic numB = b.numerator;
        dynamic denomB = b.denominator;

        TFraction<T> res = new TFraction<T>(
            numA * denomB,
            denomA * numB);

        return res.Reduce();
    }

    protected dynamic Gcd(dynamic a, dynamic b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
            {
                a %= b;
            }
            else
            {
                b %= a;
            }
        }

        return a + b;
    }
}