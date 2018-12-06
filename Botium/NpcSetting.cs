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
    public partial class NpcSetting : UserControl
    {
        public delegate void _NPC_ADD(string name);
        public event _NPC_ADD __NPC_ADD;
        public delegate void _NPC_REMOVE(string name);
        public event _NPC_REMOVE __NPC_REMOVE;
        public delegate void _AlientPriority(bool priority);
        public event _AlientPriority __AlientPriority;
        
        private List<string> NPC_ALLOWED = new List<string>();

        private StartPage form_1;
        public NpcSetting(StartPage x)
        {
            form_1 = x;
            InitializeComponent();
            form_1.__SET_ADD_NPC += AddNpc;
        }

        private void AddNpc(string name)
        {
            NPC_ALLOWED.Add(name);
        }
        private void StreunerCBox_OnChange(object sender, EventArgs e)
        {
            if (StreunerCBox.Checked)
            {
                __NPC_ADD(StreunerLabel.Text);
            }
            else
            {
                __NPC_REMOVE(StreunerLabel.Text);
            }
        }
        private void RecruitStreunerCBox_OnChange(object sender, EventArgs e)
        {
            if (RecruitStreunerCBox.Checked)
            {
                __NPC_ADD(RecruitStreunerLabel.Text);
            }
            else
            {
                __NPC_REMOVE(RecruitStreunerLabel.Text);
            }
        }
        private void AiderStreunerCBox_OnChange(object sender, EventArgs e)
        {
            if (AiderStreunerCBox.Checked)
            {
                __NPC_ADD(AiderStreunerLabel.Text);
            }
            else
            {
                __NPC_REMOVE(AiderStreunerLabel.Text);
            }
        }
        private void LordakiaCBox_OnChange(object sender, EventArgs e)
        {
            if (LordakiaCBox.Checked)
            {
                __NPC_ADD(LordakiaLabel.Text);
            }
            else
            {
                __NPC_REMOVE(LordakiaLabel.Text);
            }
        }
        private void SaimonCBox_OnChange(object sender, EventArgs e)
        {
            if (SaimonCBox.Checked)
            {
                __NPC_ADD(SaimonLabel.Text);
            }
            else
            {
                __NPC_REMOVE(SaimonLabel.Text);
            }
        }
        private void MordonCBox_OnChange(object sender, EventArgs e)
        {
            if (MordonCBox.Checked)
            {
                __NPC_ADD(MordonLabel.Text);
            }
            else
            {
                __NPC_REMOVE(MordonLabel.Text);
            }
        }
        private void DevolariumCBox_OnChange(object sender, EventArgs e)
        {
            if (DevolariumCBox.Checked)
            {
                __NPC_ADD(DevolariumLabel.Text);
            }
            else
            {
                __NPC_REMOVE(DevolariumLabel.Text);
            }
        }
        private void SibelonCBox_OnChange(object sender, EventArgs e)
        {
            if (SibelonCBox.Checked)
            {
                __NPC_ADD(SibelonLabel.Text);
            }
            else
            {
                __NPC_REMOVE(SibelonLabel.Text);
            }
        }
        private void SibelonitCBox_OnChange(object sender, EventArgs e)
        {
            if (SibelonitCBox.Checked)
            {
                __NPC_ADD(SibelonitLabel.Text);
            }
            else
            {
                __NPC_REMOVE(SibelonitLabel.Text);
            }
        }
        private void LordakiumCBox_OnChange(object sender, EventArgs e)
        {
            if (LordakiumCBox.Checked)
            {
                __NPC_ADD(LordakiumLabel.Text);
            }
            else
            {
                __NPC_REMOVE(LordakiumLabel.Text);
            }
        }
        private void KristallinCBox_OnChange(object sender, EventArgs e)
        {
            if (KristallinCBox.Checked)
            {
                __NPC_ADD(KristallinLabel.Text);
            }
            else
            {
                __NPC_REMOVE(KristallinLabel.Text);
            }
        }
        private void KristallonCBox_OnChange(object sender, EventArgs e)
        {
            if (KristallonCBox.Checked)
            {
                __NPC_ADD(KristallonLabel.Text);
            }
            else
            {
                __NPC_REMOVE(KristallonLabel.Text);
            }
        }
        private void StreuneRRCBox_OnChange(object sender, EventArgs e)
        {
            if (StreuneRRCBox.Checked)
            {
                __NPC_ADD(StreuneRRLabel.Text);
            }
            else
            {
                __NPC_REMOVE(StreuneRRLabel.Text);
            }
        }
        private void BlightedGygerthrallCBox_OnChange(object sender, EventArgs e)
        {
            if (BlightedGygerthrallCBox.Checked)
            {
                __NPC_ADD(BlightedGygerthrallLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BlightedGygerthrallLabel.Text);
            }
        }
        private void BlightedKristallonCBox_OnChange(object sender, EventArgs e)
        {
            if (BlightedKristallonCBox.Checked)
            {
                __NPC_ADD(BlightedKristallonLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BlightedKristallonLabel.Text);
            }
        }
        private void BossStreunerCBox_OnChange(object sender, EventArgs e)
        {
            if (BossStreunerCBox.Checked)
            {
                __NPC_ADD(BossStreunerLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossStreunerLabel.Text);
            }
        }
        private void BossLordakiaCBox_OnChange(object sender, EventArgs e)
        {
            if (BossLordakiaCBox.Checked)
            {
                __NPC_ADD(BossLordakiaLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossLordakiaLabel.Text);
            }
        }
        private void BossSaimonCBox_OnChange(object sender, EventArgs e)
        {
            if (BossSaimonCBox.Checked)
            {
                __NPC_ADD(BossSaimonLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossSaimonLabel.Text);
            }
        }
        private void BossMordonCBox_OnChange(object sender, EventArgs e)
        {
            if (BossMordonCBox.Checked)
            {
                __NPC_ADD(BossMordonLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossMordonLabel.Text);
            }
        }
        private void BossDevolariumCBox_OnChange(object sender, EventArgs e)
        {
            if (BossDevolariumCBox.Checked)
            {
                __NPC_ADD(BossDevolariumLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossDevolariumLabel.Text);
            }
        }
        private void BossSibelonCBox_OnChange(object sender, EventArgs e)
        {
            if (BossSibelonCBox.Checked)
            {
                __NPC_ADD(BossSibelonLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossSibelonLabel.Text);
            }
        }
        private void BossSibelonitCBox_OnChange(object sender, EventArgs e)
        {
            if (BossSibelonitCBox.Checked)
            {
                __NPC_ADD(BossSibelonitLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossSibelonitLabel.Text);
            }
        }
        private void BossLordakiumCBox_OnChange(object sender, EventArgs e)
        {
            if (BossLordakiumCBox.Checked)
            {
                __NPC_ADD(BossLordakiumLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossLordakiumLabel.Text);
            }
        }
        private void BossKristallinCBox_OnChange(object sender, EventArgs e)
        {
            if (BossKristallinCBox.Checked)
            {
                __NPC_ADD(BossKristallinLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossKristallinLabel.Text);
            }
        }
        private void BossKristallonLabel_OnChange(object sender, EventArgs e)
        {
            if (BossKristallonCBox.Checked)
            {
                __NPC_ADD(BossKristallonCBox.Text);
            }
            else
            {
                __NPC_REMOVE(BossKristallonCBox.Text);
            }

        }
        private void BossStreuneRRCBox_OnChange(object sender, EventArgs e)
        {
            if (BossStreuneRRCBox.Checked)
            {
                __NPC_ADD(BossStreuneRRLabel.Text);
            }
            else
            {
                __NPC_REMOVE(BossStreuneRRLabel.Text);
            }
        }
        private void AlienPriorityCBox_OnChange(object sender, EventArgs e)
        {
            __AlientPriority(AlienPriorityCBox.Checked);
        }
        private void NpcSetting_Load(object sender, EventArgs e)
        {
            foreach (var x in NPC_ALLOWED)
            {
                switch (x)
                {
                    case "-=[ Streuner ]=-":
                        {
                            StreunerCBox.Checked = true;
                            break;
                        }
                    case "-=[ Recruit Streuner ]=-":
                        {
                            RecruitStreunerCBox.Checked = true;
                            break;
                        }
                    case "-=[ Aider Streuner ]=-":
                        {
                            AiderStreunerCBox.Checked = true;
                            break;
                        }
                    case "-=[ Lordakia ]=-":
                        {
                            LordakiaCBox.Checked = true;
                            break;
                        }
                    case "-=[ Saimon ]=-":
                        {
                            SaimonCBox.Checked = true;
                            break;
                        }
                    case "-=[ Mordon ]=-":
                        {
                            MordonCBox.Checked = true;
                            break;
                        }
                    case "-=[ Devolarium ]=-":
                        {
                            DevolariumCBox.Checked = true;
                            break;
                        }
                    case "-=[ Sibelon ]=-":
                        {
                            SibelonCBox.Checked = true;
                            break;
                        }
                    case "-=[ Sibelonit ]=-":
                        {
                            SibelonitCBox.Checked = true;
                            break;
                        }
                    case "-=[ Lordakium ]=-":
                        {
                            LordakiumCBox.Checked = true;
                            break;
                        }
                    case "-=[ Kristallin ]=-":
                        {
                            KristallinCBox.Checked = true;
                            break;
                        }
                    case "-=[ Kristallon ]=-":
                        {
                            KristallonCBox.Checked = true;
                            break;
                        }
                    case "-=[ StreuneR ]=-":
                        {
                            StreuneRRCBox.Checked = true;
                            break;
                        }
                    case "<=< Blighted Gygerthrall >=>":
                        {
                            BlightedGygerthrallCBox.Checked = true;
                            break;
                        }
                    case "-=[ Blighted Kristallon ]=-":
                        {
                            BlightedKristallonCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Streuner }::..":
                        {
                            BossStreunerCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Lordakia }::..":
                        {
                            BossLordakiaCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Saimon }::..":
                        {
                            BossSaimonCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Mordon }::..":
                        {
                            BossMordonCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Devolarium }::..":
                        {
                            BossDevolariumCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Sibelon }::..":
                        {
                            BossSibelonCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Sibelonit }::..":
                        {
                            BossSibelonitCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Lordakium }::..":
                        {
                            BossLordakiumCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss Kristallin }::..":
                        {
                            BossKristallinCBox.Checked = true;
                            break;
                        }
                    case "-..::{ Boss Kristallon }::..":
                        {
                            BossKristallonCBox.Checked = true;
                            break;
                        }
                    case "..::{ Boss StreuneR }::..":
                        {
                            BossStreuneRRCBox.Checked = true;
                            break;
                        }
                }
            }
            NPC_ALLOWED.Clear();
        }
    }
}
