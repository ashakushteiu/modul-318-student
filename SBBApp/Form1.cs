using SwissTransport.Core;
using SwissTransport.Models;

namespace EasyTravel
{
    public partial class Form1 : Form
    {
        Search search = new Search();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMainSearch_Click(object sender, EventArgs e)
        {
            lbxMainOutput.Items.Clear();
            List<string> resultSearch = search.NormalSearch(tbxMainSearchFrom.Text, tbxMainSearchTo.Text);
            lbxMainOutput.Items.AddRange(resultSearch.ToArray());
            resultSearch.Clear();
        }

        private void btnMainSearchChange_Click(object sender, EventArgs e)
        {
            string _fromText = tbxMainSearchFrom.Text;
            string _toText = tbxMainSearchTo.Text;
            tbxMainSearchTo.Text = _fromText;
            tbxMainSearchFrom.Text = _toText;
        }
    }
}