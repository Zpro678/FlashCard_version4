using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CardBUS
    {
        private static CardBUS instance;

        public static CardBUS Instance { 
            get
            {
                if (instance == null)
                    instance = new CardBUS();
                return instance;
            }
            set => instance = value; 
        }

    }
}
