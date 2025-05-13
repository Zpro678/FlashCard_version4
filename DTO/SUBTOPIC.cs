using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SUBTOPIC
    {
        private int id;
        private string imageName;
        private string topicName;
        private int topicId;
        private string subtopicName;
        private List<CARD> lsCards;
        public int Id { get => id; set => id = value; }
        public string ImageName { get => imageName; set => imageName = value; }
        public string SubtopicName { get => subtopicName; set => subtopicName = value; }
        public int TopicId { get => topicId; set => topicId = value; }
        public List<CARD> LsCards { get => lsCards; set => lsCards = value; }
        public string TopicName { get => topicName; set => topicName = value; }

        public SUBTOPIC() { }

        public SUBTOPIC(DataRow row)
        {
            Id = Int32.Parse(row["id"].ToString());
            ImageName = row["image_name"].ToString();
            SubtopicName = row["subtopic_name"].ToString();
            TopicId = Int32.Parse(row["topic_id"].ToString());
        }

    }
}
