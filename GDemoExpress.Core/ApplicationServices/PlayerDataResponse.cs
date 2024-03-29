﻿namespace GDemoExpress.Core.ApplicationServices
{
    public record PlayerDataResponse(
        Guid PlayerId,
        string Account,
        PlayerStatus Status,
        string? LastName,
        string? FullName,
        string? NickName,
        string? PhoneNumber,
        string? Mailbox,
        DateTimeOffset CreatedOn,
        DateTimeOffset UpdatedOn);
}
