using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        this._customer = customer;
    }

    public void AddProduct(string name, int id, double price = 0.00, int quantity = 1)
    {
        Product product = new Product(name, id, price, quantity);

        this._products.Add(product);
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
        string packingSlip =
            $"Date: {DateTime.Now}\n\nShip To:\n{this._customer.DisplayName()}\n{this._customer.DisplayCustomerAddress()}\n\n";

        // Quantity | Id | Product Description | Price\n

        packingSlip += String.Format(
            "{0, 0} | {1, 0} | {2, 0} | {3, 0}",
            "Quantity",
            "Id",
            "Product Description",
            "Price\n"
        );

        foreach (Product product in this._products)
        {
            packingSlip += String.Format(
                "{0, 0} | {1, 0} | {2, 0} | {3, 0}",
                $"{product.GetQuantity()}",
                $"{product.GetId()}",
                $"{product.GetName()}",
                $"{product.CalculatePrice():F2}\n"
            );
        }

        int shippingCost = this._customer.LivesInUnitedStates() ? 5 : 35;

        packingSlip += $"\nSubTotal: {this.CalculateTotal():F2}";
        packingSlip += $"\nShipping: ${shippingCost}";
        packingSlip += $"\nTotal: {this.CalculateTotal() + shippingCost:F2}";

        return packingSlip;
    }

    public string DisplayShippingLabel()
    {
        return $"To:\n{this._customer.DisplayName()}\n{this._customer.DisplayCustomerAddress()}";
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
