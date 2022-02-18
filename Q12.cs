using System.Collections.Generic;
using System;
					
public class Program
{
	public static void Main()
	{
		var listaA = new List<int>{1, 2, 3, 4};
		var listaB = new List<int>{1, 2, 5, 8};
		var listaC = new List<int>();
		
		Console.WriteLine("Concatenação das listas:");
		
		foreach(var numA in listaA){
			listaC.Add(numA);
		}
		
		foreach(var numB in listaB){
			if(!listaC.Contains(numB)) listaC.Add(numB);
		}
		
		Console.WriteLine(string.Join(", ", listaC));
	}
}