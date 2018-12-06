using Newtonsoft.Json;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Botium
{

    public class MoveXY
    {
        public string x { get; set; }
        public string y { get; set; }
    }

    public class LockNPC
    {
        public string alien_id { get; set; }
        public string alien_x { get; set; }
        public string alien_y { get; set; }
        public string user_x { get; set; }
        public string user_y { get; set; }
    }
    //  string lock_script = "document.getElementById('preloader').locktarget(" + alien_id + "," + alien_x + "," + alien_y + "," + user_x + "," + user_y + ")";

    public class Socket_IO
    {
        public delegate void _CMD_COMING(string id, string cmd);
        public event _CMD_COMING __CMD_COMING;

        public delegate void _CONNECTED();
        public event _CONNECTED __CONNECTED;

        public delegate void _DISSCONECTED();
        public event _DISSCONECTED __DISSCONECTED;

        public delegate void _CONNECTED_TO_SERVER();
        public event _CONNECTED_TO_SERVER __CONNECTED_TO_SERVER;

        public delegate void _MOVE_X_Y(string x, string y);
        public event _MOVE_X_Y __MOVE_X_Y;

        public delegate void _PICKBOX(string hash);
        public event _PICKBOX __PICKBOX;

        public delegate void _LOCKNPC(string npc_id, string npc_x, string npc_y, string user_x, string user_y);
        public event _LOCKNPC __LOCKNPC;


        public delegate void _SHOT();
        public event _SHOT __SHOT;

        public delegate void _TARGETNAME(string name);
        public event _TARGETNAME __TARGETNAME;

        public delegate void _TARGETMAXSHIELD(string maxshield);
        public event _TARGETMAXSHIELD __TARGETMAXSHIELD;

        public delegate void _TARGETSHIELD(string shield);
        public event _TARGETSHIELD __TARGETSHIELD;

        public delegate void _TARGETMAXHP(string maxhp);
        public event _TARGETMAXHP __TARGETMAXHP;

        public delegate void _TARGETHP(string hp);
        public event _TARGETHP __TARGETHP;



        public delegate void _PLAYERMAXSHIELD(string maxshield);
        public event _PLAYERMAXSHIELD __PLAYERMAXSHIELD;

        public delegate void _PLAYERSHIELD(string shield);
        public event _PLAYERSHIELD __PLAYERSHIELD;

        public delegate void _PLAYERMAXHP(string maxhp);
        public event _PLAYERMAXHP __PLAYERMAXHP;

        public delegate void _PLAYERHP(string hp);
        public event _PLAYERHP __PLAYERHP;

        public delegate void _REVIVESHIP(string spawn);
        public event _REVIVESHIP __REVIVESHIP;

        public delegate void _JUMP();
        public event _JUMP __JUMP;

        public delegate void _URIDIUM(string uri);
        public event _URIDIUM __URIDIUM;

        public delegate void _MONEY(string uri);
        public event _MONEY __MONEY;


        public delegate void _SETTING_ON();
        public event _SETTING_ON __SETTING_ON;

        public delegate void _SET_KILLNPC(Boolean state);
        public event _SET_KILLNPC __SET_KILLNPC;

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

        public delegate void _SET_COLLECTABLES(string name, Boolean state);
        public event _SET_COLLECTABLES __SET_COLLECTABLES;

        public delegate void _SET_ADD_ALIEN(string name);
        public event _SET_ADD_ALIEN __SET_ADD_ALIEN;

        public delegate void _CREDITS_HOUR(string name);
        public event _CREDITS_HOUR __CREDITS_HOUR;

        public delegate void _URIDIUM_HOUR(string name);
        public event _URIDIUM_HOUR __URIDIUM_HOUR;



        private bool settings_send = false;

        Socket socket;

        public void SendData(string data)
        {
            socket.Emit("command", data);

        }
        public void SendCircle(int data)
        {
            if (settings_send)
            {
                socket.Emit("circledistance", data);
            }
        }
        public void SendPosition(string x, string y)
        {
            socket.Emit("position", "{\"x\" : \"" + x + "\",\"y\" : \"" + y + "\"}");

        }

        public void SendSpawn(int spawn)
        {
            if (settings_send)
            {
                socket.Emit("setspawn", spawn);
            }

        }
        public void MoveDone()
        {
            socket.Emit("movedone", "");
        }
        public void SendStart()
        {
            socket.Emit("start", "");

        }
        public void SendStop()
        {
            socket.Emit("stop", "");
        }
        public void TargetState(string state)
        {
            socket.Emit("targetstate", state);
        }
        public void SendCollect()
        {
            if (settings_send)
            {
                socket.Emit("collect", "");
            }

        }
        public void SendRepairHp(int repair)
        {

            if (settings_send)
            {
                socket.Emit("repairhp", repair);
            }
        }
        public void SendCollectRemove(string name)
        {
            if (settings_send)
            {
                socket.Emit("box_allowed_remove", name);
            }

        }
        public void SendCollectAdd(string name)
        {
            if (settings_send)
            {
                socket.Emit("box_allowed_add", name);
            }

        }

        public void SendAlien()
        {
            if (settings_send)
            {
                socket.Emit("alien_killing", "");
            }

        }
        public void SendAlienAdd(string name)
        {

            if (settings_send)
            {
                socket.Emit("alien_allowed_add", name);
            }
        }

        public void SendAlienRemove(string name)
        {

            if (settings_send)
            {
                socket.Emit("alien_allowed_remove", name);
            }
        }
        public void ResetSettion()
        {
            socket.Emit("reset_session", "");
        }

        public void Dissconect()
        {
            socket.Disconnect();
        }
        public void SendWorkMap(string workmap)
        {

            if (settings_send)
            {
                socket.Emit("workmap", workmap);
            }
        }
        public void RunSocket()
        {
            socket.Emit("cmd", (data) =>
            {
                string s_data = (string)data;
                string[] splited_data = s_data.Split('|');
                __CMD_COMING(splited_data[0], splited_data[1]);
            });
            socket.Emit("user_verify", (data) =>
            {
                __CONNECTED_TO_SERVER();
            });
            socket.Emit("settingsready", () =>
            {
                settings_send = true;
                __SETTING_ON();
            });
            socket.Emit("revive", (data) =>
            {
                string revive = Convert.ToString(data);
                __REVIVESHIP(revive);
            });
            socket.Emit("movetoxy", (data) =>
            {
                MoveXY move = JsonConvert.DeserializeObject<MoveXY>((string)data);
                __MOVE_X_Y(move.x, move.y);
            });
            socket.Emit("pickbox", (data) =>
            {
                string hash = (string)data;
                __PICKBOX(hash);
            });
            socket.Emit("lock_npc", (data) =>
            {
                LockNPC _lock = JsonConvert.DeserializeObject<LockNPC>((string)data);
                __LOCKNPC(_lock.alien_id, _lock.alien_x, _lock.alien_y, _lock.user_x, _lock.user_y);
            });
            socket.Emit("shot", (data) =>
            {
                __SHOT();
            });
            socket.Emit("targetname", (data) =>
            {
                __TARGETNAME((string)data);
            });
            socket.Emit("targetmaxshield", (data) =>
            {
                string max_shield = Convert.ToString(data);
                __TARGETMAXSHIELD(max_shield);
            });

            socket.Emit("targetshield", (data) =>
            {
                string shield = Convert.ToString(data);
                __TARGETSHIELD(shield);
            });
            socket.Emit("targetmaxhp", (data) =>
            {
                string max_hp = Convert.ToString(data);
                __TARGETMAXHP(max_hp);
            });
            socket.Emit("targethealth", (data) =>
            {
                string hp = Convert.ToString(data);
                __TARGETHP(hp);
            });
            socket.Emit("playerhealth", (data) =>
            {
                string health = Convert.ToString(data);
                __PLAYERHP(health);
            });
            socket.Emit("playershieldmax", (data) =>
            {
                string max_shield = Convert.ToString(data);
                __PLAYERMAXSHIELD(max_shield);
            });
            socket.Emit("playerhealthmax", (data) =>
            {
                string max_hp = Convert.ToString(data);
                __PLAYERMAXHP(max_hp);
            });
            socket.Emit("playershield", (data) =>
            {
                string shield = Convert.ToString(data);
                __PLAYERSHIELD(shield);
            });
            socket.Emit("jump", (data) =>
            {
                __JUMP();
            });
            socket.Emit("uridium", (data) =>
            {
                string uri = Convert.ToString(data);
                __URIDIUM(uri);
            });
            socket.Emit("credits", (data) =>
            {
                string money = Convert.ToString(data);
                __MONEY(money);
            });
            socket.Emit("set_killnpc", (data) =>
            {
                Boolean temp = Convert.ToBoolean(data);
                __SET_KILLNPC(temp);
            });
            socket.Emit("set_collect", (data) =>
            {
                Boolean temp = Convert.ToBoolean(data);
                __SET_COLLECT(temp);
            });
            socket.Emit("set_distane_circle", (data) =>
            {
                int temp = Convert.ToInt32(data);
                __SET_DISTANCE_CIRCLE(temp);
            });
            socket.Emit("set_repair_hp", (data) =>
            {
                int temp = Convert.ToInt32(data);
                __SET_REPAIR_HP(temp);
            });
            socket.Emit("set_spawn", (data) =>
            {
                int temp = Convert.ToInt32(data);
                __SET_SPAWN(temp);
            });
            socket.Emit("set_work_map", (data) =>
            {
                string temp = Convert.ToString(data);
                __SET_WORK_MAP(temp);
            });
            socket.Emit("set_collectables", (data) =>
            {
                Collect temp_object = JsonConvert.DeserializeObject<Collect>((string)data);
                __SET_COLLECTABLES(temp_object.name, temp_object.state);
            });
            socket.Emit("set_npc_list", (data) =>
            {
                string temp = Convert.ToString(data);
                __SET_ADD_ALIEN(temp);
            });
            socket.Emit("credits_hour", (data) =>
            {
                string temp = Convert.ToString(data);
                __CREDITS_HOUR(temp);
            });
            socket.Emit("uridium_hour", (data) =>
            {
                string temp = Convert.ToString(data);
                __URIDIUM_HOUR(temp);
            });
        }
        public class Collect
        {
            public Boolean state { get; set; }
            public string name { get; set; }
        }
    }
}
