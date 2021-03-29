﻿using System;
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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        //Авторизация пользователя//
        //Поменял private на public//
        private void Enter_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string query = "Select count(*) from UsersDB where Login = '" + logBox.Text + "' and Password = '" + passBox.Text + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                Count = Convert.ToInt32(cmDB.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка авторизации.Попробуйте еще раз");
                MessageBox.Show(ex.Message);

            }
            if (Count > 0)
            {
                MainMenu win = new MainMenu();
                win.Show();
                this.Hide();
            }
            if (Count == 0)
            {
                MessageBox.Show("Ошибка авторизации");
            }
        }

    }
}
