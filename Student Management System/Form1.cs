
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Linq;


namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\student_db.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into [Table] values(@id,@name,@age,@course)", con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox4.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            cmd.Parameters.AddWithValue("@course", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successful");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\student_db.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update [Table] set name=@name, age=@age, course=@course where id=@id", con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox4.Text);
            cmd.Parameters.AddWithValue("@age", textBox3.Text);
            cmd.Parameters.AddWithValue("@course", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\student_db.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from [Table] where id=@id", con);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\student_db.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [Table]", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
