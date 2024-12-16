import heapq

def min_meeting_rooms(intervals):
    if not intervals:
        return 0

    intervals.sort(key=lambda x: x[0])

    meeting_rooms = []
    heapq.heappush(meeting_rooms, intervals[0][1])