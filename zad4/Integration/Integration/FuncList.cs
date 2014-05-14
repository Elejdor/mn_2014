using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    class FuncList : List<Function>
    {
        public delegate void ChangedEventHandler(object sender, EventArgs e);
        public event ChangedEventHandler Changed;

        public new void Add(Function item)
        {
            base.Add(item);
            Changed(this, null);
        }
    }
}
