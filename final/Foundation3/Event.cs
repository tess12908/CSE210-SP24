class Event
{
    protected string _title;
    protected string _des;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _des = description;
        _date = date;
        _time = time;
        _address = address; 
    }

    public string GetEventSummary()
    {
        return $"Title: {_title}\nDescription: {_des}\nDate: {_date}\nTime: {_time}\nAddress: {_address.AllTogether()}";
    }
}
