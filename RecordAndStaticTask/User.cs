namespace RecordAndStaticTask
{
    public class User
    {

        private static int _id;
        public readonly int Id;
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email, string password, string fullname)
        {
            Email = email;
            Password = password;
            FullName = fullname;
            Id = ++_id;
        }

        public static bool PasswordChecker(string pw)
        {
            bool ContainsUpper = false;
            bool ContainsLower = false;
            bool ContainsDigit = false;

            for (int i = 0; i < pw.Length; i++)
            {
                if (char.IsUpper(pw[i]))
                    ContainsUpper = true;
                if (char.IsLetter(pw[i]))
                    ContainsLower = true;
                if (char.IsDigit(pw[i]))
                    ContainsDigit = true;
            }

            return ContainsUpper && ContainsLower && ContainsDigit && pw.Length >= 8;
        }

        public string GetInfo()
        {
            return $"FullName : {FullName}, Id : {Id} , Email : {Email}";
        }

        public static string FindUserById(int id, User[] users)
        {
            foreach (var user in users)
            {
                if (id == user.Id)
                    return $"FullName : {user.FullName}, Id : {user.Id} , Email : {user.Email}";
            }
            return "No user with given Id";
        }
    }
}
