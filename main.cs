using System;
using System.Collections;
using System.Text;

internal class Euler
{
	private IEnumerable factors(long thing)
	{
		long bottom = 1;
		long top = thing;
		for (long i = bottom; i < top; i++)
		{
			if ((thing % i) == 0)
			{
				bottom = i;
				top = thing / bottom;
				yield return bottom;
				yield return top;
			}
		}
	}

	private bool isPrime(long thing)
	{
		foreach (long f in factors(thing))
		{
			if ((f != 1) && (f != thing))
			{
				return false;
			}
		}
		return true;
	}
	
	private string reverse(string str)
	{
		StringBuilder builder = new StringBuilder(str.Length);
		for (int i = 0; i < str.Length; i++)
		{
			builder.Append(str[str.Length - i - 1]);
		}
		return builder.ToString();
	}

	private bool isPalindromic(long number)
	{
		if (number.ToString() == reverse(number.ToString()))
			return true;
		return false;
	}

	private bool isDivisibleTo(long number, int n)
	{
		for (int i = 1; i < n; i++)
		{
			if ((number % i) != 0)
				return false;
		}
		return true;
	}

	public void Compute()
	{
		Console.WriteLine("sum of squares");
		long sumOfSquares = 0;
		long squareOfSums = 0;
		for (int i = 1; i <= 100; i++)
		{
			long square = i * i;
			sumOfSquares += square;
		}
		for (int i = 1; i <= 100; i++)
		{
			squareOfSums += i;
		}
		squareOfSums *= squareOfSums;
		Console.WriteLine(sumOfSquares);
		Console.WriteLine(squareOfSums);
		Console.WriteLine(squareOfSums - sumOfSquares);
	}
}

public class Foo
{
  public static void Main(string[] argv)
  {
	  Euler app = new Euler();
	  app.Compute();
  }
}