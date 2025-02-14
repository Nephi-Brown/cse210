using System;
using System.Collections.Generic;

class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public string CustomerName()
    {
        return _customerName;
    }

    public bool InUSA()
    {
        bool localToUSA;
        localToUSA = _customerAddress.InUSA();
        return localToUSA;
    }

    public string CustomerAddress()
    {
        return _customerAddress.FullAddress();
    }
}
