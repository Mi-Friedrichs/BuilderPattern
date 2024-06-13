using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces.Models
{
    public class Product
    {
        public List<string> Parts { get; set; } = new List<string>();

        public string ListParts()
        {
            return string.Join(", ", Parts);
        }
    }
}
