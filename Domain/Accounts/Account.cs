using Ardalis.GuardClauses;
using Oogarts.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oogarts.Domain.Accounts;

public class Account : Entity
{
    private string username = default!;
    public string Username
    {
        get => username;
        set => username = Guard.Against.NullOrWhiteSpace(value, nameof(Username));
    }

    private string password = default!;
    public string Password
    {
        get => password;
        set => password = Guard.Against.NullOrWhiteSpace(value, nameof(Password));
    }

    private int staffId = default!;

    public int StaffId
    {
        get => staffId;
        set => staffId = Guard.Against.NegativeOrZero(value, nameof(StaffId));
    }

    public Account(string username, string password, int staffId)
    {
        Username = username;
        Password = password;
        StaffId = staffId;
    }

}
