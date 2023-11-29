using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ElectricityBillingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=electricitybilltb;User ID=sa;Password=1234qwer");
        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            SqlCommand cnn = new SqlCommand("select * from billingtb", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("insert into billingtb values(@client_id,@client_name,@unit,@unit_price,@total)", con);

            cnn.Parameters.AddWithValue("@Client_ID", int.Parse(clientIdTxt.Text));

            cnn.Parameters.AddWithValue("@Client_Name", clientNameTxt.Text);

            cnn.Parameters.AddWithValue("@Unit", int.Parse(unitTxt.Text));

            cnn.Parameters.AddWithValue("@Unit_Price", float.Parse(unitPriceTxt.Text));

            cnn.Parameters.AddWithValue("@Total", int.Parse(totalTxt.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

            MessageBox.Show("Record Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            double d1, d2;

            d1 = double.Parse(unitTxt.Text);
            d2 = double.Parse(unitPriceTxt.Text);

            totalTxt.Text = (d1 * d2).ToString();
            
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            clientIdTxt.Text = "";

            clientNameTxt.Text = "";

            unitTxt.Text = "";

            unitPriceTxt.Text = "";

            totalTxt.Text = "";

            textBox6.Text = "";

            textBox7.Text = "";

            textBox1.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=electricitybilltb;User ID=sa;Password=1234qwer"); 
            
            con.Open();       
                     
            SqlCommand cnn = new SqlCommand("delete billingtb where client_id = @client_id", con);

            cnn.Parameters.AddWithValue("@Client_ID", int.Parse(clientIdTxt.Text));            

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}