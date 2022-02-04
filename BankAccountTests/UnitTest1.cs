using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using BankAccount;

namespace BankAccountTests
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal soldInitial = 1000;
            decimal sumaExtrasa = 450;
            decimal sumaRamasa = 550;

            ContBancar cb = new ContBancar("Lucian", soldInitial );

            cb.FacRetragere(sumaExtrasa, DateTime.Now, "Carburant");

            decimal actual = cb.Sold;
            Assert.AreEqual(sumaRamasa,actual, "Contul nu este alimentat corect!");

          
        }

        public void TestMethod2()
        {
            decimal soldInitial = 3000;
            decimal sumaExtrasa = -4000;
            

            ContBancar coba = new ContBancar("Lucian", soldInitial);

            coba.FacRetragere(sumaExtrasa, DateTime.Now, "Asigurare");

            
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => coba.FacRetragere(sumaExtrasa,DateTime.Now,"Suma este mai mare decat soldul! "));
        }
    }
}
