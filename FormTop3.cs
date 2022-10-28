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

namespace MemoryMatchingGame
{
    public partial class FormTop3 : Form
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = @"FileTop3.xml";

        public FormTop3()
        {
            InitializeComponent();

            find3();
        }

        public FormTop3(infoObject obj)
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
            XmlNode top = doc.CreateElement("Top");

            XmlElement Username = doc.CreateElement("Username");
            Username.InnerText = obj.UserName;
            top.AppendChild(Username);

            XmlElement Rank = doc.CreateElement("Rank");
            Rank.InnerText = obj.Rank;
            top.AppendChild(Rank);

            XmlElement TimePlay = doc.CreateElement("TimePlay");
            TimePlay.InnerText = obj.Time.ToString();
            top.AppendChild(TimePlay);

            XmlElement Miss = doc.CreateElement("Miss");
            Miss.InnerText = obj.Miss.ToString();
            top.AppendChild(Miss);

            root.AppendChild(top);
            doc.Save(fileName);
        }

        public void find3()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
            var listTop3 = new List<infoObject>();
            int index = 0;
            XmlNodeList list = root.SelectNodes("Top");

            foreach (XmlNode item in list)
            {
                listTop3.Add(new infoObject(item.SelectSingleNode("Username").InnerText, item.SelectSingleNode("Rank").InnerText, Int32.Parse(item.SelectSingleNode("Miss").InnerText), Int32.Parse(item.SelectSingleNode("TimePlay").InnerText)));
            }
            
            for (int i = 0; i < listTop3.Count - 1; i++)
            {
                for (int j = i + 1; j < listTop3.Count; j++)
                {
                    infoObject tmp = new infoObject();
                    if (listTop3[j].Time < listTop3[i].Time)
                    {
                        tmp = listTop3[j];
                        listTop3[j] = listTop3[i];
                        listTop3[i] = tmp;
                    }
                }
            }

            foreach (var info in listTop3)
            {
                index++;
                infoObject temp = (infoObject)info;
                if (index <= 3)
                {
                    string username = temp.UserName;
                    string rank = temp.Rank;
                    int miss = temp.Miss;
                    int time = temp.Time;
                    txtTop3.Text += "Top " + index + ": " + username 
                        + "\r\n\t - rank: " + rank 
                        + "\r\n\t - miss: " + miss 
                        + "\r\n\t - time: " + time 
                        + "\n----------------------------------------------\r\n";
                }
            }
        }
    }
}
