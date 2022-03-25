
namespace OopLabProject
{
    partial class Form2
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
            this.checkedListBoxDifficulty = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.lbldifficulty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxDifficulty
            // 
            this.checkedListBoxDifficulty.FormattingEnabled = true;
            this.checkedListBoxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Custom"});
            this.checkedListBoxDifficulty.Location = new System.Drawing.Point(36, 82);
            this.checkedListBoxDifficulty.Name = "checkedListBoxDifficulty";
            this.checkedListBoxDifficulty.Size = new System.Drawing.Size(120, 89);
            this.checkedListBoxDifficulty.TabIndex = 0;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "square\t",
            "triangle",
            "round"});
            this.checkedListBox2.Location = new System.Drawing.Point(36, 250);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox2.TabIndex = 1;
            // 
            // lbldifficulty
            // 
            this.lbldifficulty.AutoSize = true;
            this.lbldifficulty.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldifficulty.Location = new System.Drawing.Point(47, 58);
            this.lbldifficulty.Name = "lbldifficulty";
            this.lbldifficulty.Size = new System.Drawing.Size(74, 21);
            this.lbldifficulty.TabIndex = 2;
            this.lbldifficulty.Text = "Difficulty";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbldifficulty);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBoxDifficulty);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxDifficulty;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label lbldifficulty;
    }
}