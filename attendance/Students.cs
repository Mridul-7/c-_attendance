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
    public partial class Students : MetroFramework.Forms.MetroForm
    {
        public int ClassID { get; set; }
        public String ClassName { get; set; }
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dataSet1.Students);
            metroLabel2.Text = ClassName.ToString();
            metroLabel4.Text = ClassID.ToString();

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.studentsBindingSource.EndEdit();
            this.studentsTableAdapter.Update(dataSet1.Students);
        }
    }
}
