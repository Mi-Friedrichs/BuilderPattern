using Demo.BuilderLibrary.Models.Manual;
using Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BuilderLibrary
{
    public class Builder2 : IBuilder
    {
        private Book _book = new Book();

        public Builder2()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._book = new Book();
        }

        public void BuildPartA()
        {
            this._book.AddChapter(new ChapterA());
        }

        public void BuildPartB()
        {
            this._book.AddChapter(new ChapterB());
        }

        public void BuildPartC()
        {
            this._book.AddChapter(new ChapterC());
        }

        public string GetManual()
        {
            string content = PrintContent();
            this.Reset();
            return content;
        }

        private string PrintContent()
        {
            List<string> content = new List<string>();

            GenerateTableOfContents();
            content.AddRange(_book.TableOfContents);

            foreach (var part in _book.Parts)
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
            _book.TableOfContents.Clear();

            foreach (var part in _book.Parts)
            {
                _book.TableOfContents.Add(part.Header.PadRight(30, '.') + currentPage.ToString().PadLeft(3, '.'));
                currentPage += part.Pages;
            }
        }

        private string PrintChapter(Chapter part)
        {
            return part.ToString();
        }
    }
}
