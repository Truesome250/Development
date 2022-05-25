namespace BTS.Models.Domain.Auth
{
    public partial class BtPermission : BaseObject
    {
        public string PermissionId { get; set; } = null!;
        public string Permissions { get; set; } = null!;

    }
}
