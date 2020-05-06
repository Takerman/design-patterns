using System;

namespace Takerman.DesignPattern.FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountFacade accessingBank = new BankAccountFacade(12345678, 1234);
            accessingBank.WithdrawCash(50.00);
            accessingBank.WithdrawCash(900.00);
            accessingBank.WithdrawCash(200.00);
            Console.ReadKey();
        }
    }
}
