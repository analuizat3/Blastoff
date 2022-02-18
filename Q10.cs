using System;
					
public class Program
{
	public static void Main()
	{
		var num = Convert.ToInt64(Console.ReadLine());
		var x = num;
		
		while(num>1){
			x = x*(num-1);
			num--;
		}
		Console.WriteLine(x);

	}
}