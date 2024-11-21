using System;

public class Fraction
{
    private int _num;
    private int _den;

    public Fraction() 
    {
        _num = 1;
        _den = 1;
    }

    public Fraction(int numerator)
    {
        _num = numerator;
        _den = 1;
    }

    public Fraction(int numerator, int denominator) 
    {
        _num = numerator;
        _den = denominator != 0 ? denominator : throw new ArgumentException("Denominator cannot be zero.");
    }

    public int GetNumerator()
    {
        return _num;
    }

    public void SetNumerator(int numerator)
    {
        _num = numerator;
    }

    public int GetDenominator()
    {
        return _den;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _den = denominator;
    }

    public string GetFractionString()
    {
        return $"{_num}/{_den}";
    }

    public double GetDecimalValue()
    {
        return (double)_num / _den;
    }
}
