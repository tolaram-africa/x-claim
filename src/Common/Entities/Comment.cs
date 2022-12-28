﻿using XClaim.Common.Base;

namespace XClaim.Common.Entities;

public class Comment : BaseEntity {
    public Claim? Claim { get; set; }
    public Payment? Payment { get; set; }
    public User User { get; set; }
    public string? Message { get; set; }
}
