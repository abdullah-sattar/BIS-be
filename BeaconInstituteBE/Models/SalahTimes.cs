namespace BeaconInstituteBE.Models
{
    public class SalahTimes
    {
        public int ID { get; private set; }
        public DateOnly date { get; private set; }
        public TimeOnly fajrBegins { get; private set; }
        public TimeOnly fajrJammah { get; private set; }
        public TimeOnly Sunrise { get; private set; }
        public TimeOnly zuhrBegins { get; private set; }
        public TimeOnly zuhrJammah { get; private set; }
        public TimeOnly asrMithl1 { get; private set; }
        public TimeOnly asrMithl2 { get; private set; }
        public TimeOnly asrJammah { get; private set; }
        public TimeOnly maghribBegins { get; private set; }
        public TimeOnly maghribJammah { get; private set; }
        public TimeOnly ishaBegins { get; private set; }
        public TimeOnly ishaJammah { get; private set; }

    }
}
