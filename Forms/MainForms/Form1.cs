using Project_1_SimpleCalculetor.Logical;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_SimpleCalculetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Logic_Form1 Object = new Logic_Form1();
        private void TX_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButLogin_Click(object sender, EventArgs e)
        {


            Object.Proce_Login(TX_UserName.Text, TX_Password.Text,this);
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
