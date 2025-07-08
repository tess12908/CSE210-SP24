class Order
{
    private List<Product> _productsList;
    private Customer _customer;

    public Order(Customer customer)
    {
        _productsList = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _productsList.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach ( Product product in _productsList)
        { 
            totalCost += product.GetTotalCost();
        }
        
        double shippingCost = 0; 
        if (_customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _productsList)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    public DateTime Arrival (int daysToShip)
    {
        return DateTime.Today.AddDays(daysToShip);
    }
}
