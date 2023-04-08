using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Product
    {
        private string _name { get; set; }
        private string _productId { get; set; }
        private double _price { get; set; }
        private int _quantity { get; set; }


        public Product(string name, string productId, double price, int quantity)
        {
            this._name = name;
            this._productId = productId;
            this._price = price;
            this._quantity = quantity;
        }

        public double GetPrice()
        {
            return _price * _quantity;
        }

        public string GetName()
        {
            return _name;
        }

      
        public string GetProductId()
        {
            return _productId;
        }

    }
}