public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public void GetInfo()
    {
        System.Console.WriteLine($"{FirstName} {LastName}");
    }
    public void Login()
    {
        string username=Console.ReadLine();
        string password=Console.ReadLine();
        if (UserName==username && Password==password)
        {
            System.Console.WriteLine("Login successful!");
        }
        else System.Console.WriteLine("Your Login or Password Failed");
    }
}