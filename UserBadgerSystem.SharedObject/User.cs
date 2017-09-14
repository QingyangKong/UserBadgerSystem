using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBadgerSystem.SharedObject
{
    public class User
    {
        public Guid UserId { get; set; }
        public List<Question> Questions { get; set; }
        public List<Answer> Answers { get; set; }
        public DateTime RegisteredOn { get; set; }
        public int Reputation { get; set; }
    }
}
