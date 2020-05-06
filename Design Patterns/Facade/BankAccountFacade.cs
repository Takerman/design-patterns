using System;

namespace Takerman.DesignPattern.FacadePattern
{
    /// <summary>
    /// There is nothing to do with the Facade pattern.
    /// Actually the facade pattern is a class which is using other classes inside. That's it!
    /// </summary>
    public class BankAccountFacade
    {
        private int accountNumber;
        private int securityNumber;

        private AccountNumberCheck accountNumberCheck;
        private SecurityCheck securityCheck;

        public void WithdrawCash(double value)
        {
            Console.WriteLine("Transaction Complete");
        }

        private WelcomeToBank welcomeToBank;

        public BankAccountFacade(int accountNumber, int securityNumber)
        {
            this.accountNumber = accountNumber;
            this.securityNumber = securityNumber;

            accountNumberCheck = new AccountNumberCheck();
            securityCheck = new SecurityCheck();
            welcomeToBank = new WelcomeToBank();
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public int GetSecurityNumber()
        {
            return securityNumber;
        }
    }
}