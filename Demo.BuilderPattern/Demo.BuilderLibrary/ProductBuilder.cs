using Demo.BuilderLibrary.InternalBuilderModels.Product;
using Demo.Interfaces;
using Demo.Interfaces.Models;

namespace Demo.BuilderLibrary
{
    public class ProductBuilder : IBuilder
    {
        private InternalProduct _product = new InternalProduct();

        public ProductBuilder()
        {
            this.Reset();
        }


        public void Reset()
        {
            this._product = new InternalProduct();
        }

        // All production steps work with the same product instance.
        public void AddPartA()
        {
            this._product.Add(new PartA());
        }

        public void AddPartB()
        {
            this._product.Add(new PartB());
        }

        public void AddPartC()
        {
            this._product.Add(new PartC());
        }

        public Product BuildProduct()
        {
            Product result = new Product();
            result.Parts = this._product.ListParts();

            this.Reset();

            return result;
        }


    }
}
