using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserBadgerSystem.Interface;
using UserBadgerSystem.SharedObject;

namespace UserBadgerSystem.Badgers
{
    public class NotableQuestion : IUserBadger
    {
        public string BadgerName()
        {
            return "Notable Question";
        }

        public bool CheckUser(User user)
        {
            bool qualified = false;
            foreach (var question in user.Questions)
            {
                if (question.Views >= 2500)
                {
                    qualified = true;
                    break;
                }
            }
            return qualified;
        }
    }
}
