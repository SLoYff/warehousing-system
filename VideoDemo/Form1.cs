using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Reflection;
using System.IO;
using CamDLLHelper;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Net.Http;





namespace VideoDemo
{
    public partial class Form1 : Form
    {
        int m_fileNameIndex = 0; //保存文件名的后缀

        int m_cameraIndex = 0; //打开的摄像头标识

        int m_cameraFormat = 0; //视频格式

        int m_currentWidth = 0;//当前分辨率
        int m_currentHeight = 0;

        bool m_FirstLoadUI = true;// 第一次

        public Form1()
        {
            InitializeComponent();

            this.Load += delegate
            {
                m_FirstLoadUI = false;
                InitData();
            };

        }

        //初始化UI界面中的数据
        private void InitUIData()
        {
            string folder = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
           //saveFolderText.Text = folder;

           //UpdataFileName();
        }

        //开始视频显示
        private bool StartVideo()
        {
            CamDLL.CloseCamera(m_cameraIndex);
            CamDLL.DisposeCamera();
            int re = CamDLL.InitializeCamera();
            if (re != 0)
            {
                ShowError("Init", re);
                return false;
            }
            
            re = CamDLL.OpenCamera(m_cameraIndex, m_cameraFormat, m_currentWidth, m_currentHeight);
            if (re != 0)
            {
                ShowError("OpenCamera", re);
                return false;
            }

            re = CamDLL.SetPreviewWindow(m_cameraIndex, pictureBox1.Handle);
            if (re != 0)
            {
                ShowError("SetPreviewWindow", re);
                return false;
            }

            return true;
        }

        //配置设备名UI
        private void configureDeviceNameUI()
        {
            int deviceCount = 0;
            CamDLL.GetDeviceCount(ref deviceCount);
            deviceComboBox.Items.Clear();
            for (int i = 0; i < deviceCount; i++)
            {
                IntPtr nameInt = CamDLL.GetDeviceName(i);
                string name = Marshal.PtrToStringAnsi(nameInt);
                deviceComboBox.Items.Add(name);
            }
            deviceComboBox.SelectedIndex = 0;
        }

        //配置视频格式UI
        private void configureVideoFormatUI()
        {
            int formatCount = 0;
            CamDLL.GetDeviceVideoFormatCount(m_cameraIndex, ref formatCount);
            videoFormatComboBox.Items.Clear();
            for (int i = 0; i < formatCount; i++)
            {
                string name = CamDLL.GetDeviceVideoFormatName(m_cameraIndex, i);
                videoFormatComboBox.Items.Add(name);
            }
            videoFormatComboBox.SelectedIndex = 0;
        }

        //配置分辨率UI
        private void configureResolutionUI()
        {
            int count = 0;
            CamDLL.GetDeviceResolutionCount(m_cameraIndex, m_cameraFormat, ref count);
            resoultionComboBox.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                int h = 0,w = 0;
                CamDLL.GetDeviceResolution(m_cameraIndex,m_cameraFormat,i,ref w,ref h);
                string name = string.Format("{0}*{1}", w, h);
                resoultionComboBox.Items.Add(name);
                if (i == 0)
                {
                    m_currentWidth = w;
                    m_currentHeight = h;
                }
            }
            resoultionComboBox.SelectedIndex = 0;
        }

        //配置设备信息UI
        private void InitDeviceUIInfo()
        {
            configureDeviceNameUI();
            configureVideoFormatUI();
            configureResolutionUI();
            
        } 

        //初始化数据
        private void InitData()
        {
            //初始化UI数据
            InitUIData();
            //开始视频
            bool re = StartVideo();
            if (!re)
            {
                return;
            }
            //初始化UI中的设备信息
            InitDeviceUIInfo();
        }


