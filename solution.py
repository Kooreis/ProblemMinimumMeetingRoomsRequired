Here is a Python console application that solves the problem:

```python
import heapq

def min_meeting_rooms(intervals):
    if not intervals:
        return 0

    intervals.sort(key=lambda x: x[0])

    meeting_rooms = []
    heapq.heappush(meeting_rooms, intervals[0][1])

    for i in range(1, len(intervals)):
        if meeting_rooms[0] <= intervals[i][0]:
            heapq.heappop(meeting_rooms)

        heapq.heappush(meeting_rooms, intervals[i][1])

    return len(meeting_rooms)

def main():
    intervals = []
    n = int(input("Enter the number of meetings: "))
    for i in range(n):
        start_time = int(input("Enter the start time of meeting {}: ".format(i+1)))
        end_time = int(input("Enter the end time of meeting {}: ".format(i+1)))
        intervals.append((start_time, end_time))
    print("Minimum number of meeting rooms required: ", min_meeting_rooms(intervals))

if __name__ == "__main__":
    main()
```

This console application first asks for the number of meetings. Then for each meeting, it asks for the start and end times. It then calculates and prints the minimum number of meeting rooms required. The calculation is done by sorting the intervals by start time, then using a priority queue (implemented with a heap) to keep track of end times. If the start time of the next meeting is after the end time of the earliest ending meeting, we can use the same room, so we pop from the heap. Otherwise, we need a new room, so we push onto the heap. The size of the heap at the end is the minimum number of rooms required.