// See https://aka.ms/new-console-template for more information
namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.Write("Enter the id value:");
            customer.id=Convert.ToInt32(Console.ReadLine());
            Console.Write("FirstName:");
            customer.FirstName = Console.ReadLine();
            Console.Write("LastName:");
            customer.LastName = Console.ReadLine();
            Console.Write("City:");
            customer.city = Console.ReadLine();

            Console.WriteLine("************ Customer *************");
            Console.WriteLine(); 
            Console.WriteLine(customer.id+" "+ customer.FirstName+" "+ customer.LastName+" "+ customer.city);

            Console.Read();

        }
    }
}
