using XClaim.Common.Base;

namespace XClaim.Web.Server.Entities;

public class TransferRequestEntity : BaseEntity {
    public UserEntity? User { get; set; }
    public Guid? UserId { get; set; }
    public CompanyEntity? Company { get; set; }
    public Guid? CompanyId { get; set; }
    public bool Completed { get; set; }
}