using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary.Models.Manual
{
    public class ChapterC : Chapter
    {
        public override string Header { get => "Chapter 0815"; set => throw new NotImplementedException(); }
        public override string Teaser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Pages { get => 5; set => throw new NotImplementedException(); }

    }
}
