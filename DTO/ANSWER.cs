using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ANSWER
    {
        private int cardId;
        private int answerId;
        private string answerText;
        private bool isTrue;
        public int CardId { get => cardId; set => cardId = value; }
        public int AnswerId { get => answerId; set => answerId = value; }
        public string AnswerText { get => answerText; set => answerText = value; }
        public bool IsTrue { get => isTrue; set => isTrue = value; }

        public ANSWER() { }

        public ANSWER(DataRow row)
        {
            CardId = Int32.Parse(row["card_id"].ToString());
            AnswerId = Int32.Parse(row["answer_id"].ToString());
            AnswerText = row["answer_text"].ToString();
            isTrue = bool.Parse(row["is_true"].ToString());
        }
    }
}
