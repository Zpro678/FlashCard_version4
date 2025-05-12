using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class TopicBUS
    {
        private static TopicBUS instance;

        public static TopicBUS Instance { 
            get
            {
                if (instance == null)
                    instance = new TopicBUS();
                return instance;
            }
            set => instance = value; 
        }

        public List<TOPIC> getListTopic()
        {
            try
            {
                return TopicDAO.Instance.getListTopic();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

            }
        }
    }
}
