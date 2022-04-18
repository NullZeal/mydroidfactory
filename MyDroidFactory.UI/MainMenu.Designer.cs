namespace MyDroidFactory.UI
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnExit = new System.Windows.Forms.Button();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.wvDroidArmyVideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnCreateNewDroid = new System.Windows.Forms.Button();
            this.lvListOfDroids = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.btnSellDroid = new System.Windows.Forms.Button();
            this.btnIdSearch = new System.Windows.Forms.Button();
            this.txtIdSearch = new System.Windows.Forms.TextBox();
            this.btnSecureAllDroids = new System.Windows.Forms.Button();
            this.btnUpdateDroid = new System.Windows.Forms.Button();
            this.musicReset = new System.Windows.Forms.Timer(this.components);
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.cbDisplayType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wvDroidArmyVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(945, 428);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 118);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerAlarm
            // 
            this.timerAlarm.Enabled = true;
            this.timerAlarm.Interval = 70000;
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // wvDroidArmyVideo
            // 
            this.wvDroidArmyVideo.CreationProperties = null;
            this.wvDroidArmyVideo.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.wvDroidArmyVideo.Location = new System.Drawing.Point(34, 234);
            this.wvDroidArmyVideo.Name = "wvDroidArmyVideo";
            this.wvDroidArmyVideo.Size = new System.Drawing.Size(501, 296);
            this.wvDroidArmyVideo.Source = new System.Uri("https://invidious.snopyta.org/embed/enrUBmDgeOQ?volume=0&loop=1&controls=0&autopl" +
        "ay=1&iv_load_policy=3&quality=hd720", System.UriKind.Absolute);
            this.wvDroidArmyVideo.TabIndex = 2;
            this.wvDroidArmyVideo.TabStop = false;
            this.wvDroidArmyVideo.ZoomFactor = 1D;
            this.wvDroidArmyVideo.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.wvDroidArmyVideo_CoreWebView2InitializationCompleted);
            this.wvDroidArmyVideo.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.wvDroidArmyVideo_NavigationCompleted);
            // 
            // btnCreateNewDroid
            // 
            this.btnCreateNewDroid.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCreateNewDroid.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateNewDroid.Location = new System.Drawing.Point(581, 227);
            this.btnCreateNewDroid.Name = "btnCreateNewDroid";
            this.btnCreateNewDroid.Size = new System.Drawing.Size(358, 95);
            this.btnCreateNewDroid.TabIndex = 2;
            this.btnCreateNewDroid.Text = "&Manufacture New Droid";
            this.btnCreateNewDroid.UseVisualStyleBackColor = false;
            this.btnCreateNewDroid.Click += new System.EventHandler(this.btnCreateNewDroid_Click);
            // 
            // lvListOfDroids
            // 
            this.lvListOfDroids.BackColor = System.Drawing.SystemColors.Info;
            this.lvListOfDroids.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lvListOfDroids.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvListOfDroids.FullRowSelect = true;
            this.lvListOfDroids.GridLines = true;
            this.lvListOfDroids.Location = new System.Drawing.Point(12, 23);
            this.lvListOfDroids.MultiSelect = false;
            this.lvListOfDroids.Name = "lvListOfDroids";
            this.lvListOfDroids.Size = new System.Drawing.Size(1160, 194);
            this.lvListOfDroids.TabIndex = 1;
            this.lvListOfDroids.UseCompatibleStateImageBehavior = false;
            this.lvListOfDroids.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Droid Type";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Number";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Model";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Manufacturer";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Height (m)";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mass (kg)";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Equipment 1";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Equipment 2";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Equipment 3";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Equipment 4";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Equipment 5";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Equipment 6";
            this.columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Armament 1";
            this.columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Armament 2";
            this.columnHeader14.Width = 150;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Armament 3";
            this.columnHeader15.Width = 150;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Armament 4";
            this.columnHeader16.Width = 150;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Plating";
            this.columnHeader17.Width = 150;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Ai Chip";
            this.columnHeader18.Width = 150;
            // 
            // btnSellDroid
            // 
            this.btnSellDroid.BackColor = System.Drawing.Color.IndianRed;
            this.btnSellDroid.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSellDroid.Location = new System.Drawing.Point(813, 428);
            this.btnSellDroid.Name = "btnSellDroid";
            this.btnSellDroid.Size = new System.Drawing.Size(126, 118);
            this.btnSellDroid.TabIndex = 5;
            this.btnSellDroid.Text = "Sell Selected Droid";
            this.btnSellDroid.UseVisualStyleBackColor = false;
            this.btnSellDroid.Click += new System.EventHandler(this.btnSellDroid_Click);
            // 
            // btnIdSearch
            // 
            this.btnIdSearch.BackColor = System.Drawing.Color.Plum;
            this.btnIdSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIdSearch.Location = new System.Drawing.Point(945, 240);
            this.btnIdSearch.Name = "btnIdSearch";
            this.btnIdSearch.Size = new System.Drawing.Size(129, 68);
            this.btnIdSearch.TabIndex = 6;
            this.btnIdSearch.Text = "ID Search";
            this.btnIdSearch.UseVisualStyleBackColor = false;
            this.btnIdSearch.Click += new System.EventHandler(this.btnIdSearch_Click);
            // 
            // txtIdSearch
            // 
            this.txtIdSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdSearch.Location = new System.Drawing.Point(1084, 265);
            this.txtIdSearch.Name = "txtIdSearch";
            this.txtIdSearch.Size = new System.Drawing.Size(87, 23);
            this.txtIdSearch.TabIndex = 7;
            // 
            // btnSecureAllDroids
            // 
            this.btnSecureAllDroids.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSecureAllDroids.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSecureAllDroids.Location = new System.Drawing.Point(581, 428);
            this.btnSecureAllDroids.Name = "btnSecureAllDroids";
            this.btnSecureAllDroids.Size = new System.Drawing.Size(226, 120);
            this.btnSecureAllDroids.TabIndex = 4;
            this.btnSecureAllDroids.Text = "&Secure All Droids";
            this.btnSecureAllDroids.UseVisualStyleBackColor = false;
            this.btnSecureAllDroids.Click += new System.EventHandler(this.btnSecureAllDroids_Click);
            // 
            // btnUpdateDroid
            // 
            this.btnUpdateDroid.BackColor = System.Drawing.Color.Tan;
            this.btnUpdateDroid.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateDroid.Location = new System.Drawing.Point(581, 324);
            this.btnUpdateDroid.Name = "btnUpdateDroid";
            this.btnUpdateDroid.Size = new System.Drawing.Size(358, 86);
            this.btnUpdateDroid.TabIndex = 3;
            this.btnUpdateDroid.Text = "&Update Selected Droid";
            this.btnUpdateDroid.UseVisualStyleBackColor = false;
            this.btnUpdateDroid.Click += new System.EventHandler(this.btnUpdateDroid_Click);
            // 
            // musicReset
            // 
            this.musicReset.Enabled = true;
            this.musicReset.Interval = 192000;
            this.musicReset.Tick += new System.EventHandler(this.musicReset_Tick);
            // 
            // pbLoading
            // 
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(34, 223);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(501, 325);
            this.pbLoading.TabIndex = 13;
            this.pbLoading.TabStop = false;
            // 
            // cbDisplayType
            // 
            this.cbDisplayType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbDisplayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisplayType.ForeColor = System.Drawing.SystemColors.Info;
            this.cbDisplayType.FormattingEnabled = true;
            this.cbDisplayType.Items.AddRange(new object[] {
            "All Droids",
            "Battle Droids",
            "Assassin Droids",
            "AstroMech Droids"});
            this.cbDisplayType.Location = new System.Drawing.Point(953, 374);
            this.cbDisplayType.Name = "cbDisplayType";
            this.cbDisplayType.Size = new System.Drawing.Size(218, 23);
            this.cbDisplayType.TabIndex = 14;
            this.cbDisplayType.SelectedIndexChanged += new System.EventHandler(this.cbDisplayType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(953, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Display Type";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1184, 558);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDisplayType);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.btnUpdateDroid);
            this.Controls.Add(this.txtIdSearch);
            this.Controls.Add(this.btnIdSearch);
            this.Controls.Add(this.btnSellDroid);
            this.Controls.Add(this.btnSecureAllDroids);
            this.Controls.Add(this.lvListOfDroids);
            this.Controls.Add(this.btnCreateNewDroid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.wvDroidArmyVideo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.wvDroidArmyVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private System.Windows.Forms.Timer timerAlarm;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvDroidArmyVideo;
        private Button btnCreateNewDroid;
        private ListView lvListOfDroids;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private Button btnSellDroid;
        private Button btnIdSearch;
        private TextBox txtIdSearch;
        private Button btnSecureAllDroids;
        private Button btnUpdateDroid;
        private System.Windows.Forms.Timer musicReset;
        private PictureBox pbLoading;
        private ComboBox cbDisplayType;
        private Label label1;
    }
}