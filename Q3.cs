using System;
					
public class Program
{
	public static void Main()
	{
		var a = Convert.ToDouble(Console.ReadLine());
		var b = Convert.ToDouble(Console.ReadLine());
		var c = Convert.ToDouble(Console.ReadLine());
		var menor = 0.0; 
		
		if(a < b) {
			if(a < c)
				menor = a;
			else
				menor = c;			
		}
		else{
			if(b < c)
				menor = b;
			else
				menor = c;
		}
		Console.WriteLine(menor);
		
	}
}