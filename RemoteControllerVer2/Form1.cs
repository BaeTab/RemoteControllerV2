using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RemoteControllerVer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initEventHandler();
            startMonitorLocation();
        }

        private void startMonitorLocation()
        {
            this.StartPosition = FormStartPosition.Manual;
            Screen[] screens = Screen.AllScreens;

            // 세 번째 모니터가 존재하는지 확인
            if (screens.Length >= 3)
            {
                // 세 번째 모니터의 작업 영역 위치를 가져옴
                Rectangle monitorBounds = screens[2].WorkingArea;

                // 폼의 위치를 세 번째 모니터의 시작 위치로 설정
                this.Location = new Point(monitorBounds.Left, monitorBounds.Top);
            }
        }
       
        private void initEventHandler()
        {
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            button8.Click += Button8_Click;
            button9.Click += Button9_Click;
        }

        private void Button1_Click(object sender , EventArgs e)
        {
            string[] startUrls = { "https://10.1.1.1", "https://192.168.1.120:8443/mc2/faces/adminlogin.xhtml", "https://192.168.1.141:8443/go/login", "https://192.168.10.20/era/webconsole/", "https://gw.majestar.asia/app/home" };
            foreach (string url in startUrls)
            {
                Process.Start(url);
            }
        }

        private void Button2_Click(object sender , EventArgs e)
        {
            Process.Start(@"D:\source");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\mySource");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\IT_Document");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\IT_Document\관리 문서\계정 및 비밀번호");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\IT_Document\관리 문서\프로그램별 권한 등록조서");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Microsoft Office\Office12\excel.exe");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files\WindowsApps\19282JackieLiu.Notepads-Beta_1.5.4.0_x64__echhpq9pdbte8\notepads.exe");
        }

        private void Button9_Click(object sender , EventArgs e)
        {
            Process.Start(@"D:\BHW_Info\원격 접속");
        }
    }
}
