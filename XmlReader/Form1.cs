using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Diagnostics;
using System.IO;

namespace XmlReader
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Виберіть Xml файл",
                Filter = "Xml files (*.xml)|*.xml",
                Title = "Open xlm file"
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void ReadXmlButton_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\d99p\source\repos\XmlReader\XmlReader\XmlGroups.xml";

            XmlDataSet.ReadXml(filePath);

            dataGridView1.DataSource = XmlDataSet;
            dataGridView1.DataMember = "Document";
        }

        private void ShowSchemaButton_Click(object sender, EventArgs e)
        {
            System.IO.StringWriter swXML = new System.IO.StringWriter();
            XmlDataSet.WriteXmlSchema(swXML);
            textBox1.Text = swXML.ToString();
        }

        private void DownloadXmlButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        
                        XmlDataSet.ReadXml(filePath);

                        dataGridView1.DataSource = XmlDataSet;
                        dataGridView1.DataMember = "Document";
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
