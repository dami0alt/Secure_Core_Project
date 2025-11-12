using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentesDeAcceso;
using HashUtils;

namespace JobHuntersSystem
{
    public partial class frmLogin : Form
    {
        BaseDeDades dataBase = new BaseDeDades();
        clsHash hash = new clsHash();
        public frmLogin()
        {
            frmSplash frmSplash = new frmSplash();
            frmSplash.ShowDialog();
            InitializeComponent();
        }
        private DataTable consultationDataBase(string user)
        {
            string query = $"SELECT * FROM Users WHERE Login = '{user}'";
            DataTable db = dataBase.PortarDataTable(query);
            return db;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            string passInitial = "12345aA";            

            DataTable db = consultationDataBase(user);
            if(db.Rows.Count == 0)
            {
                lblMessage.Text = ("Invalid user or nonexistent user credentials");
                lblMessage.ForeColor = Color.Red;
            }
            else
            {
                string dbPassword = db.Rows[0]["Password"].ToString();
                bool passValidateInitial = CheckPasswordInitial(pass, passInitial, dbPassword);

                CheckFinalPassword(passValidateInitial, db, pass, dbPassword);
            }
            
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckPasswordInitial(string pass, string passInitial, string dbPass)
        {
            if (hash.ValidatePass(pass, passInitial) && hash.ValidatePass(pass, dbPass))
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        private void CheckFinalPassword(bool passValidateInitial, DataTable db, string pass, string dbPassword)
        {
            string validatePass, salt;
            if (passValidateInitial)
            {
                //abrir form y pasar el user
            }
            else
            {
                salt = db.Rows[0]["Hash"].ToString();
                validatePass = hash.CreatePassword(pass, salt);

                bool passHashed = hash.ValidatePass(validatePass, dbPassword);
                if (passHashed)
                {
                    //abrir main


                }
                else
                {
                    lblMessage.Text = ("Wrong Password, pleas check the credentials.");
                    lblMessage.ForeColor = Color.Red;
                }
            }
        }
    }
}
