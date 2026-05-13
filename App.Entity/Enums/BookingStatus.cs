namespace App.Entity.Enums
{
    public enum BookingStatus
    {
        Reserved = 1,     // PNR created, seat locked
        Confirmed,    // payment completed, ticket issued
        CheckedIn,    // passenger checked in
        Cancelled,    // user/system cancelled
        NoShow,       // flight departed, passenger absent
        Completed     // journey completed (flight landed)
    }
}