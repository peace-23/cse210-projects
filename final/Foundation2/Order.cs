using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer;

        public Order(Customer customer)
        {
            this._customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalCost()
        {
            double totalCost = 0.0;
            foreach (Product product in _products)
            {
                totalCost += product.GetPrice();
            }
            // totalCost += _customer.GetShippingCost();
            return totalCost;
        }

        private double getTotal()
        {
            return  GetTotalCost() + GetShippingCost();
        }

        private double GetShippingCost()
        {
            double shipping;

            if(_customer.IsInUSA())
            {
                shipping = 5;
            }
            else
            {
                shipping = 35;
            }

            return shipping;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "";
            foreach (Product product in _products)
            {
                packingLabel += product.GetName() + " (" + product.GetProductId() + ")\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return _customer.GetName() + "\n" + _customer.GetAddress().ToString();
        }

        // internal string CalculateTotalPrice()
        // {
        //     double totalPrice = 0;
        // foreach (Product product in _products)
        // {
        //     totalPrice += product.GetPrice * product.Quantity;
        // }

        // double shippingCost = _customer.Address.IsInUSA() ? 5 : 35;
        // totalPrice += shippingCost;

        // return totalPrice.ToString("C2");
        // }

        internal string CalculateTotalPrice()
        {
            double shipping = GetShippingCost();
            double subTotal = Math.Round(GetTotalCost(),2);
            double total = Math.Round(getTotal(),2);
            string priceString = $"{"Shipping:",-15}${shipping}\n{"Subtotal:",-27}${subTotal}\n{"Total:",-27}${total}";

            return priceString;
        }
    }
}