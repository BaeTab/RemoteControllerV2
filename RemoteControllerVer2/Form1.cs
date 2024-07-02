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
            timer1.Start();
        }

        private void startMonitorLocation()
        {
            this.StartPosition = FormStartPosition.Manual;
            Screen[] screens = Screen.AllScreens;

            // 세 번째 모니터가 존재하는지 확인
            // 개인에 맞게 튜닝해주세요
            if (screens.Length >= 3)
            {
                // 세 번째 모니터의 작업 영역 위치를 가져옴
                // 테스트 해보고 개인에 맞네 screens[] 안의 숫자 변경
                Rectangle monitorBounds = screens[1].WorkingArea;

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
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender ,EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy년 MM월dd일 HH:mm:ss");
        }

        private void Button1_Click(object sender , EventArgs e)
        {
            string[] startUrls = { "https://10.1.1.1", "https://192.168.1.120:8443/mc2/faces/adminlogin.xhtml", "https://192.168.1.141:8443/go/login", "https://us02.protect.eset.com/era/webconsole/", "https://gw.sevenstarcasino.co.kr" };
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
            Process.Start("notepads.exe");
        }

        private void Button9_Click(object sender , EventArgs e)
        {
            Process.Start(@"D:\BHW_Info\원격 접속");
        }
    }
}
