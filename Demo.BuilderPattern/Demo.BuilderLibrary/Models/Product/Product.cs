using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary.Models.Product
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(object part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Join(", ", _parts);

            return "Product parts: " + str + "\n";
        }
    }
}
