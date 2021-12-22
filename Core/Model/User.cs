namespace Core.Model
{
    public class User : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string[] Privileges { get; set; }

        public Group[] Groups { get; set; }
    }
}
