using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary.InternalBuilderModels.Manual
{
    internal abstract class Chapter
    {
        public abstract string Header { get; set; }

        public abstract string Teaser { get; set; }

        public abstract string Text { get; set; }

        public abstract int Pages { get; set; }

        public override string ToString()
        {
            return Header;
        }
    }
}
