using Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary
{
    public class Director : IDirector
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildSimpleProduct()
        {
            this._builder.BuildPartA();
        }

        public void BuildComplexProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
