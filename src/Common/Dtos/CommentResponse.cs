﻿using XClaim.Common.Base;

namespace XClaim.Common.Dtos;

[GenerateAutoFilter]
public class CommentResponse : BaseResponse {
    public CommentResponse(ClaimResponse? claim, PaymentResponse? payment, User? owner, string? content) {
        Claim = claim;
        Payment = payment;
        Owner = owner;
        Content = content;
    }

    public ClaimResponse? Claim { get; set; }
    public PaymentResponse? Payment { get; set; }
    public User? Owner { get; set; }
    public string? Content { get; set; }
}