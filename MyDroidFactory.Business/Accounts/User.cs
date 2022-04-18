namespace MyDroidFactory.Business;

[Serializable]
public class User
{
    private string _username;
    private string _password;

    public string UserName { get => _username; set => _username = value; }
    public string Password { get => _password; set => _password = value; }

    public User()
    {
        _username = "";
        _password = "";
    }

    public User(string username, string password)
    {
        UserName = username;
        Password = password;
    }
}
