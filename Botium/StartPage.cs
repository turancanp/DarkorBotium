using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.IO;
using System.Threading;
using System.Timers;

namespace Botium
{
    public partial class StartPage : Form
    {
        public GlobalSettings _globalsetting_control;
        public NpcSetting _npc_setting_control;
        static public ChromiumWebBrowser _chrome_game;
        public ChromiumWebBrowser _chrome_browser;

        private Point lastLocation;



        public Thread Thread_Packet_Reader;

        public Thread Thread_Control;
        public bool Thread_Control_Work = false;

        public Control _CONTROL = new Control();

        public Komendy _CMD = new Komendy();
        public KomendyJS _CMDJS = new KomendyJS();

        public string SERVER_GAME_LINK = "";
        

        public delegate void _SET_NPC_KILLING(Boolean state);
        public event _SET_NPC_KILLING __SET_NPC_KILLING;

        public delegate void _SET_COLLECT(Boolean state);
        public event _SET_COLLECT __SET_COLLECT;

        public delegate void _SET_DISTANCE_CIRCLE(int value);
        public event _SET_DISTANCE_CIRCLE __SET_DISTANCE_CIRCLE;

        public delegate void _SET_REPAIR_HP(int value);
        public event _SET_REPAIR_HP __SET_REPAIR_HP;

        public delegate void _SET_SPAWN(int value);
        public event _SET_SPAWN __SET_SPAWN;


        public delegate void _SET_WORK_MAP(string value);
        public event _SET_WORK_MAP __SET_WORK_MAP;

        public delegate void _SET_COLLECTEBLES(string name, Boolean state);
        public event _SET_COLLECTEBLES __SET_COLLECTEBLES;

        public delegate void _SET_ADD_NPC(string name);
        public event _SET_ADD_NPC __SET_ADD_NPC;

        public StartPage()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSharpSettings.LegacyJavascriptBindingEnabled = true;
            CefSettings settings = new CefSettings();
            settings.CachePath = "cache";
            CefSharpSettings.WcfEnabled = true;
            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "https",
                SchemeHandlerFactory = new CefSharpSchemeHandlerFactory()
            });
            var architecture = Environment.Is64BitProcess ? "x64" : "x86";
            settings.BrowserSubprocessPath = architecture + @"\CefSharp.BrowserSubprocess.exe";
            //    settings.CefCommandLineArgs.Add("enable-system-flash", "1");

            Cef.Initialize(settings);
            _chrome_game = new ChromiumWebBrowser();
            _chrome_browser = new ChromiumWebBrowser("https://www.darkorbit.com");
            _chrome_browser.FrameLoadEnd += LoginAccount;
            _chrome_browser.FrameLoadEnd += StartMap;
            _chrome_game.FrameLoadEnd += LoadScriptConnector;
            //     _chrome_game.RegisterJsObject("cmdjs", _CMD);
        }
        private void LoadScriptConnector(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Frame.IsMain)
            {

                _chrome_game.ExecuteScriptAsync(Properties.Resources.skrypt);
                try
                {
                    _chrome_game.JavascriptObjectRepository.Register("cmdjs", _CMD, true);
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.ToString());
                }
            }
        }
        private void StartMap(object sender, FrameLoadEndEventArgs e)
        {
            IFrame frame;
            frame = _chrome_browser.GetMainFrame();
            string uri = frame.Url;
            if (uri.Contains("indexInternal.es?action=internalStart"))
            {
                string[] splited = uri.Split('/');
                if (InvokeRequired)
                {
                    centerPanel.Invoke(new Action(() => centerPanel.Controls.Clear()));
                    centerPanel.Invoke(new Action(() => centerPanel.Controls.Add(_chrome_game)));
                    _chrome_game.Invoke(new Action(() => _chrome_game.Dock = DockStyle.Fill));
                }
                else
                {
                    centerPanel.Controls.Clear();
                    centerPanel.Controls.Add(_chrome_game);
                    _chrome_game.Dock = DockStyle.Fill;
                }

                SERVER_GAME_LINK = "https://" + splited[2] + "/indexInternal.es?action=internalMapRevolution";
                _chrome_game.Load("https://" + splited[2] + "/indexInternal.es?action=internalMapRevolution");


            }
        }
        private void LoginAccount(object sender, FrameLoadEndEventArgs e)
        {

            if (e.Frame.IsMain && e.Url == "https://www.darkorbit.com/login")
            {
                IFrame frame;
                frame = _chrome_browser.GetMainFrame();
                if (frame.Url == "https://www.darkorbit.com/login")
                {
                    frame.ExecuteJavaScriptAsync("$('input[id=bgcdw_login_form_username').val('" + LoginTBox.Text + "');");
                    frame.ExecuteJavaScriptAsync("$('input[id=bgcdw_login_form_password]').val('" + PasswordTBox.Text + "');");
                    frame.ExecuteJavaScriptAsync("$('input[type=submit]').click()");
                }
            }
        }
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(_chrome_browser);
            _chrome_browser.Dock = DockStyle.Fill;
            _chrome_browser.Load("https://www.darkorbit.com/login");
        }

        private void BrowserBTN_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(_chrome_browser);
            _chrome_browser.Dock = DockStyle.Fill;
        }

        private void GameBTN_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(_chrome_game);
            _chrome_game.Dock = DockStyle.Fill;
        }

        private void NpcSettingBTN_Click(object sender, EventArgs e)
        {

        }

        public class KomendyJS
        {
            public void Move(string x, string y)
            {
                _chrome_game.ExecuteScriptAsync("document.getElementById('preloader').fly(" + x + "," + y + ");");
            }
            public void PickBox(string hash)
            {
                _chrome_game.ExecuteScriptAsync("document.getElementById('preloader').box" + hash + "();");
            }

        }
        private void InitEvents()
        {
            //_socket.__MOVE_X_Y += _CMDJS.Move;
            //_socket.__PICKBOX += _CMDJS.PickBox;
           
            //_CMD.__PlayerPositionUpdate += PlayerPosition;
            //_CMD.__PlayerPositionUpdate += _socket.SendPosition;
            //_CMD.__PlayerMoveDone += _socket.MoveDone;

            //_globalsetting_control.__COLLECT += ChangeCollect;

            //_globalsetting_control.__COLLECTADD += AddCollect;
            //_globalsetting_control.__COLLECTREMOVE += ColectRemove;
        }

        private void CollectCBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
