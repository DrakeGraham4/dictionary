using login.model;

User drake = new User("drake", "Iheartcode123!!");
User haven = new User("haven", "Password12");
User hannah = new User("Hannah", "Iloverocks");

Dictionary<string, User> users = new Dictionary<string, User>(){
    {drake.Name, drake},
    {haven.Name, haven},

};
users.Add(hannah.Name, hannah);


Console.Clear();
Console.WriteLine("Welcome, please log in to continue");
Console.Write("Username: ");
string? username = Console.ReadLine()?.ToLower();
Console.Write("Password: ");
string? password = Console.ReadLine();

Console.WriteLine($"{username} : {password}");

if (users.ContainsKey(username) && users[username].ValidatePassword(password))
{
    Console.WriteLine("You are in...");

}
else
{
    Console.WriteLine("You are not allowed");
}
