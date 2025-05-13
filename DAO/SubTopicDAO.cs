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
                subTopic.TopicName = TopicDAO.Instance.getTopicNameByID(subTopic.TopicId);
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
                subTopic.TopicName = TopicDAO.Instance.getTopicNameByID(subTopic.TopicId);
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
            string query = "INSERT INTO SUBTOPIC (IMAGE_NAME, SUBTOPIC_NAME, TOPIC_ID) VALUES (@IMAGE_NAME, @SUBTOPIC_NAME, @TOPIC_ID)";

            List<Object> paramters = new List<object>();
            paramters.Add(subTopic.ImageName);
            paramters.Add(subTopic.SubtopicName);
            paramters.Add(subTopic.TopicId);

            int result = DataProvider.Instance.executeNonQuery(query, paramters);

            return result;
        }

        public int addImage(SUBTOPIC subtopic)
        {
            string query = "UPDATE SUBTOPIC SET IMAGE_NAME = @IMAGE_NAME WHERE ID = @ID";

            List<object> parameters = new List<object>();

            parameters.Add(subtopic.ImageName);
            parameters.Add(subtopic.Id);

            int result = DataProvider.Instance.executeNonQuery(query, parameters);

            return result;
        }
    }
}
