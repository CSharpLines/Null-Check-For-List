using NullChecks;

List<User> users = null;

if(users != null)
{
    if(users.Any())
    {
        // do something
    }
}

if(users != null && users.Any())
{

}

if((users?.Any()).GetValueOrDefault())
{

}

if(users?.Any() ?? false)
{

}