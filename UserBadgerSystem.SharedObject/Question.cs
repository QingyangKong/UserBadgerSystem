using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserBadgerSystem.SharedObject
{
    public class Question
    {
        public Guid QuestionId { get; set; }
        public Guid AskedBy { get; set; }
        public DateTime AskedOn { get; set; }
        public bool IsOpen { get; set; }
        public List<Answer> Answers { get; set; }
        public int Upvotes { get; set; }
        public int Views { get; set; }
    }
}
