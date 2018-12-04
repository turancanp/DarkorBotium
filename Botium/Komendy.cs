using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Botium
{
    public class Packet
    {
        public string id { get; set; }
        public string cmd { get; set; }


        public Packet(string id, string cmd)
        {
            this.id = id;
            this.cmd = cmd;
        }
    }


    public class Komendy
    {

        public delegate void _PackedFromJS(string cmd);
        public event _PackedFromJS __PackedFromJS;

        public delegate void _Connected();
        public event _Connected __Connected;

        public delegate void _Disconnected();
        public event _Disconnected __Disconnected;

        public delegate void _PlayerPositionUpdate(string x, string y);
        public event _PlayerPositionUpdate __PlayerPositionUpdate;

        public delegate void _PlayerMoveDone();
        public event _PlayerMoveDone __PlayerMoveDone;

        public delegate void _TargetState(string state);
        public event _TargetState __TargetState;



        public void packedfromjs(string cmd)
        {
            // var comand = cmd;
            //  var splited = comand.Split('|');

            __PackedFromJS(cmd);
        }

        public void player(string x, string y, string cofing)
        {
            __PlayerPositionUpdate(x, y);
        }

        public void movecomplete()
        {
            __PlayerMoveDone();
        }
        public void connected()
        {
            __Connected();
        }
        public void disconnect()
        {
            __Disconnected();
        }
        public void targetstate(string state)
        {
            __TargetState(state);
        }
    }
}



