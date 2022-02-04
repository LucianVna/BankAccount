using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class ContBancar
    {
        public string Numar { get; }

        public string Client  { get; set; }

        public decimal Sold {
            get
            {
                decimal sold = 0;
                foreach (var item in allTransactions)
                {
                    sold += item.Suma;
                }

                return sold;
            }  
        
        
        
        
        }

        private static int numarCont = 0000000001;

        private List<Tranzactii> allTransactions = new List<Tranzactii>();

        public ContBancar(string nume, decimal initialSold)
        {
            this.Client = nume;

            FacDepunere(initialSold, DateTime.Now, "Sold initial");

            this.Numar = numarCont.ToString();
            numarCont++;
        }

        public void FacDepunere(decimal suma, DateTime data, string nota)
        {
            if (suma <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(suma), "Suma depozitului trebuie sa fie pozitiva! ");
            }
            var deposit = new Tranzactii(suma, data, nota);
            allTransactions.Add(deposit);
        }

        public void FacRetragere(decimal suma, DateTime data, string nota)
        {
            if (suma <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(suma), "Suma retragerii trebuie sa fie pozitiva!");
            }
            if (Sold - suma < 0)
            {
                throw new InvalidOperationException("Fonduri insuficiente pentru retragere!");
            }
            var withdrawal = new Tranzactii(-suma, data, nota);
            allTransactions.Add(withdrawal);
        }

        public string IstoricCont()
        {
            var report = new System.Text.StringBuilder();

            decimal sold = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                sold += item.Suma;
                report.AppendLine($"{item.Data.ToShortDateString()}\t{item.Suma}\t{sold}\t{item.Nota}");
            }

            return report.ToString();
        }
    }
}
