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

namespace RSSFileReading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void lst_headings_SelectedIndexChanged(object sender, EventArgs e)
        {
            News selectedNews = lst_headings.SelectedItem as News;
            wb_showingContent.DocumentText = selectedNews.Description;
        }

        private void btn_getDataInUrl_Click(object sender, EventArgs e)
        {
            List<News> XMLConvert()
            {
                List<News> newsList= new List<News>();
                XDocument ReadXml = XDocument.Load(txt_RSSUrl.Text);
                List<XElement> Rows = ReadXml.Descendants("item").ToList();
                foreach(XElement row in Rows){
                    News temp = new News();
                    temp.Headline = row.Element("title").Value;
                    temp.Link = row.Element("link").Value;
                    temp.Description = row.Element("description").Value;
                    newsList.Add(temp);    
                    }
                return newsList;
            }
            List<News> Records = XMLConvert();
            lst_headings.DataSource = Records;
        }
        
    }
}
