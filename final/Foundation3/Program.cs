class Program
{
    static void Main()
    {
        Address addressForLecture = new Address("1234 Maplewood Dr", "Springfeild", "IL", "62704");
        Address addressForReception = new Address("456 Park Ave", "Los Angeles", "CA", "90001");
        Address addressForOutdoor = new Address("789 Sunset Blvd", "Miami", "FL", "33101");

        Lecture lecture = new Lecture("How to Teach 101", "A lecture about the importance of effecive teaching", "4/15/25", "10:00 AM", addressForLecture, "Dr. Terry Smith", 100);
        Reception reception = new Reception("Wedding Reception", "Celebrate Josh and Denise's 50th year aniverary", "1/12/26", "6:00 PM", addressForReception, "ImAExampleEmail@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Ward Picnic", "Join us for a fun outdoor picnic to kick off the semester!", "4/20/25", "12:00 PM", addressForOutdoor, "Sunny and warm");

        Console.WriteLine("");
        Console.WriteLine("Full details:"); 
        Console.WriteLine(lecture.GetDetailedEventInfo());
        Console.WriteLine(""); 
        Console.WriteLine("Short description:"); 
        Console.WriteLine(lecture.ShortSummary()); 
        Console.WriteLine(""); 
        Console.WriteLine("Standard details:");
        Console.WriteLine(lecture.GetEventSummary()); 
        Console.WriteLine(""); 
        Console.WriteLine("////////////////////////////////////////"); 

        Console.WriteLine(""); 
        Console.WriteLine("Full details:");
        Console.WriteLine(reception.GetDetailedEventInfo());
        Console.WriteLine(""); 
        Console.WriteLine("Short description:");
        Console.WriteLine(reception.ShortSummary());
        Console.WriteLine(""); 
        Console.WriteLine("Standard details:");
        Console.WriteLine(reception.GetEventSummary());
        Console.WriteLine(""); 
        Console.WriteLine("////////////////////////////////////////"); 

        Console.WriteLine(""); 
        Console.WriteLine("Full details:");
        Console.WriteLine(outdoorGathering.GetDetailedEventInfo());
        Console.WriteLine("");
        Console.WriteLine("Short description:");
        Console.WriteLine(outdoorGathering.ShortSummary());
        Console.WriteLine("");
        Console.WriteLine("Standard details:");
        Console.WriteLine(outdoorGathering.GetEventSummary());
        Console.WriteLine("");
        Console.WriteLine("////////////////////////////////////////"); 
        
    }
}
