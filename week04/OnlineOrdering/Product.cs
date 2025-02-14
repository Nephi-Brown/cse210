using System;
using System.Collections.Generic;

class Product
{
    private string _productName;
    private string _productId;
    private decimal _productPrice;
    private int _productQuantitiy;

    public Product(string productName, string productId, decimal productPrice, int productQuantitiy)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantitiy = productQuantitiy;
    }

    public string ProductName()
    {
        return _productName;
    }

    public string ProductId()
    {
        return _productId;
    }

    public decimal TotalPrice()
    {
        return _productPrice * _productQuantitiy;
    }
}
