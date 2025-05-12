using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HISTORYCARDTOPICPLAY
    {
        private int subTopicId;
        private int cardID;
        private int playHistoryId;
        private bool isTrue;

        public int SubTopicId { get => subTopicId; set => subTopicId = value; }
        public int CardID { get => cardID; set => cardID = value; }
        public int PlayHistoryId { get => playHistoryId; set => playHistoryId = value; }
        public bool IsTrue { get => isTrue; set => isTrue = value; }

        public HISTORYCARDTOPICPLAY() { }

        public HISTORYCARDTOPICPLAY(DataRow row)
        {
            SubTopicId = Int32.Parse(row["subtopic_id"].ToString());
            cardID = Int32.Parse(row["card_id"].ToString());
            playHistoryId = Int32.Parse(row["play_history_id"].ToString());
            isTrue = bool.Parse(row["is_true"].ToString());
        }    
    }
}
