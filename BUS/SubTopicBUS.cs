using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class SubTopicBUS
    {
        private static SubTopicBUS instance;

        public static SubTopicBUS Instance { 
            get
            {
                if (instance == null)
                    instance = new SubTopicBUS();
                return instance;
            }
            set => instance = value; 
        }

        public int addImage(SUBTOPIC subTopic)
        {
            try
            {
                return SubTopicDAO.Instance.addImage(subTopic);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
