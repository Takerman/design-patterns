using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    public abstract class Record
    {
        public void Save()
        {
            this.Validate();
            this.BeforeSave();
            // actual save
        }

        public abstract void Validate();

        public virtual void BeforeSave()
        {
            Console.WriteLine("Before save");
        }
    }
}
