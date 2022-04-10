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

namespace OopLabProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"XMLFile1.xml");
            for(int i=0; i <= checkedListBoxDifficulty.Items.Count; i++)
            {
                checkedListBoxDifficulty.GetItemChecked(i);
                int ind=checkedListBoxDifficulty.Items.IndexOf(i);
                XElement element = new XElement(ind.ToString());
            }
            xDoc.Save(@"XMLFile1.xml");
        }

        private void btnmanageinfo_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
