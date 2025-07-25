using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool inUSA()
    {
        return _address.UsaCustomer();
    }

    public string GetCustomerDetails()
    {
        return $"Recipient: {_name}\nAddress: {_address.FullAddress()}";
    }
}