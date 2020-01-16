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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public bool LoginFlag { get; set; }
        public int UserID { get; set; }
        public Login()
        {
            InitializeComponent();
            LoginFlag = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter userAda = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPass(metroTextBox1.Text, metroTextBox2.Text);

            if(dt.Rows.Count>0)
            {
                //valid login
                MessageBox.Show("Logged In");
                UserID = int.Parse(dt.Rows[0]["UserID"].ToString());
                LoginFlag = true;

            }
            else
            {
                //invlaid login
                MessageBox.Show("incorrect credentials");
                LoginFlag = false;
            }
            Close();

        }
    }
}
