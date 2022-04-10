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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnetner_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"Password.xml");
            XElement rootElement = xDoc.Root;

            if (txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                Form4 f4 = new Form4();
                f4.Show();
                return;
                
            }

            foreach (XElement User in rootElement.Elements())
            {
                if (txtusername.Text == User.Attribute("Username").Value)
                {
                    if(txtpassword.Text==User.Element("Password").Value)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();

                        XDocument xDocpass = XDocument.Load("Lastlogin.xml");
                        XElement rootelement = xDocpass.Root;
                        XElement newelement = new XElement("User");
                        XAttribute usernameattribute = new XAttribute("Username", txtusername.Text);
                        XElement passwordelement = new XElement("Password", txtpassword.Text);
                        newelement.Add(usernameattribute, passwordelement);
                        rootelement.Add(newelement);
                        xDocpass.Save("Lastlogin.xml");
                        return;
                    }
                    else
                    {
                        lblerror.Text = "Your username or password is correct";

                    }
                }
                
            }

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument xDocument = XDocument.Load("Lastlogin.xml");
            XElement rootelement = xDocument.Root;

            foreach (XElement User in rootelement.Elements())
            {
                txtusername.Text = User.Attribute("Username").Value;
                //txtpassword.Text = User.Element("Password").Value;

            }
        }
    }


    
}
