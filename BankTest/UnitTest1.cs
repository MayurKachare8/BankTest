using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankingTest;

namespace BankTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double InitialBalance = 100;
            double debitAmount = 10;
            double expected = 90;
            BankClass bc = new BankClass("Mayur Kachare", InitialBalance);

            // Act
            bc.debit(debitAmount);
           

            // Assert
            double actual = bc.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account debited correctly");
        }



        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double InitialBalance = 100;
            double creditAmount = 40;
            double expected = 140;
            BankClass bc = new BankClass("Mayur Kachare", InitialBalance);

            // Act
            bc.credit(creditAmount);


            // Assert
            double actual = bc.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account credited correctly");
        }

    }
}
