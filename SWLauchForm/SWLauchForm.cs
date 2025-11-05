using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SWUserControls
{
    public partial class SWLauchForm : UserControl
    {
        public SWLauchForm()
        {
            InitializeComponent();
        }
        private string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                this.lblOptionName.Text = value;
            }
        }
        private string _Class;
        public string Class
        {
            get { return _Class; }
            set { _Class = value; }
        }
        private string _Form;
        public string Form
        {
            get { return _Form; }
            set { _Form = value; }
        }
        private int _AccessLevel;
        public int AccessLevel
        {
            get { return _AccessLevel; }
            set { _AccessLevel = value; }
        }

        private void SWLauchForm_Click(object sender, EventArgs e)
        {
            Assembly assembly;
            assembly = Assembly.LoadFrom(_Class);
            Object dllBD;

            Type types;

            types = assembly.GetType(_Form);

            dllBD = Activator.CreateInstance(types);

            ((Form)dllBD).Show();
        }
    }
}
