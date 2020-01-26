namespace Scraper
{
    partial class EntryForm
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
            this.keywordEntry = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chapterSelect = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // keywordEntry
            // 
            this.keywordEntry.Location = new System.Drawing.Point(28, 62);
            this.keywordEntry.Name = "keywordEntry";
            this.keywordEntry.Size = new System.Drawing.Size(515, 114);
            this.keywordEntry.TabIndex = 0;
            this.keywordEntry.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keywords:";
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(652, 299);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 33);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chapters to Search:";
            // 
            // chapterSelect
            // 
            this.chapterSelect.FormattingEnabled = true;
            this.chapterSelect.ItemHeight = 20;
            this.chapterSelect.Items.AddRange(new object[] {
            "CH1: Understanding Science",
            "CH2: Plate Tectonics",
            "CH3: Minerals"});
            this.chapterSelect.Location = new System.Drawing.Point(38, 248);
            this.chapterSelect.Name = "chapterSelect";
            this.chapterSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.chapterSelect.Size = new System.Drawing.Size(281, 84);
            this.chapterSelect.TabIndex = 6;
            this.chapterSelect.SelectedIndexChanged += new System.EventHandler(this.chapterSelect_SelectedIndexChanged);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.chapterSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keywordEntry);
            this.Name = "EntryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox keywordEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox chapterSelect;
    }
}

