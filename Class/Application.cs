using System.IO;
using KPMToCSV.Extensions;

namespace KPMToCSV.Class
{
    public class Application : CSVLine
    {
        public const string ApplicationName = "Application:";
        private const string LoginId = "Login:";
        private const string Password = "Password:";
        private const string Comment = "Comment:";

        public Application(string name, StreamReader reader)
        {
            {
                Name = name;
                reader.ReadLine();//Ignore this line;
                Login = reader.ReadLine()?.MatchRemoveAndTrim(LoginId);
                Pwd = reader.ReadLine()?.MatchRemoveAndTrim(Password);
                Note = reader.ReadLine()?.MatchRemoveAndTrim(Comment);
            }
        }
    }
}