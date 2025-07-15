namespace SMSModels.Models.Structs;
public struct TimeSlot {
    public string DayOfWeek { get; }
    public TimeSpan StartTime { get; }
    public TimeSpan EndTime { get; }

    public TimeSlot(string dayOfWeek, TimeSpan starttime, TimeSpan endtime) {
        DayOfWeek = dayOfWeek;
        StartTime = starttime;
        EndTime = endtime;
    }

    public override string ToString()
        => $"{DayOfWeek} {StartTime}-{EndTime}";
}
