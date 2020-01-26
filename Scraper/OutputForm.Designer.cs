namespace Scraper
{
    partial class OutputForm
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
            this.outputTabs = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTabs
            // 
            this.outputTabs.Location = new System.Drawing.Point(13, 13);
            this.outputTabs.Name = "outputTabs";
            this.outputTabs.SelectedIndex = 0;
            this.outputTabs.Size = new System.Drawing.Size(775, 364);
            this.outputTabs.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputTabs);
            this.Name = "OutputForm";
            this.Text = "OutputForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl outputTabs;
        private System.Windows.Forms.Button button1;
    }
}