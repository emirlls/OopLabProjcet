using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;

namespace OopLabProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnaddnewuser_Click(object sender, EventArgs e)
        {
            XDocument xDocpass = XDocument.Load("Password.xml");
            XElement rootelement = xDocpass.Root;
            XElement newelement = new XElement("User");
            XAttribute usernameattribute = new XAttribute("Username", txtnewusername.Text);
            XElement nameelement = new XElement("NameSurname", txtnamesurname.Text);
            XElement passwordelement = new XElement("Password", txtpassword.Text);
            XElement phoneelement = new XElement("Phone", txtphone.Text);
            XElement addresselement = new XElement("Address", txtaddress.Text);
            XElement cityelement = new XElement("City", txtcity.Text);
            XElement countryelement = new XElement("Country", txtcountry.Text);
            XElement mailelement = new XElement("Mail", txtmail.Text);

            newelement.Add(usernameattribute, nameelement, passwordelement, phoneelement, addresselement, cityelement, countryelement, mailelement);
            rootelement.Add(newelement);
            xDocpass.Save("Password.xml");

            XDocument xDoc = XDocument.Load("User.xml");
            XElement rootElement = xDoc.Root;
            
            XElement newElement = new XElement("User");
            XAttribute usernameAttribute = new XAttribute("Username", txtnewusername.Text);
            XElement nameElement = new XElement("NameSurname", txtnamesurname.Text);
            XElement passwordElement = new XElement("Password", txtpassword.Text);
            XElement phoneElement = new XElement("Phone", txtphone.Text);
            XElement addressElement = new XElement("Address", txtaddress.Text);
            XElement cityElement = new XElement("City", txtcity.Text);
            XElement countryElement = new XElement("Country", txtcountry.Text);
            XElement mailElement = new XElement("Mail", txtmail.Text);


            SHA256Managed sha256 = new SHA256Managed();
            byte[] bytearray = System.Text.Encoding.UTF8.GetBytes(txtpassword.Text);

            string cyrptopassword = Convert.ToBase64String(sha256.ComputeHash(bytearray));

            newElement.Add(usernameAttribute, nameElement, cyrptopassword, phoneElement, addressElement, cityElement, countryElement, mailElement);

            rootElement.Add(newElement);

            txtnewusername.Text = "";
            txtnamesurname.Text = "";
            txtpassword.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
            txtcity.Text = "";
            txtcountry.Text = "";
            txtmail.Text = "";

            xDoc.Save(@"User.xml");


        }
        private void btnlistallusers_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            XmlReader xmlFile;

            xmlFile = XmlReader.Create(@"User.xml", new XmlReaderSettings());
            dataset.ReadXml(xmlFile);

            dgusers.DataSource = dataset.Tables[0];

            xmlFile.Close();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"User.xml");

            XElement rootElement = xDoc.Root;
            XmlDocument xmlDocument = new XmlDocument();

            XDocument xDocpass = XDocument.Load("Password.xml");
            XElement rootelement = xDocpass.Root;


            foreach (XElement User in rootElement.Elements())
            {
                if (User.Attribute("Username").Value == txtnewusername.Text)
                {
                    User.Remove();
                    User.RemoveAttributes();
                }
            }
            xDoc.Save(@"User.xml");

            foreach (XElement User in rootelement.Elements())
            {
                if (User.Attribute("Username").Value == txtnewusername.Text)
                {
                    User.Remove();
                }
            }
            xDoc.Save(@"Password.xml");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            XDocument xDoc = new XDocument();
            xDoc = XDocument.Load(@"User.xml");

            XElement rootElement = xDoc.Root;

            foreach (XElement User in rootElement.Elements())
            {
                if (txtnewusername.Text==User.Attribute("Username").Value)
                {
                    User.Element("NameSurname").Value = txtnamesurname.Text;
                    //User.Element("Password").Value = txtpassword.Text;
                    User.Element("Phone").Value = txtphone.Text;
                    User.Element("Address").Value = txtaddress.Text;
                    User.Element("City").Value = txtcity.Text;
                    User.Element("Country").Value = txtcountry.Text;
                    User.Element("Mail").Value = txtmail.Text;                  

                }

            }
            txtnewusername.Text = "";
            txtnamesurname.Text = "";
            txtpassword.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
            txtcity.Text = "";
            txtcountry.Text = "";
            txtmail.Text = "";
            xDoc.Save(@"User.xml");
            MessageBox.Show("SUCCESS");

        }
    
    }

}


