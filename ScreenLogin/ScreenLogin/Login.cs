using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ScreenLogin
{
    public partial class LoginScreen : Form
    {
        //conect reference
        SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-4D975RH\SQLEXPRESS;Initial Catalog=LoginScreenData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        // show password button
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
               
              textBox2.PasswordChar = '\0' ;
                
            } else { textBox2.PasswordChar = '*'; }
            
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            conect.Open();  //open login
            string username = textBox1.Text;
            string password = textBox2.Text;

            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND Password = @Password", conect);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                MainScreen MainScreen = new MainScreen();
                this.Hide();
                MainScreen.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reader.Close();
            conect.Close();
        }
    }
}
