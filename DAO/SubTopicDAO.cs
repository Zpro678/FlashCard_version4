using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class SubTopicDAO
    {
        private static SubTopicDAO instance;

        public static SubTopicDAO Instance {
            get
            {
                if (instance == null)
                    instance = new SubTopicDAO();
                return instance;
            } 
                
            set => instance = value; 
        }

        public List<SUBTOPIC> getListSubTopic()
        {
            List<SUBTOPIC> lsSubTopic = new List<SUBTOPIC>();
            string query = "SELECT * FROM SUBTOPIC";
            DataTable table = DataProvider.Instance.executeReader(query);

            foreach(DataRow row in table.Rows)
            {
                SUBTOPIC subTopic = new SUBTOPIC(row);
                subTopic.Topic = TopicDAO.Instance.getTopicByID(subTopic.TopicId);
                subTopic.LsCards = CardDAO.Instance.getListCardsBySubTopicId(subTopic.Id);
                lsSubTopic.Add(subTopic);
            }
            return lsSubTopic;
        }    
        
        public List<SUBTOPIC> getListSubTopicByTopicID(int id)
        {
            List<SUBTOPIC> lsSubTopic = new List<SUBTOPIC>();
            string query = "SELECT * FROM SUBTOPIC WHERE TOPIC_ID = @TOPIC_ID";
            List<Object> parameters = new List<object>();

            parameters.Add(id);
            DataTable table = DataProvider.Instance.executeReader(query, parameters);

            foreach (DataRow row in table.Rows)
            {
                SUBTOPIC subTopic = new SUBTOPIC(row);

                subTopic.LsCards= CardDAO.Instance.getListCardsBySubTopicId(subTopic.Id);
                lsSubTopic.Add(subTopic);
            }
            return lsSubTopic;
        }

        public SUBTOPIC getSubTopicByID(int id)
        {
            string query = "SELECT * FROM SUBTOPIC WHERE ID = @ID";
            List<Object> parameters = new List<object>();

            parameters.Add(id);
            DataTable table = DataProvider.Instance.executeReader(query, parameters);

            SUBTOPIC subtopic = new SUBTOPIC(table.Rows[0]);
            subtopic.LsCards = CardDAO.Instance.getListCardsBySubTopicId(subtopic.Id);
            return subtopic;
        }
        public int addSubTopic(SUBTOPIC subTopic)
        {
            string query = "INSERT INTO SUBTOPIC (IMAGE_NAME, TOPIC_NAME, TOPIC_ID) VALUES (@IMAGE_NAME, @TOPIC_NAME, @TOPIC_ID)";

            List<Object> paramters = new List<object>();
            paramters.Add(subTopic.ImageName);
            paramters.Add(subTopic.SubtopicName);
            paramters.Add(subTopic.TopicId);

            int result = DataProvider.Instance.executeNonQuery(query, paramters);

            return result;
        }
    }
}
