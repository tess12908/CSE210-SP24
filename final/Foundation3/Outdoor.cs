class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetDetailedEventInfo()
    {
        return $"{GetEventSummary()}\nEvent Type: Outdoor Gathering\nWeather Forecast: {_weather}";
    }
    
       public string ShortSummary()
    {
        return $"Outdoor: {_title} on {_date} at {_address.AllTogether()} "; 
    }
}