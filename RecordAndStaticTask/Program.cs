namespace RecordAndStaticTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"User {i + 1}");
                users[i] = CreateUser();
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Show all students");
                Console.WriteLine("2. Get info by id");
                Console.WriteLine("0.Quit");
                Console.Write("Enter operation : ");
                string opt = Console.ReadLine();
                if (opt == "1")
                {
                    foreach (var user in users)
                    {
                        Console.WriteLine(user.GetInfo());
                    }
                }
                else if (opt == "2")
                {
                    Console.Write("Enter Id to get User : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine(User.FindUserById(id, users));
                }
                else if (opt == "0")
                {
                    break;
                }
                else
                    Console.WriteLine("Please enter valid operation!");
                Console.ReadLine();
            }
        }

        public static User CreateUser()
        {
            Console.Write("Please enter your Full Name : ");
            string fullname = Console.ReadLine();
            Console.Write("Please enter your Email : ");
            string email = Console.ReadLine();
            string pw;
            while (true)
            {
                Console.Write("Please enter your Password : ");
                pw = Console.ReadLine();
                if (User.PasswordChecker(pw))
                    break;
                Console.WriteLine("Please enter valid password!");
            }
            
            return new User(email, pw, fullname);
        }
    }
}
