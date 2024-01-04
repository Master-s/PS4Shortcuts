using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS4Shortcuts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text == "Folder" | string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Enter a folder name");
                }
                else
                {
                    string foldername = label1.Text + "\\" + textBox1.Text;
                    Directory.CreateDirectory(foldername);
                   StreamWriter sw = new StreamWriter(Application.StartupPath +"\\" + label1.Text + "\\" + textBox1.Text + "\\tbl_appinfo.csv");
                    sw.WriteLine(label2.Text+","+ label3.Text+","+ label4.Text);
                    sw.WriteLine(textBox2.Text + "," + label5.Text + "," + textBox3.Text);
                    sw.WriteLine(textBox2.Text + "," + label6.Text + "," + textBox4.Text);
                    sw.WriteLine(textBox2.Text + "," + label7.Text + "," + textBox5.Text);
                    sw.WriteLine(textBox2.Text + "," + label8.Text + "," + textBox6.Text);
                    sw.WriteLine(textBox2.Text + "," + label9.Text + "," + textBox7.Text);
                    sw.WriteLine(textBox2.Text + "," + label10.Text + "," + textBox8.Text);
                    sw.WriteLine(textBox2.Text + "," + label11.Text + "," + textBox9.Text);
                    sw.WriteLine(textBox2.Text + "," + label12.Text + "," + textBox10.Text);
                    sw.WriteLine(textBox2.Text + "," + label13.Text + "," + textBox11.Text);
                    sw.WriteLine(textBox2.Text + "," + label14.Text + "," + textBox12.Text);
                    sw.WriteLine(textBox2.Text + "," + label15.Text + "," + textBox13.Text);
                    sw.WriteLine(textBox2.Text + "," + label16.Text + "," + textBox14.Text);
                    sw.WriteLine(textBox2.Text + "," + label17.Text + "," + textBox15.Text);
                    sw.WriteLine(textBox2.Text + "," + label18.Text + "," + textBox16.Text);
                    sw.WriteLine(textBox2.Text + "," + label19.Text + "," + textBox17.Text);
                    sw.WriteLine(textBox2.Text + "," + label20.Text + "," + textBox18.Text);
                    sw.WriteLine(textBox2.Text + "," + label21.Text + "," + textBox19.Text);
                    sw.WriteLine(textBox2.Text + "," + label22.Text + "," + textBox20.Text);
                    sw.WriteLine(textBox2.Text + "," + label23.Text + "," + textBox21.Text);
                    sw.WriteLine(textBox2.Text + "," + label24.Text + "," + textBox22.Text);
                    sw.WriteLine(textBox2.Text + "," + label25.Text + "," + textBox23.Text);
                    sw.WriteLine(textBox2.Text + "," + label26.Text + "," + textBox24.Text);
                    sw.WriteLine(textBox2.Text + "," + label27.Text + "," + textBox25.Text);
                    sw.WriteLine(textBox2.Text + "," + label28.Text + "," + textBox26.Text);
                    sw.WriteLine(textBox2.Text + "," + label29.Text + "," + "/user/appmeta/" +textBox27.Text);
                    sw.WriteLine(textBox2.Text + "," + label30.Text + "," + "/user/app/" + textBox28.Text);
                    sw.WriteLine(textBox2.Text + "," + label31.Text + "," + textBox29.Text);
                    sw.WriteLine(textBox2.Text + "," + label32.Text + "," + textBox30.Text);
                    sw.WriteLine(textBox2.Text + "," + label33.Text + "," + textBox31.Text);
                    sw.WriteLine(textBox2.Text + "," + label34.Text + "," + textBox32.Text);
                    sw.WriteLine(textBox2.Text + "," + label35.Text + "," + textBox33.Text);
                    sw.WriteLine(textBox2.Text + "," + label36.Text + "," + textBox34.Text);
                    sw.Close();
                  MessageBox.Show("Done");
                    textBox41.Enabled = true;
                    textBox35.Enabled = true;
                    textBox36.Enabled = true;
                    textBox37.Enabled = true;
                    textBox38.Enabled = true;
                    textBox39.Enabled = true;
                    textBox40.Enabled = true;
                    button2app.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Enter a folder name");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2app_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBox41.Text == "app.db" | string.IsNullOrEmpty(textBox41.Text))
                {
                    MessageBox.Show("Enter the file number tbl_appbrowse_(0000000000) app.db");
                }
                else
                {
                    StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + label1.Text + "\\" + textBox1.Text + "\\tbl_appbrowse_"+ textBox41.Text+ ".csv");
                    sw.WriteLine(label37.Text + "," + label40.Text + "," + label41.Text+","+ label42.Text+ ",lastAccessTime,contentStatus,onDisc,parentalLevel,visible,sortPriority,pathInfo,lastAccessIndex,dispLocation,canRemove,category,contentType,pathInfo2,presentBoxStatus,entitlement,"+
                    label43.Text+ ",lastUpdateTime,playableDate,contentSize,installDate,platform,uiCategory,skuId,disableLiveDetail,linkType,"+ label44.Text+"" +
                    ",serviceIdAddCont1,serviceIdAddCont2,serviceIdAddCont3,serviceIdAddCont4,serviceIdAddCont5,serviceIdAddCont6,serviceIdAddCont7,folderType,folderInfo,parentFolderId,positionInFolder,activeDate,entitlementTitleName,hddLocation,externalHddAppStatus,entitlementIdKamaji,mTime,");
                    sw.WriteLine(textBox35.Text + "," + textBox36.Text + "," + textBox37.Text+","+textBox38.Text+ ",2024-01-02 00:00:23.011,0,2,0,1,13,0,1800,5,0,gdi,0,0,0,1,"
                        + textBox39.Text+",2021-02-13 18:19:29.747,,538996736,2023-12-31 00:04:03.514,0,app,,0,5,"+ textBox40.Text+ ",,,,,,,,0,,000000002,2,,,0,0,,2023-12-31 00:03:57.871,0,0,0,0,0,");
                    sw.Close();
                    MessageBox.Show("Done");

                }
            }
            catch
            {
                MessageBox.Show("Enter a folder name");
            }
        }
    }
}
