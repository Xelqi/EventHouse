namespace frontend
{
    /*public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
    } */

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public User(string u, string p)
        {
            Username = u;
            Password = p;
        }
    }
}
