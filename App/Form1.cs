using App.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        CreatePatient createPatient;

        public Form1()
        {
            InitializeComponent();
            createPatient = new CreatePatient(this);
        }

        public void Display()
        {
            DbPatient.Display("SELECT Id, FirstName, LastName, Email, Pesel, PhoneNumber, Adress FROM [dbo].[Table]", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createPatient.Clear();
            createPatient.AddPatient();
            createPatient.ShowDialog();
        }

        private void Form1_Shown_1(object sender, EventArgs e)
        {
            Display();
        }

        private void textSearch1_TextChanged(object sender, EventArgs e)
        {
            DbPatient.Display("SELECT Id, FirstName, LastName, Email, Pesel, PhoneNumber, Adress FROM [dbo].[Table] " +
                "WHERE FirstName LIKE '%" + textSearch1.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                createPatient.Clear();
                createPatient.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                createPatient.firstName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                createPatient.lastName = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                createPatient.email = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                createPatient.pesel = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                createPatient.phoneNumber = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                createPatient.adress = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                createPatient.UpdatePatient();
                createPatient.ShowDialog();

                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Czy chcesz usunąć dane tego pacjenta?", "Information", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbPatient.DeletePatient(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
