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
using System.Xml.Linq;
using System.IO;
using System.Xml;

namespace OopLabProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnregistersave_Click(object sender, EventArgs e)
        {
            if (txtregisterusername.Text !="" && txtregisternamesurname.Text != "" && txtregisterpassword.Text != "" && txtregisterphone.Text != "" && txtregisteraddress.Text != "" && txtregistercity.Text != "" && txtregistercountry.Text != "" && txtregistermail.Text != "")
            {
                XDocument xDocpass = XDocument.Load("Password.xml");
                XElement rootelement = xDocpass.Root;
                XElement newelement = new XElement("User");
                XAttribute usernameattribute = new XAttribute("Username", txtregisterusername.Text);
                XElement nameelement = new XElement("NameSurname", txtregisternamesurname.Text);
                XElement passwordelement = new XElement("Password", txtregisterpassword.Text);             
                XElement phoneelement = new XElement("Phone", txtregisterphone.Text);
                XElement addresselement = new XElement("Address", txtregisteraddress.Text);
                XElement cityelement = new XElement("City", txtregistercity.Text);
                XElement countryelement = new XElement("Country", txtregistercountry.Text);
                XElement mailelement = new XElement("Mail", txtregistermail.Text);
                newelement.Add(usernameattribute, nameelement,passwordelement,phoneelement,addresselement,cityelement,countryelement,mailelement);
                rootelement.Add(newelement);
                xDocpass.Save("Password.xml");

                XDocument xDoc = XDocument.Load("User.xml");
                XElement rootElement = xDoc.Root;
                XElement newElement = new XElement("User");
                XAttribute usernameAttribute = new XAttribute("Username", txtregisterusername.Text);

                SHA256Managed sha256 = new SHA256Managed();
                byte[] bytearray = System.Text.Encoding.UTF8.GetBytes(txtregisterpassword.Text);

                string cyrptopassword = Convert.ToBase64String(sha256.ComputeHash(bytearray));

                XElement nameElement = new XElement("NameSurname", txtregisternamesurname.Text);
                XElement passwordElement = new XElement("Password", cyrptopassword);
                XElement phoneElement = new XElement("Phone", txtregisterphone.Text);
                XElement addressElement = new XElement("Address", txtregisteraddress.Text);
                XElement cityElement = new XElement("City", txtregistercity.Text);
                XElement countryElement = new XElement("Country", txtregistercountry.Text);
                XElement mailElement = new XElement("Mail", txtregistermail.Text);

                newElement.Add(usernameAttribute, nameElement, cyrptopassword, phoneElement, addressElement, cityElement, countryElement, mailElement);

                rootElement.Add(newElement);
                xDoc.Save(@"User.xml");

                txtregisterusername.Text = "";
                txtregisternamesurname.Text = "";
                txtregisterpassword.Text = "";
                txtregisterphone.Text = "";
                txtregisteraddress.Text = "";
                txtregistercity.Text = "";
                txtregistercountry.Text = "";
                txtregistermail.Text = "";
                lblregister.Text = "SUCCESS";

                
            }
            else
            {
                MessageBox.Show("Please write your all information.");
                return;
            }

        }
    }
}
