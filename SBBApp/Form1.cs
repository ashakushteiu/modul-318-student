using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMainSearch_Click(object sender, EventArgs e)
        {
            var transport = new Transport();
            var Connections = transport.GetConnections("Emmen", "Willisau");

            foreach (Connection connection in Connections.ConnectionList)
            {
                //lbxMainOutput.Items.Add(connection.From.Departure);
            }
            lbxMainOutput.Items.Add("Test");
        }
    }
}