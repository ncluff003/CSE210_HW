using System;

public class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price = 0.00, int quantity = 1)
    {
        this._name = name;
        this._id = id;
        this._price = price;
        this._quantity = quantity;
    }

    public double CalculateTotal()
    {
        return this._price * this._quantity;
    }
}
