using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdentityUser;

using ManagementForms;

namespace JobHuntersSystem
{
    public partial class frmMain : Form
    {
        //A futuro remplazar las propiedaedes del "user"por un data set con la query del usuario
        /*private int _AccessLevelUser;
        private string _UserName = "Damian2005";
        private string _RoleUser = "Admin";
        private string _ProfileImagePath="Multimedia/png/Clon.png";*/
        private SpeechManager speech;

        public frmMain()
        {
            InitializeComponent();
            /*
             * A futuro, aplicar esta lógico para cargar los botones según nivel de acceso, comparando con la tabla "UserOptions" - DB
            foreach(DataTable row in UserOptions)
            {
                int AccessLevel = poner "Row["AccesLevel"]"
                if(_AccessLevelUser >= AccessLevel)
                {
                    flpOptions.Controls.Add(new SWUserControls.SWLauchForm
                    {
                          //Asignar propiedades de la DB al control
                            
                    });
                }
            }
            */
           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var user = CurrentUser.MainUser;

            if (user != null)
            {
                lblUserName.Text = user.UserName;
                lblRoleUser.Text = user.DescRank;

                string fullPath = AppDomain.CurrentDomain.BaseDirectory + user.Photo;
                if (System.IO.File.Exists(fullPath))
                    pctProfileImage.Image = Image.FromFile(fullPath);
            }

            speech = new SpeechManager(this);
        }

        private void pnlPanelTool_Click(object sender, EventArgs e)
        {
            frmUsers form = new frmUsers();
            form.Show();
        }
    }
}
