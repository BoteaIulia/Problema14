using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Verificam daca numarul N este polindrom");
		Console.Write("\n");
		int n;
		int ogl = 0;
		int x1;

		Console.Write("N = ");
		n = Convert.ToInt32(Console.ReadLine());
		x1 = n;
		while (x1 != 0)
		{
			ogl = ogl * 10 + x1 % 10;
			x1 = x1 / 10;
		}
		if (n == ogl)
		{
			Console.Write("Numarul este un palindrom");
		}
		else
		{
			Console.Write("Numarul nu este un palindrom");
		}
	}
}
