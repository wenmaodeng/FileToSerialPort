using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串口读取文本文件逐行发送数据
{
    public partial class MainForm : Form
    {
        string 串口 = System.Configuration.ConfigurationManager.AppSettings["串口"];
        int 波特率 = int.Parse(System.Configuration.ConfigurationManager.AppSettings["波特率"]);
        int 发送间隔 = int.Parse(System.Configuration.ConfigurationManager.AppSettings["发送间隔"]);
        SerialPort serialPort = null;
        Timer timer = null;
        string[] data = null;
        int sendindex = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            InitSeri();
        }
        void InitSeri()
        {
            try
            {
                if (serialPort != null)
                    return;
                serialPort = new SerialPort(串口, 波特率);
                serialPort.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buttonchoosefile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //打开的文件选择对话框上的标题
            openFileDialog.Title = "请选择文件";
            //设置文件类型
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            //设置默认文件类型显示顺序
            openFileDialog.FilterIndex = 1;
            //保存对话框是否记忆上次打开的目录
            openFileDialog.RestoreDirectory = true;
            //设置是否允许多选
            openFileDialog.Multiselect = false;
            //按下确定选择的按钮
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径
                string localFilePath = openFileDialog.FileName.ToString();
                //读取数据
                var temp=File.ReadAllLines(localFilePath);
                if(temp==null)
                {
                    MessageBox.Show("读取到的数据为空！");
                    return;
                }
                data = temp.ToList().Where(x => !string.IsNullOrEmpty(x)).ToArray();
                sendindex = 0;
                labelsendcount.Text = $"{sendindex}/{data.Length}";
            }
        }

        private void buttonsenddata_Click(object sender, EventArgs e)
        {
            if(timer==null)
            {
                timer = new Timer();
                timer.Interval = 发送间隔;
                timer.Tick += Timer_Tick;
                timer.Start();
                buttonsenddata.Text = "停止发送";
                buttonchoosefile.Enabled = false;
            }
            else
            {
                stopsend();
                reset();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(data==null)
            {
                stopsend();
            }
            else
            {
                if (sendindex < data.Length)
                {
                    serialPort.Write(data[sendindex]);
                    AppendText(data[sendindex]);
                    sendindex++;
                    setsendcount();
                }
                else
                {
                    sendindex = 0;
                    stopsend();
                    reset();
                }
            }
        }
        private void stopsend()
        {
            if (timer != null)
            {
                timer.Tick -= Timer_Tick;
                timer.Stop();
                timer = null;
            }
        }
        private void setsendcount()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    setsendcount();

                }));
            }
            else
            {
                labelsendcount.Text = $"{sendindex}/{data.Length}";
            }
        }
        private void reset()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    reset();

                }));
            }
            else
            {
                buttonsenddata.Text = "发送数据";
                labelsendcount.Text = "/";
                buttonchoosefile.Enabled = true;
            }
            
        }
        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() =>
                {
                    AppendText(text);

                }));
            }
            else
            {
                richTextBoxsenddata.AppendText($"{DateTime.Now.ToString("HH:MM:ss")}：{text}\r\n");
                richTextBoxsenddata.SelectionStart = richTextBoxsenddata.TextLength;
                richTextBoxsenddata.ScrollToCaret();
                if (richTextBoxsenddata.Lines.Count() > 100)
                    richTextBoxsenddata.Clear();
            }
        }
    }
}
