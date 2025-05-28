using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = @"Data Source=localhost;Initial Catalog=YourDatabase;Integrated Security=True";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataSet;
        BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        // Упражнение 1: DataReader + ListBox
        private void btnFillListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string query = "SELECT Id, Name, Age FROM Users";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBox1.Items.Add($"{reader["Id"]}: {reader["Name"]} ({reader["Age"]})");
                }
                reader.Close();
                connection.Close();
            }
        }

        // Упражнение 2: DataSet + DataGridView
        private void btnFillGrid_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users";
            adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dataSet = new DataSet();
            adapter.Fill(dataSet, "Users");
            dataGridView1.DataSource = dataSet.Tables["Users"];
        }

        private void btnUpdateDb_Click(object sender, EventArgs e)
        {
            if (adapter != null && dataSet != null)
            {
                adapter.Update(dataSet, "Users");
                MessageBox.Show("Данные обновлены в базе!");
            }
        }

        // Упражнение 3: DataView
        private void btnApplyView_Click(object sender, EventArgs e)
        {
            if (dataSet != null)
            {
                DataView view = new DataView(dataSet.Tables["Users"])
                {
                    RowFilter = "Age >= 18",
                    Sort = "Name ASC"
                };
                listBox2.DataSource = view;
                listBox2.DisplayMember = "Name";
            }
        }

        // Упражнение 4: BindingSource
        private void btnBindControls_Click(object sender, EventArgs e)
        {
            if (dataSet != null)
            {
                bindingSource = new BindingSource(dataSet, "Users");
                textBoxId.DataBindings.Clear();
                textBoxName.DataBindings.Clear();
                textBoxAge.DataBindings.Clear();
                comboBox1.DataBindings.Clear();

                textBoxId.DataBindings.Add("Text", bindingSource, "Id");
                textBoxName.DataBindings.Add("Text", bindingSource, "Name");
                textBoxAge.DataBindings.Add("Text", bindingSource, "Age");
                comboBox1.DataSource = bindingSource;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSource?.MoveNext();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bindingSource?.MovePrevious();
        }
    }
}