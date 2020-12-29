using BudgetApp.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    class RetrieveData
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Expenditures
        public DataTable SelectExpenditures(string type)
        {
            //Step 1: Create Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            string sql = null;
            try
            {
                //Step 2: SQL Query
                if (type == "Ongoing")
                    sql = "SELECT * FROM tbl_Expense WHERE expenseType='Ongoing'";
                else
                    sql = "SELECT * FROM tbl_Expense WHERE expenseType='Adhoc'";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public List<double> SelectExpenseAmount()
        {
            //Step 1: Create Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            List<double> ccList = new List<double>();
            DataTable dt = new DataTable();

            try
            {
                //Step 2: SQL Query
                string sql = "SELECT expenseAmount FROM tbl_Expense";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s = dt.Rows[i][0].ToString();
                ccList.Add(Convert.ToDouble(s));
            }

            return ccList;
        }

        public bool InsertExpenditure(Expenditure r)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: SQL Query to insert data
                string sql = "INSERT INTO tbl_Expense (expenseType, expenseName, expenseAmount) VALUES (@expType, @expName, @expAmount)";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@expType", r.expType);
                cmd.Parameters.AddWithValue("@expName", r.expName);
                cmd.Parameters.AddWithValue("@expAmount", r.expAmount);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the query runs successfully then rows > 0
                isSuccess = (rows > 0);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
                Console.WriteLine("Test");
                Console.WriteLine(r.expType);

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool UpdateExpenditure(Expenditure r)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: SQL Query to insert data
                string sql = "UPDATE tbl_Expense SET expenseName=@expName, expenseAmount=@expAmount WHERE expenseID=@expID";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@expName", r.expName);
                cmd.Parameters.AddWithValue("@expAmount", r.expAmount);
                cmd.Parameters.AddWithValue("@expID", r.expID);

                //Open Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then rows > 0
                isSuccess = (rows > 0);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool DeleteExpenditure(Expenditure r)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: SQL Query to insert data
                string sql = "DELETE FROM tbl_Expense WHERE expenseID=@expID";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@expID", r.expID);

                //Open Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then rows > 0
                isSuccess = (rows > 0);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Credit Cards
        public DataTable SelectCreditCards()
        {
            //Step 1: Create Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            
            try
            {
                //Step 2: SQL Query
                string sql = "SELECT * FROM tbl_CreditCards";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public List<double> SelectCCAmounts(string column)
        {
            //Step 1: Create Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            List<double> ccList = new List<double>();
            DataTable dt = new DataTable();
            
            try
            {
                //Step 2: SQL Query
                string sql = "SELECT "+column+" FROM tbl_CreditCards";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s = dt.Rows[i][0].ToString();
                ccList.Add(Convert.ToDouble(s));
            }

            return ccList;
        }

        public bool InsertCreditCard(CreditCards c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: SQL Query to insert data
                string sql = "INSERT INTO tbl_CreditCards (cardName, cardAmount, cardLimit, cardOwing) VALUES (@cardName, @cardAmount, @cardLimit, @cardOwing)";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@cardName", c.cardName);
                cmd.Parameters.AddWithValue("@cardAmount", c.cardAmount);
                cmd.Parameters.AddWithValue("@cardLimit", c.cardLimit);
                cmd.Parameters.AddWithValue("@cardOwing", c.cardOwing);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then rows > 0
                isSuccess = (rows > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Test");
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool UpdateCreditCard(CreditCards c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: SQL Query to insert data
                string sql = "UPDATE tbl_CreditCards SET cardName=@cardName, cardAmount=@cardAmount, cardLimit=@cardLimit, cardOwing=@cardOwing WHERE cardID=@cardID";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@cardID", c.cardID);
                cmd.Parameters.AddWithValue("@cardName", c.cardName);
                cmd.Parameters.AddWithValue("@cardAmount", c.cardAmount);
                cmd.Parameters.AddWithValue("@cardLimit", c.cardLimit);
                cmd.Parameters.AddWithValue("@cardOwing", c.cardOwing);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then rows > 0
                isSuccess = (rows > 0);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool DeleteCreditCard(CreditCards c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: SQL Query to insert data
                string sql = "DELETE FROM tbl_CreditCards WHERE cardID=@cardID";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add data
                cmd.Parameters.AddWithValue("@cardID", c.cardID);

                //Open Connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then rows > 0
                isSuccess = (rows > 0);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Income
        public List<double> SelectIncomes()
        {
            //Step 1: Create Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            List<double> ccList = new List<double>();
            DataTable dt = new DataTable();

            try
            {
                //Step 2: SQL Query
                string sql = "SELECT incomeAmount FROM tbl_Income";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s = dt.Rows[i][0].ToString();
                ccList.Add(Convert.ToDouble(s));
            }

            return ccList;
        }

        public bool UpdateIncome(int id, double d)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database Connection
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //Step 2: SQL Query to insert data
                string sql = "UPDATE tbl_Income SET incomeAmount="+d+" WHERE incomeID="+id;
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then rows > 0
                isSuccess = (rows > 0);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
