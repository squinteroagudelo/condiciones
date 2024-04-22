namespace calculadora
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			double num1, num2, result = 0;
			string? operador;
			bool byZero = false;

			Console.Write("Ingrese un número: ");
			num1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Ingrese otro número: ");
			num2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine(
				"Indique la operación que desea realizar:\n\tSuma: +\n\tResta: -\n\tMultiplicación: x\n\tDivisión /");
			Console.Write("Operación: ");
			operador = Console.ReadLine();

			if (operador == "+" || operador == "-" || operador == "x" || operador == "X" || operador == "*" ||
			    operador == "/")
			{
				if (operador == "+")
				{
					result = num1 + num2;
				}
				else if (operador == "-")
				{
					result = num1 - num2;
				}
				else if (operador == "/")
				{
					if (num2 > 0)
					{
						result = num1 / num2;
					}
					else
					{
						byZero = true;
						Console.WriteLine("La división por " + num2 + " no es una operación válida");
					}
				}
				else
				{
					result = num1 * num2;
				}
			}
			else
			{
				byZero = true;
				Console.WriteLine(operador + " no es un operador válido");
			}

			if (!byZero)
			{
				Console.WriteLine("\nResultado: " + num1 + " " + operador + " " + num2 + " = " + result);
			}
		}
	}
}