using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserCategories
{
    public partial class frmUserCategoriesScreen : ManagementForms.frmScreenCS
    {
        public frmUserCategoriesScreen(string tableName, string formName, string controlId) : base(tableName, formName, controlId)
        {
            InitializeComponent();
        }
    }
}
