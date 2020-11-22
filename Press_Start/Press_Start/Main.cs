using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Press_Start
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Gamepad id = new Gamepad(txt_id.Text, txt_manufacture.Text, txt_description.Text, txt_model.Text, int.Parse(txt_stock.Text), decimal.Parse(txt_price.Text));
            MessageBox.Show(id.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new About().Show();
            
        }
    }
}
