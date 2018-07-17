using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using do_account_checker.DarkOrbit;

namespace do_account_checker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            new User("test", "test").Login();
        }
    }
}
