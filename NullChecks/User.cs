using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullChecks;
public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public bool IsActive { get; set; }


    public User(string firstName, string lastName, bool isActive)
    {
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
        UserName = $"{FirstName}{LastName}";
    }
}
