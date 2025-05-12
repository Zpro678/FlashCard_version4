using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class AnswerDAO
    {
        private static AnswerDAO instance;

        public static AnswerDAO Instance { 
            get
            {
                if (instance == null)
                    instance = new AnswerDAO();
                return instance;
            }
            set => instance = value; 
        }

        public List<ANSWER> getListAnswer(int id)
        {
            string query = "SELECT * FROM ANSWER WHERE CARD_ID = @ID";

            List<Object> parameters = new List<object>();

            parameters.Add(id);

            List<ANSWER> lsAnswers = new List<ANSWER>();

            DataTable table = DataProvider.Instance.executeReader(query, parameters);

            foreach(DataRow row in table.Rows)
            {
                ANSWER answer = new ANSWER(row);
                answer.Card = CardDAO.Instance.getCardByID(answer.CardId);
                lsAnswers.Add(answer);
            }
            return lsAnswers;
        }

        public int addAnswer(ANSWER answer)
        {
            string query = "INSERT INTO ANSWER(CARD_ID, ANSWER_ID, ANSWER_TEXT) "
                + "VALUES (@CARD_ID, @ANSWER_ID, @ANSWER_TEXT)";
            List<object> parameters = new List<object>();
            parameters.Add(answer.CardId);
            parameters.Add(answer.AnswerId);
            parameters.Add(answer.AnswerText);
            int result = DataProvider.Instance.executeNonQuery(query, parameters);
            return result;
        }
    }
}
