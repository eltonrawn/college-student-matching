namespace MedicalProgram
{
    partial class PreferenceForm
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
            this.clgGridView = new System.Windows.Forms.DataGridView();
            this.clgNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.selectedGridView = new System.Windows.Forms.DataGridView();
            this.clgNoCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgNameCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.featuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.clgGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clgGridView
            // 
            this.clgGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.clgGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.clgGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clgGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clgNoCol,
            this.clgNameCol,
            this.addCol});
            this.clgGridView.Location = new System.Drawing.Point(22, 64);
            this.clgGridView.Name = "clgGridView";
            this.clgGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clgGridView.Size = new System.Drawing.Size(298, 301);
            this.clgGridView.TabIndex = 0;
            this.clgGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clgGridView_CellContentClick);
            // 
            // clgNoCol
            // 
            this.clgNoCol.DataPropertyName = "CollegeNo";
            this.clgNoCol.HeaderText = "College No";
            this.clgNoCol.Name = "clgNoCol";
            this.clgNoCol.ReadOnly = true;
            this.clgNoCol.Visible = false;
            // 
            // clgNameCol
            // 
            this.clgNameCol.DataPropertyName = "CollegeName";
            this.clgNameCol.HeaderText = "College Name";
            this.clgNameCol.Name = "clgNameCol";
            this.clgNameCol.ReadOnly = true;
            this.clgNameCol.Width = 128;
            // 
            // addCol
            // 
            this.addCol.HeaderText = "Add";
            this.addCol.Name = "addCol";
            this.addCol.ReadOnly = true;
            this.addCol.Text = "Add";
            this.addCol.UseColumnTextForButtonValue = true;
            this.addCol.Width = 127;
            // 
            // selectedGridView
            // 
            this.selectedGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.selectedGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.selectedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clgNoCol2,
            this.clgNameCol2,
            this.removeCol});
            this.selectedGridView.Location = new System.Drawing.Point(348, 64);
            this.selectedGridView.Name = "selectedGridView";
            this.selectedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedGridView.Size = new System.Drawing.Size(303, 301);
            this.selectedGridView.TabIndex = 1;
            this.selectedGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedGridView_CellContentClick);
            // 
            // clgNoCol2
            // 
            this.clgNoCol2.DataPropertyName = "CollegeNo";
            this.clgNoCol2.HeaderText = "College No";
            this.clgNoCol2.Name = "clgNoCol2";
            this.clgNoCol2.ReadOnly = true;
            this.clgNoCol2.Visible = false;
            // 
            // clgNameCol2
            // 
            this.clgNameCol2.DataPropertyName = "CollegeName";
            this.clgNameCol2.HeaderText = "College Name";
            this.clgNameCol2.Name = "clgNameCol2";
            this.clgNameCol2.ReadOnly = true;
            this.clgNameCol2.Width = 130;
            // 
            // removeCol
            // 
            this.removeCol.HeaderText = "Remove";
            this.removeCol.Name = "removeCol";
            this.removeCol.ReadOnly = true;
            this.removeCol.Text = "Remove";
            this.removeCol.UseColumnTextForButtonValue = true;
            this.removeCol.Width = 130;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SubmitButton.Location = new System.Drawing.Point(245, 380);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(348, 380);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(99, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available College";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(428, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selected College";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featuresToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // featuresToolStripMenuItem
            // 
            this.featuresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.featuresToolStripMenuItem.Name = "featuresToolStripMenuItem";
            this.featuresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.featuresToolStripMenuItem.Text = "Features";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // PreferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(676, 445);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.selectedGridView);
            this.Controls.Add(this.clgGridView);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "PreferenceForm";
            this.Text = "PreferenceForm";
            this.Load += new System.EventHandler(this.PreferenceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clgGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clgGridView;
        private System.Windows.Forms.DataGridView selectedGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNameCol;
        private System.Windows.Forms.DataGridViewButtonColumn addCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNoCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgNameCol2;
        private System.Windows.Forms.DataGridViewButtonColumn removeCol;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem featuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}