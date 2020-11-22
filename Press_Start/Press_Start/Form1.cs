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
    public partial class Form1 : Form
    {
        public int count
        {
            get { return count; }
            set
            {
                if (count == 3)
                {
                    Application.Exit();
                }
            }
        }
        
        public void SetCount(int count)
        {
            count = 0;
            count = count + 1;
            
        }
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
           
            if (txtPassword.Text == "english123")
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
                txtPassword.Clear();
                
                
            }
        }
        private void Add(int i)
        {
           
           int add =  i;
           int count = add + 1;
            if (add == 3)
            {
                Application.Exit();
            }

        }
    }
}
