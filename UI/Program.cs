using System;
using System.Linq;
using System.Collections.Generic;
using UserBadgerSystem.BadgerChecker;
using UserBadgerSystem.SharedObject;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a users to test
            User user_1 = new User();
            Question q_1 = new Question();
            q_1.Views = 26000;
            user_1.Questions = new List<Question>();
            user_1.Questions.Add(q_1);

            UserBadgerChecker checker = new UserBadgerChecker();
            checker.CheckUsers(user_1);
            var results = checker.results;
            var qualifiedBadgers = results.Where(x => x.Item2).Select(x => x.Item1);

            //print out results
            Console.WriteLine("Qualified Badgers are: ");
            foreach (string qualifiedBadger in qualifiedBadgers)
            {
                Console.WriteLine(qualifiedBadger);
            }

            Console.ReadKey();
        }
    }
}
