namespace Takerman.DesignPattern.FacadePattern
{
    public class SecurityCheck
    {
        private readonly int securityNumber = 123123123;

        public int GetSecurityCheck()
        {
            return securityNumber;
        }
    }
}
