namespace fruteria
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			double cantKg, valor, desc, vrTotal;

			desc = 0;
			valor = 10000;

			Console.WriteLine("Ingresa la cantidad de kilos:");
			cantKg = Convert.ToInt32(Console.ReadLine());

			valor *= cantKg;

			if (cantKg <= 0)
			{
				Console.WriteLine("Cantidad no válida. Por favor, corrija sus datos e intente nuevamente.");
			}
			else if (cantKg <= 2)
			{
				desc = 0;
			}
			else if (cantKg <= 5)
			{
				desc = valor * 0.1;
			}
			else if (cantKg <= 10)
			{
				desc = valor * 0.15;
			}
			else
			{
				desc = valor * 0.2;
			}

			vrTotal = valor - desc;

			if (vrTotal > 0)
			{
				Console.WriteLine("El valor a pagar es: $ " + vrTotal);
			}
		}
	}
}