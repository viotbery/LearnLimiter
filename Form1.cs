using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace 自律v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            const int GWL_STYLE = -16;
            const int WS_SYSMENU = 0x00080000;
            [DllImport("user32.dll")]
            static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32.dll")]
            static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
            IntPtr handle = this.Handle;
            int style = GetWindowLong(handle, GWL_STYLE);
            style &= ~WS_SYSMENU;
            SetWindowLong(handle, GWL_STYLE, style);
        }
        bool flag = true;
        public struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]


        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        static UInt32 SW_SHOWMINIMIZED = 2;
        static bool _IsExit = false;
        const int SW_MAXIMIZE = 3;
        public const int WM_SYSCOMMAND = 0x112;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public string appPath = "";
        public static bool GetMinimized(IntPtr handle)
        {
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            placement.length = Marshal.SizeOf(placement);
            GetWindowPlacement(handle, ref placement);
            return placement.showCmd == SW_SHOWMINIMIZED;
            //1 = normal
            //2 = minimized
            //3 = maximized
        }
        public void RunMonitor(object obj)
        {
            string targetProcessName = obj as string; // 替换为你的目标应用程序的进程名称
            while (!_IsExit)
            {
                Thread.Sleep(2000);
                Process[] processes = Process.GetProcessesByName(targetProcessName);
                // 获取本软件的Process
                Process[] thisProcesses = Process.GetProcessesByName("LearnLimiter");
                if (processes.Length == 0)
                {
                    this.Invoke(new Action(() => { addLog("Target process not found. Waiting..."); }));
                    // 运行appPath中的应用程序
                    Process p = new Process();
                    p.StartInfo.FileName = appPath;
                    p.Start();
                    continue;
                }
                else
                {
                    this.Invoke(new Action(() => { addLog("founded program !"); }));
                }
                Process targetProcess = processes[0];
                Process thisProcess = thisProcesses[0];
                // 判断应用是否最小化

                if (GetMinimized(targetProcess.MainWindowHandle))
                {
                    // 打印信息到textBox1控件
                    this.Invoke(new Action(() => { addLog("Target process is minimized. Waiting..."); }));
                    // 最大化该进程
                    ShowWindow(targetProcess.MainWindowHandle, SW_MAXIMIZE);
                    SetForegroundWindow(targetProcess.MainWindowHandle.ToInt32());
                    continue;
                }
                else
                {
                    // 打印信息到textBox1控件
                    this.Invoke(new Action(() => { addLog("Target process is NOT minimized. Waiting.."); }));
                    if (targetProcess.MainWindowHandle != IntPtr.Zero
                        && targetProcess.MainWindowHandle == GetForegroundWindow()
                    )
                    {
                        // 打印信息到textBox1控件
                        this.Invoke(new Action(() => { addLog("Target process is in foreground. Waiting..."); }));
                    }
                    else if (thisProcess.MainWindowHandle != GetForegroundWindow())
                    {
                        // 打印信息到textBox1控件
                        this.Invoke(new Action(() => { addLog("Target process is NOT in foreground. Maximizing..."); }));

                        // 最大化该进程
                        ShowWindow(targetProcess.MainWindowHandle, SW_MAXIMIZE);
                        SetForegroundWindow(targetProcess.MainWindowHandle.ToInt32());
                    }
                }

            }
        }
        public void addLog(string message)
        {   // 追加信息
            textBox1.AppendText(Environment.NewLine + message);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            _IsExit = false;
            // 从comboBox1获取选中的字符串
            string selectedString = "";
            if (comboBox1.SelectedItem != null)
            {
                selectedString = comboBox1.SelectedItem.ToString();
                Thread checkMiniMinimizedThread = new Thread(new ParameterizedThreadStart(RunMonitor));
                checkMiniMinimizedThread.Start(selectedString);
                pwText.Text = generatePassword(26);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = answerText.Text.ToString();
            if (input == pwText.Text.ToString())
            {
                _IsExit = true;
                addLog("Stop program !");
            }
            else
            {
                MessageBox.Show("回答错误！");
            }
        }
        public string generatePassword(int digits)
        {
            // 返回一个随机字符串
            return string.Concat(Enumerable.Range(0, digits).Select(_ => new Random().Next(16).ToString("X")));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 创建打开文件对话框
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // 设置对话框的属性
            openFileDialog1.InitialDirectory = "C:\\";  // 设置默认文件夹
            openFileDialog1.Filter = "可执行程序|*.exe";  // 设置文件类型过滤器

            // 显示打开文件对话框
            DialogResult result = openFileDialog1.ShowDialog();

            // 处理用户的文件选择
            if (result == DialogResult.OK)
            {
                // 获取用户所选文件的路径
                string selectedFilePath = openFileDialog1.FileName;
                appPath = selectedFilePath;
                // 在 label1 中显示所选文件的路径
                addLog(selectedFilePath);
            }
        }
    }
}