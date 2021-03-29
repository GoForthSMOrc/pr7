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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            get_Info(listView1);
        }

        //Выдача информации при переходе в главное меню//
        void get_Info(ListView List)
        {
            listView1.Items.Clear();
            string query = "SELECT Sculpture.Id_Sculpture, Sculpture.NameSculpture,Sculpture.NameSize,Materials.NameMaterials,Master.NameMaster FROM Sculpture JOIN Materials ON Sculpture.id_Materials = Materials.Id_Materials JOIN Master ON Sculpture.id_Master = Master.Id_Master ORDER BY Id_Sculpture ASC;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);
            }
        }
        
        // Переход на окно добавления нового пользователя //
        private void NewUser_Click(object sender, EventArgs e)
        {
            AddNewUser Win = new AddNewUser();
            Win.Show();
        }
        //Переход в окно добавления новой записи//
        private void NewSculpture_Click(object sender, EventArgs e)
        {
            AddNewSculpture Win = new AddNewSculpture();
            Win.Show();
        }
        //Показать список работ//
        //Поменял private на public//
        private void ListButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "SELECT Sculpture.Id_Sculpture, Sculpture.NameSculpture,Sculpture.NameSize,Materials.NameMaterials,Master.NameMaster FROM Sculpture JOIN Materials ON Sculpture.id_Materials = Materials.Id_Materials JOIN Master ON Sculpture.id_Master = Master.Id_Master ORDER BY Id_Sculpture ASC;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1),rd.GetString(2),rd.GetString(3),rd.GetString(4) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);
            }
        }
        //Переход в окно удаления записи//
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteOne Win = new DeleteOne();
            Win.Show();
        }

        private void FindSculpt_Click(object sender, EventArgs e)
        {
            FindMain Win = new FindMain();
            Win.Show();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

