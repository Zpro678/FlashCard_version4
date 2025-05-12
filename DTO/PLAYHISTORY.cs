using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PLAYHISTORY
    {
        private int id;
        private DateTime timeHistory;

        public int Id { get => id; set => id = value; }
        public DateTime TimeHistory { get => timeHistory; set => timeHistory = value; }

        public PLAYHISTORY() { }

        public PLAYHISTORY(DataRow row)
        {
            Id = Int32.Parse(row["id"].ToString());
            TimeHistory = DateTime.Parse(row["time_history"].ToString());
        }    
    }
}
