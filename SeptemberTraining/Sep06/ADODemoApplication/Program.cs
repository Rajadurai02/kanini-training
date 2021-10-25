using System;
using System.Data;
using System.Data.SqlClient;

namespace ADODemoApplication
{
    class Program
    {
        SqlConnection conn;
        public Program()
        {
            conn = new SqlConnection(@"Data source=KANINI-LTP-474\KANINISQLSERVER;Integrated Security=true;Initial Catalog=dbCompany06Sep21");
            //conn.Open();
            //Console.WriteLine("Connection done");
        }
        void GetEmployeeDetailsFromDatabase()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Employees";
            //connected architecture
            //conn.Open();
            //SqlDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    Console.WriteLine("Employee Id: " + dr[0]);
            //    Console.WriteLine("Employee Name: " + dr[1]);
            //    Console.WriteLine("Employee Age: " + dr[2]);
            //    Console.WriteLine("-------------------------------");
            //}
            //conn.Close();
            //disconnected architecture
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);//connect-fetch-store in dataset-disconnect
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine("Employee Id: " + dr[0]);
                Console.WriteLine("Employee Name: " + dr[1]);
                Console.WriteLine("Employee Age: " + dr[2]);
                Console.WriteLine("-------------------------------");
            }
        }
        private void InsertEmployee()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Employees(name,age) values(@ename,@eage)";
            Console.WriteLine("enter the employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the employee age");
            int age = Convert.ToInt32(Console.ReadLine());
            cmd.Parameters.AddWithValue("@ename", name);
            cmd.Parameters.AddWithValue("@eage", age);
            conn.Open();
            int result = cmd.ExecuteNonQuery();//for DML queries
            if (result > 0)
            {
                Console.WriteLine("Employee Added\n");
            }
            else
            {
                Console.WriteLine("Employee not Added\n");
            }
            conn.Close();
        }
        private void ModifyEmployee()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update Employees SET name = @ename where id = @eid;";
            Console.WriteLine("Enter the employee Id you want to change the name");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the employee name to be changed");
            string name = Console.ReadLine();
            cmd.Parameters.AddWithValue("@ename", name);
            cmd.Parameters.AddWithValue("@eid", id);
            conn.Open();
            int result = cmd.ExecuteNonQuery();//for DML queries
            if (result > 0)
            {
                Console.WriteLine("Employee Name changed\n");
            }
            else
            {
                Console.WriteLine("Employee Name not Added\n");
            }
            conn.Close();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.InsertEmployee();
            program.ModifyEmployee();
            program.GetEmployeeDetailsFromDatabase();
            Console.ReadKey();
        }
    }
}