        //样品照片拍照
        private void captureBtn_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "" || textBox2.Text == " ")
            {
                MessageBox.Show("ID值不能为空");
                return;
            }

            string fileName = saveFolderText.Text + "\\" + textBox2.Text + "_sample" + ".jpg";
            int re = CamDLL.SnapshotCapture(m_cameraIndex, new StringBuilder(fileName, 150));
            textBox11.Text = textBox2.Text + "_sample";
            if (re != 0)
            {
                ShowError("Capture",re);
                return;
            }           
        }

        //承诺书照片拍照
        private void caputureBtn1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == " ")
            {
                MessageBox.Show("ID值不能为空");
                return;
            }

            string fileName = saveFolderText.Text + "\\" + textBox2.Text + "_letter" + ".jpg";
            int re = CamDLL.SnapshotCapture(m_cameraIndex, new StringBuilder(fileName, 150));
            textBox12.Text = textBox2.Text + "_letter";
            if (re != 0)
            {
                ShowError("Capture", re);
                return;
            }
        }



        //错误
        private void ShowError(string errorMsg, int errorCode)
        {

            string msg = string.Format("{0} Fail:error Code = {1}", errorMsg, errorCode);
            MessageBox.Show(msg);
        }

        //裁切
        private void cropCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox b = sender as CheckBox;
            CamDLL.AutoCropArea(m_cameraIndex, b.Checked ? 1:0);
          
        }
        
        //选择文件夹
        private void viewFolderBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
          
                this.saveFolderText.Text = folder.SelectedPath;

            }
        }

        //打开文件夹
        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(saveFolderText.Text);
        }

        //关闭消息
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                //需要反初始化
                CamDLL.CloseCamera(m_cameraIndex);
                CamDLL.DisposeCamera();

            }

            base.WndProc(ref m);
        }

        //切换设备
        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_FirstLoadUI)
            {
                return;
            }
            ComboBox m = sender as ComboBox;

            if (m.SelectedIndex == m_cameraIndex)
            {
                return;
            }

            CamDLL.CloseCamera(m_cameraIndex);
            m_cameraIndex = m.SelectedIndex;
            CamDLL.OpenCamera(m_cameraIndex, m_cameraFormat, 0, 0);
            CamDLL.SetPreviewWindow(m_cameraIndex, pictureBox1.Handle);
           
            configureVideoFormatUI();
            configureResolutionUI();
        }

        //切换分辨率
        private void resoultionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_FirstLoadUI)
            {
                return;
            }
            ComboBox m = sender as ComboBox;
            int w = 0, h = 0;
            CamDLL.GetDeviceResolution(m_cameraIndex, m_cameraFormat, m.SelectedIndex, ref w, ref h);
            if (w == m_currentWidth && h == m_currentHeight)
            {
                return;
            }
            m_currentWidth = w;
            m_currentHeight = h;
            CamDLL.CloseCamera(m_cameraIndex);
            int re = CamDLL.OpenCamera(m_cameraIndex, m_cameraFormat, m_currentWidth, m_currentHeight);
            if (re != 0)
            {
                ShowError("OpenCamera", re);
            }
            re = CamDLL.SetPreviewWindow(m_cameraIndex, pictureBox1.Handle);
            if (re != 0)
            {
                ShowError("SetPreviewWindow", re);
                return;
            }
        }

        //切换视频格式
        private void videoFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_FirstLoadUI)
            {
                
                return;
            }
            ComboBox m = sender as ComboBox;
            if (m_cameraFormat == m.SelectedIndex)
            {
                return;
            }
            m_cameraFormat = m.SelectedIndex;
            CamDLL.CloseCamera(m_cameraIndex);
            int re = CamDLL.OpenCamera(m_cameraIndex, m_cameraFormat, m_currentWidth, m_currentHeight);
            if (re != 0)
            {
                ShowError("OpenCamera", re);
            }
            re = CamDLL.SetPreviewWindow(m_cameraIndex, pictureBox1.Handle);
            if (re != 0)
            {
                ShowError("SetPreviewWindow", re);
                return;
            }
        }

        //打码入库
        private void button2_Click(object sender, EventArgs e)
        {
            //打码
            objectID iD = new objectID();
            iD.ObjectId = textBox2.Text.ToString();
            if (iD.ObjectId == "")
            {
                MessageBox.Show("输入为空");
                return;
            }
            else
            {
                var json = "{ \"objectID\":\"" + iD.ObjectId + "\"}";

                HttpClient httpClient = new HttpClient();
                StringContent postContent = new StringContent(json, Encoding.UTF8, "application/json");
                httpClient.PostAsync("http://localhost:12736/api/PrintQR", postContent);
            }
            //入库
            if (textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && textBox5.Text != null && textBox6.Text != null && textBox7.Text != null && textBox8.Text != null && textBox9.Text != null && textBox10.Text != null && textBox13.Text != null)
            {                
                string strDSN = "SERVER=; DATABASE=;UID=;PWD=;CharSet=utf8";
                string sqlstr = null;
                MySqlConnection myConn = new MySqlConnection(strDSN);
                MySqlCommand myCmd = new MySqlCommand("", myConn);
                StringBuilder strbuilder = new StringBuilder();


                Genestoragein content = new Genestoragein();
                content.objectID = textBox2.Text.ToString();
                content.name = textBox3.Text.ToString();
                content.coding = textBox4.Text.ToString();
                content.sendCompany = textBox5.Text.ToString();
                content.sendPeople = textBox6.Text.ToString();
                content.sendTime = textBox7.Text.ToString();
                content.quantity = textBox8.Text.ToString();
                content.location = textBox9.Text.ToString();
                content.state = textBox10.Text.ToString();
                content.sampleSrc = textBox11.Text.ToString();
                content.letterSrc = textBox12.Text.ToString();
                content.operator_name = textBox13.Text.ToString();

                sqlstr = "INSERT INTO genestoragein VALUES (null,'" + content.objectID + "','" + content.name + "','" + content.coding + "','" + content.sendCompany + "','" + content.sendPeople + "','" + content.sendTime + "','" + content.quantity + "','" + content.location + "','" + content.state + "','" + content.sampleSrc + "','" + content.letterSrc + "','" + content.operator_name + "')";
                myConn.Open();
                myCmd.CommandText = sqlstr;
                myCmd.ExecuteNonQuery();

                myConn.Close();

                MessageBox.Show("数据库导入成功");
            }
            else
            {
                MessageBox.Show("数据输入不完整");
            }

        }

        public class Genestoragein
        {
            public string objectID { get; set; }
            public string name { get; set; }
            public string coding { get; set; }
            public string sendCompany { get; set; }
            public string sendPeople { get; set; }
            public string sendTime { get; set; }
            public string quantity { get; set; }
            public string location { get; set; }
            public string state { get; set; }
            public string sampleSrc { get; set; }
            public string letterSrc { get; set; }
            public string operator_name { get; set; }
        }

        public class objectID
        {
            public string ObjectId { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox7.Text = DateTime.Now.ToShortDateString();
            saveFolderText.Text = "D:\\publish\\wwwroot";
        }
    }
}
