using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysqlConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = null;
        Boolean isOpen = false;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            String cs = 
                $"server={tbHost.Text};userid={tbUser.Text};password={tbPass.Text};database={tbDBName.Text};port=3306;SslMode=None";
            try
            {
                if (isOpen)
                {
                    // zamyka
                    conn.Close();
                    conn.Dispose();
                    isOpen = false;
                    btnConnect.Text = "Połącz";
                }
                else
                {
                    conn = new MySqlConnection(cs);
                    conn.Open();
                    isOpen = true;
                    btnConnect.Text = "Rozłącz";
                }
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!isOpen)
                return;

            try
            {
                MySqlCommand cmd = new MySqlCommand(tbSql.Text, conn);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
