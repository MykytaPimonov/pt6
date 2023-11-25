namespace lw4.task14;

public class TMixFraction<T> : TFraction<T> where T : struct
{
    private T whole;

    public TMixFraction()
    {
        this.whole = default;
    }

    public TMixFraction(T numerator, T denominator, T whole) : base(numerator, denominator)
    {
        this.whole = whole;
    }

    public TMixFraction(TMixFraction<T> fraction) : base(fraction)
    {
        this.whole = fraction.whole;
    }

    public T Whole
    {
        get => whole;
        set => whole = value;
    }

    public override TFraction<T> Reduce()
    {
        dynamic a = Numerator + (dynamic) Denominator * whole;
        dynamic b = Denominator;
        dynamic d = Gcd(a, b);
        a /= d;
        b /= d;
        Denominator = b;
        Numerator = a % b;
        whole = a / b;
        return this;
    }

    public static TMixFraction<T> operator +(TMixFraction<T> a, TMixFraction<T> b)
    {
        dynamic a_n = a.Numerator + (dynamic) a.Denominator * a.whole;
        dynamic b_n = b.Numerator + (dynamic) b.Denominator * b.whole;

        TMixFraction<T> res = new TMixFraction<T>(
            a_n * b.Denominator + a.Denominator * b_n,
            (dynamic) a.Denominator * b.Denominator,
            default(T));

        return res.Reduce() as TMixFraction<T>;
    }

    public static TMixFraction<T> operator -(TMixFraction<T> a, TMixFraction<T> b)
    {
        dynamic a_n = a.Numerator + (dynamic) a.Denominator * a.whole;
        dynamic b_n = b.Numerator + (dynamic) b.Denominator * b.whole;

        TMixFraction<T> res = new TMixFraction<T>(
            a_n * b.Denominator - a.Denominator * b_n,
            (dynamic) a.Denominator * b.Denominator,
            default(T));

        return res.Reduce() as TMixFraction<T>;
    }

    public static TMixFraction<T> operator *(TMixFraction<T> a, TMixFraction<T> b)
    {
        dynamic a_n = a.Numerator + (dynamic) a.Denominator * a.whole;
        dynamic b_n = b.Numerator + (dynamic) b.Denominator * b.whole;

        TMixFraction<T> res = new TMixFraction<T>(
            a_n * b_n,
            (dynamic) a.Denominator * b.Denominator,
            default(T));

        return res.Reduce() as TMixFraction<T>;
    }

    public static TMixFraction<T> operator /(TMixFraction<T> a, TMixFraction<T> b)
    {
        dynamic a_n = a.Numerator + (dynamic)  a.Denominator * a.whole;
        dynamic b_n = b.Numerator + (dynamic) b.Denominator * b.whole;

        TMixFraction<T> res = new TMixFraction<T>(
            a_n * b.Denominator,
            a.Denominator * b_n,
            default(T));

        return res.Reduce() as TMixFraction<T>;
    }
}
