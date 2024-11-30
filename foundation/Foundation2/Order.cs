using System;
using System.Collections.Generic;
public class Order
{
    private List<Product> products;
    private Customer customer;
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        double shippingCost = customer.IsInUSA() ? 5.00 : 35.00;
        total += shippingCost;
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetProductLabel() + "\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
    }
}
