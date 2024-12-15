Here is a C# console application that solves the problem:

```CSharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Meeting
{
    public int Start { get; set; }
    public int End { get; set; }
}

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

    public static int MinMeetingRooms(List<Meeting> meetings)
    {
        if (!meetings.Any())
        {
            return 0;
        }

        int[] startTimes = meetings.Select(m => m.Start).OrderBy(x => x).ToArray();
        int[] endTimes = meetings.Select(m => m.End).OrderBy(x => x).ToArray();

        int startPointer = 0, endPointer = 0;
        int usedRooms = 0, minRooms = 0;

        while (startPointer < meetings.Count)
        {
            if (startTimes[startPointer] >= endTimes[endPointer])
            {
                usedRooms--;
                endPointer++;
            }

            usedRooms++;
            startPointer++;

            minRooms = Math.Max(minRooms, usedRooms);
        }

        return minRooms;
    }
}
```

This program defines a `Meeting` class with `Start` and `End` properties. It then defines a `MinMeetingRooms` function that takes a list of meetings and returns the minimum number of meeting rooms required. The function works by sorting the start and end times of the meetings, then iterating through them and keeping track of the number of rooms in use. If a meeting starts after another one ends, it can use the same room, so the number of rooms in use decreases. If a meeting starts before another one ends, a new room is needed, so the number of rooms in use increases. The function returns the maximum number of rooms in use at any point, which is the minimum number of rooms required. The `Main` function creates a list of meetings and prints the result of the `MinMeetingRooms` function.