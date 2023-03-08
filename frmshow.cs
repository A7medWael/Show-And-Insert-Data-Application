using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error
{
    public partial class frmshow : Form
    {
        SqlConnection cnn = new SqlConnection("server=(local); database=EmployeeData; integrated security=true");
        public frmshow()
        {
            InitializeComponent();
        }

        private void btndatasow_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("select Emp_name,Emp_nationalid,Emp_birthdate,Emp_address,Emp_phone from Emp_data", sqlco);
            //sqlco.Open();
            //SqlDataReader reader = command.ExecuteReader();
            //List<Clsdata> ldata = new List<Clsdata>();
            //while (reader.Read())
            //{
            //    Clsdata sdata = new Clsdata();
            //    sdata.name = (string)reader["Emp_name"];
            //    sdata.nationalid = (string)reader["Emp_nationalid"];
            //    sdata.datebirth = (DateTime)reader["Emp_birthdate"];
            //    sdata.address = (string)reader["Emp_address"];
            //    sdata.phone = (string)reader["Emp_phone"];
            //    ldata.Add(sdata);
            //}

            //sqlco.Close();
            //dgv.DataSource = ldata;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Emp_id, Emp_name,Emp_nationalid,Emp_address,Emp_birthdate,Emp_phone from Emp_data";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Clsdata> list = new List<Clsdata>();

            while (dr.Read())
            {
                Clsdata clssho = new Clsdata();
                clssho.id = (int)dr["Emp_id"];
                clssho.name = (string)dr["Emp_name"];
                clssho.nationalid = (string)dr["Emp_nationalid"];
                clssho.datebirth = (DateTime)dr["Emp_birthdate"];
                clssho.address = (string)dr["Emp_address"];
                clssho.phone = (string)dr["Emp_phone"];
                list.Add(clssho);
            }
            cnn.Close();

            dgv.DataSource = list;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Frmins frmin = new Frmins();
            frmin.Show();
            this.Dispose(false);
        }
    }
}
