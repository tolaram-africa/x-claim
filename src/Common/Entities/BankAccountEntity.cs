﻿using System.ComponentModel.DataAnnotations;
using XClaim.Common.Base;

namespace XClaim.Common.Entities;

public sealed class BankAccountEntity : BaseEntity {
    public string FullName { get; set; } = string.Empty;
    [Required]
    public BankEntity? Bank { get; set; }
    public Guid? BankId { get; set; }
    public UserEntity? Owner { get; set; }
    public Guid? OwnerId { get; set; }
    [Required]
    [MaxLength(20)]
    public string? Number { get; set; }
    [MaxLength(1024)]
    public string? Description { get; set; }
}