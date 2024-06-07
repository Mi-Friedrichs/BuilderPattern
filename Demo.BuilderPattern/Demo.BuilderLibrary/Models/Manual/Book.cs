using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary.Models.Manual
{
    public class Book
    {
        private List<string> _TableOfContents;
        public List<string> TableOfContents
        {
            get
            {
                if (_TableOfContents == null)
                {
                    _TableOfContents = new List<string>();
                }

                return _TableOfContents;
            }
            set { _TableOfContents = value; }
        }


        public List<Chapter> Parts { get; set; } = new List<Chapter>();

        internal void AddChapter(Chapter part)
        {
            Parts.Add(part);
        }

    }
}
