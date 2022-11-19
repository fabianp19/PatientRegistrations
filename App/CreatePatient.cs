using App.Database;
using App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class CreatePatient : Form
    {
        private readonly Form1 _parent;
        public string id, firstName, lastName, email, pesel, phoneNumber, adress;

        public CreatePatient(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdatePatient()
        {
            Text = "UpdatePatient";
            label2.Text = "Aktualizacja danych";
            buttonSave.Text = "Aktualizuj";
            textFirstName.Text = firstName;
            textLastName.Text = lastName;
            textEmail.Text = email;
            textPesel.Text = pesel;
            textPhoneNumber.Text = phoneNumber;
            textAdress.Text = adress;
        }

        public void AddPatient()
        {
            label2.Text = "Dodaj pacjenta";
            buttonSave.Text = "Dodaj";
        }

        public void Clear()
        {
            textFirstName.Text = textLastName.Text = textEmail.Text = textPesel.Text = textPhoneNumber.Text = textAdress.Text
                = string.Empty;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textFirstName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Imię jest puste.");
                return;
            }
            if (textLastName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Nazwisko jest puste.");
                return;
            }
            if (!IsEmailValid(textEmail.Text.Trim()))
            {
                MessageBox.Show("Email jest nieprawidłowy.");
                return;
            }
            if (textPesel.Text.Trim().Length != 11)
            {
                MessageBox.Show("Pesel jest nieprawidłowy.");
                return;
            }
            if (!IsPhoneNumberValid(textPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("Numer telefonu nieprawidłowy.");
                return;
            }
            if (textAdress.Text.Trim().Length < 1)
            {
                MessageBox.Show("Adres jest nieprawidłowy.");
                return;
            }
            if (buttonSave.Text == "Dodaj")
            {
                Patients createPatient = new Patients(textFirstName.Text.Trim(), textLastName.Text.Trim(),
                    textEmail.Text.Trim(), textPesel.Text.Trim(), textPhoneNumber.Text.Trim(), textAdress.Text.Trim());
                DbPatient.CreatePatient(createPatient);
                Clear();
            }
            if (buttonSave.Text == "Aktualizuj")
            {
                Patients patients = new Patients(textFirstName.Text.Trim(), textLastName.Text.Trim(),
                    textEmail.Text.Trim(), textPesel.Text.Trim(), textPhoneNumber.Text.Trim(), textAdress.Text.Trim());
                DbPatient.UpdatePatient(patients, id);
            }

            _parent.Display();
        }

        private bool IsEmailValid(string email)
        {
            Regex regexEmail = new Regex(@"^[a-zA-Z0-9]*[@][a-zA-Z0-9]*[.][a-zA-Z0-9]*$");

            return regexEmail.IsMatch(email);
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            Regex regexEmail = new Regex(@"^[0-9]{9}$");

            return regexEmail.IsMatch(phoneNumber);
        }
    }
}
