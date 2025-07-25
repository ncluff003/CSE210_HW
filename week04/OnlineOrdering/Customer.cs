using System;

public class Customer
{
    private string _name;

    private Address _address;

    public Customer(
        string name,
        string streetAddress,
        string city,
        string stateOrProvince,
        string country,
        string zipCode = ""
    )
    {
        this._name = name;
        this._address = new Address(streetAddress, city, stateOrProvince, country, zipCode);
    }

    public Boolean LivesInUnitedStates()
    {
        return this._address.IsUnitedStatesAddress();
    }
}
