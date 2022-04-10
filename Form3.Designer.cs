
namespace OopLabProject
{
    partial class Form3
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
            this.lblmanagement = new System.Windows.Forms.Label();
            this.btnlistallusers = new System.Windows.Forms.Button();
            this.btnaddnewuser = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtnewusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcountry = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtnamesurname = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbladdres = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lblcountry = new System.Windows.Forms.Label();
            this.lblmail = new System.Windows.Forms.Label();
            this.dgusers = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgusers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmanagement
            // 
            this.lblmanagement.AutoSize = true;
            this.lblmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmanagement.Location = new System.Drawing.Point(12, 9);
            this.lblmanagement.Name = "lblmanagement";
            this.lblmanagement.Size = new System.Drawing.Size(132, 20);
            this.lblmanagement.TabIndex = 0;
            this.lblmanagement.Text = "Manager Screen";
            // 
            // btnlistallusers
            // 
            this.btnlistallusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlistallusers.Location = new System.Drawing.Point(8, 51);
            this.btnlistallusers.Name = "btnlistallusers";
            this.btnlistallusers.Size = new System.Drawing.Size(154, 31);
            this.btnlistallusers.TabIndex = 7;
            this.btnlistallusers.Text = "List All Users";
            this.btnlistallusers.UseVisualStyleBackColor = true;
            this.btnlistallusers.Click += new System.EventHandler(this.btnlistallusers_Click);
            // 
            // btnaddnewuser
            // 
            this.btnaddnewuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddnewuser.Location = new System.Drawing.Point(192, 51);
            this.btnaddnewuser.Name = "btnaddnewuser";
            this.btnaddnewuser.Size = new System.Drawing.Size(166, 31);
            this.btnaddnewuser.TabIndex = 8;
            this.btnaddnewuser.Text = "Add a New User";
            this.btnaddnewuser.UseVisualStyleBackColor = true;
            this.btnaddnewuser.Click += new System.EventHandler(this.btnaddnewuser_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.Location = new System.Drawing.Point(8, 101);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(154, 31);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(8, 144);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(154, 30);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete a User";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtnewusername
            // 
            this.txtnewusername.Location = new System.Drawing.Point(138, 194);
            this.txtnewusername.Name = "txtnewusername";
            this.txtnewusername.Size = new System.Drawing.Size(314, 22);
            this.txtnewusername.TabIndex = 12;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(138, 291);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(314, 22);
            this.txtpassword.TabIndex = 15;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(138, 395);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(314, 22);
            this.txtaddress.TabIndex = 16;
            // 
            // txtcountry
            // 
            this.txtcountry.Location = new System.Drawing.Point(138, 483);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(314, 22);
            this.txtcountry.TabIndex = 17;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(138, 345);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(314, 22);
            this.txtphone.TabIndex = 18;
            // 
            // txtnamesurname
            // 
            this.txtnamesurname.Location = new System.Drawing.Point(138, 243);
            this.txtnamesurname.Name = "txtnamesurname";
            this.txtnamesurname.Size = new System.Drawing.Size(314, 22);
            this.txtnamesurname.TabIndex = 19;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(138, 441);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(314, 22);
            this.txtcity.TabIndex = 20;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(138, 527);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(314, 22);
            this.txtmail.TabIndex = 21;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblusername.Location = new System.Drawing.Point(47, 198);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(77, 18);
            this.lblusername.TabIndex = 22;
            this.lblusername.Text = "Username";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblname.Location = new System.Drawing.Point(11, 244);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(113, 18);
            this.lblname.TabIndex = 23;
            this.lblname.Text = "Name-Surname";
            // 
            // lbladdres
            // 
            this.lbladdres.AutoSize = true;
            this.lbladdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladdres.Location = new System.Drawing.Point(56, 399);
            this.lbladdres.Name = "lbladdres";
            this.lbladdres.Size = new System.Drawing.Size(62, 18);
            this.lbladdres.TabIndex = 24;
            this.lbladdres.Text = "Address";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblphone.Location = new System.Drawing.Point(67, 349);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(51, 18);
            this.lblphone.TabIndex = 25;
            this.lblphone.Text = "Phone";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpassword.Location = new System.Drawing.Point(47, 295);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(75, 18);
            this.lblpassword.TabIndex = 26;
            this.lblpassword.Text = "Password";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcity.Location = new System.Drawing.Point(85, 442);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(33, 18);
            this.lblcity.TabIndex = 27;
            this.lblcity.Text = "City";
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcountry.Location = new System.Drawing.Point(59, 483);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(60, 18);
            this.lblcountry.TabIndex = 28;
            this.lblcountry.Text = "Country";
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmail.Location = new System.Drawing.Point(79, 531);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(35, 18);
            this.lblmail.TabIndex = 29;
            this.lblmail.Text = "Mail";
            // 
            // dgusers
            // 
            this.dgusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusers.Location = new System.Drawing.Point(474, 51);
            this.dgusers.Name = "dgusers";
            this.dgusers.RowHeadersWidth = 51;
            this.dgusers.RowTemplate.Height = 24;
            this.dgusers.Size = new System.Drawing.Size(782, 497);
            this.dgusers.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1006, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(171, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Please write username to delete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Write username to update other infos";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 567);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgusers);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.lblcountry);
            this.Controls.Add(this.lblcity);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lbladdres);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtnamesurname);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtnewusername);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddnewuser);
            this.Controls.Add(this.btnlistallusers);
            this.Controls.Add(this.lblmanagement);
            this.Name = "Form3";
            this.Text = "Manager Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgusers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmanagement;
        private System.Windows.Forms.Button btnlistallusers;
        private System.Windows.Forms.Button btnaddnewuser;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtnewusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcountry;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtnamesurname;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbladdres;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.DataGridView dgusers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}