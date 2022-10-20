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
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Nauka\Projekty\C#\App\App\App\Database\DbPatients.mdf;Integrated Security=True";
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

        public static void AddPatient(Patients patient)
        {
            string sql = "INSERT INTO DbPatients VALUES (NULL, @FirstName, @LastName, @Email, @Pesel, @PhoneNumber, @Adress)";

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
            string sql = "UPDATE DbPatients SET (FirstName = @FirstName, LastName = @LastName, Email = @Email, Pesel = @Pesel, " +
                " PhoneNumber = @PhoneNumber, Adress = @Adress) WHERE ID = @PatientId";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);

            command.CommandType = CommandType.Text;
            
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
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
            string sql = "DELETE FROM DbPatients WHERE Id = @Id";

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
