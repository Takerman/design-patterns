namespace Takerman.DotNetCore.StrategyPattern
{
    public class Duck
    {
        IDisplayBehaviour db;
        IFlyBehaviour fb;
        IQuackBehaviour qb;

        public Duck(IDisplayBehaviour db, IFlyBehaviour fb, IQuackBehaviour qb)
        {
            this.db = db;
            this.fb = fb;
            this.qb = qb;
        }

        public void Display()
        {
            this.db.Display();
        }

        public void Fly()
        {
            this.fb.Fly();
        }

        public void Quack()
        {
            this.qb.Quack();
        }
    }
}
