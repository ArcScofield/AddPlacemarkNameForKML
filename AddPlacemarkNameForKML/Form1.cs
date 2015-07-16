using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AddPlacemarkNameForKML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择KML文件";
            openFileDialog.Filter = "KML文件(*.kml)|*.kml|所有文件 (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtBoxFileKML.Text = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnAddNamesToKML_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBoxFileKML.Text))
            {
                MessageBox.Show("请先选择KML文件");
                return;
            }


            XDocument document = XDocument.Load(txtBoxFileKML.Text);

            String nameValue = null;
            foreach (var item in document.Element(AddXmlns("kml")).
                                                            Element(AddXmlns("Document")).
                                                            Element(AddXmlns("Folder")).
                                                            Elements(AddXmlns("Placemark")))
            {
                nameValue = ((XElement)item).
                                      Element(AddXmlns("ExtendedData")).
                                      Element(AddXmlns("SchemaData")).
                                      Elements(AddXmlns("SimpleData")).
                                      First(c => c.Attribute("name").Value == "村（镇）名").Value;
                item.AddFirst(new XElement("name", nameValue));
            }

            document.Save(txtBoxFileKML.Text);

            MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Creating an XName in a Namespace
        /// </summary>
        private String AddXmlns(String name)
        {
            String strXmlnsWrapper = @"{http://www.opengis.net/kml/2.2}";
            return strXmlnsWrapper + name.Trim();
        }
    }
}
