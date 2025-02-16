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
            this.partyButton = new System.Windows.Forms.Button();
            this.encounterGenerationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFormOpenButton
            // 
            this.inputFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFormOpenButton.Location = new System.Drawing.Point(912, 355);
            this.inputFormOpenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputFormOpenButton.Name = "inputFormOpenButton";
            this.inputFormOpenButton.Size = new System.Drawing.Size(210, 55);
            this.inputFormOpenButton.TabIndex = 0;
            this.inputFormOpenButton.Text = "Encounter Input";
            this.inputFormOpenButton.UseVisualStyleBackColor = true;
            this.inputFormOpenButton.Click += new System.EventHandler(this.inputFormOpenButton_Click);
            // 
            // partyButton
            // 
            this.partyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyButton.ForeColor = System.Drawing.Color.Black;
            this.partyButton.Location = new System.Drawing.Point(252, 355);
            this.partyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partyButton.Name = "partyButton";
            this.partyButton.Size = new System.Drawing.Size(210, 55);
            this.partyButton.TabIndex = 1;
            this.partyButton.Text = "View Party";
            this.partyButton.UseVisualStyleBackColor = true;
            this.partyButton.Click += new System.EventHandler(this.partyButton_Click);
            // 
            // encounterGenerationButton
            // 
            this.encounterGenerationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encounterGenerationButton.Location = new System.Drawing.Point(535, 578);
            this.encounterGenerationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encounterGenerationButton.Name = "encounterGenerationButton";
            this.encounterGenerationButton.Size = new System.Drawing.Size(280, 82);
            this.encounterGenerationButton.TabIndex = 2;
            this.encounterGenerationButton.Text = "Generate Encounters";
            this.encounterGenerationButton.UseVisualStyleBackColor = true;
            this.encounterGenerationButton.Click += new System.EventHandler(this.encounterGenerationButton_Click);
            // 
            // DeckOfManyEncounters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1331, 871);
            this.Controls.Add(this.encounterGenerationButton);
            this.Controls.Add(this.partyButton);
            this.Controls.Add(this.inputFormOpenButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1357, 942);
            this.MinimumSize = new System.Drawing.Size(1357, 942);
            this.Name = "DeckOfManyEncounters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deck of Many Encounters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inputFormOpenButton;
        private System.Windows.Forms.Button partyButton;
        private System.Windows.Forms.Button encounterGenerationButton;
    }
}

