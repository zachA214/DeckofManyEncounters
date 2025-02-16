namespace DeckOfManyEncounters
{
    partial class PartyMemberInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartyMemberInputForm));
            this.nameInput = new System.Windows.Forms.TextBox();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.levelBox = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Location = new System.Drawing.Point(168, 37);
            this.nameInput.MaxLength = 15;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(213, 26);
            this.nameInput.TabIndex = 0;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classBox
            // 
            this.classBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classBox.FormattingEnabled = true;
            this.classBox.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.classBox.Location = new System.Drawing.Point(197, 87);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(184, 28);
            this.classBox.TabIndex = 1;
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(261, 136);
            this.levelBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.levelBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(120, 26);
            this.levelBox.TabIndex = 2;
            this.levelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.levelBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel.Location = new System.Drawing.Point(25, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(125, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Character Name";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.levelLabel.Location = new System.Drawing.Point(104, 138);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(46, 20);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Level";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.classLabel.Location = new System.Drawing.Point(102, 87);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(48, 20);
            this.classLabel.TabIndex = 5;
            this.classLabel.Text = "Class";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(29, 193);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(143, 32);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save and Close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PartyMemberInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(405, 264);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.nameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyMemberInputForm";
            this.Text = "PartyMemberInputForm";
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.NumericUpDown levelBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Button saveButton;
    }
}