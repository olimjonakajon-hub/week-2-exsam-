public class Mathh
{
    public double Abs(double value)
    {
        if (value < 0)
            return -value;
        return value;
    }

    public float Abs(float value)
    {
        if (value < 0)
            return -value;

        return value;
    }

    public int Abs(int value)
    {
        if (value < 0)
            return -value;

        return value;
    }

    public double Pow(double x, double y)
    {
        double result = 1;

        for (int i = 0; i < y; i++)
        {
            result = result * x;
        }

        return result;
    }

    public double Sqrt(int d)
    {
        for (double i = 0; i <= d; i++)
        {
            if (i * i == d)
                return i;
        }

        return -1;
    }

    public int Max(int val1, int val2)
    {
        if (val1 > val2)
            return val1;

        return val2;
    }

    public int Min(int val1, int val2)
    {
        if (val1 < val2)
            return val1;

        return val2;
    }

}