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


        private List<Chapter> _parts = new List<Chapter>();

        internal void AddChapter(Chapter part)
        {
            _parts.Add(part);
        }

        public string PrintContent()
        {
            List<string> content = new List<string>();

            GenerateTableOfContents();
            content.AddRange(TableOfContents);

            foreach (var part in _parts)
            {
                content.Add("   <PageBreak>");
                content.Add(PrintChapter(part));
            }
            content.Add("   <End of Book>");

            return string.Join("\r\n", content) + "\r\n";
        }

        private void GenerateTableOfContents()
        {
            int currentPage = 2;
            TableOfContents.Clear();

            foreach (var part in _parts)
            {
                TableOfContents.Add(part.Header.PadRight(30, '.') + currentPage.ToString().PadLeft(3, '.'));
                currentPage += part.Pages;
            }
        }

        private string PrintChapter(Chapter part)
        {
            return part.ToString();
        }
    }
}
