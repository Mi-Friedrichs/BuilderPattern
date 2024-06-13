using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary.InternalBuilderModels.Product
{
    internal class InternalProduct
    {
        private List<object> _parts = new List<object>();

        internal void Add(object part)
        {
            _parts.Add(part);
        }

        internal List<string> ListParts()
        {
            List<string> parts = new List<string>();

            foreach (var item in _parts)
            {
                parts.Add(item.ToString());
            }

            return parts;
        }
    }
}
