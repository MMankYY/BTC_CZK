using BussinesLogic.Dowlnoaders;
using BussinesLogic.Helpers;
using BussinesLogic.Objects;
using System.Data;

namespace BTC_CZK
{
    public partial class BitcoinForm : Form
    {
        List<DisplayValues> readedValues = new List<DisplayValues>();
        DbHelper dbHelper = new DbHelper();

        List<BitcoinRate> btcRates = new List<BitcoinRate>();
        List<BitcoinRate> modifiedRates = new List<BitcoinRate>();


        public BitcoinForm()
        {
            InitializeComponent();
            TriggerTimer.Start();
        }

        private async void TriggerTimer_Tick(object sender, EventArgs e)
        {
            CoinDeskDowlnoader coinDeskDowlnoader = new CoinDeskDowlnoader();
            BitcoinData bitcoinData = await coinDeskDowlnoader.ReadCoindeskData();
            CnbDowlnoader cnbDowlnoader = new CnbDowlnoader();
            CnbResp cnbResp = await cnbDowlnoader.ReadCnbData();

            var displayvalues = CalculationHelper.GetDisplayValues(bitcoinData, cnbResp);
            dataGridView1.Rows.Add(displayvalues.GridViewValues());

            readedValues.Add(displayvalues);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await dbHelper.SaveDisplayValues(readedValues);
            readedValues.Clear();
            dataGridView1.Rows.Clear();
        }

        private void TriggerTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            TriggerTimer.Interval = (int)(TriggerTimerInterval.Value * 1000);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private async void tabPage2_Enter(object sender, EventArgs e)
        {
            btcRates = await dbHelper.GetDisplayValues();
            dataGridView2.Rows.Clear();

            foreach (var value in btcRates)
            {
                dataGridView2.Rows.Add(value.GridViewValues());
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();

            foreach (var item in dataGridView2.SelectedRows)
            {
                DataGridViewRow row = (DataGridViewRow)item;
                var val = int.Parse((string)row.Cells[0].Value);

                ids.Add(val);
            }

            List<BitcoinRate> ratesToDelete = new List<BitcoinRate>();

            foreach (var id in ids)
            {
                var founded = btcRates.FirstOrDefault(p => p.ID == id);
                ratesToDelete.Add(founded);
            }

            await dbHelper.DeleteValues(ratesToDelete);


            btcRates = await dbHelper.GetDisplayValues();
            dataGridView2.Rows.Clear();

            foreach (var value in btcRates)
            {
                dataGridView2.Rows.Add(value.GridViewValues());
            }


        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await dbHelper.UpdateValues(modifiedRates);

            modifiedRates.Clear();

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var modifiedRow = dataGridView2.Rows[e.RowIndex];

            DataGridViewRow row = (DataGridViewRow)modifiedRow;
            var ID = int.Parse((string)row.Cells[0].Value);
            var note = (string)row.Cells[6].Value;

            var modifiedRate = btcRates.FirstOrDefault(p => p.ID == ID);

            var foundedRate = modifiedRates.FirstOrDefault(p => p.ID == ID);

            if (foundedRate!= null)
            {
                foundedRate.Note = note;

            }
            else
            {
                modifiedRate.Note = note;
                modifiedRates.Add(modifiedRate);
            }



            string s = "aaa";
        }
    }
}
