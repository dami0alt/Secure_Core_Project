using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementForms
{
    public partial class frmSpaceShipCategories : ManagementForms.frmBase
    {

        private string _tableName = "SpaceShipCategories";

        public frmSpaceShipCategories()
        {
            InitializeComponent();
            base._tableName = _tableName;
        }

        protected override void ConfigurateDataGridView()
        {
            base.ConfigurateDataGridView();
            dgtData.Columns["CodeSpaceShipCategory"].HeaderText = "Ship Code";
            dgtData.Columns["DescSpaceShipCategory"].HeaderText = "Ship Description";

            dgtData.Columns["idSpaceShipCategory"].Visible = false;
        }
    }
}
