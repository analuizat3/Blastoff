using System;
					
public class Program
{
	public static void Main()
	{
		var a = Convert.ToInt64(Console.ReadLine());
		var b = Convert.ToInt64(Console.ReadLine());
		
		if(a<b){
			if(b%a==0) Console.WriteLine("São múltiplos");
			else Console.WriteLine("Não são múltiplos");
		}else{
			if(a%b==0) Console.WriteLine("São múltiplos");
			else Console.WriteLine("Não são múltiplos");
		}
	
	}

}