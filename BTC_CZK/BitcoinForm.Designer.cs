namespace BTC_CZK
{
    partial class BitcoinForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            TriggerTimerInterval = new NumericUpDown();
            btn_save = new Button();
            dataGridView1 = new DataGridView();
            BtcEur = new DataGridViewTextBoxColumn();
            EurCzk = new DataGridViewTextBoxColumn();
            BtcCzk = new DataGridViewTextBoxColumn();
            ValidAt = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            BTC_EUR = new DataGridViewTextBoxColumn();
            CZK_EUR = new DataGridViewTextBoxColumn();
            BTC_CZK = new DataGridViewTextBoxColumn();
            CreateDate = new DataGridViewTextBoxColumn();
            DownloadedDate = new DataGridViewTextBoxColumn();
            Note = new DataGridViewTextBoxColumn();
            btn_delete = new Button();
            btn_update = new Button();
            TriggerTimer = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TriggerTimerInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1524, 936);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1516, 898);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Actual Values";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(TriggerTimerInterval, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_save, 3, 5);
            tableLayoutPanel1.Controls.Add(dataGridView1, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1510, 892);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TriggerTimerInterval
            // 
            TriggerTimerInterval.Dock = DockStyle.Fill;
            TriggerTimerInterval.Location = new Point(1353, 23);
            TriggerTimerInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            TriggerTimerInterval.Name = "TriggerTimerInterval";
            TriggerTimerInterval.Size = new Size(94, 31);
            TriggerTimerInterval.TabIndex = 1;
            TriggerTimerInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
            TriggerTimerInterval.ValueChanged += TriggerTimerInterval_ValueChanged;
            // 
            // btn_save
            // 
            btn_save.Dock = DockStyle.Fill;
            btn_save.Location = new Point(1353, 815);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 54);
            btn_save.TabIndex = 2;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtcEur, EurCzk, BtcCzk, ValidAt });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(183, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1164, 686);
            dataGridView1.TabIndex = 3;
            // 
            // BtcEur
            // 
            BtcEur.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BtcEur.HeaderText = "BtcEur";
            BtcEur.MinimumWidth = 8;
            BtcEur.Name = "BtcEur";
            BtcEur.ReadOnly = true;
            BtcEur.Width = 97;
            // 
            // EurCzk
            // 
            EurCzk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EurCzk.HeaderText = "EurCzk";
            EurCzk.MinimumWidth = 8;
            EurCzk.Name = "EurCzk";
            EurCzk.ReadOnly = true;
            EurCzk.Width = 101;
            // 
            // BtcCzk
            // 
            BtcCzk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BtcCzk.HeaderText = "BtcCzk";
            BtcCzk.MinimumWidth = 8;
            BtcCzk.Name = "BtcCzk";
            BtcCzk.ReadOnly = true;
            // 
            // ValidAt
            // 
            ValidAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ValidAt.HeaderText = "ValidAt";
            ValidAt.MinimumWidth = 8;
            ValidAt.Name = "ValidAt";
            ValidAt.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1516, 898);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Database Values";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(dataGridView2, 1, 1);
            tableLayoutPanel2.Controls.Add(btn_delete, 3, 2);
            tableLayoutPanel2.Controls.Add(btn_update, 3, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1510, 892);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ID, BTC_EUR, CZK_EUR, BTC_CZK, CreateDate, DownloadedDate, Note });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(23, 23);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            tableLayoutPanel2.SetRowSpan(dataGridView2, 4);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1294, 846);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellEndEdit += dataGridView2_CellEndEdit;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 66;
            // 
            // BTC_EUR
            // 
            BTC_EUR.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BTC_EUR.HeaderText = "BTC_EUR";
            BTC_EUR.MinimumWidth = 8;
            BTC_EUR.Name = "BTC_EUR";
            BTC_EUR.ReadOnly = true;
            BTC_EUR.Width = 115;
            // 
            // CZK_EUR
            // 
            CZK_EUR.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CZK_EUR.HeaderText = "CZK_EUR";
            CZK_EUR.MinimumWidth = 8;
            CZK_EUR.Name = "CZK_EUR";
            CZK_EUR.ReadOnly = true;
            CZK_EUR.Width = 118;
            // 
            // BTC_CZK
            // 
            BTC_CZK.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            BTC_CZK.HeaderText = "BTC_CZK";
            BTC_CZK.MinimumWidth = 8;
            BTC_CZK.Name = "BTC_CZK";
            BTC_CZK.ReadOnly = true;
            BTC_CZK.Width = 114;
            // 
            // CreateDate
            // 
            CreateDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CreateDate.HeaderText = "CreateDate";
            CreateDate.MinimumWidth = 8;
            CreateDate.Name = "CreateDate";
            CreateDate.ReadOnly = true;
            CreateDate.Width = 135;
            // 
            // DownloadedDate
            // 
            DownloadedDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DownloadedDate.HeaderText = "DownloadedDate";
            DownloadedDate.MinimumWidth = 8;
            DownloadedDate.Name = "DownloadedDate";
            DownloadedDate.ReadOnly = true;
            DownloadedDate.Width = 187;
            // 
            // Note
            // 
            Note.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Note.HeaderText = "Note";
            Note.MinimumWidth = 8;
            Note.Name = "Note";
            // 
            // btn_delete
            // 
            btn_delete.Dock = DockStyle.Fill;
            btn_delete.Location = new Point(1343, 705);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(144, 54);
            btn_delete.TabIndex = 1;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Dock = DockStyle.Fill;
            btn_update.Location = new Point(1343, 815);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(144, 54);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // TriggerTimer
            // 
            TriggerTimer.Interval = 1000;
            TriggerTimer.Tick += TriggerTimer_Tick;
            // 
            // BitcoinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 936);
            Controls.Add(tabControl1);
            Name = "BitcoinForm";
            Text = "BitcoinForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TriggerTimerInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage2;
        private NumericUpDown TriggerTimerInterval;
        private Button btn_save;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BtcEur;
        private DataGridViewTextBoxColumn EurCzk;
        private DataGridViewTextBoxColumn BtcCzk;
        private DataGridViewTextBoxColumn ValidAt;
        private System.Windows.Forms.Timer TriggerTimer;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView2;
        private Button btn_delete;
        private Button btn_update;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn BTC_EUR;
        private DataGridViewTextBoxColumn CZK_EUR;
        private DataGridViewTextBoxColumn BTC_CZK;
        private DataGridViewTextBoxColumn CreateDate;
        private DataGridViewTextBoxColumn DownloadedDate;
        private DataGridViewTextBoxColumn Note;
    }
}
