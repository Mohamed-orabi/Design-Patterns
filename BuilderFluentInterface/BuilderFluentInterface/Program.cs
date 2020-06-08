using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderFluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client.Builder()
                .FirstName("Mohamed")
                .LastName("Orabi")
                .build();

            Console.WriteLine("Data client: "+"\nFirstName: " + client.FirstName 
                + "\nLastName: " + client.LastName);

            Console.ReadKey();
                
        }
    }
}
