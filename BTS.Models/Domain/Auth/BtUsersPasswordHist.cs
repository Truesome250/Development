namespace BTS.Models.Domain.Auth
{
    public class BtUsersPasswordHist : BaseObject
    {
        public string HistoryId { get; set; }
        public string AppUserId { get; set; }
        public int PwdCount { get; set; }
        public string PwdEncrypt { get; set; }
    }
}
