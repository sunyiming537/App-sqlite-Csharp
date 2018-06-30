using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppForSqlite
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }



        // SQLiteConnection dbConnection = new SQLiteConnection("data source=sqlite.db");
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // SQLiteConnection.CreateFile("sqlite.db");
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=sqlite.db;Version=3;");
            m_dbConnection.Open();

            string sql = "insert into table1 (Name, Age) values ('Me1', 3000)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();

            SQLiteConnection m_dbConnection1 = new SQLiteConnection("Data Source=sqlite.db;Version=3;");
            m_dbConnection1.Open();

            string sql1 = "insert into table1 (Name, Age) values ('Me2', 3000)";
            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection1);
            command1.ExecuteNonQuery();
            m_dbConnection1.Close();



            //SqliteHelper sql = new SqliteHelper("data source=sqlite.db");
            ////插入两条数据
            //sql.InsertValues("table1", new string[] { "1", "张三", "22", "Zhang@163.com" });
            //sql.CloseConnection();


            //SqliteHelper sq2 = new SqliteHelper("data source=sqlite.db");
            //sq2.InsertValues("table1", new string[] { "2", "李四", "25", "Li4@163.com" });

            //更新数据，将Name="张三"的记录中的Name改为"Zhang3"
            //  sql.UpdateValues("table1", new string[] { "Name" }, new string[] { "张三" }, "Name", "Zhang3");

            ////删除Name="张三"且Age=26的记录,DeleteValuesOR方法类似
            //sql.DeleteValuesAND("table1", new string[] { "Name", "Age" }, new string[] { "张三", "22" }, new string[] { "=", "=" });


            //读取整张表
            //SQLiteDataReader reader = sql.ReadFullTable("table1");
            //while (reader.Read())
            //{
            //    //读取ID
            //    Console.WriteLine("" + reader.GetInt32(reader.GetOrdinal("ID")));
            //    //读取Name
            //    Console.WriteLine("" + reader.GetString(reader.GetOrdinal("Name")));
            //    //读取Age
            //    Console.WriteLine("" + reader.GetInt32(reader.GetOrdinal("Age")));
            //    //读取Email
            //    Console.WriteLine(reader.GetString(reader.GetOrdinal("Email")));
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SQLiteConnection m_dbConnection1 = new SQLiteConnection("Data Source=sqlite.db;Version=3;");
            m_dbConnection1.Open();

            string sql1 = "insert into table1 (Name, Age) values ('Me4', 3000)";
            SQLiteCommand command1 = new SQLiteCommand(sql1, m_dbConnection1);
            command1.ExecuteNonQuery();
            m_dbConnection1.Close();

        }
    }
}

////数据库连接
//SQLiteConnection m_dbConnection;

//static void Main(string[] args)
//{
//    Program p = new Program();
//}

//public Program()
//{
//    createNewDatabase();
//    connectToDatabase();
//    createTable();
//    fillTable();
//    printHighscores();
//}

////创建一个空的数据库
//void createNewDatabase()
//{
//    SQLiteConnection.CreateFile("MyDatabase.sqlite");
//}

////创建一个连接到指定数据库
//void connectToDatabase()
//{
//    m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
//    m_dbConnection.Open();
//}

////在指定数据库中创建一个table
//void createTable()
//{
//    string sql = "create table highscores (name varchar(20), score int)";
//    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
//    command.ExecuteNonQuery();
//}

////插入一些数据
//void fillTable()
//{
//    string sql = "insert into highscores (name, score) values ('Me', 3000)";
//    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
//    command.ExecuteNonQuery();

//    sql = "insert into highscores (name, score) values ('Myself', 6000)";
//    command = new SQLiteCommand(sql, m_dbConnection);
//    command.ExecuteNonQuery();

//    sql = "insert into highscores (name, score) values ('And I', 9001)";
//    command = new SQLiteCommand(sql, m_dbConnection);
//    command.ExecuteNonQuery();
//}

////使用sql查询语句，并显示结果
//void printHighscores()
//{
//    string sql = "select * from highscores order by score desc";
//    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
//    SQLiteDataReader reader = command.ExecuteReader();
//    while (reader.Read())
//        Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
//    Console.ReadLine();
//}
