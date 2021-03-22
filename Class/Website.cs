using System.IO;
using KPMToCSV.Extensions;


namespace KPMToCSV.Class
{
    public class Website : CSVLine
    {
        public const string WebsiteName = "Website name:";
        private const string WebsiteNameUrl = "Website URL:";
        private const string LoginId = "Login:";
        private const string Password = "Password:";
        private const string Comment = "Comment:";
       
        public Website(string name, StreamReader reader)
        {
            Name = name;
            Url = reader.ReadLine()?.MatchRemoveAndTrim(WebsiteNameUrl);
            reader.ReadLine();//Ignore this line;
            Login = reader.ReadLine()?.MatchRemoveAndTrim(LoginId);
            Pwd = reader.ReadLine()?.MatchRemoveAndTrim(Password);
            Note = reader.ReadLine()?.MatchRemoveAndTrim(Comment);
        }
    }
}
