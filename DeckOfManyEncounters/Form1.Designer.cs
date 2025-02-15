namespace DeckOfManyEncounters
{
    partial class DeckOfManyEncounters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckOfManyEncounters));
            this.inputFormOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFormOpenButton
            // 
            this.inputFormOpenButton.Location = new System.Drawing.Point(657, 343);
            this.inputFormOpenButton.Name = "inputFormOpenButton";
            this.inputFormOpenButton.Size = new System.Drawing.Size(157, 44);
            this.inputFormOpenButton.TabIndex = 0;
            this.inputFormOpenButton.Text = "Input form here";
            this.inputFormOpenButton.UseVisualStyleBackColor = true;
            this.inputFormOpenButton.Click += new System.EventHandler(this.inputFormOpenButton_Click);
            // 
            // DeckOfManyEncounters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.inputFormOpenButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "DeckOfManyEncounters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deck of Many Encounters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inputFormOpenButton;
    }
}

