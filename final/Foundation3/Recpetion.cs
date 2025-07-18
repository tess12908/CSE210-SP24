class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string  date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvp = rsvpEmail;
    }

    public string GetDetailedEventInfo()
    {
        return $"{GetEventSummary()}\nEvent Type: Reception\nRSVP Email: {_rsvp}";
    }

       public string ShortSummary()
    {
        return $"Reception: {_title} on {_date} at {_address.AllTogether()} "; 
    }
}