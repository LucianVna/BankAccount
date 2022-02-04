using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Tranzactii
    {
        public decimal  Suma{ get; }
        public DateTime Data { get; }
        public string Nota { get; }

        public Tranzactii(decimal suma, DateTime data, string nota)
        {
            this.Suma = suma;
            this.Data = data;
            this.Nota = nota;
        }
    }
}
