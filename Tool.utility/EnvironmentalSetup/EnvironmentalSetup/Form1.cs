using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvironmentalSetup.ConfigChanges;
using System.Web.Configuration;

namespace EnvironmentalSetup
{
    public partial class Form1 : Form
    {
        private string _FileName = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialogConfig.ShowDialog();
            _FileName = openFileDialogConfig.FileName;
            ConfigService svc = new ConfigService();
            var x = svc.GetAllConfiguration(WebConfigurationManager.OpenWebConfiguration("/erxWeb", "Hotfix"));
          //  dataGridView1.DataSource = x.
           // dataGridView1.Refresh();
         
        }
    }
}
