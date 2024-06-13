using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary.InternalBuilderModels.Manual
{
    internal class ChapterB : Chapter
    {
        public override string Header { get => "Chapter 4711"; set => throw new NotImplementedException(); }
        public override string Teaser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Pages { get => 9; set => throw new NotImplementedException(); }

    }
}
