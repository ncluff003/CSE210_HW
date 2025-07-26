using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        this._customer = customer;
    }

    public double CalculateTotal()
    {
        double total = 0.00;
        foreach (Product product in this._products)
        {
            total += product.CalculatePrice();
        }
        return total;
    }

    public string DisplayPackingSlip()
    {
        return $"Date: {DateTime.Now}\n\nShip To:\n{this._customer.DisplayName()}\n{this._customer.DisplayCustomerAddress()}\n\n";
    }

    public string DisplayShippingLabel()
    {
        return "";
    }
}

// Packing Slip
// Date
//
// Ship To: Name
//               Street Address
//               City, State, Zipcode, Country
// Quantity | Id | Product Description | Price
// Listing the products under the above categories
// Sub-Total
// Shipping
// Total

// Shipping Label
// From
// Company
// Street Address
// City, State, Zipcode, Country
//
// To
// Customer Name
// Customer Address
