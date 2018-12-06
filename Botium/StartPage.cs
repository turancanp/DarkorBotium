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
using Selenium;

namespace Botium
{
    public partial class StartPage : Form
    {

        public GlobalSettings _globalsetting_control;
        public NpcSetting _npc_setting_control;

        static public ChromiumWebBrowser _chrome_game;
        public ChromiumWebBrowser _chrome_browser;

        public Socket_IO _socket = new Socket_IO();

        public Komendy _CMD = new Komendy();
        public KomendyJS _CMDJS = new KomendyJS();

        public Thread Thread_Packet_Reader;
        public Thread Thread_Control;
        public bool Thread_Control_Work = false;

        public Control _CONTROL = new Control();

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
            _globalsetting_control = new GlobalSettings(this);
            _npc_setting_control = new NpcSetting(this);
            InitializeComponent();
            InitEvents();
            ReadSetting();
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
            _chrome_browser = new ChromiumWebBrowser("https://lp.darkorbit.com/");
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
            IFrame frame;
            frame = _chrome_browser.GetMainFrame();
            if (frame.Url == "https://lp.darkorbit.com/")
            {
                frame.ExecuteJavaScriptAsync("$('input[name=username').val('" + LoginTBox.Text + "');");
                frame.ExecuteJavaScriptAsync("$('input[name=password]').val('" + PasswordTBox.Text + "');");
                frame.ExecuteJavaScriptAsync("$('button[type=submit]').click()");
            }
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            centerPanel.Controls.Clear();
            centerPanel.Controls.Add(_chrome_browser);
            _chrome_browser.Dock = DockStyle.Fill;
            _chrome_browser.Load("https://lp.darkorbit.com/");
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
            _npc_setting_control.Dock = DockStyle.None;
            centerPanel.Controls.Add(_npc_setting_control);
            _npc_setting_control.BringToFront();
        }
        private void GlobalSettingBTN_Click(object sender, EventArgs e)
        {

            _globalsetting_control.Dock = DockStyle.None;
            centerPanel.Controls.Add(_globalsetting_control);
            _globalsetting_control.BringToFront();
        }
        private void StartBTN_Click(object sender, EventArgs e)
        {
            if (Thread_Control_Work == false)
            {
                //_socket.ResetSettion();
                //StartBTN.Image = Properties.Resources.stop;
                StartBTN.Text = "Stop Bot";
                _socket.SendStart();
                Thread_Control_Work = true;                
            }
            else
            {                
                //StartBTN.Image = Properties.Resources.start;
                StartBTN.Text = "Start Bot";
                Thread_Control_Work = false;
                _socket.SendStop();
            }
        }
        public class KomendyJS
        {
            public void Move(string x, string y)
            {
                _chrome_game.ExecuteScriptAsync("document.getElementById('preloader').fly(" + x + "," + y + ");");
            }
            public void JumpGate()
            {
                _chrome_game.ExecuteScriptAsync("document.getElementById('preloader').jump()");
            }
            public void StartAttack()
            {
                _chrome_game.ExecuteScriptAsync("document.getElementById('preloader').shot()");
            }
            public void PickBox(string hash)
            {
                _chrome_game.ExecuteScriptAsync("document.getElementById('preloader').box" + hash + "();");
            }
            public void Lock(string alien_id, string alien_x, string alien_y, string user_x, string user_y)
            {
                string lock_script = "document.getElementById('preloader').locktarget(" + alien_id + "," + alien_x + "," + alien_y + "," + user_x + "," + user_y + ")";
                _chrome_game.ExecuteScriptAsync(lock_script);
            }
            public void Revive(string revive)
            {
                _chrome_game.ExecuteScriptAsync("document.getElementById('preloader').spawn(" + revive + ");");
            }
        }
        private void InitEvents()
        {
            
            _socket.__MOVE_X_Y += _CMDJS.Move;

            _socket.__PICKBOX += _CMDJS.PickBox;

            _socket.__LOCKNPC += _CMDJS.Lock;

            _socket.__SHOT += _CMDJS.StartAttack;

            _socket.__TARGETNAME += ChangeTargetName;

            _socket.__TARGETMAXSHIELD += ChangeTargetMaxShield;
            _socket.__TARGETSHIELD += ChangeTargetShield;

            _socket.__TARGETMAXHP += ChangeTargetMaxHealth;
            _socket.__TARGETHP += ChangeTargetHealth;                        

            _socket.__PLAYERMAXSHIELD += ChangePlayerMaxShield;
            _socket.__PLAYERSHIELD += ChangePlayerShield;

            _socket.__PLAYERMAXHP += ChangePlayerMaxHealth;
            _socket.__PLAYERHP += ChangePlayerHealth;

            _socket.__REVIVESHIP += _CMDJS.Revive;

            _socket.__JUMP += _CMDJS.JumpGate;

            _socket.__URIDIUM += UriUpdate;
            _socket.__MONEY += MoneyUpdate;

            //_socket.__SETTING_ON += TurnOnSettings;

            _socket.__SET_KILLNPC += SetNpcKiling;

            _socket.__SET_COLLECT += SetCollect;

            _socket.__SET_DISTANCE_CIRCLE += SetDistanceCircle;

            _socket.__SET_REPAIR_HP += SetRepairHp;

            _socket.__SET_SPAWN += SetSpawn;

            _socket.__SET_WORK_MAP += SetWorkMap;

            _socket.__SET_COLLECTABLES += SetCollectables;

            _socket.__SET_ADD_ALIEN += AddAlien;

            _socket.__CREDITS_HOUR += CreditsHour;
            _socket.__URIDIUM_HOUR += UridiumHour;

            _CMD.__Connected += GameConnect;
            _CMD.__Disconnected += GameDisconected;

            _CMD.__PackedFromJS += _socket.SendData;
            _CMD.__PlayerPositionUpdate += PlayerPosition;
            _CMD.__PlayerPositionUpdate += _socket.SendPosition;
            _CMD.__PlayerMoveDone += _socket.MoveDone;
            _CMD.__TargetState += _socket.TargetState;
            _CMD.__PackedFromJS += AddLog;


            _globalsetting_control.__SETSPAWN += ChangeSpawn;

            _globalsetting_control.__COLLECT += ChangeCollect;

            _globalsetting_control.__KILLNPC += ChangeKillNpc;

            _globalsetting_control.__UPDATECIRCLERANGE += UpdateCirle;

            _globalsetting_control.__UPDATEHPREPAIR += UpdateHpRepair;

            _globalsetting_control.__COLLECTADD += AddCollect;

            _globalsetting_control.__COLLECTREMOVE += ColectRemove;

            _globalsetting_control.__UPDATEREPAIRENEMY += EnemyRepair;

            _globalsetting_control.__UPDATEWORKMAP += UpdateWorkMap;

            _globalsetting_control.__UPDATEANGLE += ChangeAngle;

            _npc_setting_control.__NPC_ADD += NpcAllowedAdd;

            _npc_setting_control.__NPC_REMOVE += NpcAllowedRemove;

            _npc_setting_control.__AlientPriority += AlienPriority;
        }

