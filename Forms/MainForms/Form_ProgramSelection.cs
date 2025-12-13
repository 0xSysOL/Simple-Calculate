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
    public partial class Form_ProgramSelection : Form
    {
        public Form_ProgramSelection()
        {
            InitializeComponent();
        }
      private  Logic_ProgramSelection _LogicProgramSelection = new Logic_ProgramSelection();
      private  RadioButton get = new RadioButton();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

     




      
        private void radioChange(object sender, EventArgs e)
        {
            get = (RadioButton)sender;

            if (Convert.ToBoolean(butSubmet.Tag) == true)
            {
                _LogicProgramSelection.Proce_WitchProgramWeWantToRun(get.TabIndex,this);
            }
            butSubmet.Tag = false;

        }
        private void butSubmet_Click(object sender, EventArgs e)
        {

            butSubmet.Tag = true;
            radioChange(get, e);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
