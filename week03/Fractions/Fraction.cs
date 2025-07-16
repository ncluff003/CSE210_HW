using System;

public class Fraction
{
  private int _top;
  private int _bottom;

  public Fraction()
  {
    _top = 1;
    _bottom = 1;
  }

  public Fraction(int top)
  {
    _top = top;
    _bottom = 1;
  }

  public Fraction(int top, int bottom)
  {
    _top = top;
    _bottom = bottom;
  }

  public int getTop()
  {
    return _top;
  }

  public void setTop(int top)
  {
    _top = top;
  }

  public int getBottom()
  {
    return _bottom;
  }

  public void setBottom(int bottom)
  {
    _bottom = bottom;
  }

  public string getFractionString()
  {
    return $"{_top}/{_bottom}";
  }

  public double getDecimalValue()
  {
    if (_bottom == 0)
    {
      throw new DivideByZeroException("Cannot divide by zero.");
    }
    return (double)_top / _bottom;
  }

}