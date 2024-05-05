using BussinesLogic.Dowlnoaders;
using BussinesLogic.Helpers;
using BussinesLogic.Objects;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;

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
            try
            {
                CoinDeskDowlnoader coinDeskDowlnoader = new CoinDeskDowlnoader();
                BitcoinData bitcoinData = await coinDeskDowlnoader.ReadCoindeskData();
                CnbDowlnoader cnbDowlnoader = new CnbDowlnoader();
                CnbResp cnbResp = await cnbDowlnoader.ReadCnbData();

                var displayvalues = CalculationHelper.GetDisplayValues(bitcoinData, cnbResp);
                dataGridView1.Rows.Add(displayvalues.GridViewValues());

                readedValues.Add(displayvalues);
                DrawGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                await dbHelper.SaveDisplayValues(readedValues);
                readedValues.Clear();
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TriggerTimerInterval_ValueChanged(object sender, EventArgs e)
        {
            TriggerTimer.Interval = (int)(TriggerTimerInterval.Value * 1000);
        }
        private async void tabPage2_Enter(object sender, EventArgs e)
        {
            UpdateValues();
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
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

                UpdateValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                await dbHelper.UpdateValues(modifiedRates);
                modifiedRates.Clear();
                UpdateValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var modifiedRow = dataGridView2.Rows[e.RowIndex];
                DataGridViewRow row = (DataGridViewRow)modifiedRow;
                var id = int.Parse((string)row.Cells[0].Value);
                var note = (string)row.Cells[6].Value;

                var foundedRate = modifiedRates.FirstOrDefault(p => p.ID == id);

                if (foundedRate != null)
                {
                    foundedRate.Note = note;
                }
                else
                {
                    var modifiedRate = btcRates.FirstOrDefault(p => p.ID == id);
                    modifiedRate.Note = note;
                    modifiedRates.Add(modifiedRate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //

        private async void UpdateValues()
        {
            try
            {
                btcRates = await dbHelper.GetDisplayValues();
                dataGridView2.Rows.Clear();

                foreach (var value in btcRates)
                {
                    dataGridView2.Rows.Add(value.GridViewValues());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawGraph()
        {
            try
            {
                var model = new PlotModel { Title = "BTC_CZK in Time" };
                var scatterSeries = new LineSeries { MarkerType = MarkerType.Circle };

                foreach (var item in readedValues)
                {
                    var y = (double)item.BtcCzk / 1000000;
                    var x = item.ValidAt.Ticks;
                    scatterSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(item.ValidAt), y));
                }

                model.Series.Add(scatterSeries);
                //model.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom,Title = "Time", Minimum = DateTimeAxis.ToDouble(DateTime.Now), Maximum = DateTimeAxis.ToDouble(DateTime.Now.AddHours(12)), StringFormat ="hh:mm:ss" });
                model.Axes.Add(new DateTimeAxis { Position = AxisPosition.Bottom, Title = "Time", StringFormat = "hh:mm:ss" });
                model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "BTC_CZK * 1 000 000" });

                plotView1.Model = model;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
