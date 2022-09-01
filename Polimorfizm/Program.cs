// See https://aka.ms/new-console-template for more information
namespace Polimorfizm
{
	class Program
	{
		static void Main(string[] args)
		{
			Parrot parrot = new Parrot
			{
				kind = "Parrot",
				speed = 50,
				name = "Sweety",
				color = "Blue-Yellow",
				weight = 1600
			};
			
			Console.WriteLine("************* Parrot *************");
			Console.WriteLine(parrot.kind);
			Console.WriteLine(parrot.name);
            Console.WriteLine(parrot.speed);
            Console.WriteLine(parrot.color);
			Console.WriteLine(parrot.weight);
			Console.WriteLine(parrot.makeNoise());
			Console.Read();
		}
	}

}
