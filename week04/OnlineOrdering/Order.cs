using System;
using System.ComponentModel;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _products = product;
    }

    public int OrderPrice()
    {
        int totalOrderPrice = 0;
        foreach (Product product in _products)
        {
            totalOrderPrice += product.TotalPrice();
        }

        if (_customer.inUSA())
        {
            totalOrderPrice += 5;
        }
        else
        {
            totalOrderPrice += 35;
        }

        return totalOrderPrice;

    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductDetails()}\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        return _customer.GetCustomerDetails();
    }
}