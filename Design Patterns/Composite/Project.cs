using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Project : ITodoList
    {
        private string _title;
        private IEnumerable<Todo> _todos;

        public Project(string title, IEnumerable<Todo> todos)
        {
            _title = title;
            _todos = todos;
        }

        public string GetHtml()
        {
            var html = $"<h1>{_title}</h1><ul>";

            foreach (var item in _todos)
                html += $"<li>{item.GetHtml()}</li>";

            html += "</ul>";

            return _title;
        }
    }
}
