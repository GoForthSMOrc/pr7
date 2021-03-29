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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
        {
            InitializeComponent();
        }
        // Кнопка Добавить //
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Проверка, заполнено ли поле Login и обновлено ли поле Password //
            if (NewLogin.Text == "" || Password.Text == "Обновите")
            {
                MessageBox.Show("Проверьте поля : поле Login должно быть заполнено, поле Password должно быть обновлено для получения пароля");
            }
            else
            {
                string query = "INSERT INTO UsersDB(Login,Password) values('" + NewLogin.Text + "','" + Password.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        // Новый пользователь Функция создания случайного пароля //
        static string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        static Random r = new Random();

        static string GetRandom(string type)
        {
            string Result = "";
            if (type == "Password")
            {
                for (int i = 0; i < 10; i++)
                {
                    var index = r.Next(symbols.Length);
                    Result += symbols[index];
                }

            }
            return Result;
        }
        // Кнопка обновить //
        private void RefreshPassButton_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.Text = GetRandom(Password.Name.ToString());
        }

        private void HelloNewUser_Click(object sender, EventArgs e)
        {

        }
    }
}
