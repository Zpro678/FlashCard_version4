using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class CardDAO
    {
        private static CardDAO instance;

        public static CardDAO Instance {
            get
            {
                if (instance == null)
                    instance = new CardDAO();
                return instance;
            } 
                
            set => instance = value; 
        }

        public List<CARD> getListCards()
        {
            string query = "SELECT * FROM CARD";

            List<CARD> lsCards = new List<CARD>();

            DataTable table = DataProvider.Instance.executeReader(query);

            foreach(DataRow row in table.Rows)
            {
                CARD card = new CARD(row);
                lsCards.Add(card);
            }
            return lsCards;
        }

        public List<CARD> getListCardsBySubTopicId(int id)
        {
            string query = "SELECT * FROM CARD WHERE SUBTOPIC_ID = @ID";
            List<Object> parameters = new List<object>();
            parameters.Add(id);

            List<CARD> lsCards = new List<CARD>();

            DataTable table = DataProvider.Instance.executeReader(query, parameters);
            foreach(DataRow row in table.Rows)
            {
                CARD card = new CARD(row);
                lsCards.Add(card);
            }
            return lsCards;
        }
        
        public CARD getCardByID(int id)
        {
            string query = "SELECT * FROM CARD WHERE ID = @ID";
            List<Object> parameters = new List<object>();
            parameters.Add(id);

            DataTable table = DataProvider.Instance.executeReader(query, parameters);

            CARD card = new CARD(table.Rows[0]);
            return card;
        }

        public int addCard(CARD card)
        {
            string query = "INSERT INTO CARD (Correct_Answert, Question_Cate, Question, SubTopic_ID)" +
                (" VALUES (@Correct, @Question_Cate, @Question, @SubTopic_ID)");

            List<object> parameters = new List<object>();
            parameters.Add(card.QuestionCate);
            parameters.Add(card.Question);
            parameters.Add(card.SubTopicId);

            int result = DataProvider.Instance.executeNonQuery(query, parameters);

            return result;
        }

    }
}
