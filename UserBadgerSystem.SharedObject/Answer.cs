using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBadgerSystem.SharedObject
{
    public class Answer
    {
        public Guid AnswerId { get; set; }
        public Guid QuestionId { get; set; }
        public Guid AnsweredBy { get; set; }
        public DateTime AnswerDate { get; set; }
        public int Upvotes { get; set; }
    }
}
