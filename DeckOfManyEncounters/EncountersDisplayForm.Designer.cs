namespace DeckOfManyEncounters
{
    partial class EncountersDisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncountersDisplayForm));
            this.encounterTabs = new System.Windows.Forms.TabControl();
            this.Encounter1 = new System.Windows.Forms.TabPage();
            this.Encounter2 = new System.Windows.Forms.TabPage();
            this.Encounter3 = new System.Windows.Forms.TabPage();
            this.Encounter4 = new System.Windows.Forms.TabPage();
            this.Encounter5 = new System.Windows.Forms.TabPage();
            this.Encounter6 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.encounterTabs.SuspendLayout();
            this.Encounter1.SuspendLayout();
            this.SuspendLayout();
            // 
            // encounterTabs
            // 
            this.encounterTabs.Controls.Add(this.Encounter1);
            this.encounterTabs.Controls.Add(this.Encounter2);
            this.encounterTabs.Controls.Add(this.Encounter3);
            this.encounterTabs.Controls.Add(this.Encounter4);
            this.encounterTabs.Controls.Add(this.Encounter5);
            this.encounterTabs.Controls.Add(this.Encounter6);
            this.encounterTabs.Location = new System.Drawing.Point(28, 12);
            this.encounterTabs.Name = "encounterTabs";
            this.encounterTabs.SelectedIndex = 0;
            this.encounterTabs.Size = new System.Drawing.Size(739, 415);
            this.encounterTabs.TabIndex = 0;
            // 
            // Encounter1
            // 
            this.Encounter1.Controls.Add(this.panel1);
            this.Encounter1.Location = new System.Drawing.Point(4, 29);
            this.Encounter1.Name = "Encounter1";
            this.Encounter1.Padding = new System.Windows.Forms.Padding(3);
            this.Encounter1.Size = new System.Drawing.Size(731, 382);
            this.Encounter1.TabIndex = 0;
            this.Encounter1.Text = "Encounter 1";
            this.Encounter1.UseVisualStyleBackColor = true;
            // 
            // Encounter2
            // 
            this.Encounter2.Location = new System.Drawing.Point(4, 29);
            this.Encounter2.Name = "Encounter2";
            this.Encounter2.Padding = new System.Windows.Forms.Padding(3);
            this.Encounter2.Size = new System.Drawing.Size(731, 382);
            this.Encounter2.TabIndex = 1;
            this.Encounter2.Text = "Encounter 2";
            this.Encounter2.UseVisualStyleBackColor = true;
            // 
            // Encounter3
            // 
            this.Encounter3.Location = new System.Drawing.Point(4, 29);
            this.Encounter3.Name = "Encounter3";
            this.Encounter3.Size = new System.Drawing.Size(731, 382);
            this.Encounter3.TabIndex = 2;
            this.Encounter3.Text = "Encounter 3";
            this.Encounter3.UseVisualStyleBackColor = true;
            // 
            // Encounter4
            // 
            this.Encounter4.Location = new System.Drawing.Point(4, 29);
            this.Encounter4.Name = "Encounter4";
            this.Encounter4.Size = new System.Drawing.Size(731, 382);
            this.Encounter4.TabIndex = 3;
            this.Encounter4.Text = "Encounter 4";
            this.Encounter4.UseVisualStyleBackColor = true;
            // 
            // Encounter5
            // 
            this.Encounter5.Location = new System.Drawing.Point(4, 29);
            this.Encounter5.Name = "Encounter5";
            this.Encounter5.Size = new System.Drawing.Size(731, 382);
            this.Encounter5.TabIndex = 4;
            this.Encounter5.Text = "Encounter 5";
            this.Encounter5.UseVisualStyleBackColor = true;
            // 
            // Encounter6
            // 
            this.Encounter6.Location = new System.Drawing.Point(4, 29);
            this.Encounter6.Name = "Encounter6";
            this.Encounter6.Size = new System.Drawing.Size(731, 382);
            this.Encounter6.TabIndex = 5;
            this.Encounter6.Text = "Encounter 6";
            this.Encounter6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 379);
            this.panel1.TabIndex = 0;
            // 
            // EncountersDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.encounterTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncountersDisplayForm";
            this.Text = "Generated Encounters";
            this.encounterTabs.ResumeLayout(false);
            this.Encounter1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl encounterTabs;
        private System.Windows.Forms.TabPage Encounter1;
        private System.Windows.Forms.TabPage Encounter2;
        private System.Windows.Forms.TabPage Encounter3;
        private System.Windows.Forms.TabPage Encounter4;
        private System.Windows.Forms.TabPage Encounter5;
        private System.Windows.Forms.TabPage Encounter6;
        private System.Windows.Forms.Panel panel1;
    }
}