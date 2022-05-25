namespace BTS.Models.Domain.Auth
{
    public class BtUserLoginHistory
    {
        public string HistId { get; set; }
        public string UserId { get; set; }
        public string IpAddress { get; set; }
        public DateTime SessionDate { get; set; }
        public string Operation { get; set; }
        public string Browser { get; set; }
    }
}
