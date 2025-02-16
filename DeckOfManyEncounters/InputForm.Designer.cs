namespace DeckOfManyEncounters
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveAndCloseInput = new System.Windows.Forms.Button();
            this.difficultyBox = new System.Windows.Forms.ComboBox();
            this.realmSelector = new System.Windows.Forms.ComboBox();
            this.realmLabel = new System.Windows.Forms.Label();
            this.creatureCountLabel = new System.Windows.Forms.Label();
            this.CreatureCounter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.swimmerCheckBox = new System.Windows.Forms.CheckBox();
            this.flyerCheckBox = new System.Windows.Forms.CheckBox();
            this.swimmerLabel = new System.Windows.Forms.Label();
            this.flyerLabel = new System.Windows.Forms.Label();
            this.alignmentBox = new System.Windows.Forms.ComboBox();
            this.alignLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CreatureCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // saveAndCloseInput
            // 
            this.saveAndCloseInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveAndCloseInput.Enabled = false;
            this.saveAndCloseInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveAndCloseInput.Location = new System.Drawing.Point(145, 365);
            this.saveAndCloseInput.Name = "saveAndCloseInput";
            this.saveAndCloseInput.Size = new System.Drawing.Size(131, 26);
            this.saveAndCloseInput.TabIndex = 2;
            this.saveAndCloseInput.Text = "Save and Close";
            this.saveAndCloseInput.UseVisualStyleBackColor = false;
            this.saveAndCloseInput.Click += new System.EventHandler(this.saveAndCloseInput_Click);
            // 
            // difficultyBox
            // 
            this.difficultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyBox.FormattingEnabled = true;
            this.difficultyBox.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Very Hard",
            "IMPOSSIBLE",
            "WORLD ENDER"});
            this.difficultyBox.Location = new System.Drawing.Point(145, 189);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(121, 29);
            this.difficultyBox.TabIndex = 3;
            this.difficultyBox.SelectedIndexChanged += new System.EventHandler(this.difficultyBox_SelectedIndexChanged);
            this.difficultyBox.SelectedValueChanged += new System.EventHandler(this.difficultyBox_TextUpdate);
            // 
            // realmSelector
            // 
            this.realmSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.realmSelector.FormattingEnabled = true;
            this.realmSelector.Items.AddRange(new object[] {
            "Feywild",
            "Elemental Plane",
            "Astral Plane",
            "Nine Hells",
            "Any"});
            this.realmSelector.Location = new System.Drawing.Point(16, 189);
            this.realmSelector.Name = "realmSelector";
            this.realmSelector.Size = new System.Drawing.Size(121, 29);
            this.realmSelector.TabIndex = 5;
            this.realmSelector.SelectedIndexChanged += new System.EventHandler(this.realmSelector_SelectedIndexChanged);
            // 
            // realmLabel
            // 
            this.realmLabel.AutoSize = true;
            this.realmLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.realmLabel.Location = new System.Drawing.Point(50, 151);
            this.realmLabel.Name = "realmLabel";
            this.realmLabel.Size = new System.Drawing.Size(54, 21);
            this.realmLabel.TabIndex = 6;
            this.realmLabel.Text = "Realm";
            // 
            // creatureCountLabel
            // 
            this.creatureCountLabel.AutoSize = true;
            this.creatureCountLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.creatureCountLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatureCountLabel.Location = new System.Drawing.Point(147, 238);
            this.creatureCountLabel.Name = "creatureCountLabel";
            this.creatureCountLabel.Size = new System.Drawing.Size(116, 21);
            this.creatureCountLabel.TabIndex = 7;
            this.creatureCountLabel.Text = "Creature Count";
            // 
            // CreatureCounter
            // 
            this.CreatureCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreatureCounter.Location = new System.Drawing.Point(145, 276);
            this.CreatureCounter.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.CreatureCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CreatureCounter.Name = "CreatureCounter";
            this.CreatureCounter.Size = new System.Drawing.Size(121, 28);
            this.CreatureCounter.TabIndex = 8;
            this.CreatureCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CreatureCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(44, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 9;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.difficultyLabel.Location = new System.Drawing.Point(170, 151);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(72, 21);
            this.difficultyLabel.TabIndex = 10;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // swimmerCheckBox
            // 
            this.swimmerCheckBox.AutoSize = true;
            this.swimmerCheckBox.Location = new System.Drawing.Point(167, 79);
            this.swimmerCheckBox.Name = "swimmerCheckBox";
            this.swimmerCheckBox.Size = new System.Drawing.Size(22, 21);
            this.swimmerCheckBox.TabIndex = 11;
            this.swimmerCheckBox.UseVisualStyleBackColor = true;
            // 
            // flyerCheckBox
            // 
            this.flyerCheckBox.AutoSize = true;
            this.flyerCheckBox.Location = new System.Drawing.Point(167, 35);
            this.flyerCheckBox.Name = "flyerCheckBox";
            this.flyerCheckBox.Size = new System.Drawing.Size(22, 21);
            this.flyerCheckBox.TabIndex = 12;
            this.flyerCheckBox.UseVisualStyleBackColor = true;
            // 
            // swimmerLabel
            // 
            this.swimmerLabel.AutoSize = true;
            this.swimmerLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.swimmerLabel.Location = new System.Drawing.Point(17, 80);
            this.swimmerLabel.Name = "swimmerLabel";
            this.swimmerLabel.Size = new System.Drawing.Size(134, 21);
            this.swimmerLabel.TabIndex = 13;
            this.swimmerLabel.Text = "Ignore Swimming";
            // 
            // flyerLabel
            // 
            this.flyerLabel.AutoSize = true;
            this.flyerLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flyerLabel.Location = new System.Drawing.Point(36, 39);
            this.flyerLabel.Name = "flyerLabel";
            this.flyerLabel.Size = new System.Drawing.Size(101, 21);
            this.flyerLabel.TabIndex = 14;
            this.flyerLabel.Text = "Ignore Flying";
            // 
            // alignmentBox
            // 
            this.alignmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alignmentBox.FormattingEnabled = true;
            this.alignmentBox.Items.AddRange(new object[] {
            "Evil",
            "Neutral",
            "Good",
            "Any"});
            this.alignmentBox.Location = new System.Drawing.Point(16, 275);
            this.alignmentBox.Name = "alignmentBox";
            this.alignmentBox.Size = new System.Drawing.Size(121, 29);
            this.alignmentBox.TabIndex = 15;
            this.alignmentBox.SelectedValueChanged += new System.EventHandler(this.alignmentBox_SelectedValueChanged);
            // 
            // alignLabel
            // 
            this.alignLabel.AutoSize = true;
            this.alignLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.alignLabel.Location = new System.Drawing.Point(36, 238);
            this.alignLabel.Name = "alignLabel";
            this.alignLabel.Size = new System.Drawing.Size(82, 21);
            this.alignLabel.TabIndex = 16;
            this.alignLabel.Text = "Alignment";
            // 
            // InputForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(179)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(278, 394);
            this.Controls.Add(this.alignLabel);
            this.Controls.Add(this.alignmentBox);
            this.Controls.Add(this.flyerLabel);
            this.Controls.Add(this.swimmerLabel);
            this.Controls.Add(this.flyerCheckBox);
            this.Controls.Add(this.swimmerCheckBox);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreatureCounter);
            this.Controls.Add(this.creatureCountLabel);
            this.Controls.Add(this.realmLabel);
            this.Controls.Add(this.realmSelector);
            this.Controls.Add(this.difficultyBox);
            this.Controls.Add(this.saveAndCloseInput);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encounter Details";
            ((System.ComponentModel.ISupportInitialize)(this.CreatureCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button saveAndCloseInput;
        private System.Windows.Forms.ComboBox difficultyBox;
        private System.Windows.Forms.ComboBox realmSelector;
        private System.Windows.Forms.Label realmLabel;
        private System.Windows.Forms.Label creatureCountLabel;
        private System.Windows.Forms.NumericUpDown CreatureCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.CheckBox swimmerCheckBox;
        private System.Windows.Forms.CheckBox flyerCheckBox;
        private System.Windows.Forms.Label swimmerLabel;
        private System.Windows.Forms.Label flyerLabel;
        private System.Windows.Forms.ComboBox alignmentBox;
        private System.Windows.Forms.Label alignLabel;
    }
}