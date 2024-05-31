using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary.Models.Handbook
{
    internal class ChapterA : Chapter
    {
        public override string Header { get => "Introduction"; set => throw new NotImplementedException(); }
        public override string Teaser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Pages { get => 4; set => throw new NotImplementedException(); }

        public override string ToString()
        {
            return "Einleitung";
        }
    }
}
