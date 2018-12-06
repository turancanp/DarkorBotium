using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Botium
{
    public partial class GlobalSettings : UserControl
    {
        public delegate void _SETSPAWN(int spawn);
        public event _SETSPAWN __SETSPAWN;
        public delegate void _KILLNPC(bool killnpc);
        public event _KILLNPC __KILLNPC;
        public delegate void _COLLECT(bool collectbox);
        public event _COLLECT __COLLECT;
        public delegate void _UPDATEHPREPAIR(int distance);
        public event _UPDATEHPREPAIR __UPDATEHPREPAIR;
        public delegate void _UPDATECIRCLERANGE(int repair);
        public event _UPDATECIRCLERANGE __UPDATECIRCLERANGE;
        public delegate void _COLLECTADD(string name);
        public event _COLLECTADD __COLLECTADD;
        public delegate void _COLLECTREMOVE(string name);
        public event _COLLECTREMOVE __COLLECTREMOVE;
        public delegate void _UPDATEREPAIRENEMY(int value);
        public event _UPDATEREPAIRENEMY __UPDATEREPAIRENEMY;
        public delegate void _UPDATEWORKMAP(string value);
        public event _UPDATEWORKMAP __UPDATEWORKMAP;
        public delegate void _UPDATEANGLE(double value);
        public event _UPDATEANGLE __UPDATEANGLE;

        private List<Collectables> Collect_table = new List<Collectables>();

        private Boolean Kill_Npc_state = false;
        private Boolean Collect_state = false;
        private int Repair_state = 30;
        private int Circle_Distance = 400;
        private string workmap = null;
        private int spawn = 1;

        private StartPage form_1;
        public GlobalSettings(StartPage x)
        {
            form_1 = x;
            form_1.__SET_NPC_KILLING += set_npc_killing;
            form_1.__SET_COLLECT += set_collect;
            form_1.__SET_WORK_MAP += set_work_map;
            form_1.__SET_SPAWN += set_spawn;
            form_1.__SET_DISTANCE_CIRCLE += set_distance_circle;
            form_1.__SET_REPAIR_HP += set_repair_hp;
            form_1.__SET_COLLECTEBLES += AddCollectables;
            InitializeComponent();
        }

        private void AddCollectables(string name, Boolean state)
        {
            Collect_table.Add(new Collectables(state, name));
        }
        public class Collectables
        {
            public bool state;
            public string name;

            public Collectables(bool state, string name)
            {
                this.state = state;
                this.name = name;
            }
        }
        private void set_repair_hp(int value)
        {
            Repair_state = value;
        }
        private void set_distance_circle(int value)
        {
            Circle_Distance = value;
        }
        private void set_spawn(int value)
        {
            spawn = value;
        }
        private void set_work_map(string value)
        {
            workmap = value;
        }
        private void set_collect(Boolean value)
        {
            Collect_state = value;
        }
        private void set_npc_killing(Boolean value)
        {
            Kill_Npc_state = value;
        }
        private void CircleDistanceTBar_ValueChanged(object sender, EventArgs e)
        {
            DistanceShowLabel.Text = CircleDistanceTBar.Value.ToString();
            __UPDATECIRCLERANGE(CircleDistanceTBar.Value);
        }
        private void RepairTBar_ValueChanged(object sender, EventArgs e)
        {
            RepairPercentLabel.Text = RepairTBar.Value.ToString() + " %";
            __UPDATEHPREPAIR(RepairTBar.Value);
        }
        private void KillnpcCBox_OnChange(object sender, EventArgs e)
        {
            if (KillnpcCBox.Checked)
            {
                __KILLNPC(true);
            }
            else
            {
                __KILLNPC(false);
            }
        }
        // Updates the textbox text.
        private void CollectCBox_OnChange(object sender, EventArgs e)
        {
            if (CollectCBox.Checked)
            {
                __COLLECT(true);
            }
            else
            {
                __COLLECT(false);
            }
        }
        private void SpawnBaseCBox_OnChange(object sender, EventArgs e)
        {
            if (SpawnBaseCBox.Checked)
            {
                __SETSPAWN(0);
                SpawnPointCBox.Checked = false;
                SpawnPortalCBox.Checked = false;
            }

        }
        private void SpawnPortalCBox_OnChange(object sender, EventArgs e)
        {
            if (SpawnPortalCBox.Checked)
            {
                __SETSPAWN(1);
                SpawnPointCBox.Checked = false;
                SpawnBaseCBox.Checked = false;
            }
        }
        private void SpawnPointCBox_OnChange(object sender, EventArgs e)
        {
            if (SpawnPointCBox.Checked)
            {
                __SETSPAWN(2);
                SpawnPortalCBox.Checked = false;
                SpawnBaseCBox.Checked = false;
            }
        }
        private void MusocumCBox_OnChange(object sender, EventArgs e)
        {
            if (MusocumCBox.Checked)
            {
                __COLLECTADD("MUCOSUM");
            }
            else
            {
                __COLLECTREMOVE("MUCOSUM");
            }
        }
        private void ScarpCBox_OnChange(object sender, EventArgs e)
        {
            if (ScarpCBox.Checked)
            {
                __COLLECTADD("SCRAPIUM");
            }
            else
            {
                __COLLECTREMOVE("SCRAPIUM");
            }
        }
        private void PlazmidCBox_OnChange(object sender, EventArgs e)
        {
            if (PlazmidCBox.Checked)
            {
                __COLLECTADD("BOLTRUM");
            }
            else
            {
                __COLLECTREMOVE("BOLTRUM");
            }
        }
        private void PrismatiumCBox_OnChange(object sender, EventArgs e)
        {
            if (PrismatiumCBox.Checked)
            {
                __COLLECTADD("PRISMATIUM");
            }
            else
            {
                __COLLECTREMOVE("PRISMATIUM");
            }
        }
        private void HybridAlloyCBox_OnChange(object sender, EventArgs e)
        {
            if (HybridAlloyCBox.Checked)
            {
                __COLLECTADD("HYBRID_ALLOYBOX");
            }
            else
            {
                __COLLECTREMOVE("HYBRID_ALLOYBOX");
            }
        }
        private void PirateBoxGreenCBox_OnChange(object sender, EventArgs e)
        {
            if (PirateBoxGreenCBox.Checked)
            {
                __COLLECTADD("PIRATE_BOOTY");
            }
            else
            {
                __COLLECTREMOVE("PIRATE_BOOTY");
            }
        }
        private void PirateBoxRedCBox_OnChange(object sender, EventArgs e)
        {
            if (PirateBoxRedCBox.Checked)
            {
                __COLLECTADD("PIRATE_BOOTY_RED");
            }
            else
            {
                __COLLECTREMOVE("PIRATE_BOOTY_RED");
            }
        }
        private void PirateBoxBlueCBox_OnChange(object sender, EventArgs e)
        {
            if (PirateBoxBlueCBox.Checked)
            {
                __COLLECTADD("PIRATE_BOOTY_BLUE");
            }
            else
            {
                __COLLECTREMOVE("PIRATE_BOOTY_BLUE");
            }
        }
        private void BonusBoxCBox_OnChange(object sender, EventArgs e)
        {
            if (BonusBoxCBox.Checked)
            {
                __COLLECTADD("BONUS_BOX");
            }
            else
            {
                __COLLECTREMOVE("BONUS_BOX");
            }
        }
        private void EnemyAttackTBar_ValueChanged(object sender, EventArgs e)
        {
            enemyatackrepair.Text = EnemyAttackTBar.Value.ToString() + " %";
            __UPDATEREPAIRENEMY(EnemyAttackTBar.Value);
        }
        private void CircleDistanceTBar_Scroll(object sender, EventArgs e)
        {
            DistanceShowLabel.Text = CircleDistanceTBar.Value.ToString();
            __UPDATECIRCLERANGE(CircleDistanceTBar.Value);
        }
        private void WorkMapCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            __UPDATEWORKMAP(WorkMapCBox.SelectedItem.ToString());
        }
        private void Speed_Scroll(object sender, EventArgs e)
        {
            double speed = Speed.Value;
            speed = speed / 10;
            LabelSpeed.Text = Convert.ToString(speed);
            __UPDATEANGLE(speed);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RepairTBar_Scroll(object sender, EventArgs e)
        {

        }
        private void GlobalSettings_Load(object sender, EventArgs e)
        {
            bunifuCheckbox1.Checked = Kill_Npc_state;
            CollectCBox.Checked = Collect_state;
            RepairPercentLabel.Text = Repair_state.ToString() + " %";
            RepairTBar.Value = Repair_state;
            CircleDistanceTBar.Value = Circle_Distance;
            DistanceShowLabel.Text = Circle_Distance.ToString();
            if (spawn == 1)
            {
                SpawnPortalCBox.Checked = true;
                SpawnPointCBox.Checked = false;
                SpawnBaseCBox.Checked = false;
            }
            if (spawn == 2)
            {
                SpawnPortalCBox.Checked = false;
                SpawnPointCBox.Checked = true;
                SpawnBaseCBox.Checked = false;
            }
            if (spawn == 0)
            {
                SpawnPortalCBox.Checked = false;
                SpawnPointCBox.Checked = false;
                SpawnBaseCBox.Checked = true;
            }

            if (workmap != null)
            {
                int index = WorkMapCBox.FindString(workmap);
                if (index > -1)
                {
                    WorkMapCBox.SelectedIndex = index;
                }
            }
            foreach (var x in Collect_table)
            {
                switch (x.name)
                {
                    case "BONUS_BOX":
                        {
                            BonusBoxCBox.Checked = true;
                            break;
                        }
                    case "MUCOSUM":
                        {
                            MusocumCBox.Checked = true;
                            break;
                        }
                    case "SCRAPIUM":
                        {
                            ScarpCBox.Checked = true;
                            break;
                        }
                    case "BOLTRUM":
                        {
                            PlazmidCBox.Checked = true;
                            break;
                        }
                    case "PRISMATIUM":
                        {
                            PrismatiumCBox.Checked = true;
                            break;
                        }
                    case "HYBRID_ALLOYBOX":
                        {
                            HybridAlloyCBox.Checked = true;
                            break;
                        }
                }
            }
            Collect_table.Clear();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
