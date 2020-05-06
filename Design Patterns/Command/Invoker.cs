namespace Takerman.DesignPatterns.CommandPattern
{
    public class Invoker
    {
        private ICommand on;
        private ICommand off;
        private ICommand up;
        private ICommand down;

        public void SetCommand(ICommand on, ICommand off, ICommand up, ICommand down)
        {
            this.on = on;
            this.off = off;
            this.up = up;
            this.down = down;
        }

        public void ClickOn()
        {
            on.execute();
        }

        public void ClickOff()
        {
            off.execute();
        }

        public void ClickUp()
        {
            up.execute();
        }

        public void ClickDown()
        {
            down.execute();
        }
    }
}
