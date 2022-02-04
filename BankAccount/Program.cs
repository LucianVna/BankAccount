using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new ContBancar("Lucian", 1000);
            Console.WriteLine($"Contul {account.Numar} a fost creat pentru {account.Client} cu {account.Sold} lei, soldul initial.");


            account.FacRetragere(150, DateTime.Now, "Abonament sala");
            Console.WriteLine(account.Sold);
            account.FacDepunere(100, DateTime.Now, "Rata masina");
            Console.WriteLine(account.Sold);

            

            account.FacRetragere(50, DateTime.Now, "Abonament telefon");
            Console.WriteLine(account.Sold);

            Console.WriteLine(account.IstoricCont());









           /* try
            {
                account.FacRetragere(1750, DateTime.Now, "Suma este prea mare");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exceptie, suma este mai mare decat soldul");
                Console.WriteLine(e.ToString());
            }

            try
          {
              var contInvalid = new ContBancar("invalid", -55);
          }
          catch (ArgumentOutOfRangeException e)
          {
              Console.WriteLine("Exceptie, nu se poate crea un cont cu o suma negativa");
              Console.WriteLine(e.ToString());
              return;
          }*/


            Console.ReadKey();
        }


    }
    
    
}
