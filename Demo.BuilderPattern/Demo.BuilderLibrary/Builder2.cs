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
            string content = this._book.PrintContent();
            this.Reset();
            return content;
        }
    }
}
