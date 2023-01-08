using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ScreenLogin
{
    public partial class Register : Form
    {
        //conect reference
         SqlConnection Conect = new SqlConnection(@"Data Source=DESKTOP-4D975RH\SQLEXPRESS;Initial Catalog=LoginScreenData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    

        public Register()
        {
            InitializeComponent();
            textBox4.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Register button
        private void LoginButton_Click(object sender, EventArgs e)
        {       
            string username = textBox1.Text;
            string password = textBox2.Text;
            string password2 = textBox3.Text;
            string Nome = textBox4.Text;
            if (password!=password2)
            {
                MessageBox.Show("Senhas não são iguais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Conect.Open();  //open conect
                SqlCommand command = new SqlCommand("INSERT INTO users (Username, Password, Nome) VALUES (@Username, @Password, @Nome)", Conect);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password); //add values 
                command.Parameters.AddWithValue("@Nome", Nome);
                command.ExecuteNonQuery();
                MessageBox.Show("Login criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Text = "";
                textBox2.Text = ""; //clear text
                textBox3.Text = "";
                textBox4.Text = "";
                Conect.Close(); //close conect
            }
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //show password button
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';

            }
            else 
            { 
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginScreen Login = new LoginScreen();
            this.Hide();
            Login.Show();
        }
    }
}
