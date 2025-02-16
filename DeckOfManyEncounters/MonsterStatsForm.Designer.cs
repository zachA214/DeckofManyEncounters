namespace DeckOfManyEncounters
{
    partial class MonsterStatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonsterStatsForm));
            this.monsterStat = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // monsterStat
            // 
            this.monsterStat.Location = new System.Drawing.Point(0, 0);
            this.monsterStat.Name = "monsterStat";
            this.monsterStat.ReadOnly = true;
            this.monsterStat.Size = new System.Drawing.Size(798, 445);
            this.monsterStat.TabIndex = 0;
            this.monsterStat.Text = "";
            // 
            // MonsterStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monsterStat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonsterStatsForm";
            this.Text = "MonsterStatsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox monsterStat;
    }
}