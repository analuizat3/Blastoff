using System.Collections.Generic;
using System;
					
public class Program
{
	public static void Main()
	{
		var lista = Console.ReadLine();
		var listaPares = new List<double>();
		
		Console.WriteLine("Números pares:");
		
		foreach(var num in lista){
			if(!string.IsNullOrWhiteSpace(Convert.ToString(num)) && num != ','){
				var numero = Char.GetNumericValue(num);
				if(numero%2 == 0) listaPares.Add(numero);
			}
		};
		
		Console.WriteLine(string.Join(", ", listaPares));
	}
}