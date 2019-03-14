using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public int Points { get; set; }
        public int GamesCounter { get; set; }
        public int WinsCounter{ get; set; }
        public bool IsOnline { get; set; }

        public User(string iUserName)
        {
            UserID = UserIdFactory.getId();
            UserName = iUserName;
            Points = 0;
            GamesCounter = 0;
            WinsCounter = 0;
            IsOnline = true;
        }

        public override string ToString()
        {
            return string.Format("{0} [{1}]", UserName, Points);
        }
    }
}
