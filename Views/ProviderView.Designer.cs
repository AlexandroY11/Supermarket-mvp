namespace Supermarket_mvp.Views
{
    partial class ProviderView
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
            PanelProvider = new Panel();
            pictureBox1 = new PictureBox();
            LblProvider = new Label();
            tabControl1 = new TabControl();
            tabPageProviderList = new TabPage();
            DgProvider = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            LblSearch = new Label();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            tabPageProviderDetail = new TabPage();
            TxtProviderPhone = new TextBox();
            label2 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProviderAddress = new TextBox();
            label1 = new Label();
            TxtProviderName = new TextBox();
            LblProviderName = new Label();
            TxtProviderId = new TextBox();
            LblProviderId = new Label();
            PanelProvider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).BeginInit();
            tabPageProviderDetail.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProvider
            // 
            PanelProvider.Controls.Add(pictureBox1);
            PanelProvider.Controls.Add(LblProvider);
            PanelProvider.Dock = DockStyle.Top;
            PanelProvider.Location = new Point(0, 0);
            PanelProvider.Name = "PanelProvider";
            PanelProvider.Size = new Size(800, 100);
            PanelProvider.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LblProvider
            // 
            LblProvider.AutoSize = true;
            LblProvider.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LblProvider.Location = new Point(114, 30);
            LblProvider.Name = "LblProvider";
            LblProvider.Size = new Size(151, 37);
            LblProvider.TabIndex = 0;
            LblProvider.Text = "PROVIDER";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProviderDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(DgProvider);
            tabPageProviderList.Controls.Add(BtnSearch);
            tabPageProviderList.Controls.Add(TxtSearch);
            tabPageProviderList.Controls.Add(LblSearch);
            tabPageProviderList.Controls.Add(BtnClose);
            tabPageProviderList.Controls.Add(BtnDelete);
            tabPageProviderList.Controls.Add(BtnEdit);
            tabPageProviderList.Controls.Add(BtnNew);
            tabPageProviderList.Location = new Point(4, 24);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(792, 322);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "Provider List";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // DgProvider
            // 
            DgProvider.AllowUserToAddRows = false;
            DgProvider.AllowUserToDeleteRows = false;
            DgProvider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProvider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProvider.Location = new Point(8, 75);
            DgProvider.Name = "DgProvider";
            DgProvider.ReadOnly = true;
            DgProvider.RowTemplate.Height = 25;
            DgProvider.Size = new Size(542, 240);
            DgProvider.TabIndex = 15;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(505, 32);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(47, 37);
            BtnSearch.TabIndex = 14;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(10, 40);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(478, 23);
            TxtSearch.TabIndex = 13;
            // 
            // LblSearch
            // 
            LblSearch.AutoSize = true;
            LblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblSearch.Location = new Point(8, 15);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(96, 15);
            LblSearch.TabIndex = 12;
            LblSearch.Text = "Search Provider";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(585, 250);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(199, 62);
            BtnClose.TabIndex = 11;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(585, 182);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(199, 62);
            BtnDelete.TabIndex = 10;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(585, 114);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(199, 62);
            BtnEdit.TabIndex = 9;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(585, 46);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(199, 62);
            BtnNew.TabIndex = 8;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // tabPageProviderDetail
            // 
            tabPageProviderDetail.Controls.Add(TxtProviderPhone);
            tabPageProviderDetail.Controls.Add(label2);
            tabPageProviderDetail.Controls.Add(BtnCancel);
            tabPageProviderDetail.Controls.Add(BtnSave);
            tabPageProviderDetail.Controls.Add(TxtProviderAddress);
            tabPageProviderDetail.Controls.Add(label1);
            tabPageProviderDetail.Controls.Add(TxtProviderName);
            tabPageProviderDetail.Controls.Add(LblProviderName);
            tabPageProviderDetail.Controls.Add(TxtProviderId);
            tabPageProviderDetail.Controls.Add(LblProviderId);
            tabPageProviderDetail.Location = new Point(4, 24);
            tabPageProviderDetail.Name = "tabPageProviderDetail";
            tabPageProviderDetail.Padding = new Padding(3);
            tabPageProviderDetail.Size = new Size(792, 322);
            tabPageProviderDetail.TabIndex = 1;
            tabPageProviderDetail.Text = "Provider Detail";
            tabPageProviderDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProviderPhone
            // 
            TxtProviderPhone.Location = new Point(8, 196);
            TxtProviderPhone.Multiline = true;
            TxtProviderPhone.Name = "TxtProviderPhone";
            TxtProviderPhone.PlaceholderText = "Provider Phone";
            TxtProviderPhone.Size = new Size(354, 23);
            TxtProviderPhone.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 178);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 16;
            label2.Text = "Provider Phone";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(201, 241);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(161, 74);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(8, 241);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(161, 74);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProviderAddress
            // 
            TxtProviderAddress.Location = new Point(8, 144);
            TxtProviderAddress.Multiline = true;
            TxtProviderAddress.Name = "TxtProviderAddress";
            TxtProviderAddress.PlaceholderText = "Provider Address";
            TxtProviderAddress.Size = new Size(354, 23);
            TxtProviderAddress.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 126);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 12;
            label1.Text = "Provider Address";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(8, 91);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Provider Name";
            TxtProviderName.Size = new Size(354, 23);
            TxtProviderName.TabIndex = 11;
            // 
            // LblProviderName
            // 
            LblProviderName.AutoSize = true;
            LblProviderName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblProviderName.Location = new Point(8, 73);
            LblProviderName.Name = "LblProviderName";
            LblProviderName.Size = new Size(91, 15);
            LblProviderName.TabIndex = 10;
            LblProviderName.Text = "Provider Name";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(8, 35);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.ReadOnly = true;
            TxtProviderId.Size = new Size(183, 23);
            TxtProviderId.TabIndex = 9;
            TxtProviderId.Text = "0";
            TxtProviderId.TextAlign = HorizontalAlignment.Right;
            // 
            // LblProviderId
            // 
            LblProviderId.AutoSize = true;
            LblProviderId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblProviderId.Location = new Point(8, 17);
            LblProviderId.Name = "LblProviderId";
            LblProviderId.Size = new Size(69, 15);
            LblProviderId.TabIndex = 8;
            LblProviderId.Text = "Provider Id";
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(PanelProvider);
            Name = "ProviderView";
            Text = "ProviderView";
            PanelProvider.ResumeLayout(false);
            PanelProvider.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).EndInit();
            tabPageProviderDetail.ResumeLayout(false);
            tabPageProviderDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProvider;
        private PictureBox pictureBox1;
        private Label LblProvider;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProviderDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProvider;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label LblSearch;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProviderAddress;
        private Label label1;
        private TextBox TxtProviderName;
        private Label LblProviderName;
        private TextBox TxtProviderId;
        private Label LblProviderId;
        private TextBox TxtProviderPhone;
        private Label label2;
    }
}