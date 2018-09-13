namespace MedicalProgram
{
    partial class CandidateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateForm));
            this.buttonResult = new System.Windows.Forms.Button();
            this.resButton = new System.Windows.Forms.Label();
            this.PrefButton = new System.Windows.Forms.Button();
            this.prefLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.givePreferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resTextBox = new System.Windows.Forms.TextBox();
            this.clgGridView = new System.Windows.Forms.DataGridView();
            this.ClgNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clgGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult
            // 
            this.buttonResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonResult.BackgroundImage")));
            this.buttonResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResult.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(165, 43);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(140, 89);
            this.buttonResult.TabIndex = 0;
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // resButton
            // 
            this.resButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resButton.AutoSize = true;
            this.resButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resButton.Location = new System.Drawing.Point(208, 146);
            this.resButton.Name = "resButton";
            this.resButton.Size = new System.Drawing.Size(62, 24);
            this.resButton.TabIndex = 2;
            this.resButton.Text = "Result";
            // 
            // PrefButton
            // 
            this.PrefButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrefButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrefButton.BackgroundImage")));
            this.PrefButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrefButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrefButton.Location = new System.Drawing.Point(374, 43);
            this.PrefButton.Name = "PrefButton";
            this.PrefButton.Size = new System.Drawing.Size(140, 89);
            this.PrefButton.TabIndex = 3;
            this.PrefButton.UseVisualStyleBackColor = true;
            this.PrefButton.Click += new System.EventHandler(this.PrefButton_Click);
            // 
            // prefLabel
            // 
            this.prefLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prefLabel.AutoSize = true;
            this.prefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.prefLabel.Location = new System.Drawing.Point(390, 146);
            this.prefLabel.Name = "prefLabel";
            this.prefLabel.Size = new System.Drawing.Size(103, 24);
            this.prefLabel.TabIndex = 4;
            this.prefLabel.Text = "Preference";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.givePreferenceToolStripMenuItem,
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // givePreferenceToolStripMenuItem
            // 
            this.givePreferenceToolStripMenuItem.Name = "givePreferenceToolStripMenuItem";
            this.givePreferenceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.givePreferenceToolStripMenuItem.Text = "Give Preference";
            this.givePreferenceToolStripMenuItem.Click += new System.EventHandler(this.givePreferenceToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.backToolStripMenuItem.Text = "LogOut";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // resTextBox
            // 
            this.resTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resTextBox.Location = new System.Drawing.Point(161, 228);
            this.resTextBox.Multiline = true;
            this.resTextBox.Name = "resTextBox";
            this.resTextBox.ReadOnly = true;
            this.resTextBox.Size = new System.Drawing.Size(364, 311);
            this.resTextBox.TabIndex = 6;
            // 
            // clgGridView
            // 
            this.clgGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clgGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clgGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClgNoCol,
            this.clgNameCol});
            this.clgGridView.Location = new System.Drawing.Point(128, 195);
            this.clgGridView.Name = "clgGridView";
            this.clgGridView.Size = new System.Drawing.Size(423, 354);
            this.clgGridView.TabIndex = 7;
            // 
            // ClgNoCol
            // 
            this.ClgNoCol.DataPropertyName = "CollegeNo";
            this.ClgNoCol.HeaderText = "College No";
            this.ClgNoCol.Name = "ClgNoCol";
            this.ClgNoCol.ReadOnly = true;
            this.ClgNoCol.Visible = false;
            // 
            // clgNameCol
            // 
            this.clgNameCol.DataPropertyName = "CollegeName";
            this.clgNameCol.HeaderText = "College Name";
            this.clgNameCol.Name = "clgNameCol";
            this.clgNameCol.ReadOnly = true;
            // 
            // CandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 584);
            this.ControlBox = false;
            this.Controls.Add(this.clgGridView);
            this.Controls.Add(this.resTextBox);
            this.Controls.Add(this.prefLabel);
            this.Controls.Add(this.PrefButton);
            this.Controls.Add(this.resButton);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "CandidateForm";
            this.Text = "Candidate Form";
            this.Load += new System.EventHandler(this.CandidateForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clgGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label resButton;
        private System.Windows.Forms.Button PrefButton;
        private System.Windows.Forms.Label prefLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem givePreferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox resTextBox;
        private System.Windows.Forms.DataGridView clgGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClgNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNameCol;
    }
}