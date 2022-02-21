using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class User
    {
        public string Username;
        public object Password;
        public User(string username,object password)
        {
            Username = username;
            Password = password;
        }
        public string full()
        {
            return $"Username:{Username},Password:{Password}";
        }
    }
}
