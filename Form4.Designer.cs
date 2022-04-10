
namespace OopLabProject
{
    partial class Form4
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
            this.btnsave = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btnmanager = new System.Windows.Forms.Button();
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
            this.checkedListBoxDifficulty.Location = new System.Drawing.Point(39, 44);
            this.checkedListBoxDifficulty.Name = "checkedListBoxDifficulty";
            this.checkedListBoxDifficulty.Size = new System.Drawing.Size(120, 89);
            this.checkedListBoxDifficulty.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(39, 174);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 34);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "square\t",
            "triangle",
            "round"});
            this.checkedListBox2.Location = new System.Drawing.Point(39, 254);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox2.TabIndex = 4;
            // 
            // btnmanager
            // 
            this.btnmanager.Location = new System.Drawing.Point(635, 44);
            this.btnmanager.Name = "btnmanager";
            this.btnmanager.Size = new System.Drawing.Size(153, 34);
            this.btnmanager.TabIndex = 6;
            this.btnmanager.Text = "Manager Screen";
            this.btnmanager.UseVisualStyleBackColor = true;
            this.btnmanager.Click += new System.EventHandler(this.btnmanager_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmanager);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBoxDifficulty);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxDifficulty;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button btnmanager;
    }
}