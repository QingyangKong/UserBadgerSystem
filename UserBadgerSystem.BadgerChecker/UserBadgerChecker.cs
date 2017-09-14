using System;
using System.Collections.Generic;
using UserBadgerSystem.SharedObject;
using System.IO;
using System.Configuration;
using System.Reflection;
using UserBadgerSystem.Interface;

namespace UserBadgerSystem.BadgerChecker
{
    public class UserBadgerChecker
    {
        public List<IUserBadger> userBadgers;
        public List<Tuple<string, bool>> results;

        public UserBadgerChecker()
        {
            LoadBadgers();
        }

        public void LoadBadgers()
        {
            userBadgers = new List<IUserBadger>();

            string path = ConfigurationManager.AppSettings["PathToDlls"];
            IEnumerable<string> dlls = Directory.EnumerateFiles(path, "*.dll", SearchOption.TopDirectoryOnly);
            foreach (string dll in dlls)
            {
                Assembly assembly = Assembly.LoadFrom(dll);
                IEnumerable<Type> types = assembly.ExportedTypes;
                foreach (Type type in types)
                {
                    if (type.IsClass && typeof(IUserBadger).IsAssignableFrom(type))
                    {
                        IUserBadger userBadger = Activator.CreateInstance(type) as IUserBadger;
                        userBadgers.Add(userBadger);
                    }
                }
            }
        }

        public void CheckUsers(User user)
        {
            results = new List<Tuple<string, bool>>();
            foreach (IUserBadger badger in userBadgers)
            {
                results.Add(new Tuple<string, bool>(badger.BadgerName(), badger.CheckUser(user)));
            }
        }

    }
}
