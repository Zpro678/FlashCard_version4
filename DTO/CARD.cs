using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CARD
    {
        private int id;
        private int questionCate;
        private string question;
        private int subTopicId;
        private string subTopicName;
        private List<ANSWER> lsanswers;

        public int Id { get => id; set => id = value; }
        public int QuestionCate { get => questionCate; set => questionCate = value; }
        public string Question { get => question; set => question = value; }
        public int SubTopicId { get => subTopicId; set => subTopicId = value; }
        public List<ANSWER> Lsanswers { get => lsanswers; set => lsanswers = value; }
        public string SubTopicName { get => subTopicName; set => subTopicName = value; }

        public CARD() { }

        public CARD(DataRow row)
        {
            Id = Int32.Parse(row["id"].ToString());
            QuestionCate = Int32.Parse(row["question_cate"].ToString());
            Question = row["question"].ToString();
            SubTopicId = Int32.Parse(row["subtopic_id"].ToString());
        }
    }
}
