using System;
					
public class Program
{
	public static void Main()
	{
		var num = Convert.ToInt64(Console.ReadLine());
		
		for(var i=0; i<=10; i++){
			Console.WriteLine(num + " x " + i + "= " + num*i);
		}
	}
}