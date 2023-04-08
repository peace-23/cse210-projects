using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            this._name = name;
            this._address = address;
        }

        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }

        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public string GetShippingLabel()
        {
            return $"Name: {_name}\nAddress: {_address.ToString()}";
        }
    }

}