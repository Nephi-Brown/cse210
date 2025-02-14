using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in _products)
        {
            totalCost = totalCost + product.TotalPrice();
        }
        bool localToUSA;
        localToUSA = _customer.InUSA();
        if(localToUSA == true)
        {
            totalCost = totalCost + 5;
            return totalCost;
        }
        else
        {
            totalCost = totalCost + 35;
            return totalCost;
        }
    }

    public string PackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach(var product in _products)
        {
            packingLabel = packingLabel + $"Product: {product.ProductName()}, ID: {product.ProductId()}\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.CustomerName()}\n{_customer.CustomerAddress()}";
    }
}
