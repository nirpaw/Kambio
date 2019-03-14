using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FireSharp.Response;
using Newtonsoft.Json;

namespace ClassLibrary1
{
    public class MenuWizard
    {
        public User LoggedInUser { get; set; }
        public List<SessionManager> ActiveSessions { get; set; }
        public List<User> ActiveUsers { get; set; }
        
        public MenuWizard(User iLoggedInUser)
        {
            LoggedInUser = iLoggedInUser;
            ActiveUsers = DataBaseActions.GetActiveUserList();
            DataBaseActions.AddUserToDB(LoggedInUser);
        }

        private  void getActiveUsers()
        {
            FirebaseResponse response =  DataBaseActions.Client.Get("Users");
            dynamic rooms = JsonConvert.DeserializeObject(response.Body);
            if (rooms != null)
            {
                foreach (var room in rooms)
                {
                    ActiveUsers.Add(room);
                }
            }

        }
    }
}