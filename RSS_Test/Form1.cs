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

namespace RSS_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string rssHurriyet = "http://mix.chimpfeedr.com/07479-Hurriyet-Gazetesi";
        string rssMilliyet = "https://www.milliyet.com.tr/rss/rssnew/gundemrss.xml";
        string rssFotomac = "https://www.fotomac.com.tr/rss/anasayfa.xml";

        void HaberleriGetir(string rssLink)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlReader = new XmlTextReader(rssLink);
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "title")
                {
                    listBox1.Items.Add(xmlReader.ReadString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HaberleriGetir(rssHurriyet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HaberleriGetir(rssMilliyet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HaberleriGetir(rssFotomac);
        }
    }
}
