namespace error
{
    using System.Data;
    using System.Data.SqlClient;
    public partial class Frmins : Form
    {
        SqlConnection conn = new SqlConnection("server=(local); database=EmployeeData; integrated security=true");
        public Frmins()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" && txtnational.Text == "" && txtbirth.Text == "" && txtaddres.Text == "" && txtphone.Text == "")
            {
                MessageBox.Show("invalied data");
            }
            else
            {
                try
                {
                    SqlCommand ccmd = new SqlCommand("insert into Emp_data (Emp_name,Emp_nationalid,Emp_birthdate,Emp_address,Emp_phone) values(@name,@nationalid,@datebirth,@address,@phone)", conn);
                    ccmd.Parameters.AddWithValue("name", txtname.Text);
                    ccmd.Parameters.AddWithValue("nationalid", txtnational.Text);
                    ccmd.Parameters.AddWithValue("datebirth", txtbirth.Text);
                    ccmd.Parameters.AddWithValue("address", txtaddres.Text);
                    ccmd.Parameters.AddWithValue("phone", txtphone.Text);
                    conn.Open();
                    int h = ccmd.ExecuteNonQuery();
                    if (h > 0)
                    {
                        txtname.Clear();
                        txtnational.Clear();
                        txtbirth.Clear();
                        txtaddres.Clear();
                        txtphone.Clear();
                        MessageBox.Show("added");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");

                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}