for i in range(1, len(intervals)):
        if meeting_rooms[0] <= intervals[i][0]:
            heapq.heappop(meeting_rooms)

        heapq.heappush(meeting_rooms, intervals[i][1])