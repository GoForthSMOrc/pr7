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
    public partial class DeleteOne : Form
    {
        public DeleteOne()
        {
            InitializeComponent();
        }

        private void DeleteHi_Click(object sender, EventArgs e)
        {

        }
        //Кнопка Удалить//
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteNumber.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                string query = "DELETE FROM Sculpture WHERE Id_Sculpture = '" + DeleteNumber.Text + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Запись удалена");
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
