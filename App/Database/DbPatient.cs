using App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Database
{
    class DbPatient
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Nauka\Projekty\C#\PatientsRegistration\App\Database\DbPatients.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void CreatePatient(Patients patient)
        {
            string sql = "INSERT INTO [dbo].[Table] VALUES (@FirstName, @LastName, @Email, @Pesel, @PhoneNumber, @Adress)";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);

            command.CommandType = CommandType.Text;
            
            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = patient.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = patient.LastName;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = patient.Email;
            command.Parameters.Add("@Pesel", SqlDbType.VarChar).Value = patient.Pesel;
            command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = patient.PhoneNumber;
            command.Parameters.Add("@Adress", SqlDbType.VarChar).Value = patient.Adress;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Dodano pacjenta", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas dodawania. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        public static void UpdatePatient(Patients patient, string id)
        {
            string sql = "UPDATE [dbo].[Table] SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Pesel = @Pesel, " +
                " PhoneNumber = @PhoneNumber, Adress = @Adress WHERE ID = @Id";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);

            command.CommandType = CommandType.Text;

            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = patient.FirstName;
            command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = patient.LastName;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = patient.Email;
            command.Parameters.Add("@Pesel", SqlDbType.VarChar).Value = patient.Pesel;
            command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = patient.PhoneNumber;
            command.Parameters.Add("@Adress", SqlDbType.VarChar).Value = patient.Adress;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Zmodyfikowano dane pacjenta", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas modyfikowania. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        public static void DeletePatient(string id)
        {
            string sql = "DELETE FROM [dbo].[Table] WHERE ID = @Id";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);

            command.CommandType = CommandType.Text;

            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Usunięto dane pacjenta", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas usuwania. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        public static void Display(string query, DataGridView dgv)
        {
            string sql = query;

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            dgv.DataSource = table;
            connection.Close();
        }
    }
}
