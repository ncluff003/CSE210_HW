using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _zipCode;
    private string _country;

    public Address(
        string streetAddress,
        string city,
        string stateOrProvince,
        string country,
        string zipCode = ""
    )
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateOrProvince = stateOrProvince;
        this._zipCode = zipCode;
        this._country = country;
    }

    public Boolean IsUnitedStatesAddress()
    {
        return this._country == "USA"
            || this._country == "US"
            || this._country == "United States"
            || this._country == "United States of America";
    }

    public string DisplayAddress()
    {
        return $"{this._streetAddress}\n{this._city}, {this._stateOrProvince}, {this._zipCode}\n{this._country}";
    }
}
