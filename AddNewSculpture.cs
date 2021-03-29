using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practica7
{
    public partial class AddNewSculpture : Form
    {
        public AddNewSculpture()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Size_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddNewSculp_Click(object sender, EventArgs e)
        {
            if (NewSculpture.Text == "" || Size.Text == "" || Materials.Text == "" || Masters.Text == "" )
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else {
                string query = "INSERT INTO Sculpture (NameSculpture,NameSize,id_Materials,id_Master) values('" + NewSculpture.Text + "','" + Size.Text + "','" + Materials.Text + "','" + Masters.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Скульптура добавлена");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
