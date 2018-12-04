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

        
        
    }

        class Socket
    {

    }
}
