using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GetServerDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            m_cboDatabase.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void OnSearchButtonClick(object sender, EventArgs e)
        {
            string text = m_serverText.Text;
            SQLDMO.SQLServer srv = new SQLDMO.SQLServerClass();
            srv.Connect("localhost", "sa", "zhoukaikai");
            this.m_cboDatabase.Items.Clear();
            if (srv.Databases == null)
            {
                return;
            }
            foreach (SQLDMO.Database db in srv.Databases)
            {
                if (db.Name != null)
                    this.m_cboDatabase.Items.Add(db.Name);
            }
        }
    }
}
