using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLIMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datacontainer.connectsource = "Data Source=Klingen-test-su-db,62468; Initial Catalog = Klingen_Test;";
            Datacontainer.anvandarnamn = "tomha5";
            Datacontainer.losen = "202211";
            Datacontainer.connectionString = @Datacontainer.connectsource + "User ID=" + Datacontainer.anvandarnamn + ";Password=" + Datacontainer.losen + "";
            Datacontainer.cnn = new SqlConnection(Datacontainer.connectionString);
            Datacontainer.cnn.Open();
            MessageBox.Show("Connection Open  !");
        }
    }
}
