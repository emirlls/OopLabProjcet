
namespace OopLabProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnetner = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(275, 170);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(117, 22);
            this.txtusername.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(275, 237);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(117, 22);
            this.txtpassword.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(135, 174);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(69, 18);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(135, 241);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 18);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password:";
            // 
            // btnetner
            // 
            this.btnetner.Location = new System.Drawing.Point(295, 307);
            this.btnetner.Name = "btnetner";
            this.btnetner.Size = new System.Drawing.Size(97, 48);
            this.btnetner.TabIndex = 4;
            this.btnetner.Text = "Login";
            this.btnetner.UseVisualStyleBackColor = true;
            this.btnetner.Click += new System.EventHandler(this.btnetner_Click);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(28, 275);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 17);
            this.lblerror.TabIndex = 5;
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnregister.Location = new System.Drawing.Point(550, 306);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(97, 48);
            this.btnregister.TabIndex = 7;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btnetner);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Button btnetner;
        private System.Windows.Forms.Label lblerror;
        public System.Windows.Forms.TextBox txtusername;
        public System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnregister;
    }
}

