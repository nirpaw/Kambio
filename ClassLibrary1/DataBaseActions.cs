using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace ClassLibrary1
{
    public static class DataBaseActions
    {
        private static IFirebaseClient _client;
        private static IFirebaseConfig _config = new FirebaseConfig
        {
            AuthSecret = "hz1Tc1YPQf5mNTRsd5qLitggAF3hHBlGJ4M0C82V",
            BasePath = "https://kambiotest.firebaseio.com/"

        };

        static DataBaseActions()
        {
            _client = new FirebaseClient(_config);
            if (_client == null)
            {
                throw new Exception("cant set client");
            }
        }

        public static IFirebaseClient Client
        {
            get => _client;
            set => _client = value;
        }

        public static IFirebaseConfig Config
        {
            get => _config;
            set => _config = value;
        }


        public static async void AddUserToDB(User iUser)
        {
             FirebaseResponse response = await _client.PushAsync("Users/", iUser);
             User result = response.ResultAs<User>();
        }

       
        public static List<User> GetActiveUserList()
        {
            List<User> list = new List<User>();
            FirebaseResponse response = DataBaseActions.Client.Get("Users");
            List<User> sList= response.ResultAs<List<User>>();


            return sList;
        }
    }
}
