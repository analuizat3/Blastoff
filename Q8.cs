using System;
					
public class Program
{
	public static void Main()
	{
		var n = Convert.ToInt64(Console.ReadLine());
		var cont = 0;
		
   		for (var i = 1; i <= n; i++){
     		if (n%i == 0)  
       			cont++;
		}
		if(cont==2)
			Console.WriteLine("É primo");
		else
			Console.WriteLine("Não é primo");
	}
}