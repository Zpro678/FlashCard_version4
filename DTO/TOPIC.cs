using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TOPIC
    { 
        private int id;
        private string imageName;
        private string topicName;
        private List<SUBTOPIC> lsTopic;
        public int Id { get => id; set => id = value; }
        public string ImageName { get => imageName; set => imageName = value; }
        public string TopicName { get => topicName; set => topicName = value; }
        public List<SUBTOPIC> LsTopic { get => lsTopic; set => lsTopic = value; }

        public TOPIC() { }

        public TOPIC(DataRow row)
        {
            Id = Int32.Parse(row["id"].ToString());
            ImageName = row["image_name"].ToString();
            TopicName = row["topic_name"].ToString();
        }

        public TOPIC(int id, string image, string name)
        {
            Id = id;
            ImageName = image;
            TopicName = name;
        }
    }
}
