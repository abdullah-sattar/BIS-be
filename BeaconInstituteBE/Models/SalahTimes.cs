namespace BeaconInstituteBE.Models
{
    public class SalahTimes
    {
        public int ID { get; private set; }
        public DateOnly d_date { get; private set; }
        public TimeOnly fajr_begins { get; private set; }
        public TimeOnly fajr_jamah { get; private set; }
        public TimeOnly sunrise { get; private set; }
        public TimeOnly zuhr_begins { get; private set; }
        public TimeOnly zuhr_jamah { get; private set; }
        public TimeOnly asr_mithl_1 { get; private set; }
        public TimeOnly asr_mithl_2 { get; private set; }
        public TimeOnly asr_jamah { get; private set; }
        public TimeOnly maghrib_begins { get; private set; }
        public TimeOnly maghrib_jamah { get; private set; }
        public TimeOnly isha_begins { get; private set; }
        public TimeOnly isha_jamah { get; private set; }

    }
}
