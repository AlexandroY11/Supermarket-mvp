namespace Supermarket_mvp.Views
{
    partial class PayModeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelPayMode = new Panel();
            pictureBox1 = new PictureBox();
            LblPayMode = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClosePayMode = new Button();
            BtnDeletePayMode = new Button();
            BtnEditPayMode = new Button();
            BtnNewPayMode = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            LblSearch = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtPayModeObservation = new TextBox();
            label1 = new Label();
            TxtPayModeName = new TextBox();
            LblPayModeName = new Label();
            TxtPayModeId = new TextBox();
            LblPayModeId = new Label();
            PanelPayMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPayMode
            // 
            PanelPayMode.Controls.Add(pictureBox1);
            PanelPayMode.Controls.Add(LblPayMode);
            PanelPayMode.Dock = DockStyle.Top;
            PanelPayMode.Location = new Point(0, 0);
            PanelPayMode.Name = "PanelPayMode";
            PanelPayMode.Size = new Size(800, 100);
            PanelPayMode.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LblPayMode
            // 
            LblPayMode.AutoSize = true;
            LblPayMode.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LblPayMode.Location = new Point(114, 30);
            LblPayMode.Name = "LblPayMode";
            LblPayMode.Size = new Size(152, 37);
            LblPayMode.TabIndex = 0;
            LblPayMode.Text = "PAY MODE";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClosePayMode);
            tabPagePayModeList.Controls.Add(BtnDeletePayMode);
            tabPagePayModeList.Controls.Add(BtnEditPayMode);
            tabPagePayModeList.Controls.Add(BtnNewPayMode);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(LblSearch);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 322);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClosePayMode
            // 
            BtnClosePayMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClosePayMode.Image = Properties.Resources.cerrar;
            BtnClosePayMode.Location = new Point(587, 252);
            BtnClosePayMode.Name = "BtnClosePayMode";
            BtnClosePayMode.Size = new Size(199, 62);
            BtnClosePayMode.TabIndex = 7;
            BtnClosePayMode.UseVisualStyleBackColor = true;
            // 
            // BtnDeletePayMode
            // 
            BtnDeletePayMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDeletePayMode.Image = Properties.Resources.delete;
            BtnDeletePayMode.Location = new Point(587, 184);
            BtnDeletePayMode.Name = "BtnDeletePayMode";
            BtnDeletePayMode.Size = new Size(199, 62);
            BtnDeletePayMode.TabIndex = 6;
            BtnDeletePayMode.UseVisualStyleBackColor = true;
            // 
            // BtnEditPayMode
            // 
            BtnEditPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEditPayMode.Image = Properties.Resources.edit;
            BtnEditPayMode.Location = new Point(587, 116);
            BtnEditPayMode.Name = "BtnEditPayMode";
            BtnEditPayMode.Size = new Size(199, 62);
            BtnEditPayMode.TabIndex = 5;
            BtnEditPayMode.UseVisualStyleBackColor = true;
            // 
            // BtnNewPayMode
            // 
            BtnNewPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNewPayMode.Image = Properties.Resources._new;
            BtnNewPayMode.Location = new Point(587, 48);
            BtnNewPayMode.Name = "BtnNewPayMode";
            BtnNewPayMode.Size = new Size(199, 62);
            BtnNewPayMode.TabIndex = 4;
            BtnNewPayMode.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(16, 76);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(542, 240);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(513, 33);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(47, 37);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(18, 41);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(478, 23);
            TxtSearch.TabIndex = 1;
            // 
            // LblSearch
            // 
            LblSearch.AutoSize = true;
            LblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblSearch.Location = new Point(16, 16);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(102, 15);
            LblSearch.TabIndex = 0;
            LblSearch.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label1);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(LblPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(LblPayModeId);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 322);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(213, 240);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(161, 74);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(20, 240);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(161, 74);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(20, 150);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(354, 73);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 132);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 4;
            label1.Text = "Pay Mode Observation";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(20, 90);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(354, 23);
            TxtPayModeName.TabIndex = 3;
            // 
            // LblPayModeName
            // 
            LblPayModeName.AutoSize = true;
            LblPayModeName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblPayModeName.Location = new Point(20, 72);
            LblPayModeName.Name = "LblPayModeName";
            LblPayModeName.Size = new Size(97, 15);
            LblPayModeName.TabIndex = 2;
            LblPayModeName.Text = "Pay Mode Name";
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(20, 34);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(183, 23);
            TxtPayModeId.TabIndex = 1;
            // 
            // LblPayModeId
            // 
            LblPayModeId.AutoSize = true;
            LblPayModeId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblPayModeId.Location = new Point(20, 16);
            LblPayModeId.Name = "LblPayModeId";
            LblPayModeId.Size = new Size(75, 15);
            LblPayModeId.TabIndex = 0;
            LblPayModeId.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(PanelPayMode);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            PanelPayMode.ResumeLayout(false);
            PanelPayMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPayMode;
        private Label LblPayMode;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private TextBox TxtSearch;
        private Label LblSearch;
        private Button BtnSearch;
        private DataGridView DgPayMode;
        private Button BtnClosePayMode;
        private Button BtnDeletePayMode;
        private Button BtnEditPayMode;
        private Button BtnNewPayMode;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private Label label1;
        private TextBox TxtPayModeName;
        private Label LblPayModeName;
        private TextBox TxtPayModeId;
        private Label LblPayModeId;
        private Button BtnCancel;
    }
}