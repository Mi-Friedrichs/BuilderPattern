using Demo.BuilderLibrary.Models.Product;
using Demo.Interfaces;

namespace Demo.BuilderLibrary
{
    public class Builder1 : IBuilder
    {
        private Product _product = new Product();

        public Builder1()
        {
            this.Reset();
        }


        public void Reset()
        {
            this._product = new Product();
        }

        // All production steps work with the same product instance.
        public void BuildPartA()
        {
            this._product.Add(new PartA());
        }

        public void BuildPartB()
        {
            this._product.Add(new PartB());
        }

        public void BuildPartC()
        {
            this._product.Add(new PartC());
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
