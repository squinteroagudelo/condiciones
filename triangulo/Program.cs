namespace triangulo;

internal class Program
{
	/*Cree un programa que pida los tres lados de un triángulo e indique el tipo
	de triángulo que es según sus lados: Equilátero, Isósceles o Escaleno.*/
	public static void Main(string[] args)
	{
		double a, b, c;
		
		Console.Write("Ingrese el primer lado del triángulo: ");
		a = Convert.ToDouble(Console.ReadLine());
        
		Console.Write("Ingrese el segundo lado del triángulo: ");
        b = Convert.ToDouble(Console.ReadLine());
        
		Console.Write("Ingrese el tercer lado del triángulo: ");
        c = Convert.ToDouble(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
	        if (a == b && a == c)
	        {
		        Console.WriteLine("Triángulo equilatero");
	        }
	        else if (a == b || a == c || b == c)
	        {
		        Console.WriteLine("Triángulo isóceles");
	        }
	        else
	        {
		        
		        Console.WriteLine("Triángulo escaleno");
	        }
        }
        else
        {
	        Console.WriteLine("Algunos de los datos ingresados son incorrectos");
        }
	}
}

