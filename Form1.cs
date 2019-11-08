using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ADO.net_Sample
{
    public partial class Form1 : Form
    {
        SqlConnection strconn;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToSQL();
            //ds.ReadXml(@"c:\users\administrator\documents\visual studio 2015\Projects\ADO.net Sample\ADO.net Sample\XMLFile1.xml");
            //dataGridView1.DataSource = ds.Tables[0];
            
            

            

        }

        private void ConnectToSQL() {
             strconn = new SqlConnection("Data Source=LASYAPC;Initial Catalog=master;Integrated Security=true;");
            strconn.Open();
             cmd = new SqlCommand();
            cmd.Connection = strconn;
            cmd.CommandType = CommandType.StoredProcedure;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataRow dr = ds.Tables[0].NewRow();
            dr["emp_id"] = txtEmpID.Text;
            dr["emp_name"] = txtEmpName.Text;
            dr["emp_age"] = txtEmpAge.Text;
            ds.Tables[0].Rows.Add(dr);
            ds.AcceptChanges();
            ds.WriteXml(@"c:\users\administrator\documents\visual studio 2015\Projects\ADO.net Sample\ADO.net Sample\WriteXml.xml");
        }

        private void getEmpDetails()
        {
            ConnectToSQL();
            cmd.CommandText = "sp_getEmpDetails";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btngetDetails_Click(object sender, EventArgs e)
        {
            getEmpDetails();
        }

        private void btnInsert_Click(object sender, EventArgs e)
           {
            ConnectToSQL();
            cmd.CommandText = "sp_insertEmpDetails";
            SqlParameter par1, par2, par3,par4,par5;
             par1 = new SqlParameter("@emp_id",SqlDbType.Int);
            par1.Value = txtEmpID.Text.Trim();
            par2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
            par2.Value = txtEmpName.Text.Trim();
            par3 = new SqlParameter("@emp_age", SqlDbType.Int);
            par3.Value = txtEmpAge.Text.Trim();
            par4 = new SqlParameter("@emp_sal", SqlDbType.Int);
            par4.Value = txtEmpSal.Text.Trim();
            par5 = new SqlParameter("@empDOB", SqlDbType.DateTime);
            par5.Value = txtEmpDOB.Text.Trim();
            cmd.Parameters.Add(par1);
            cmd.Parameters.Add(par2);
            cmd.Parameters.Add(par3);
            cmd.Parameters.Add(par4);
            cmd.Parameters.Add(par5);
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i != 0) { MessageBox.Show("Record inserted successfully");
                    ds.Clear();
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                    getEmpDetails();
                }
            }
            catch (Exception ex) { throw ex; }
            finally { strconn.Close(); }
              
           

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ConnectToSQL();
            cmd.CommandText = "sp_updateEmpDetails";
            SqlParameter par1, par2, par3, par4,par5;
            par1 = new SqlParameter("@emp_id", SqlDbType.Int);
            par1.Value = txtEmpID.Text.Trim();
            par2 = new SqlParameter("@emp_name", SqlDbType.VarChar);
            par2.Value = txtEmpName.Text.Trim();
            par3 = new SqlParameter("@emp_age", SqlDbType.Int);
            par3.Value = txtEmpAge.Text.Trim();
            par4 = new SqlParameter("@emp_sal", SqlDbType.Int);
            par4.Value = txtEmpSal.Text.Trim();
            par5 = new SqlParameter("@empDOB", SqlDbType.DateTime);
            par5.Value = txtEmpDOB.Text.Trim();
            cmd.Parameters.Add(par1);
            cmd.Parameters.Add(par2);
            cmd.Parameters.Add(par3);
            cmd.Parameters.Add(par4);
            cmd.Parameters.Add(par5);
            try
            {
                int j = cmd.ExecuteNonQuery();
                if (j != 0) { MessageBox.Show("Record updated successfully");
                    ds.Clear();
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                    getEmpDetails();
                    
                }
            }
            catch (Exception ex) { throw ex; }
            finally { strconn.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ConnectToSQL();
            cmd.CommandText = "sp_deleteEmpDetails";
            SqlParameter par1;
            par1 = new SqlParameter("@emp_id", SqlDbType.Int);
            par1.Value = txtEmpID.Text.Trim();
            cmd.Parameters.Add(par1);
            try {
                int q = cmd.ExecuteNonQuery();
                if (q != 0)
                {
                    MessageBox.Show("Record deleted Successfully");
                    ds.Clear();
                    dataGridView1.Refresh();
                    dataGridView1.Update();
                    getEmpDetails();
                }
            

            }
            catch (Exception ex) { throw ex; }
            finally { strconn.Close(); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int s = 0;
            ConnectToSQL();
            cmd.CommandText = "sp_searchEmp";
            SqlParameter p1 = new SqlParameter("@emp_id", SqlDbType.Int);
            cmd.Parameters.Add(p1);
            p1.Value = txtEmpID.Text.Trim();
            try { s = Convert.ToInt32(cmd.ExecuteScalar());
                MessageBox.Show(" Salary is " + s);
            }
            catch (Exception ex) { throw ex; }
            finally { strconn.Close(); }
        }

       
    }
}

