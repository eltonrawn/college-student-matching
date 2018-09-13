namespace MedicalProgram
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.candidateButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.candidateLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.clgButton = new System.Windows.Forms.Button();
            this.clgLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.appButton = new System.Windows.Forms.Button();
            this.appLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cndGridView = new System.Windows.Forms.DataGridView();
            this.canNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sscMarkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hscMarkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFFCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.triCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cndGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cndName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gkCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgGridView = new System.Windows.Forms.DataGridView();
            this.clgNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totSeatCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ffReservedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tribalResCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finGridView = new System.Windows.Forms.DataGridView();
            this.studentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgNameCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cndGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cndGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clgGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // candidateButton
            // 
            this.candidateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.candidateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("candidateButton.BackgroundImage")));
            this.candidateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.candidateButton.Location = new System.Drawing.Point(47, 35);
            this.candidateButton.Name = "candidateButton";
            this.candidateButton.Size = new System.Drawing.Size(119, 93);
            this.candidateButton.TabIndex = 11;
            this.candidateButton.UseVisualStyleBackColor = true;
            this.candidateButton.Click += new System.EventHandler(this.candidateButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resultButton.BackgroundImage")));
            this.resultButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resultButton.Location = new System.Drawing.Point(202, 35);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(121, 93);
            this.resultButton.TabIndex = 12;
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // candidateLabel
            // 
            this.candidateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.candidateLabel.AutoSize = true;
            this.candidateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.candidateLabel.Location = new System.Drawing.Point(56, 151);
            this.candidateLabel.Name = "candidateLabel";
            this.candidateLabel.Size = new System.Drawing.Size(110, 25);
            this.candidateLabel.TabIndex = 14;
            this.candidateLabel.Text = "Candidate";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resultLabel.Location = new System.Drawing.Point(222, 151);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(73, 25);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "Result";
            // 
            // clgButton
            // 
            this.clgButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clgButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clgButton.BackgroundImage")));
            this.clgButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clgButton.Location = new System.Drawing.Point(361, 35);
            this.clgButton.Name = "clgButton";
            this.clgButton.Size = new System.Drawing.Size(117, 93);
            this.clgButton.TabIndex = 16;
            this.clgButton.UseVisualStyleBackColor = true;
            this.clgButton.Click += new System.EventHandler(this.clgButton_Click);
            // 
            // clgLabel
            // 
            this.clgLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clgLabel.AutoSize = true;
            this.clgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clgLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clgLabel.Location = new System.Drawing.Point(374, 151);
            this.clgLabel.Name = "clgLabel";
            this.clgLabel.Size = new System.Drawing.Size(85, 25);
            this.clgLabel.TabIndex = 17;
            this.clgLabel.Text = "College";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(167, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 24);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(458, 199);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(31, 24);
            this.searchButton.TabIndex = 19;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // appButton
            // 
            this.appButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.appButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("appButton.BackgroundImage")));
            this.appButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.appButton.Location = new System.Drawing.Point(516, 35);
            this.appButton.Name = "appButton";
            this.appButton.Size = new System.Drawing.Size(117, 93);
            this.appButton.TabIndex = 20;
            this.appButton.UseVisualStyleBackColor = true;
            this.appButton.Click += new System.EventHandler(this.appButton_Click);
            // 
            // appLabel
            // 
            this.appLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.appLabel.AutoSize = true;
            this.appLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.appLabel.Location = new System.Drawing.Point(529, 151);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(95, 25);
            this.appLabel.TabIndex = 21;
            this.appLabel.Text = "Run App";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // cndGridView
            // 
            this.cndGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cndGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cndGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.cndGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cndGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.canNoCol,
            this.nameCol,
            this.sscMarkCol,
            this.hscMarkCol,
            this.isFFCol,
            this.triCodeCol,
            this.isFirst});
            this.cndGridView.Location = new System.Drawing.Point(35, 228);
            this.cndGridView.Name = "cndGridView";
            this.cndGridView.Size = new System.Drawing.Size(614, 320);
            this.cndGridView.TabIndex = 24;
            this.cndGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cndGridView_CellContentClick);
            // 
            // canNoCol
            // 
            this.canNoCol.DataPropertyName = "CandidateNo";
            this.canNoCol.HeaderText = "Candidate No";
            this.canNoCol.Name = "canNoCol";
            this.canNoCol.Visible = false;
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "Name";
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            // 
            // sscMarkCol
            // 
            this.sscMarkCol.DataPropertyName = "SscMark";
            this.sscMarkCol.HeaderText = "SSC Mark";
            this.sscMarkCol.Name = "sscMarkCol";
            // 
            // hscMarkCol
            // 
            this.hscMarkCol.DataPropertyName = "HscMark";
            this.hscMarkCol.HeaderText = "HSC Mark";
            this.hscMarkCol.Name = "hscMarkCol";
            // 
            // isFFCol
            // 
            this.isFFCol.DataPropertyName = "IsFF";
            this.isFFCol.HeaderText = "Is Freedom Fighter Eligible";
            this.isFFCol.Name = "isFFCol";
            // 
            // triCodeCol
            // 
            this.triCodeCol.DataPropertyName = "TribalCode";
            this.triCodeCol.HeaderText = "Tribal Code";
            this.triCodeCol.Name = "triCodeCol";
            // 
            // isFirst
            // 
            this.isFirst.DataPropertyName = "IsFirst";
            this.isFirst.HeaderText = "Is First Year";
            this.isFirst.Name = "isFirst";
            // 
            // cndGridView2
            // 
            this.cndGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cndGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cndGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.cndGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cndGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cndName,
            this.bioCol,
            this.chemCol,
            this.phyCol,
            this.engCol,
            this.gkCol});
            this.cndGridView2.Location = new System.Drawing.Point(35, 229);
            this.cndGridView2.Name = "cndGridView2";
            this.cndGridView2.Size = new System.Drawing.Size(614, 320);
            this.cndGridView2.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CandidateNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Candidate No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // cndName
            // 
            this.cndName.DataPropertyName = "Name";
            this.cndName.HeaderText = "Name";
            this.cndName.Name = "cndName";
            // 
            // bioCol
            // 
            this.bioCol.DataPropertyName = "BioMark";
            this.bioCol.HeaderText = "Biology";
            this.bioCol.Name = "bioCol";
            // 
            // chemCol
            // 
            this.chemCol.DataPropertyName = "ChemMark";
            this.chemCol.HeaderText = "Chemistry";
            this.chemCol.Name = "chemCol";
            // 
            // phyCol
            // 
            this.phyCol.DataPropertyName = "PhyMark";
            this.phyCol.HeaderText = "Physics";
            this.phyCol.Name = "phyCol";
            // 
            // engCol
            // 
            this.engCol.DataPropertyName = "EngMark";
            this.engCol.HeaderText = "English";
            this.engCol.Name = "engCol";
            // 
            // gkCol
            // 
            this.gkCol.DataPropertyName = "GkMark";
            this.gkCol.HeaderText = "General Knowledge";
            this.gkCol.Name = "gkCol";
            // 
            // clgGridView
            // 
            this.clgGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clgGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clgGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.clgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clgGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clgNoCol,
            this.clgNameCol,
            this.totSeatCol,
            this.ffReservedCol,
            this.tribalResCol,
            this.dataGridViewTextBoxColumn2});
            this.clgGridView.Location = new System.Drawing.Point(35, 229);
            this.clgGridView.Name = "clgGridView";
            this.clgGridView.Size = new System.Drawing.Size(614, 319);
            this.clgGridView.TabIndex = 26;
            // 
            // clgNoCol
            // 
            this.clgNoCol.DataPropertyName = "CollegeNo";
            this.clgNoCol.HeaderText = "College Code";
            this.clgNoCol.Name = "clgNoCol";
            this.clgNoCol.Visible = false;
            // 
            // clgNameCol
            // 
            this.clgNameCol.DataPropertyName = "CollegeName";
            this.clgNameCol.HeaderText = "College Name";
            this.clgNameCol.Name = "clgNameCol";
            // 
            // totSeatCol
            // 
            this.totSeatCol.DataPropertyName = "TotalSeat";
            this.totSeatCol.HeaderText = "Total Seat";
            this.totSeatCol.Name = "totSeatCol";
            // 
            // ffReservedCol
            // 
            this.ffReservedCol.DataPropertyName = "FFReserved";
            this.ffReservedCol.HeaderText = "Freedom Fighter Reserved";
            this.ffReservedCol.Name = "ffReservedCol";
            // 
            // tribalResCol
            // 
            this.tribalResCol.DataPropertyName = "TribalReserved";
            this.tribalResCol.HeaderText = "Tribal Reserved";
            this.tribalResCol.Name = "tribalResCol";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TribalCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tribal Code";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // finGridView
            // 
            this.finGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.finGridView.BackgroundColor = System.Drawing.Color.White;
            this.finGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNo,
            this.clgNo,
            this.stuNameCol,
            this.clgNameCol2,
            this.statusCol});
            this.finGridView.Location = new System.Drawing.Point(35, 228);
            this.finGridView.Name = "finGridView";
            this.finGridView.Size = new System.Drawing.Size(614, 321);
            this.finGridView.TabIndex = 27;
            this.finGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.finGridView_CellContentClick);
            // 
            // studentNo
            // 
            this.studentNo.DataPropertyName = "StudentNo";
            this.studentNo.HeaderText = "Student No";
            this.studentNo.Name = "studentNo";
            this.studentNo.Visible = false;
            // 
            // clgNo
            // 
            this.clgNo.DataPropertyName = "ClgNo";
            this.clgNo.HeaderText = "College No";
            this.clgNo.Name = "clgNo";
            this.clgNo.Visible = false;
            // 
            // stuNameCol
            // 
            this.stuNameCol.DataPropertyName = "StudentName";
            this.stuNameCol.HeaderText = "Candidate";
            this.stuNameCol.Name = "stuNameCol";
            this.stuNameCol.ReadOnly = true;
            // 
            // clgNameCol2
            // 
            this.clgNameCol2.DataPropertyName = "ClgName";
            this.clgNameCol2.HeaderText = "College Name";
            this.clgNameCol2.Name = "clgNameCol2";
            this.clgNameCol2.ReadOnly = true;
            // 
            // statusCol
            // 
            this.statusCol.DataPropertyName = "Status";
            this.statusCol.HeaderText = "Status";
            this.statusCol.Name = "statusCol";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(684, 584);
            this.ControlBox = false;
            this.Controls.Add(this.finGridView);
            this.Controls.Add(this.clgGridView);
            this.Controls.Add(this.cndGridView2);
            this.Controls.Add(this.cndGridView);
            this.Controls.Add(this.appLabel);
            this.Controls.Add(this.appButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clgLabel);
            this.Controls.Add(this.clgButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.candidateLabel);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.candidateButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cndGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cndGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clgGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button candidateButton;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Label candidateLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button clgButton;
        private System.Windows.Forms.Label clgLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button appButton;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView cndGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn canNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sscMarkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn hscMarkCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFFCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn triCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFirst;
        private System.Windows.Forms.DataGridView cndGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cndName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn engCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gkCol;
        private System.Windows.Forms.DataGridView clgGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totSeatCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ffReservedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn tribalResCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView finGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNameCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCol;
    }
}