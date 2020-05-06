using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Todo : ITodoList
    {
        private string _text;

        public Todo(string text)
        {
            _text = text;
        }

        public string GetHtml()
        {
            return _text;
        }
    }
}
