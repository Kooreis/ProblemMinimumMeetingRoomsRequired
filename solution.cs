public class Program
{
    public static void Main(string[] args)
    {
        List<Meeting> meetings = new List<Meeting>
        {
            new Meeting { Start = 1, End = 4 },
            new Meeting { Start = 2, End = 5 },
            new Meeting { Start = 3, End = 6 }
        };

        Console.WriteLine(MinMeetingRooms(meetings));
    }