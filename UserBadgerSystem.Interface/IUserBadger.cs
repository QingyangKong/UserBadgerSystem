using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserBadgerSystem.SharedObject;

namespace UserBadgerSystem.Interface
{
    public interface IUserBadger
    {
        bool CheckUser(User user);
        string BadgerName();
    }
}