        public void UridiumHour(string value)
        {
            if (InvokeRequired)
            {
                UridiumHourLabel.Invoke(new Action(() => UridiumHourLabel.Text = value));
            }
            else
            {
                UridiumHourLabel.Text = value;
            }
        }
        public void CreditsHour(string value)
        {
            if (InvokeRequired)
            {
                CreditsHourLabel.Invoke(new Action(() => CreditsHourLabel.Text = value));
            }
            else
            {
                CreditsHourLabel.Text = value;
            }
        }
        public void AddAlien(string name)
        {
            __SET_ADD_NPC(name);
        }
        public void SetCollectables(string name, Boolean state)
        {
            __SET_COLLECTEBLES(name, state);
        }
        public void SetWorkMap(string value)
        {
            __SET_WORK_MAP(value);
        }
        public void SetSpawn(int value)
        {
            __SET_SPAWN(value);
        }
        public void SetRepairHp(int value)
        {
            __SET_REPAIR_HP(value);
        }
        public void SetNpcKiling(Boolean state)
        {
            __SET_NPC_KILLING(state);
        }
        public void SetCollect(Boolean state)
        {
            __SET_COLLECT(state);
        }
        public void SetDistanceCircle(int value)
        {
            __SET_DISTANCE_CIRCLE(value);
        }
        public void AddLog(string cmd)
        {
            var splited = cmd.Split('|');
            if (InvokeRequired)
            {
                LogBox.Invoke(new Action(() => LogBox.Text += "ID: " + splited[0] + " CMD: " + splited[1] + Environment.NewLine));
            }
            else
            {
                LogBox.Text += "ID: " + splited[0] + " CMD: " + splited[1] + Environment.NewLine;
            }
        }
        public void MoneyUpdate(string money)
        {
            if (InvokeRequired)
            {
                MoneyLabel.Invoke(new Action(() => MoneyLabel.Text = money));
            }
            else
            {
                MoneyLabel.Text = money;
            }
        }
        public void UriUpdate(string uri)
        {
            if (InvokeRequired)
            {
                UriLabel.Invoke(new Action(() => UriLabel.Text = uri));
            }
            else
            {
                UriLabel.Text = uri;
            }
        }
        public void ChangePlayerHealth(string health)
        {
            if (InvokeRequired)
            {
                PlayerHealthBar.Invoke(new Action(() => PlayerHealthBar.Value = Convert.ToInt32(health)));
            }
            else
            {
                PlayerHealthBar.Value = Convert.ToInt32(health);
            }
        }
        public void ChangePlayerShield(string shield)
        {
            if (InvokeRequired)
            {
                PlayerShieldBar.Invoke(new Action(() => PlayerShieldBar.Value = Convert.ToInt32(shield)));
            }
            else
            {
                PlayerShieldBar.Value = Convert.ToInt32(shield);
            }
        }
        public void ChangePlayerMaxShield(string maxshield)
        {
            if (InvokeRequired)
            {
                PlayerShieldBar.Invoke(new Action(() => PlayerShieldBar.Maximum_Value = Convert.ToInt32(maxshield)));
            }
            else
            {
                PlayerShieldBar.Maximum_Value = Convert.ToInt32(maxshield);
            }
        }
        public void ChangePlayerMaxHealth(string maxhp)
        {
            if (InvokeRequired)
            {
                PlayerHealthBar.Invoke(new Action(() => PlayerHealthBar.Maximum_Value = Convert.ToInt32(maxhp)));
            }
            else
            {
                PlayerHealthBar.Maximum_Value = Convert.ToInt32(maxhp);
            }
        }
        public void ChangeTargetHealth(string hp)
        {

            if (InvokeRequired)
            {
                TargetHealthBar.Invoke(new Action(() => TargetHealthBar.Value = Convert.ToInt32(hp)));
            }
            else
            {
                TargetHealthBar.Value = Convert.ToInt32(hp);
            }
        }
        public void ChangeTargetMaxHealth(string maxhp)
        {
            if (InvokeRequired)
            {
                TargetHealthBar.Invoke(new Action(() => TargetHealthBar.Maximum_Value = Convert.ToInt32(maxhp)));
            }
            else
            {
                TargetHealthBar.Maximum_Value = Convert.ToInt32(maxhp);
            }
        }
        public void ChangeTargetMaxShield(string maxshield)
        {

            if (InvokeRequired)
            {
                TargetShieldBar.Invoke(new Action(() => TargetShieldBar.Maximum_Value = Convert.ToInt32(maxshield)));
            }
            else
            {
                TargetShieldBar.Maximum_Value = Convert.ToInt32(maxshield);
            }
        }
        public void ChangeTargetShield(string shield)
        {
            if (InvokeRequired)
            {
                TargetShieldBar.Invoke(new Action(() => TargetShieldBar.Value = Convert.ToInt32(shield)));
            }
            else
            {
                TargetShieldBar.Value = Convert.ToInt32(shield);
            }
        }
        public void ChangeTargetName(string name)
        {
            if (InvokeRequired)
            {
                TargetnameLabel.Invoke(new Action(() => TargetnameLabel.Text = name));
            }
            else
            {
                TargetnameLabel.Text = name;
            }
        }
        public void ChangeAngle(double x)
        {

        }
        public void UpdateWorkMap(string workmap)
        {
            _socket.SendWorkMap(workmap);
        }
        public void PackedTimerReset()
        {

        }
        public void AlienPriority(bool alien_priority)
        {

        }
        public void TakePudeleczko(string x, string y, string hash)//kutu koordinatı
        {
             //BoxPickUp.Start();
            _CMDJS.PickBox(hash);
        }
        public void EnemyRepair(int percent)
        {

        }
        public void ColectRemove(string name)
        {
            _socket.SendCollectRemove(name);
        }
        public void AddCollect(string name)
        {
            _socket.SendCollectAdd(name);
        }
        public void ChangeCollect(bool collect)
        {
            _socket.SendCollect();
        }
        public void ChangeKillNpc(bool kill)
        {
            _socket.SendAlien();
        }
        public void UpdateCirle(int range)
        {
            _socket.SendCircle(range);
        }
        public void UpdateHpRepair(int repair)
        {
            _socket.SendRepairHp(repair);
        }
        public void NpcAllowedAdd(string name)
        {
            _socket.SendAlienAdd(name);
        }
        public void NpcAllowedRemove(string name)
        {
            _socket.SendAlienRemove(name);
        }
        public void ChangeSpawn(int spawn)
        {
            _socket.SendSpawn(spawn);
        }
        private void PlayerPosition(string x, string y)
        {

        }
        public void UpdateMobUI(string max_shield, string shield, string health, string max_health, string name)
        {
            if (InvokeRequired)
            {
                TargetHealthBar.Invoke(new Action(() => TargetHealthBar.MaximumValue = Convert.ToInt32(max_health)));
                TargetHealthBar.Invoke(new Action(() => TargetHealthBar.Value = Convert.ToInt32(health)));
                TargetShieldBar.Invoke(new Action(() => TargetShieldBar.MaximumValue = Convert.ToInt32(max_shield)));
                TargetShieldBar.Invoke(new Action(() => TargetShieldBar.Value = Convert.ToInt32(shield)));
                TargetnameLabel.Invoke(new Action(() => TargetnameLabel.Text = name));
            }
            else
            {
                TargetHealthBar.MaximumValue = Convert.ToInt32(max_health);
                TargetHealthBar.Value = Convert.ToInt32(health);
                TargetShieldBar.MaximumValue = Convert.ToInt32(max_shield);
                TargetShieldBar.Value = Convert.ToInt32(shield);
                TargetnameLabel.Text = name;
            }
        }
        public void UpdateMobUIDead(string shield, string health)
        {
            if (InvokeRequired)
            {
                TargetHealthBar.Invoke(new Action(() => TargetHealthBar.Value = Convert.ToInt32(health)));
                TargetShieldBar.Invoke(new Action(() => TargetShieldBar.Value = Convert.ToInt32(shield)));
            }
            else
            {
                TargetHealthBar.Value = Convert.ToInt32(health);
                TargetShieldBar.Value = Convert.ToInt32(shield);
            }
        }
        private void UpdatePlayerLeftHealthUI(string health)
        {
            if (InvokeRequired)
            {
                PlayerHealthBar.Invoke(new Action(() => PlayerHealthBar.Value = Convert.ToInt32(health)));
            }
            else
            {
                PlayerHealthBar.Value = Convert.ToInt32(health);
            }
        }
        private void UpdatePlayerLeftShieldUI(string shield)
        {
            if (InvokeRequired)
            {
                PlayerShieldBar.Invoke(new Action(() => PlayerShieldBar.Value = Convert.ToInt32(shield)));
            }
            else
            {
                PlayerShieldBar.Value = Convert.ToInt32(shield);
            }
        }
        private void UpdatePlayerHealthUI(string health_max, string health)
        {
            if (InvokeRequired)
            {
                PlayerHealthBar.Invoke(new Action(() => PlayerHealthBar.MaximumValue = Convert.ToInt32(health_max)));
                PlayerHealthBar.Invoke(new Action(() => PlayerHealthBar.Value = Convert.ToInt32(health)));
            }
            else
            {
                PlayerHealthBar.MaximumValue = Convert.ToInt32(health_max);
                PlayerHealthBar.Value = Convert.ToInt32(health);
            }
        }
        private void UpdatePlayerShieldUI(string max_shield, string shield)
        {
            if (max_shield != "0")
                if (InvokeRequired)
                {
                    PlayerShieldBar.Invoke(new Action(() => PlayerShieldBar.MaximumValue = Convert.ToInt32(max_shield)));
                    PlayerShieldBar.Invoke(new Action(() => PlayerShieldBar.Value = Convert.ToInt32(shield)));
                }
                else
                {
                    PlayerShieldBar.MaximumValue = Convert.ToInt32(max_shield);
                    PlayerShieldBar.Value = Convert.ToInt32(shield);
                }
        }
        public void GameDisconected()
        {
            if (InvokeRequired)
            {
                BrowserBTN.Invoke(new Action(() => BrowserBTN.Visible = false));
            }
            else
            {
                BrowserBTN.Visible = false;
            }
        }
        public void GameConnect()
        {
            if (InvokeRequired)
            {
                BrowserBTN.Invoke(new Action(() => BrowserBTN.Visible = true));
            }
            else
            {
                BrowserBTN.Visible = true;
            }
        }
        public void AddLog(string id, string cmd)
        {
            if (InvokeRequired)
            {
                LogBox.Invoke(new Action(() => LogBox.Text += "ID: " + id + " CMD: " + cmd + Environment.NewLine));
            }
            else
            {
                LogBox.Text += "ID: " + id + " CMD: " + cmd + Environment.NewLine;
            }
        }
        private void SaveSetting()
        {
            Properties.Settings.Default.login = LoginTBox.Text;
            Properties.Settings.Default.password = PasswordTBox.Text;
            Properties.Settings.Default.Save();
        }
        private void ReadSetting()
        {
            LoginTBox.Text = Properties.Settings.Default.login;
            PasswordTBox.Text = Properties.Settings.Default.password;
        }

    }
}
