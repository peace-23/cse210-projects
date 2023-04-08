using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Product
    {
        public string _name { get; set; }
        public string _productId { get; set; }
        public double _price { get; set; }
        public int _quantity { get; set; }
        // private string _name;
        // private string _productId;
        // private double _price;
        // private int _quantity;

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