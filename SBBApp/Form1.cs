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
            lbxMainStationBoard.Hide();
            ClearAllListBoxAndBringToFront();
            DropDownFrom(sender, e);
            DropDownTo(sender, e);
            if (tbxMainSearchFrom.Text.Length >= 3 && tbxMainSearchTo.Text.Length >= 3)
            {
                tbxMainSearchFrom.SelectedIndex = 1;
                tbxMainSearchTo.SelectedIndex = 1;
                List<string> resultSearch = search.NormalSearch(tbxMainSearchFrom.Text, tbxMainSearchTo.Text);
                List<string> timeSearch = search.TimeSearch(tbxMainSearchFrom.Text, tbxMainSearchTo.Text);
                List<string> travelTime = search.TravelTime(tbxMainSearchFrom.Text, tbxMainSearchTo.Text);
                List<string> travelDate = search.TravelDate(tbxMainSearchFrom.Text, tbxMainSearchTo.Text);
                if (resultSearch.Count == 1)
                {
                    lbxException.Items.AddRange(resultSearch.ToArray());
                }
                else
                {
                    lbxMainOutput.Items.AddRange(resultSearch.ToArray());
                    lbxMainOutputTime.Items.AddRange(timeSearch.ToArray());
                    lbxMainTravelTime.Items.AddRange(travelTime.ToArray());
                    lbxMainTravelDate.Items.AddRange(travelDate.ToArray());
                }

                resultSearch.Clear();
                timeSearch.Clear();
                travelTime.Clear();
                travelDate.Clear();
            }
        }

        private void btnMainSearchChange_Click(object sender, EventArgs e)
        {
            string _fromText = tbxMainSearchFrom.Text;
            string _toText = tbxMainSearchTo.Text;
            tbxMainSearchTo.Text = _fromText;
            tbxMainSearchFrom.Text = _toText;
        }

        public void ClearAllListBoxAndBringToFront()
        {
            lbxException.Items.Clear();
            lbxMainOutput.Items.Clear();
            lbxMainOutput.BringToFront();
            lbxMainOutputTime.Items.Clear();
            lbxMainOutputTime.BringToFront();
            lbxMainTravelTime.Items.Clear();
            lbxMainTravelTime.BringToFront();
            lbxMainTravelDate.Items.Clear();
            lbxMainTravelDate.BringToFront();
            lbxMainStationBoard.Items.Clear();
        }

        private void DropDownFrom(object sender, EventArgs e)
        {
            if (tbxMainSearchFrom.Text.Length >= 3)
            {
                tbxMainSearchFrom.Items.Clear();
                tbxMainSearchFrom.Items.Add(tbxMainSearchFrom.Text);
                ITransport transport = new Transport();
                Stations stations = new Stations();
                stations = transport.GetStations(tbxMainSearchFrom.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    tbxMainSearchFrom.Items.Add(stations.StationList[i].Name);
                }
            }
        }

        private void DropDownTo(object sender, EventArgs e)
        {
            if (tbxMainSearchTo.Text.Length >= 3)
            {
                tbxMainSearchTo.Items.Clear();
                tbxMainSearchTo.Items.Add(tbxMainSearchTo.Text);
                ITransport transport = new Transport();
                Stations stations = new Stations();
                stations = transport.GetStations(tbxMainSearchTo.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    tbxMainSearchTo.Items.Add(stations.StationList[i].Name);
                }
            }
        }

        private void DropDownTimetable(object sender, EventArgs e)
        {
            if (tbxMainTimetable.Text.Length >= 3)
            {
                tbxMainTimetable.Items.Clear();
                tbxMainTimetable.Items.Add(tbxMainTimetable.Text);
                ITransport transport = new Transport();
                Stations stations = new Stations();
                stations = transport.GetStations(tbxMainTimetable.Text);
                for (int i = 0; i < stations.StationList.Count; i++)
                {
                    tbxMainTimetable.Items.Add(stations.StationList[i].Name);
                }
            }
        }

        private void btnMainTimetableSearch_Click(object sender, EventArgs e)
        {
            if (tbxMainTimetable.Text.Length >= 3)
            {
                ClearAllListBoxAndBringToFront();
                lbxMainStationBoard.BringToFront();
                List<string> timetableTo = search.TimeTableTo(tbxMainTimetable.Text);
                lbxMainStationBoard.Items.AddRange(timetableTo.ToArray());
                timetableTo.Clear();
            }
        }

        private void TbxMainSearchKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMainSearch_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }

        private void TbxMainTimetableKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMainTimetableSearch_Click(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}