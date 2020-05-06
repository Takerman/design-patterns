using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    public class User : Record
    {
        public override void Validate()
        {
            Console.WriteLine("Validation of the user");
        }

        public override void BeforeSave()
        {
            base.BeforeSave();

            Console.WriteLine("Override the before save method");
        }
    }
}
