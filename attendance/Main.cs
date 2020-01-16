using attendance.DataSet1TableAdapters;
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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public int UserID { get; set; }
        public Main()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if(loggedIn==0)
            {
                // open login form
                Login newlogin = new Login();
                newlogin.ShowDialog();

                if (newlogin.LoginFlag == false)
                {
                    Close();
                }
                else
                {
                    UserID = newlogin.UserID;
                    toolStripStatusLabel2.Text = UserID.ToString();
                    loggedIn = 1;
                    this.classesTableAdapter.Fill(this.dataSet1.Classes);
                    classesBindingSource.Filter = "UserID='" + UserID.ToString() + "'";
                }
            }
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Addclass addclass = new Addclass();
            addclass.UserID = this.UserID;
            addclass.ShowDialog();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.ClassName = metroComboBox1.Text;
            students.ClassID = (int)metroComboBox1.SelectedValue;
            students.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            //check if records exists if yes load them for edit or if not create a record for each student and load for edit
            AttendanceReportTableAdapter ada = new AttendanceReportTableAdapter();
            DataTable dt = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);

            if(dt.Rows.Count>0)
            {
                //we have records, so we can edit them
                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;

            }
            else
            {
                //create record for each student
                //get the class student list
                StudentsTableAdapter student_adap = new StudentsTableAdapter();
                DataTable dt_students = student_adap.GetDataByClassID((int)metroComboBox1.SelectedValue);
                foreach(DataRow row in dt_students.Rows)
                {
                    //insert new record for this student
                    ada.InsertQuery((int)row[0], (int)metroComboBox1.SelectedValue, dateTimePicker1.Text, "", row[1].ToString(), metroComboBox1.Text);


                }
                DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                dataGridView1.DataSource = dt_new;
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AttendanceReportTableAdapter ada = new AttendanceReportTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery(row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                }
            }
            DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AttendanceReportTableAdapter ada = new AttendanceReportTableAdapter();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    ada.UpdateQuery("", row.Cells[0].Value.ToString(), (int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
                }
            }
            DataTable dt_new = ada.GetDataBy((int)metroComboBox1.SelectedValue, dateTimePicker1.Text);
            dataGridView1.DataSource = dt_new;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            //get student
            StudentsTableAdapter student_adap = new StudentsTableAdapter();
            DataTable dt_students = student_adap.GetDataByClassID((int)metroComboBox2.SelectedValue);

            AttendanceReportTableAdapter ada = new AttendanceReportTableAdapter();
            //lookp through students and get the values

            int P = 0, A = 0, L = 0, E= 0;
            foreach (DataRow row in dt_students.Rows)
            {
                //presence count
                P = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "present").Rows[0][6];


                //absence count
                A = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "absent").Rows[0][6];

                //late
                L = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "late").Rows[0][6];


                //excuses
                E = (int)ada.GetDataByReport(dateTimePicker2.Value.Month, row[1].ToString(), "excused").Rows[0][6];

                ListViewItem listem = new ListViewItem();
                listem.Text = row[1].ToString();
                listem.SubItems.Add(P.ToString());
                listem.SubItems.Add(A.ToString());
                listem.SubItems.Add(L.ToString());
                listem.SubItems.Add(E.ToString());
                listView1.Items.Add(listem);

            }

            //add to listview

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
    }
}
