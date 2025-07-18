class ListMaker
{
    private List<Activity> _activitiesList = new List<Activity>();

    public void AddActivity(Activity activity)
    {
        _activitiesList.Add(activity);
    }

    public string GetAllSummaries()
    {
        string summaries = "";
        foreach (Activity activity in _activitiesList)
        {
            summaries += activity.GetSummary() + "\n" + "\n";
        }
        return summaries;
    }
}