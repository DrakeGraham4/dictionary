namespace login.model
{
    public class User
    {       //Properties Auto Prop
        public string? Name { get; set; }

        // Private Only useable within this class
        private string? _Password { get; set; }


        //Method If you find yourself writing an if statement for true or false, just right what's below
        public bool ValidatePassword(string input)
        {
            return input == _Password;
        }

        //No return type, name matches class means it's a constructor
        public User(string? name, string? password)
        {
            Name = name.ToLower();
            _Password = password;
        }


    }
}