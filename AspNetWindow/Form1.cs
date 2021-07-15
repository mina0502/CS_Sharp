using AdoNet;
using AppConfiguration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetWindow
{
    public partial class Form1 : ApplicationRoot
    {
        MsSql msql;
        string ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadConfiguration();
        }

        private void ReadConfiguration()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurationMgr instance = ConfigurationMgr.Instance();
            MessageBox.Show(instance.Connection.State.ToString());
            instance.Connection.Close();
        }
    }
}
    