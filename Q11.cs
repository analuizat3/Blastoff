using System.Collections.Generic;
using System;
					
public class Program
{
	public static void Main()
	{
		var listaA = new List<int>{1, 2, 3, 4};
		var listaB = new List<int>{1, 2, 5, 8};
		var listaC = new List<int>();
		
		Console.WriteLine("Interseção das listas:");
		
		foreach(var numA in listaA){
			foreach(var numB in listaB){
				if(numA == numB) listaC.Add(numA);
			}
		}
		
		Console.WriteLine(string.Join(", ", listaC));
	}
}