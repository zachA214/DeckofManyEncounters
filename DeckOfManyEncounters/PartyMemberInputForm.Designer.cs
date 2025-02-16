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
            this.nameInput.Location = new System.Drawing.Point(224, 46);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameInput.MaxLength = 20;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(283, 31);
            this.nameInput.TabIndex = 0;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
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
            this.classBox.Location = new System.Drawing.Point(263, 109);
            this.classBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(244, 33);
            this.classBox.TabIndex = 1;
            this.classBox.SelectedValueChanged += new System.EventHandler(this.classBox_SelectedValueChanged);
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(348, 170);
            this.levelBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.levelBox.Size = new System.Drawing.Size(160, 31);
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
            this.nameLabel.Location = new System.Drawing.Point(33, 46);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(168, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Character Name";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.levelLabel.Location = new System.Drawing.Point(139, 172);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(64, 25);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Level";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.classLabel.Location = new System.Drawing.Point(136, 109);
            this.classLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(66, 25);
            this.classLabel.TabIndex = 5;
            this.classLabel.Text = "Class";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(39, 241);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(191, 40);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save and Close";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PartyMemberInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(119)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(540, 330);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.nameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyMemberInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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