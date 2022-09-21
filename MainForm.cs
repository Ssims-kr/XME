using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using XOPS;

namespace XME
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        #region 멤버 변수
        private XOperations m_XOPS;
        private bool m_IsReadProcess;
        private int m_ProcessId;
        private bool m_LoadSuccess;
        private int m_Cnt;
        #endregion

        #region 생성자
        public MainForm()
        {
            InitializeComponent();

            m_XOPS = null;
            m_IsReadProcess = false;
            m_ProcessId = -1;
            m_LoadSuccess = false;
            m_Cnt = 0;

            // Style Manager
            this.StyleManager = metroStyleManager;

            // 초기화
            cBox_AutoDepthStencilFormat.DataSource = Enum.GetValues(typeof(XOperations.D3DFORMAT));
            cBox_WeaponArms.DataSource = Enum.GetValues(typeof(Weapon.ArmsType));
            cBox_WeaponFireMode.DataSource = Enum.GetValues(typeof(Weapon.FireMode));
            cBox_WeaponScopeMode.DataSource = Enum.GetValues(typeof(Weapon.ScopeMode));
            cBox_WeaponTexture.DataSource = Enum.GetValues(typeof(XOperations.TextureID));
            cBox_WeaponModel.DataSource = Enum.GetValues(typeof(XOperations.ModelID));
            cBox_WeaponSoundID.DataSource = Enum.GetValues(typeof(Weapon.SoundID));
            cBox_CharacterTexture.DataSource = Enum.GetValues(typeof(Character.TextureID));
            cBox_CharacterModel.DataSource = Enum.GetValues(typeof(Character.ModelID));
            cBox_CharacterAILevel.DataSource = Enum.GetValues(typeof(Character.AILevel));
            cBox_CharacterPrimaryWeapon.DataSource = Enum.GetValues(typeof(Weapon.WeaponID));
            cBox_CharacterSecondaryWeapon.DataSource = Enum.GetValues(typeof(Weapon.WeaponID));
            cBox_CharacterType.DataSource = Enum.GetValues(typeof(Character.Type));
            cBox_SmallObjectModel.DataSource = Enum.GetValues(typeof(XOperations.ModelID));
            cBox_SmallObjectTexture.DataSource = Enum.GetValues(typeof(XOperations.TextureID));
            cBox_SmallObjectSound.DataSource = Enum.GetValues(typeof(SmallObject.SoundID));

            lBox_WeaponList.DataSource = Enum.GetValues(typeof(Weapon.WeaponID));
            lBox_CharacterList.DataSource = Enum.GetValues(typeof(Character.CharacterID));
            lbox_SmallObjectList.DataSource = Enum.GetValues(typeof(SmallObject.SmallObjectID));


            lBox_WeaponList.SelectedIndex = 0;
            lBox_CharacterList.SelectedIndex = 0;
            lbox_SmallObjectList.SelectedIndex = 0;
        }
        #endregion

        #region 메서드
        private void OpenFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tBox_EXEPath.Text = openFileDialog.FileName;
                m_XOPS = new XOperations(tBox_EXEPath.Text);
                m_IsReadProcess = false;
                SetControlValue();
                SetWeaponControlValue();
                SetCharacterControlValue();
                SetSmallObjectControlValue();
                m_LoadSuccess = true;
            }
        }

        private void SaveFile()
        {
            if (m_XOPS == null) { MessageBox.Show("."); return; }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (m_XOPS.SaveGameParameter(saveFileDialog.FileName, this) == false) { MessageBox.Show("!"); }
                if (m_XOPS.Weapon.SaveData(saveFileDialog.FileName) == false) { MessageBox.Show("!!"); }
                if (m_XOPS.Character.SaveData(saveFileDialog.FileName) == false) { MessageBox.Show("!!!"); }
                if (m_XOPS.SmallObject.SaveData(saveFileDialog.FileName) == false) { MessageBox.Show("!!!!"); }
            }
        }

        private void SetControlValue()
        {
            // 게임 파라미터
            tBox_GameName.Text = m_XOPS.GameParam.GameName;                         // 게임 이름
            if (m_Cnt == 0) { tBox_GameName.MaxLength = tBox_GameName.Text.Length; }
            tBox_GameVersion.Text = m_XOPS.GameParam.GameVersion;                   // 게임 버전
            if (m_Cnt == 0) { tBox_GameVersion.MaxLength = tBox_GameVersion.Text.Length; }
            cBox_AutoDepthStencilFormat.SelectedItem = ((int)m_XOPS.GameParam.AutoDepthStencilFormat == -1) ? (XOperations.D3DFORMAT.UNKNOWN) : m_XOPS.GameParam.AutoDepthStencilFormat;
            tBox_ClippingPlaneNear.Text = m_XOPS.GameParam.ClippingPlaneNear.ToString("F3");
            tBox_ClippingPlaneFar.Text = m_XOPS.GameParam.ClippingPlaneFar.ToString("F3");
            tBox_FOVNormal.Text = m_XOPS.GameParam.FOVNormal.ToString("F3");
            tBox_FOVAUG.Text = m_XOPS.GameParam.FOVAUG.ToString("F3");
            tBox_FOVPSG1.Text = m_XOPS.GameParam.FOVPSG1.ToString("F3");

            m_Cnt += 1;
        }

        private void SetCharacterControlValue()
        {
            int idx = lBox_CharacterList.SelectedIndex;

            {
                string name = Enum.GetName(typeof(Character.TextureID), m_XOPS.Character[idx].TextureID);
                if (string.IsNullOrEmpty(name)) { cBox_CharacterTexture.SelectedItem = Character.TextureID.UNKNOWN; }
                else { cBox_CharacterTexture.SelectedItem = Enum.Parse(typeof(Character.TextureID), name); }
            }
            {
                string name = Enum.GetName(typeof(Character.ModelID), m_XOPS.Character[idx].ModelID);
                if (string.IsNullOrEmpty(name)) { cBox_CharacterModel.SelectedItem = Character.ModelID.UNKNOWN; }
                else { cBox_CharacterModel.SelectedItem = Enum.Parse(typeof(Character.ModelID), name); }
            }
            {
                string name = Enum.GetName(typeof(Character.AILevel), m_XOPS.Character[idx].AILevel);
                if (string.IsNullOrEmpty(name)) { cBox_CharacterAILevel.SelectedItem = Character.AILevel.UNKNOWN; }
                else { cBox_CharacterAILevel.SelectedItem = Enum.Parse(typeof(Character.AILevel), name); }
            }
            {
                string name = Enum.GetName(typeof(Weapon.WeaponID), m_XOPS.Character[idx].PrimaryWeapon);
                if (string.IsNullOrEmpty(name)) { cBox_CharacterPrimaryWeapon.SelectedItem = Weapon.WeaponID.UNKNOWN; }
                else { cBox_CharacterPrimaryWeapon.SelectedItem = Enum.Parse(typeof(Weapon.WeaponID), name); }
            }
            {
                string name = Enum.GetName(typeof(Weapon.WeaponID), m_XOPS.Character[idx].SecondaryWeapon);
                if (string.IsNullOrEmpty(name)) { cBox_CharacterSecondaryWeapon.SelectedItem = Weapon.WeaponID.UNKNOWN; }
                else { cBox_CharacterSecondaryWeapon.SelectedItem = Enum.Parse(typeof(Weapon.WeaponID), name); }
            }
            tBox_CharacterHP.Text = m_XOPS.Character[idx].HP.ToString();
            {
                string name = Enum.GetName(typeof(Character.Type), m_XOPS.Character[idx].Type);
                if (string.IsNullOrEmpty(name)) { cBox_CharacterType.SelectedItem = Character.Type.UNKNOWN; }
                else { cBox_CharacterType.SelectedItem = Enum.Parse(typeof(Character.Type), name); }
            }

            string Path1 = string.Empty;
            if (m_IsReadProcess)
            {
                string offsetPath = XOPSOffsetManager.GetCharacterTexturePath(m_ProcessId, m_XOPS.Ver, (Character.TextureID)Enum.Parse(typeof(Character.TextureID), cBox_CharacterTexture.SelectedItem.ToString()));
                if (string.IsNullOrEmpty(offsetPath) == false) { offsetPath.Substring(1, offsetPath.Length - 1); }

                string temp = Path.GetDirectoryName(Process.GetProcessById(m_ProcessId).MainModule.FileName) + offsetPath;
                Path1 = temp;
            }
            else
            {
                string tempPath = XOPSOffsetManager.GetCharacterTexturePath(tBox_EXEPath.Text, m_XOPS.Ver, (Character.TextureID)Enum.Parse(typeof(Character.TextureID), cBox_CharacterTexture.SelectedItem.ToString()));
                if (string.IsNullOrEmpty(tempPath) == false) { tempPath.Substring(1, tempPath.Length - 1); }

                Path1 = Path.GetDirectoryName(tBox_EXEPath.Text) + tempPath;
            }
            pBox_CharacterTexture.ImageLocation = Path1;
        }

        private void SetSmallObjectControlValue()
        {
            int idx = lbox_SmallObjectList.SelectedIndex;

            tBox_SmallObjectJump.Text = m_XOPS.SmallObject[idx].Jump.ToString();
            {
                string name = Enum.GetName(typeof(XOperations.ModelID), m_XOPS.SmallObject[idx].ModelID);
                if (string.IsNullOrEmpty(name)) { cBox_SmallObjectModel.SelectedItem = XOperations.ModelID.UNKNOWN; }
                else { cBox_SmallObjectModel.SelectedItem = Enum.Parse(typeof(XOperations.ModelID), name); }
            }
            {
                string name = Enum.GetName(typeof(XOperations.TextureID), m_XOPS.SmallObject[idx].TextureID);
                if (string.IsNullOrEmpty(name)) { cBox_SmallObjectTexture.SelectedItem = XOperations.TextureID.UNKNOWN; }
                else { cBox_SmallObjectTexture.SelectedItem = Enum.Parse(typeof(XOperations.TextureID), name); }
            }
            tBox_SmallObjectCollisionRange.Text = m_XOPS.SmallObject[idx].CollisionRange.ToString();
            tBox_SmallObjectHP.Text = m_XOPS.SmallObject[idx].HP.ToString();
            {
                string name = Enum.GetName(typeof(SmallObject.SoundID), m_XOPS.SmallObject[idx].SoundID);
                if (string.IsNullOrEmpty(name)) { cBox_SmallObjectSound.SelectedItem = SmallObject.SoundID.UNKNOWN; }
                else { cBox_SmallObjectSound.SelectedItem = Enum.Parse(typeof(SmallObject.SoundID), name); }
            }

            string Path1 = string.Empty;
            if (m_IsReadProcess)
            {
                string offsetPath = XOPSOffsetManager.GetTexturePath(m_ProcessId, m_XOPS.Ver, (XOperations.TextureID)Enum.Parse(typeof(XOperations.TextureID), cBox_SmallObjectTexture.SelectedItem.ToString()));
                if (string.IsNullOrEmpty(offsetPath) == false) { offsetPath.Substring(1, offsetPath.Length - 1); }

                string temp = Path.GetDirectoryName(Process.GetProcessById(m_ProcessId).MainModule.FileName) + offsetPath;
                Path1 = temp;
            }
            else
            {
                string tempPath = XOPSOffsetManager.GetTexturePath(tBox_EXEPath.Text, m_XOPS.Ver, (XOperations.TextureID)Enum.Parse(typeof(XOperations.TextureID), cBox_SmallObjectTexture.SelectedItem.ToString()));
                if (string.IsNullOrEmpty(tempPath) == false) { tempPath.Substring(1, tempPath.Length - 1); }

                Path1 = Path.GetDirectoryName(tBox_EXEPath.Text) + tempPath;
            }
            pBox_SmallObjectTexture.ImageLocation = Path1;
        }

        private void SetWeaponControlValue()
        {
            int idx = lBox_WeaponList.SelectedIndex;

            // 무기
            tBox_WeaponName.Text = m_XOPS.Weapon[idx].Name;
            tBox_WeaponNameLength.Text = string.Format("{0}/{1}", tBox_WeaponName.Text.Length, tBox_WeaponName.MaxLength);
            tBox_WeaponDamage.Text = m_XOPS.Weapon[idx].Damage.ToString();
            tBox_WeaponPenetration.Text = m_XOPS.Weapon[idx].Penetration.ToString();
            tBox_WeaponSpeed.Text = m_XOPS.Weapon[idx].Speed.ToString();
            tBox_WeaponSpeed2.Text = (XOperations.FPS * 60.0F / Convert.ToInt32(tBox_WeaponSpeed.Text)).ToString("F2") + "RPM";
            tBox_WeaponVelocity.Text = m_XOPS.Weapon[idx].Velocity.ToString();
            tBox_WeaponVelocity2.Text = (XOperations.FPS * 0.001F * Convert.ToInt32(tBox_WeaponVelocity.Text)).ToString("F2") + "m/s";
            tBox_WeaponAmmo.Text = m_XOPS.Weapon[idx].Ammo.ToString();
            tBox_WeaponReloadTime.Text = m_XOPS.Weapon[idx].ReloadTime.ToString();
            tBox_WeaponReloadTime2.Text = (Convert.ToSingle(tBox_WeaponReloadTime.Text) / XOperations.FPS).ToString("F2") + "초";
            tBox_WeaponReaction.Text = m_XOPS.Weapon[idx].Reaction.ToString();
            tBox_WeaponAccuracyMin.Text = m_XOPS.Weapon[idx].AccuracyMin.ToString();
            tBox_WeaponAccuracyMax.Text = m_XOPS.Weapon[idx].AccuracyMax.ToString();
            {
                string name = Enum.GetName(typeof(Weapon.ArmsType), m_XOPS.Weapon[idx].Arms);
                if (string.IsNullOrEmpty(name)) { cBox_WeaponArms.SelectedItem = Weapon.ArmsType.UNKNOWN; }
                else { cBox_WeaponArms.SelectedItem = Enum.Parse(typeof(Weapon.ArmsType), name); }
            }
            {
                string name = Enum.GetName(typeof(Weapon.FireMode), m_XOPS.Weapon[idx].FireMode);
                if (string.IsNullOrEmpty(name)) { cBox_WeaponFireMode.SelectedItem = Weapon.FireMode.UNKNOWN; }
                else { cBox_WeaponFireMode.SelectedItem = Enum.Parse(typeof(Weapon.FireMode), name); }
            }
            {
                string name = Enum.GetName(typeof(Weapon.ScopeMode), m_XOPS.Weapon[idx].ScopeMode);
                if (string.IsNullOrEmpty(name)) { cBox_WeaponScopeMode.SelectedItem = Weapon.ScopeMode.UNKNOWN; }
                else { cBox_WeaponScopeMode.SelectedItem = Enum.Parse(typeof(Weapon.ScopeMode), name); }
            }
            {
                string name = Enum.GetName(typeof(XOperations.TextureID), m_XOPS.Weapon[idx].TextureID);
                if (string.IsNullOrEmpty(name)) { cBox_WeaponTexture.SelectedItem = XOperations.TextureID.UNKNOWN; }
                else { cBox_WeaponTexture.SelectedItem = Enum.Parse(typeof(XOperations.TextureID), name); }
            }
            {
                string name = Enum.GetName(typeof(XOperations.ModelID), m_XOPS.Weapon[idx].ModelID);
                if (string.IsNullOrEmpty(name)) { cBox_WeaponModel.SelectedItem = XOperations.ModelID.UNKNOWN; }
                else { cBox_WeaponModel.SelectedItem = Enum.Parse(typeof(XOperations.ModelID), name); }
            }
            tBox_WeaponSize.Text = m_XOPS.Weapon[idx].Size.ToString();
            {
                string name = Enum.GetName(typeof(Weapon.SoundID), m_XOPS.Weapon[idx].SoundID);
                if (string.IsNullOrEmpty(name)) { cBox_WeaponSoundID.SelectedItem = Weapon.SoundID.UNKNOWN; }
                else { cBox_WeaponSoundID.SelectedItem = Enum.Parse(typeof(Weapon.SoundID), name); }
            }
            tBar_WeaponSoundVolume.Value = (int)m_XOPS.Weapon[idx].SoundVolume;
            toggle_WeaponSilencer.Checked = (m_XOPS.Weapon[idx].Silencer == 0) ? false : true;
            tBox_WeaponPositionX.Text = m_XOPS.Weapon[idx].PositionX.ToString();
            tBox_WeaponPositionY.Text = m_XOPS.Weapon[idx].PositionY.ToString();
            tBox_WeaponPositionZ.Text = m_XOPS.Weapon[idx].PositionZ.ToString();
            tBox_WeaponMFlashPositionX.Text = m_XOPS.Weapon[idx].MFlashPositionX.ToString();
            tBox_WeaponMFlashPositionY.Text = m_XOPS.Weapon[idx].MFlashPositionY.ToString();
            tBox_WeaponMFlashPositionZ.Text = m_XOPS.Weapon[idx].MFlashPositionZ.ToString();
            tBox_WeaponShellPositionX.Text = m_XOPS.Weapon[idx].ShellPositionX.ToString();
            tBox_WeaponShellPositionY.Text = m_XOPS.Weapon[idx].ShellPositionY.ToString();
            tBox_WeaponShellPositionZ.Text = m_XOPS.Weapon[idx].ShellPositionZ.ToString();
            tBox_WeaponShellMovementPositionX.Text = m_XOPS.Weapon[idx].ShellMovementPositionX.ToString();
            tBox_WeaponShellMovementPositionY.Text = m_XOPS.Weapon[idx].ShellMovementPositionY.ToString();

            string Path1 = string.Empty;
            if (m_IsReadProcess)
            {
                string offsetPath = XOPSOffsetManager.GetTexturePath(m_ProcessId, m_XOPS.Ver, (XOperations.TextureID)Enum.Parse(typeof(XOperations.TextureID), cBox_WeaponTexture.SelectedItem.ToString()));
                if (string.IsNullOrEmpty(offsetPath) == false) { offsetPath.Substring(1, offsetPath.Length - 1); }

                string temp = Path.GetDirectoryName(Process.GetProcessById(m_ProcessId).MainModule.FileName) + offsetPath;
                Path1 = temp;
            }
            else
            {
                string tempPath = XOPSOffsetManager.GetTexturePath(tBox_EXEPath.Text, m_XOPS.Ver, (XOperations.TextureID)Enum.Parse(typeof(XOperations.TextureID), cBox_WeaponTexture.SelectedItem.ToString()));
                if (string.IsNullOrEmpty(tempPath) == false) { tempPath.Substring(1, tempPath.Length - 1); }

                Path1 = Path.GetDirectoryName(tBox_EXEPath.Text) + tempPath;
            }
            pBox_WeaponImage.ImageLocation = Path1;
        }
        #endregion

        private void MenuClickEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;

            switch (tsmi.Tag.ToString())
            {
                case "Open": { OpenFile(); } break;
                case "Find":
                    {
                        FindProcess fp = new FindProcess();
                        if (fp.ShowDialog() == DialogResult.OK)
                        {
                            m_ProcessId = fp.ProcessId;
                            m_XOPS = new XOperations(m_ProcessId);
                            m_IsReadProcess = true;
                            SetControlValue();
                            SetWeaponControlValue();
                            SetCharacterControlValue();
                            SetSmallObjectControlValue();
                            m_LoadSuccess = true;
                        }
                    }
                    break;
                case "Save": { SaveFile(); } break;
                case "Exit": { Application.Exit(); } break;
            }
        }

        /// <summary>
        /// 메인 폼 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            cBox_Style.SelectedIndex = 0;
        }

        /// <summary>
        /// EXE 파일 불러오기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tBox_EXEPath_ButtonClick(object sender, EventArgs e) { OpenFile(); }

        /// <summary>
        /// 다크 모드 토글
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toggle_DarkMode_CheckedChanged(object sender, EventArgs e)
        {
            if (metroStyleManager.Theme == MetroFramework.MetroThemeStyle.Light)
            {
                metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;

                this.lBox_WeaponList.BackColor = System.Drawing.Color.Black;
                this.lBox_WeaponList.ForeColor = System.Drawing.Color.White;
                this.lBox_CharacterList.BackColor = System.Drawing.Color.Black;
                this.lBox_CharacterList.ForeColor = System.Drawing.Color.White;
                this.lbox_SmallObjectList.BackColor = System.Drawing.Color.Black;
                this.lbox_SmallObjectList.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                this.lBox_WeaponList.BackColor = System.Drawing.Color.White;
                this.lBox_WeaponList.ForeColor = System.Drawing.Color.Black;
                this.lBox_CharacterList.BackColor = System.Drawing.Color.White;
                this.lBox_CharacterList.ForeColor = System.Drawing.Color.Black;
                this.lbox_SmallObjectList.BackColor = System.Drawing.Color.White;
                this.lbox_SmallObjectList.ForeColor = System.Drawing.Color.Black;
            }
            this.Refresh();
        }

        /// <summary>
        /// 스타일 변경
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBox_Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBox_Style.SelectedIndex)
            {
                case 0: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Black; } break;
                case 1: { metroStyleManager.Style = MetroFramework.MetroColorStyle.White; } break;
                case 2: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Silver; } break;
                case 3: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Blue; } break;
                case 4: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Green; } break;
                case 5: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Lime; } break;
                case 6: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Teal; } break;
                case 7: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange; } break;
                case 8: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Brown; } break;
                case 9: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Pink; } break;
                case 10: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Magenta; } break;
                case 11: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Purple; } break;
                case 12: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Red; } break;
                case 13: { metroStyleManager.Style = MetroFramework.MetroColorStyle.Yellow; } break;
            }
            this.Refresh();
        }

        private void lBox_WeaponList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_XOPS != null)
                SetWeaponControlValue();
        }

        private void lBox_CharacterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_XOPS != null)
                SetCharacterControlValue();
        }

        private void lbox_SmallObjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_XOPS != null)
                SetSmallObjectControlValue();
        }

        private void ComboBoxChangedEvent(object sender, EventArgs e)
        {
            if (m_LoadSuccess == false) { return; }

            MetroFramework.Controls.MetroComboBox cbBox = sender as MetroFramework.Controls.MetroComboBox;
            if (cbBox == null) { return; }

            int weaponIdx = lBox_WeaponList.SelectedIndex;
            int characterIdx = lBox_CharacterList.SelectedIndex;
            int smallObjectIdx = lbox_SmallObjectList.SelectedIndex;

            if (weaponIdx >= Weapon.MAX_WEAPON) { return; }
            if (characterIdx >= Character.MAX_CHARACTER) { return; }
            if (smallObjectIdx >= SmallObject.MAX_SMALLOBJECT) { return; }

            switch (cbBox.Tag.ToString())
            {
                case "AutoDepthStencilFormat":
                    {
                        m_XOPS.GameParam.AutoDepthStencilFormat = (XOperations.D3DFORMAT)Enum.Parse(typeof(XOperations.D3DFORMAT), cBox_AutoDepthStencilFormat.SelectedItem.ToString());
                    }
                    break;
                case "WeaponArms":
                    {
                        if ((Weapon.ArmsType)cBox_WeaponArms.SelectedItem == Weapon.ArmsType.UNKNOWN) { return; }
                        m_XOPS.Weapon[weaponIdx].Arms = (short)(Weapon.ArmsType)Enum.Parse(typeof(Weapon.ArmsType), cBox_WeaponArms.SelectedItem.ToString());
                    }
                    break;
                case "WeaponFireMode":
                    {
                        if ((Weapon.FireMode)cBox_WeaponFireMode.SelectedItem == Weapon.FireMode.UNKNOWN) { return; }
                        m_XOPS.Weapon[weaponIdx].FireMode = (short)(Weapon.FireMode)Enum.Parse(typeof(Weapon.FireMode), cBox_WeaponFireMode.SelectedItem.ToString());
                    }
                    break;
                case "WeaponScopeMode":
                    {
                        if ((Weapon.ScopeMode)cBox_WeaponScopeMode.SelectedItem == Weapon.ScopeMode.UNKNOWN) { return; }
                        m_XOPS.Weapon[weaponIdx].ScopeMode = (short)(Weapon.ScopeMode)Enum.Parse(typeof(Weapon.ScopeMode), cBox_WeaponScopeMode.SelectedItem.ToString());
                    }
                    break;
                case "WeaponTexture":
                    {
                        if ((XOperations.TextureID)cBox_WeaponTexture.SelectedItem == XOperations.TextureID.UNKNOWN) { return; }
                        m_XOPS.Weapon[weaponIdx].TextureID = (short)(XOperations.TextureID)Enum.Parse(typeof(XOperations.TextureID), cBox_WeaponTexture.SelectedItem.ToString());
                    }
                    break;
                case "WeaponModel":
                    {
                        if ((XOperations.ModelID)cBox_WeaponModel.SelectedItem == XOperations.ModelID.UNKNOWN) { return; }
                        m_XOPS.Weapon[weaponIdx].ModelID = (short)(XOperations.ModelID)Enum.Parse(typeof(XOperations.ModelID), cBox_WeaponModel.SelectedItem.ToString());
                    }
                    break;
                case "WeaponSound":
                    {
                        if ((Weapon.SoundID)cBox_WeaponSoundID.SelectedItem == Weapon.SoundID.UNKNOWN) { return; }
                        m_XOPS.Weapon[weaponIdx].SoundID = (short)(Weapon.SoundID)Enum.Parse(typeof(Weapon.SoundID), cBox_WeaponSoundID.SelectedItem.ToString());
                    }
                    break;
                case "CharacterTexture":
                    {
                        if ((Character.TextureID)cBox_CharacterTexture.SelectedItem == Character.TextureID.UNKNOWN) { return; }
                        m_XOPS.Character[characterIdx].TextureID = (short)(Character.TextureID)Enum.Parse(typeof(Character.TextureID), cBox_CharacterTexture.SelectedItem.ToString());
                    }
                    break;
                case "CharacterModel":
                    {
                        if ((Character.ModelID)cBox_CharacterModel.SelectedItem == Character.ModelID.UNKNOWN) { return; }
                        m_XOPS.Character[characterIdx].ModelID = (short)(Character.ModelID)Enum.Parse(typeof(Character.ModelID), cBox_CharacterModel.SelectedItem.ToString());
                    }
                    break;
                case "CharacterAILevel":
                    {
                        if ((Character.AILevel)cBox_CharacterAILevel.SelectedItem == Character.AILevel.UNKNOWN) { return; }
                        m_XOPS.Character[characterIdx].AILevel = (short)(Character.AILevel)Enum.Parse(typeof(Character.AILevel), cBox_CharacterAILevel.SelectedItem.ToString());
                    }
                    break;
                case "CharacterPrimaryWeapon":
                    {
                        if ((Weapon.WeaponID)cBox_CharacterPrimaryWeapon.SelectedItem == Weapon.WeaponID.UNKNOWN) { return; }
                        m_XOPS.Character[characterIdx].PrimaryWeapon = (short)(Weapon.WeaponID)Enum.Parse(typeof(Weapon.WeaponID), cBox_CharacterPrimaryWeapon.SelectedItem.ToString());
                    }
                    break;
                case "CharacterSecondaryWeapon":
                    {
                        if ((Weapon.WeaponID)cBox_CharacterSecondaryWeapon.SelectedItem == Weapon.WeaponID.UNKNOWN) { return; }
                        m_XOPS.Character[characterIdx].SecondaryWeapon = (short)(Weapon.WeaponID)Enum.Parse(typeof(Weapon.WeaponID), cBox_CharacterSecondaryWeapon.SelectedItem.ToString());
                    }
                    break;
                case "CharacterType":
                    {
                        if ((Character.Type)cBox_CharacterType.SelectedItem == Character.Type.UNKNOWN) { return; }
                        m_XOPS.Character[characterIdx].Type = (short)(Character.Type)Enum.Parse(typeof(Character.Type), cBox_CharacterType.SelectedItem.ToString());
                    }
                    break;
                case "SmallObjectModel":
                    {
                        if ((XOperations.ModelID)cBox_SmallObjectModel.SelectedItem == XOperations.ModelID.UNKNOWN) { return; }
                        m_XOPS.SmallObject[smallObjectIdx].ModelID = (byte)(XOperations.ModelID)Enum.Parse(typeof(XOperations.ModelID), cBox_SmallObjectModel.SelectedItem.ToString());
                    }
                    break;
                case "SmallObjectTexture":
                    {
                        if ((XOperations.TextureID)cBox_SmallObjectTexture.SelectedItem == XOperations.TextureID.UNKNOWN) { return; }
                        m_XOPS.SmallObject[smallObjectIdx].TextureID = (byte)(XOperations.TextureID)Enum.Parse(typeof(XOperations.TextureID), cBox_SmallObjectTexture.SelectedItem.ToString());
                    }
                    break;
                case "SmallObjectSound":
                    {
                        if ((SmallObject.SoundID)cBox_SmallObjectSound.SelectedItem == SmallObject.SoundID.UNKNOWN) { return; }
                        m_XOPS.SmallObject[smallObjectIdx].SoundID = (byte)(SmallObject.SoundID)Enum.Parse(typeof(SmallObject.SoundID), cBox_SmallObjectSound.SelectedItem.ToString());
                    }
                    break;
            }

            if (toggle_AutoApply.Checked)
            {
                m_XOPS.WriteGameParameter(m_ProcessId, this);
                m_XOPS.Weapon.WriteMemoryData(m_ProcessId);
                m_XOPS.Character.WriteMemoryData(m_ProcessId);
                m_XOPS.SmallObject.WriteMemoryData(m_ProcessId);
            }

            SetControlValue();
            SetWeaponControlValue();
            SetCharacterControlValue();
            SetSmallObjectControlValue();
        }

        private void TextBoxChangedEvent(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox textBox = sender as MetroFramework.Controls.MetroTextBox;
            if (textBox == null) { return; }

            int weaponIdx = lBox_WeaponList.SelectedIndex;
            int characterIdx = lBox_CharacterList.SelectedIndex;
            int smallObjectIdx = lbox_SmallObjectList.SelectedIndex;

            if (weaponIdx >= Weapon.MAX_WEAPON) { return; }
            if (characterIdx >= Character.MAX_CHARACTER) { return; }
            if (smallObjectIdx >= SmallObject.MAX_SMALLOBJECT) { return; }

            switch (textBox.Tag.ToString())
            {
                case "GameName": { m_XOPS.GameParam.GameName = tBox_GameName.Text; } break;
                case "GameVersion": { m_XOPS.GameParam.GameVersion = tBox_GameVersion.Text; } break;
                case "ClippingPlaneNear": { m_XOPS.GameParam.ClippingPlaneNear = Convert.ToSingle(tBox_ClippingPlaneNear.Text); } break;
                case "ClippingPlaneFar": { m_XOPS.GameParam.ClippingPlaneFar = Convert.ToSingle(tBox_ClippingPlaneFar.Text); } break;
                case "FOVNormal": { m_XOPS.GameParam.FOVNormal = Convert.ToSingle(tBox_FOVNormal.Text); } break;
                case "FOVAUG": { m_XOPS.GameParam.FOVAUG = Convert.ToSingle(tBox_FOVAUG.Text); } break;
                case "FOVPSG1": { m_XOPS.GameParam.FOVPSG1 = Convert.ToSingle(tBox_FOVPSG1.Text); } break;

                case "WeaponName": { m_XOPS.Weapon[weaponIdx].Name = tBox_WeaponName.Text; } break;
                case "WeaponDamage": { m_XOPS.Weapon[weaponIdx].Damage = Convert.ToInt16(tBox_WeaponDamage.Text); } break;
                case "WeaponPenetration": { m_XOPS.Weapon[weaponIdx].Penetration = Convert.ToInt16(tBox_WeaponPenetration.Text); } break;
                case "WeaponSpeed": { m_XOPS.Weapon[weaponIdx].Speed = Convert.ToInt16(tBox_WeaponSpeed.Text); } break;
                case "WeaponVelocity": { m_XOPS.Weapon[weaponIdx].Velocity = Convert.ToInt16(tBox_WeaponVelocity.Text); } break;
                case "WeaponAmmo": { m_XOPS.Weapon[weaponIdx].Ammo = Convert.ToInt16(tBox_WeaponAmmo.Text); } break;
                case "WeaponReloadTime": { m_XOPS.Weapon[weaponIdx].ReloadTime = Convert.ToInt16(tBox_WeaponReloadTime.Text); } break;
                case "WeaponReaction": { m_XOPS.Weapon[weaponIdx].Reaction = Convert.ToInt16(tBox_WeaponReaction.Text); } break;
                case "WeaponAccuracyMin": { m_XOPS.Weapon[weaponIdx].AccuracyMin = Convert.ToInt16(tBox_WeaponAccuracyMin.Text); } break;
                case "WeaponAccuracyMax": { m_XOPS.Weapon[weaponIdx].AccuracyMax = Convert.ToInt16(tBox_WeaponAccuracyMax.Text); } break;
                case "WeaponSize": { m_XOPS.Weapon[weaponIdx].Size = Convert.ToInt16(tBox_WeaponSize.Text); } break;
                case "WeaponPositionX": { m_XOPS.Weapon[weaponIdx].PositionX = Convert.ToInt16(tBox_WeaponPositionX.Text); } break;
                case "WeaponPositionY": { m_XOPS.Weapon[weaponIdx].PositionY = Convert.ToInt16(tBox_WeaponPositionX.Text); } break;
                case "WeaponPositionZ": { m_XOPS.Weapon[weaponIdx].PositionZ = Convert.ToInt16(tBox_WeaponPositionX.Text); } break;
                case "WeaponMFlashPositionX": { m_XOPS.Weapon[weaponIdx].MFlashPositionX = Convert.ToInt16(tBox_WeaponMFlashPositionX.Text); } break;
                case "WeaponMFlashPositionY": { m_XOPS.Weapon[weaponIdx].MFlashPositionY = Convert.ToInt16(tBox_WeaponMFlashPositionY.Text); } break;
                case "WeaponMFlashPositionZ": { m_XOPS.Weapon[weaponIdx].MFlashPositionZ = Convert.ToInt16(tBox_WeaponMFlashPositionZ.Text); } break;
                case "WeaponShellPositionX": { m_XOPS.Weapon[weaponIdx].ShellPositionX = Convert.ToInt16(tBox_WeaponShellPositionX.Text); } break;
                case "WeaponShellPositionY": { m_XOPS.Weapon[weaponIdx].ShellPositionY = Convert.ToInt16(tBox_WeaponShellPositionY.Text); } break;
                case "WeaponShellPositionZ": { m_XOPS.Weapon[weaponIdx].ShellPositionZ = Convert.ToInt16(tBox_WeaponShellPositionZ.Text); } break;
                case "WeaponShellMovementPositionX": { m_XOPS.Weapon[weaponIdx].ShellMovementPositionX = Convert.ToInt16(tBox_WeaponShellMovementPositionX.Text); } break;
                case "WeaponShellMovementPositionY": { m_XOPS.Weapon[weaponIdx].ShellMovementPositionY = Convert.ToInt16(tBox_WeaponShellMovementPositionX.Text); } break;
                case "CharacterHP": { m_XOPS.Character[characterIdx].HP = Convert.ToInt16(tBox_CharacterHP.Text); } break;
                case "SmallObjectJump": { m_XOPS.SmallObject[smallObjectIdx].Jump = Convert.ToByte(tBox_SmallObjectJump.Text); } break;
                case "SmallObjectCollisionRange": { m_XOPS.SmallObject[smallObjectIdx].CollisionRange = Convert.ToByte(tBox_SmallObjectCollisionRange.Text); } break;
                case "SmallObjectHP": { m_XOPS.SmallObject[smallObjectIdx].HP = Convert.ToByte(tBox_SmallObjectHP.Text); } break;
            }

            if (toggle_AutoApply.Checked)
            {
                m_XOPS.WriteGameParameter(m_ProcessId, this);
                m_XOPS.Weapon.WriteMemoryData(m_ProcessId);
                m_XOPS.Character.WriteMemoryData(m_ProcessId);
                m_XOPS.SmallObject.WriteMemoryData(m_ProcessId);
            }

            SetControlValue();
            SetWeaponControlValue();
            SetCharacterControlValue();
            SetSmallObjectControlValue();
        }

        private void ButtonClickEvent(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroButton btn = sender as MetroFramework.Controls.MetroButton;
            if (btn == null) { return; }

            switch(btn.Tag.ToString())
            {
                case "WeaponDamage":
                    {
                        if (MessageBox.Show($"모든 무기의 공격력을 {tBox_WeaponDamage.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].Damage = Convert.ToInt16(tBox_WeaponDamage.Text); }
                        }
                    } break;
                case "WeaponPenetration":
                    {
                        if (MessageBox.Show($"모든 무기의 관통력을 {tBox_WeaponPenetration.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].Penetration = Convert.ToInt16(tBox_WeaponPenetration.Text); }
                        }
                    } break;
                case "WeaponSpeed":
                    {
                        if (MessageBox.Show($"모든 무기의 발사 속도를 {tBox_WeaponSpeed.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].Speed = Convert.ToInt16(tBox_WeaponSpeed.Text); }
                        }
                    } break;
                case "WeaponVelocity":
                    {
                        if (MessageBox.Show($"모든 무기의 탄속을 {tBox_WeaponVelocity.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].Velocity = Convert.ToInt16(tBox_WeaponVelocity.Text); }
                        }
                    } break;
                case "WeaponAmmo":
                    {
                        if (MessageBox.Show($"모든 무기의 장탄 수를 {tBox_WeaponAmmo.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].Ammo = Convert.ToInt16(tBox_WeaponAmmo.Text); }
                        }
                    } break;
                case "WeaponReloadTime":
                    {
                        if (MessageBox.Show($"모든 무기의 재장전 시간을 {tBox_WeaponReloadTime.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].ReloadTime = Convert.ToInt16(tBox_WeaponReloadTime.Text); }
                        }
                    } break;
                case "WeaponReaction":
                    {
                        if (MessageBox.Show($"모든 무기의 반동을 {tBox_WeaponReaction.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].Reaction = Convert.ToInt16(tBox_WeaponReaction.Text); }
                        }
                    } break;
                case "WeaponAccuracy":
                    {
                        if (MessageBox.Show($"모든 무기의 정확도를 {tBox_WeaponAccuracyMin.Text}와 {tBox_WeaponAccuracyMax.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].AccuracyMin = Convert.ToInt16(tBox_WeaponAccuracyMin.Text); m_XOPS.Weapon[i].AccuracyMax = Convert.ToInt16(tBox_WeaponAccuracyMax.Text); }
                        }
                    } break;
                case "WeaponArms":
                    {
                        if (MessageBox.Show($"모든 무기의 팔 유형을 {cBox_WeaponArms.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { if ((Weapon.ArmsType)cBox_WeaponArms.SelectedItem == Weapon.ArmsType.UNKNOWN) { continue; } m_XOPS.Weapon[i].Arms = (short)(Weapon.ArmsType)Enum.Parse(typeof(Weapon.ArmsType), cBox_WeaponArms.SelectedItem.ToString()); }
                        }
                    } break;
                case "WeaponFireMode":
                    {
                        if (MessageBox.Show($"모든 무기의 발사 모드를 {cBox_WeaponFireMode.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { if ((Weapon.FireMode)cBox_WeaponFireMode.SelectedItem == Weapon.FireMode.UNKNOWN) { continue; } m_XOPS.Weapon[i].FireMode = (short)(Weapon.FireMode)Enum.Parse(typeof(Weapon.FireMode), cBox_WeaponFireMode.SelectedItem.ToString()); }
                        }
                    } break;
                case "WeaponScopeMode":
                    {
                        if (MessageBox.Show($"모든 무기의 스코프 모드를 {cBox_WeaponScopeMode.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { if ((Weapon.ScopeMode)cBox_WeaponScopeMode.SelectedItem == Weapon.ScopeMode.UNKNOWN) { continue; } m_XOPS.Weapon[i].ScopeMode = (short)(Weapon.ScopeMode)Enum.Parse(typeof(Weapon.ScopeMode), cBox_WeaponScopeMode.SelectedItem.ToString()); }
                        }
                    } break;
                case "WeaponTexture":
                    {
                        if (MessageBox.Show($"모든 무기의 텍스쳐를 {cBox_WeaponTexture.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { if ((XOperations.TextureID)cBox_WeaponTexture.SelectedItem == XOperations.TextureID.UNKNOWN) { continue; } m_XOPS.Weapon[i].TextureID = (short)(XOperations.TextureID)Enum.Parse(typeof(XOperations.TextureID), cBox_WeaponTexture.SelectedItem.ToString()); }
                        }
                    } break;
                case "WeaponModel":
                    {
                        if (MessageBox.Show($"모든 무기의 모델을 {cBox_WeaponModel.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { if ((XOperations.ModelID)cBox_WeaponModel.SelectedItem == XOperations.ModelID.UNKNOWN) { continue; } m_XOPS.Weapon[i].ModelID = (short)(XOperations.ModelID)Enum.Parse(typeof(XOperations.ModelID), cBox_WeaponModel.SelectedItem.ToString()); }
                        }
                    } break;
                case "WeaponSize":
                    {
                        if (MessageBox.Show($"모든 무기의 크기를 {tBox_WeaponSize.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].Size = Convert.ToInt16(tBox_WeaponSize.Text); }
                        }
                    } break;
                case "WeaponSound":
                    {
                        if (MessageBox.Show($"모든 무기의 발사음을 {cBox_WeaponSoundID.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { if ((Weapon.SoundID)cBox_WeaponSoundID.SelectedItem == Weapon.SoundID.UNKNOWN) { continue; } m_XOPS.Weapon[i].SoundID = (short)(Weapon.SoundID)Enum.Parse(typeof(Weapon.SoundID), cBox_WeaponSoundID.SelectedItem.ToString()); }
                        }
                    } break;
                case "WeaponVolume":
                    {
                        if (MessageBox.Show($"모든 무기의 음량을 {tBar_WeaponSoundVolume.Value.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].SoundVolume = Convert.ToInt16(tBar_WeaponSoundVolume.Value); }
                        }
                    } break;
                case "WeaponSilencer":
                    {
                        if (MessageBox.Show($"모든 무기의 소음기를 {toggle_WeaponSilencer.Checked.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].Silencer = Convert.ToInt16(toggle_WeaponSilencer.Checked); }
                        }
                    } break;
                case "WeaponPosition":
                    {
                        if (MessageBox.Show($"모든 무기의 좌표를 {tBox_WeaponPositionX.Text}, {tBox_WeaponPositionY.Text}, {tBox_WeaponPositionZ.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].PositionX = Convert.ToInt16(tBox_WeaponPositionX.Text); m_XOPS.Weapon[i].PositionY = Convert.ToInt16(tBox_WeaponPositionY.Text); m_XOPS.Weapon[i].PositionZ = Convert.ToInt16(tBox_WeaponPositionZ.Text); }
                        }
                    } break;
                case "WeaponMFlashPosition":
                    {
                        if (MessageBox.Show($"모든 무기의 머즐플래시 좌표를 {tBox_WeaponMFlashPositionX.Text}, {tBox_WeaponMFlashPositionY.Text}, {tBox_WeaponMFlashPositionZ.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].MFlashPositionZ = Convert.ToInt16(tBox_WeaponMFlashPositionX.Text); m_XOPS.Weapon[i].MFlashPositionY = Convert.ToInt16(tBox_WeaponMFlashPositionY.Text); m_XOPS.Weapon[i].MFlashPositionZ = Convert.ToInt16(tBox_WeaponMFlashPositionZ.Text); }
                        }
                    } break;
                case "WeaponShellPosition":
                    {
                        if (MessageBox.Show($"모든 무기의 탄피 배출 좌표를 {tBox_WeaponShellPositionX.Text}, {tBox_WeaponShellPositionY.Text}, {tBox_WeaponShellPositionZ.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].ShellPositionX = Convert.ToInt16(tBox_WeaponShellPositionX.Text); m_XOPS.Weapon[i].ShellPositionY = Convert.ToInt16(tBox_WeaponShellPositionY.Text); m_XOPS.Weapon[i].ShellPositionZ = Convert.ToInt16(tBox_WeaponShellPositionZ.Text); }
                        }
                    } break;
                case "WeaponShellMovementPosition":
                    {
                        if (MessageBox.Show($"모든 무기의 탄피 이동 좌표를 {tBox_WeaponShellMovementPositionX.Text}, {tBox_WeaponShellMovementPositionY.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Weapon.MAX_WEAPON; i++) { m_XOPS.Weapon[i].ShellMovementPositionX = Convert.ToInt16(tBox_WeaponShellMovementPositionX.Text); m_XOPS.Weapon[i].ShellMovementPositionY = Convert.ToInt16(tBox_WeaponShellMovementPositionY.Text);  }
                        }
                    } break;
                case "CharacterTexture":
                    {
                        if (MessageBox.Show($"모든 캐릭터의 텍스쳐를 {cBox_CharacterTexture.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Character.MAX_CHARACTER; i++) { if ((Character.TextureID)cBox_CharacterTexture.SelectedItem == Character.TextureID.UNKNOWN) { continue; } m_XOPS.Character[i].TextureID = (short)(Character.TextureID)Enum.Parse(typeof(Character.TextureID), cBox_CharacterTexture.SelectedItem.ToString()); }
                        }
                    } break;
                case "CharacterModel":
                    {
                        if (MessageBox.Show($"모든 캐릭터의 모델을 {cBox_CharacterModel.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Character.MAX_CHARACTER; i++) { if ((Character.ModelID)cBox_CharacterModel.SelectedItem == Character.ModelID.UNKNOWN) { continue; } m_XOPS.Character[i].ModelID = (short)(Character.ModelID)Enum.Parse(typeof(Character.ModelID), cBox_CharacterModel.SelectedItem.ToString()); }
                        }
                    } break;
                case "CharacterAILevel":
                    {
                        if (MessageBox.Show($"모든 캐릭터의 AI 수준을 {cBox_CharacterAILevel.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Character.MAX_CHARACTER; i++) { if ((Character.AILevel)cBox_CharacterAILevel.SelectedItem == Character.AILevel.UNKNOWN) { continue; } m_XOPS.Character[i].AILevel = (short)(Character.AILevel)Enum.Parse(typeof(Character.AILevel), cBox_CharacterAILevel.SelectedItem.ToString()); }
                        }
                    } break;
                case "CharacterPrimaryWeapon":
                    {
                        if (MessageBox.Show($"모든 캐릭터의 주무기를 {cBox_CharacterPrimaryWeapon.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Character.MAX_CHARACTER; i++) { if ((Weapon.WeaponID)cBox_CharacterPrimaryWeapon.SelectedItem == Weapon.WeaponID.UNKNOWN) { continue; } m_XOPS.Character[i].PrimaryWeapon = (short)(Weapon.WeaponID)Enum.Parse(typeof(Weapon.WeaponID), cBox_CharacterPrimaryWeapon.SelectedItem.ToString()); }
                        }
                    } break;
                case "CharacterSecondaryWeapon":
                    {
                        if (MessageBox.Show($"모든 캐릭터의 보조무기를 {cBox_CharacterSecondaryWeapon.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Character.MAX_CHARACTER; i++) { if ((Weapon.WeaponID)cBox_CharacterSecondaryWeapon.SelectedItem == Weapon.WeaponID.UNKNOWN) { continue; } m_XOPS.Character[i].SecondaryWeapon = (short)(Weapon.WeaponID)Enum.Parse(typeof(Weapon.WeaponID), cBox_CharacterSecondaryWeapon.SelectedItem.ToString()); }
                        }
                    } break;
                case "CharacterType":
                    {
                        if (MessageBox.Show($"모든 캐릭터의 유형을 {cBox_CharacterType.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Character.MAX_CHARACTER; i++) { if ((Character.Type)cBox_CharacterType.SelectedItem == Character.Type.UNKNOWN) { continue; } m_XOPS.Character[i].Type = (short)(Character.Type)Enum.Parse(typeof(Character.Type), cBox_CharacterType.SelectedItem.ToString()); }
                        }
                    } break;
                case "CharacterHP":
                    {
                        if (MessageBox.Show($"모든 캐릭터의 체력을 {tBox_CharacterHP.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < Character.MAX_CHARACTER; i++) { m_XOPS.Character[i].HP = Convert.ToInt16(tBox_CharacterHP.Text); }
                        }
                    } break;
                case "SmallObjectJump":
                    {
                        if (MessageBox.Show($"모든 소품의 튀는 높이를 {tBox_SmallObjectJump.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < SmallObject.MAX_SMALLOBJECT; i++) { m_XOPS.SmallObject[i].Jump = Convert.ToByte(tBox_SmallObjectJump.Text); }
                        }
                    } break;
                case "SmallObjectModel":
                    {
                        if (MessageBox.Show($"모든 소품의 모델을 {cBox_SmallObjectModel.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < SmallObject.MAX_SMALLOBJECT; i++) { if ((XOperations.ModelID)cBox_SmallObjectModel.SelectedItem == XOperations.ModelID.UNKNOWN) { continue; } m_XOPS.SmallObject[i].ModelID = (byte)(XOperations.ModelID)Enum.Parse(typeof(XOperations.ModelID), cBox_SmallObjectModel.SelectedItem.ToString()); }
                        }
                    } break;
                case "SmallObjectTexture":
                    {
                        if (MessageBox.Show($"모든 소품의 텍스쳐를 {cBox_SmallObjectTexture.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < SmallObject.MAX_SMALLOBJECT; i++) { if ((XOperations.TextureID)cBox_SmallObjectTexture.SelectedItem == XOperations.TextureID.UNKNOWN) { continue; } m_XOPS.SmallObject[i].TextureID = (byte)(XOperations.TextureID)Enum.Parse(typeof(XOperations.TextureID), cBox_SmallObjectTexture.SelectedItem.ToString()); }
                        }
                    } break;
                case "SmallObjectSound":
                    {
                        if (MessageBox.Show($"모든 소품의 피격음을 {cBox_SmallObjectSound.SelectedItem.ToString()}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < SmallObject.MAX_SMALLOBJECT; i++) { if ((SmallObject.SoundID)cBox_SmallObjectSound.SelectedItem == SmallObject.SoundID.UNKNOWN) { continue; } m_XOPS.SmallObject[i].SoundID = (byte)(SmallObject.SoundID)Enum.Parse(typeof(SmallObject.SoundID), cBox_SmallObjectSound.SelectedItem.ToString()); }
                        }
                    } break;
                case "SmallObjectCollisionRange":
                    {
                        if (MessageBox.Show($"모든 소품의 충돌 범위를 {tBox_SmallObjectCollisionRange.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < SmallObject.MAX_SMALLOBJECT; i++) { m_XOPS.SmallObject[i].CollisionRange = Convert.ToByte(tBox_SmallObjectCollisionRange.Text); }
                        }
                    } break;
                case "SmallObjectHP":
                    {
                        if (MessageBox.Show($"모든 소품의 체력을 {tBox_SmallObjectHP.Text}로 변경하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < SmallObject.MAX_SMALLOBJECT; i++) { m_XOPS.SmallObject[i].HP = Convert.ToByte(tBox_SmallObjectHP.Text); }
                        }
                    } break;
            }
        }

        private void tBar_WeaponSoundVolume_Scroll(object sender, ScrollEventArgs e)
        {
            int weaponIdx = lBox_WeaponList.SelectedIndex;

            m_XOPS.Weapon[weaponIdx].SoundVolume = (short)tBar_WeaponSoundVolume.Value;
            SetWeaponControlValue();

            if (toggle_AutoApply.Checked)
            {
                m_XOPS.Weapon.WriteMemoryData(m_ProcessId);
            }
        }

        private void toggle_WeaponSilencer_CheckedChanged(object sender, EventArgs e)
        {
            int weaponIdx = lBox_WeaponList.SelectedIndex;

            m_XOPS.Weapon[weaponIdx].Silencer = Convert.ToInt16(toggle_WeaponSilencer.Checked);
            SetWeaponControlValue();

            if (toggle_AutoApply.Checked)
            {
                m_XOPS.Weapon.WriteMemoryData(m_ProcessId);
            }
        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

            if (files != null && files.Any())
            {
                tBox_EXEPath.Text = files.First();
                m_XOPS = new XOperations(tBox_EXEPath.Text);
                m_IsReadProcess = false;
                SetControlValue();
                SetWeaponControlValue();
                SetCharacterControlValue();
                SetSmallObjectControlValue();
                m_LoadSuccess = true;
            }
        }
    }
}
