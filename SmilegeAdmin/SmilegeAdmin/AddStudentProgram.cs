using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SmilegeAdmin
{
    public partial class AddStudentProgram : Form
    {
        public AddStudentProgram()
        {
            InitializeComponent();
        }

        private void AddProgram_AddScore_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
