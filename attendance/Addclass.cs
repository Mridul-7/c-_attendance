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
    public partial class Addclass : MetroFramework.Forms.MetroForm
    {
        public int UserID { get; set; }
        
        public Addclass()
        {
            InitializeComponent();
        }

        private void Addclass_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClassesTableAdapter ada = new DataSet1TableAdapters.ClassesTableAdapter();
            ada.AddClass(metroTextBox1.Text,UserID);
            Close();
        }
    }
}
