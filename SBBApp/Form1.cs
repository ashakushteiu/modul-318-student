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
            lbxException.Items.Clear();
            lbxMainOutput.Items.Clear();
            lbxMainOutputTime.Items.Clear();
            List<string> resultSearch = search.NormalSearch(tbxMainSearchFrom.Text, tbxMainSearchTo.Text);
            List<string> timeSearch = search.TimeSearch(tbxMainSearchFrom.Text, tbxMainSearchTo.Text);
            if (resultSearch.Count == 1)
            {
                lbxException.Items.AddRange(resultSearch.ToArray());
            }
            else
            {   
                lbxMainOutput.Items.AddRange(resultSearch.ToArray());
                lbxMainOutputTime.Items.AddRange(timeSearch.ToArray());
            }
            resultSearch.Clear();
            timeSearch.Clear();
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