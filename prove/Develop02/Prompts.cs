class Prompts
{
    public List<string> _prompts;
    public Random rnd; 



    public void Promt_dict()
    {
        _prompts = new List<string>
        {
            "What emotion did I feel most strongly today, and why?",
            "What’s something I’ve been avoiding, and how does it affect me?",
            "When was the last time I felt truly at peace?",
            "How have I changed in the past year?",
            "What am I most grateful for right now?",
            "What’s one small habit I could start to improve my life?",
            "Where do I want to be in six months, and what can I do this week to get closer?"
        };

    }
    

    public string Show()
    {
        Promt_dict(); 
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count); 
        return _prompts[index];  
    }
}