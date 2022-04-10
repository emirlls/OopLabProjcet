using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace OopLabProject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
         
            XDocument xDoc = XDocument.Load(@"Lastlogin.xml");

            XElement rootElement = xDoc.Root;

            foreach (XElement User in rootElement.Elements())
            {
                txtmanageusername.Text = (string)User.Attribute("Username").Value;
                
            }

        }

        private void btnmanagesave_Click(object sender, EventArgs e)
        {
            XDocument xDocpass = XDocument.Load("Password.xml");
            XElement rootelement = xDocpass.Root;


            XDocument xDoc = new XDocument();
            xDoc = XDocument.Load("User.xml");
            XElement rootElement = xDoc.Root;

            foreach (XElement User in rootelement.Elements())
            {
                if (txtmanageusername.Text == User.Attribute("Username").Value)
                {
                    User.Element("NameSurname").Value = txtmanagenamesurname.Text;
                    User.Element("Password").Value = txtmanagepassword.Text;
                    User.Element("Phone").Value = txtmanagephone.Text;
                    User.Element("Address").Value = txtmanageaddress.Text;
                    User.Element("City").Value = txtmanagecity.Text;
                    User.Element("Country").Value = txtmanagecountry.Text;
                    User.Element("Mail").Value = txtmanagemail.Text;
      
                }
            }
            xDocpass.Save(@"Password.xml");

            

            foreach (XElement Users in rootElement.Elements())
            {
                if(txtmanageusername.Text == Users.Attribute("Username").Value)
                {
                    SHA256Managed sha256 = new SHA256Managed();
                    byte[] bytearray = System.Text.Encoding.UTF8.GetBytes(txtmanagepassword.Text);
                    string cyrptopassword = Convert.ToBase64String(sha256.ComputeHash(bytearray));

                    Users.Element("NameSurname").Value = txtmanagenamesurname.Text;
                    //Users.Element("Password").Value = cyrptopassword;
                    Users.Element("Phone").Value = txtmanagephone.Text;
                    Users.Element("Address").Value = txtmanageaddress.Text;
                    Users.Element("City").Value = txtmanagecity.Text;
                    Users.Element("Country").Value = txtmanagecountry.Text;
                    Users.Element("Mail").Value = txtmanagemail.Text;
                }              
            }
            xDoc.Save("User.xml");

            txtmanageusername.Text = "";
            txtmanagenamesurname.Text = "";
            txtmanagepassword.Text = "";
            txtmanagephone.Text = "";
            txtmanageaddress.Text = "";
            txtmanagecity.Text = "";
            txtmanagecountry.Text = "";
            txtmanagemail.Text = "";

            MessageBox.Show("SUCCESS");

            
        }
    }
}
