using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class TopicDAO
    {
        private static TopicDAO instance;

        public static TopicDAO Instance {
            get
            {
                if (instance == null)
                    instance = new TopicDAO();
                return instance;
            }
            set => instance = value; 
        }

        public List<TOPIC> getListTopic()
        {
            string query = "SELECT * FROM TOPIC";
            DataTable table = DataProvider.Instance.executeReader(query);
            List<TOPIC> lsTopic = new List<TOPIC>();

            foreach(DataRow row in table.Rows)
            {
                TOPIC topic = new TOPIC(row);
                topic.LsTopic = SubTopicDAO.Instance.getListSubTopicByTopicID(topic.Id);
                lsTopic.Add(topic);
            }
            return lsTopic;
        }

        public TOPIC getTopicByID(int id)
        {
            string query = "SELECT * FROM TOPIC WHERE ID = @ID";
            List<object> parameters = new List<object>();
            parameters.Add(id);

            DataTable table = DataProvider.Instance.executeReader(query, parameters);

            TOPIC topic = new TOPIC(table.Rows[0]);

            topic.LsTopic = SubTopicDAO.Instance.getListSubTopicByTopicID(topic.Id);
            return topic;
        }

        public int addTopic(TOPIC topic)
        {
            string query = "INSERT INTO TOPIC (IMAGE_NAME, TOPIC_NAME) "
                + "VALUES (@IMAGE_NAME, @TOPIC_NAME)";

            List<object> paramters = new List<object>();

            paramters.Add(topic.ImageName);
            paramters.Add(topic.TopicName);

            int result = DataProvider.Instance.executeNonQuery(query, paramters);

            return result;
        }

        public int addPicture(TOPIC topic)
        {
            string query = "UPDATE TOPIC SET IMAGE_NAME = @IMAGE_NAME WHERE ID = @ID";

            List<object> parameters = new List<object>();

            parameters.Add(topic.ImageName);

            parameters.Add(topic.Id);

            int result = DataProvider.Instance.executeNonQuery(query, parameters);

            return result;
        }    
    }
}
