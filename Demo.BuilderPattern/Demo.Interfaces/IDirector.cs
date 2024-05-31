using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interfaces
{
    public interface IDirector
    {
        IBuilder Builder { set; }

        void BuildSimpleProduct();

        void BuildComplexProduct();
    }
}
