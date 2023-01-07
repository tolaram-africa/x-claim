﻿using XClaim.Common.Base;

namespace XClaim.Common.Dtos;

public record BankAccount : BaseResponse {
    public BankAccount(string? fullName, Bank? bank, User? owner, string? number, string? description) {
        FullName = fullName;
        Bank = bank;
        Owner = owner;
        Number = number;
        Description = description;
    }

    public string? FullName { get; set; } = string.Empty;
    public Bank? Bank { get; set; }
    public User? Owner { get; set; }
    public string? Number { get; set; }
    public string? Description { get; set; }
}