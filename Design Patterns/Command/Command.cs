using System;
using System.Collections.Generic;
using System.Text;

namespace Takerman.DesignPatterns.CommandPattern
{
    public class Command : ICommand
    {
        private Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void execute()
        {
            this.receiver.On();
        }

        public void unexecute()
        {
            this.receiver.Off();
        }
    }
}
