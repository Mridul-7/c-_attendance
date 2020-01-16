using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendance
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(TxtPass1.Text!=TxtPass2.Text)
            {
                MessageBox.Show("Password not matched");
                return;
            }
            DataSet1TableAdapters.UsersTableAdapter ada = new DataSet1TableAdapters.UsersTableAdapter();
            ada.InsertQuery(TxtUser.Text,TxtPass1.Text);
            MessageBox.Show("Registeration Successfull");
            Close();
        }
    }
}
