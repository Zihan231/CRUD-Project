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

namespace CRUDProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid (){
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7JBFG4A\\SQLEXPRESS;Initial Catalog=EmpCRUD;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from info",con);
            DataTable dt = new DataTable();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView.DataSource = dt.DefaultView;
        }
        public void ClearData()
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxSalary.Clear();
            textBoxCity.Clear();

        }
        public bool IsValid()
        {
            if (textBoxID.Text == string.Empty)
            {
                MessageBox.Show("ID Is Required !!!");
                return false;
            }
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Name Is Required !!!");
                return false;
            }
            if (textBoxSalary.Text == string.Empty)
            {
                MessageBox.Show("Salary Is Required !!!");
                return false;
            }
            if (textBoxCity.Text == string.Empty)
            {
                MessageBox.Show("City Is Required !!!");
                return false;
            }

            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try{
                if (IsValid())
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7JBFG4A\\SQLEXPRESS;Initial Catalog=EmpCRUD;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into info values(@id,@name,@salary,@city)", con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@salary", double.Parse(textBoxSalary.Text));
                    cmd.Parameters.AddWithValue("@city", textBoxCity.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfully Saved");
                    ClearData();
                    LoadGrid(); 

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {

                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7JBFG4A\\SQLEXPRESS;Initial Catalog=EmpCRUD;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update info set name=@name,salary=@salary,city=@city where id=@id", con);
                    cmd.Parameters.AddWithValue("@id",int.Parse(textBoxID.Text));
                    cmd.Parameters.AddWithValue("@name", textBoxName.Text);
                    cmd.Parameters.AddWithValue("@salary", double.Parse(textBoxSalary.Text));
                    cmd.Parameters.AddWithValue("@city", textBoxCity.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Updated");
                    LoadGrid();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxID.Text != string.Empty)
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7JBFG4A\\SQLEXPRESS;Initial Catalog=EmpCRUD;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from info where id = @id",con);
                    cmd.Parameters.AddWithValue("@id", textBoxID .Text);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("ID "+ textBoxID.Text+" is Deleted Successfully !!!");
                    con.Close();
                    LoadGrid();

                }
                else
                {
                    MessageBox.Show("ID is Required !!!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try {
                if (textBoxID.Text != string.Empty) {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-J7JBFG4A\\SQLEXPRESS;Initial Catalog=EmpCRUD;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from info where id=@id", con);
                    cmd.Parameters.AddWithValue("@id",textBoxID.Text);
                    DataTable dt = new DataTable();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    dt.Load(sdr);
                    con.Close();
                    dataGridView.DataSource = dt.DefaultView;
                }
                else
                {
                    MessageBox.Show("Id required !!!");
                }               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Check if the user clicked 'Yes'
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Exit the application
            }
        }


        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
