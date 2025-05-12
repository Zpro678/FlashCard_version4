using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard_version3
{
    public partial class AddCardControl : UserControl
    {
        public AddCardControl()
        {
            InitializeComponent();
        }

        private void guna2Button_AddLittle_Click(object sender, EventArgs e)
        {
            fAddCard form_AddLittleCard = new fAddCard();
            form_AddLittleCard.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            guna2Button_AddLittle_Click((object)sender, e);
        }
    }
}
