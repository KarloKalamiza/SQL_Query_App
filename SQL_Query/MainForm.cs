using SQL_Query.DAL;
using SQL_Query.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Query
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init() => LoadDatabases();

        private void LoadDatabases()
        {
            cbUseDatabase.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
            cbUseDatabase.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

        }
    }
}
