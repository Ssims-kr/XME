namespace XME
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabCtrl_Main = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Setting = new MetroFramework.Controls.MetroTabPage();
            this.gBox_Program = new System.Windows.Forms.GroupBox();
            this.toggle_AutoApply = new MetroFramework.Controls.MetroToggle();
            this.lbl_AutoApply = new MetroFramework.Controls.MetroLabel();
            this.cBox_Style = new MetroFramework.Controls.MetroComboBox();
            this.lbl_Style = new MetroFramework.Controls.MetroLabel();
            this.toggle_DarkMode = new MetroFramework.Controls.MetroToggle();
            this.lbl_DarkMode = new MetroFramework.Controls.MetroLabel();
            this.gBox_Game = new System.Windows.Forms.GroupBox();
            this.lbl_FOVPSG1 = new MetroFramework.Controls.MetroLabel();
            this.tBox_FOVPSG1 = new MetroFramework.Controls.MetroTextBox();
            this.lbl_FOVAUG = new MetroFramework.Controls.MetroLabel();
            this.tBox_FOVAUG = new MetroFramework.Controls.MetroTextBox();
            this.lbl_FOVNormal = new MetroFramework.Controls.MetroLabel();
            this.tBox_FOVNormal = new MetroFramework.Controls.MetroTextBox();
            this.lbl_ClippingNearFar = new MetroFramework.Controls.MetroLabel();
            this.tBox_ClippingPlaneFar = new MetroFramework.Controls.MetroTextBox();
            this.lbl_ClippingPlaneNear = new MetroFramework.Controls.MetroLabel();
            this.tBox_ClippingPlaneNear = new MetroFramework.Controls.MetroTextBox();
            this.lbl_AutoDepthStencilFormat = new MetroFramework.Controls.MetroLabel();
            this.cBox_AutoDepthStencilFormat = new MetroFramework.Controls.MetroComboBox();
            this.tBox_GameVersion = new MetroFramework.Controls.MetroTextBox();
            this.lbl_GameVersion = new MetroFramework.Controls.MetroLabel();
            this.lbl_GameName = new MetroFramework.Controls.MetroLabel();
            this.tBox_GameName = new MetroFramework.Controls.MetroTextBox();
            this.tBox_EXEPath = new MetroFramework.Controls.MetroTextBox();
            this.tabPage_Weapon = new MetroFramework.Controls.MetroTabPage();
            this.tBox_WeaponVelocity2 = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponReloadTime2 = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponSpeed2 = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponAccuracyMax = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponAccuracyMin = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponReloadTime = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponVelocity = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponNameLength = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponName = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponShellMovementPositionY = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponShellMovementPositionX = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponShellMovementPosition = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponShellPositionZ = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponShellPositionY = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponShellPositionX = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponShellPosition = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponMFlashPositionZ = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponMFlashPositionY = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponMFlashPositionX = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponMFlashPosition = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponPositionZ = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponPositionY = new MetroFramework.Controls.MetroTextBox();
            this.tBox_WeaponPositionX = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponPosition = new MetroFramework.Controls.MetroButton();
            this.toggle_WeaponSilencer = new MetroFramework.Controls.MetroToggle();
            this.btn_WeaponSilencer = new MetroFramework.Controls.MetroButton();
            this.tBar_WeaponSoundVolume = new MetroFramework.Controls.MetroTrackBar();
            this.btn_WeaponSoundVolume = new MetroFramework.Controls.MetroButton();
            this.cBox_WeaponSoundID = new MetroFramework.Controls.MetroComboBox();
            this.btn_WeaponSoundID = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponSize = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponSize = new MetroFramework.Controls.MetroButton();
            this.cBox_WeaponModel = new MetroFramework.Controls.MetroComboBox();
            this.btn_WeaponModel = new MetroFramework.Controls.MetroButton();
            this.cBox_WeaponTexture = new MetroFramework.Controls.MetroComboBox();
            this.btn_WeaponTexture = new MetroFramework.Controls.MetroButton();
            this.cBox_WeaponScopeMode = new MetroFramework.Controls.MetroComboBox();
            this.btn_WeaponScopeMode = new MetroFramework.Controls.MetroButton();
            this.cBox_WeaponFireMode = new MetroFramework.Controls.MetroComboBox();
            this.btn_FireMode = new MetroFramework.Controls.MetroButton();
            this.cBox_WeaponArms = new MetroFramework.Controls.MetroComboBox();
            this.btn_WeaponArms = new MetroFramework.Controls.MetroButton();
            this.btn_WeaponAccuracy = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponReaction = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponReaction = new MetroFramework.Controls.MetroButton();
            this.btn_WeaponReloadTime = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponAmmo = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponAmmo = new MetroFramework.Controls.MetroButton();
            this.btn_WeaponVelocity = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponSpeed = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponSpeed = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponPenetration = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponPenetration = new MetroFramework.Controls.MetroButton();
            this.tBox_WeaponDamage = new MetroFramework.Controls.MetroTextBox();
            this.btn_WeaponDamage = new MetroFramework.Controls.MetroButton();
            this.pBox_WeaponImage = new System.Windows.Forms.PictureBox();
            this.lBox_WeaponList = new System.Windows.Forms.ListBox();
            this.tabPage_Character = new MetroFramework.Controls.MetroTabPage();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.cBox_CharacterAILevel = new MetroFramework.Controls.MetroComboBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pBox_CharacterTexture = new System.Windows.Forms.PictureBox();
            this.cBox_CharacterType = new MetroFramework.Controls.MetroComboBox();
            this.cBox_CharacterSecondaryWeapon = new MetroFramework.Controls.MetroComboBox();
            this.cBox_CharacterPrimaryWeapon = new MetroFramework.Controls.MetroComboBox();
            this.tBox_CharacterHP = new MetroFramework.Controls.MetroTextBox();
            this.cBox_CharacterModel = new MetroFramework.Controls.MetroComboBox();
            this.cBox_CharacterTexture = new MetroFramework.Controls.MetroComboBox();
            this.lBox_CharacterList = new System.Windows.Forms.ListBox();
            this.tabPage_SmallObject = new MetroFramework.Controls.MetroTabPage();
            this.metroButton13 = new MetroFramework.Controls.MetroButton();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.pBox_SmallObjectTexture = new System.Windows.Forms.PictureBox();
            this.tBox_SmallObjectHP = new MetroFramework.Controls.MetroTextBox();
            this.tBox_SmallObjectCollisionRange = new MetroFramework.Controls.MetroTextBox();
            this.cBox_SmallObjectSound = new MetroFramework.Controls.MetroComboBox();
            this.tBox_SmallObjectJump = new MetroFramework.Controls.MetroTextBox();
            this.cBox_SmallObjectModel = new MetroFramework.Controls.MetroComboBox();
            this.cBox_SmallObjectTexture = new MetroFramework.Controls.MetroComboBox();
            this.lbox_SmallObjectList = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.metroContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로세스찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabCtrl_Main.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            this.gBox_Program.SuspendLayout();
            this.gBox_Game.SuspendLayout();
            this.tabPage_Weapon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_WeaponImage)).BeginInit();
            this.tabPage_Character.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CharacterTexture)).BeginInit();
            this.tabPage_SmallObject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_SmallObjectTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl_Main
            // 
            this.tabCtrl_Main.Controls.Add(this.tabPage_Setting);
            this.tabCtrl_Main.Controls.Add(this.tabPage_Weapon);
            this.tabCtrl_Main.Controls.Add(this.tabPage_Character);
            this.tabCtrl_Main.Controls.Add(this.tabPage_SmallObject);
            this.tabCtrl_Main.Location = new System.Drawing.Point(23, 63);
            this.tabCtrl_Main.Multiline = true;
            this.tabCtrl_Main.Name = "tabCtrl_Main";
            this.tabCtrl_Main.SelectedIndex = 3;
            this.tabCtrl_Main.Size = new System.Drawing.Size(1154, 514);
            this.tabCtrl_Main.TabIndex = 0;
            this.tabCtrl_Main.UseSelectable = true;
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.Controls.Add(this.gBox_Program);
            this.tabPage_Setting.Controls.Add(this.gBox_Game);
            this.tabPage_Setting.Controls.Add(this.tBox_EXEPath);
            this.tabPage_Setting.HorizontalScrollbarBarColor = true;
            this.tabPage_Setting.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage_Setting.HorizontalScrollbarSize = 10;
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Size = new System.Drawing.Size(1146, 472);
            this.tabPage_Setting.TabIndex = 0;
            this.tabPage_Setting.Text = "설정";
            this.tabPage_Setting.VerticalScrollbarBarColor = true;
            this.tabPage_Setting.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage_Setting.VerticalScrollbarSize = 10;
            // 
            // gBox_Program
            // 
            this.gBox_Program.BackColor = System.Drawing.Color.Transparent;
            this.gBox_Program.Controls.Add(this.toggle_AutoApply);
            this.gBox_Program.Controls.Add(this.lbl_AutoApply);
            this.gBox_Program.Controls.Add(this.cBox_Style);
            this.gBox_Program.Controls.Add(this.lbl_Style);
            this.gBox_Program.Controls.Add(this.toggle_DarkMode);
            this.gBox_Program.Controls.Add(this.lbl_DarkMode);
            this.gBox_Program.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gBox_Program.Location = new System.Drawing.Point(346, 45);
            this.gBox_Program.Name = "gBox_Program";
            this.gBox_Program.Size = new System.Drawing.Size(800, 424);
            this.gBox_Program.TabIndex = 10;
            this.gBox_Program.TabStop = false;
            this.gBox_Program.Text = "프로그램 설정";
            // 
            // toggle_AutoApply
            // 
            this.toggle_AutoApply.Location = new System.Drawing.Point(162, 87);
            this.toggle_AutoApply.Name = "toggle_AutoApply";
            this.toggle_AutoApply.Size = new System.Drawing.Size(100, 29);
            this.toggle_AutoApply.TabIndex = 31;
            this.toggle_AutoApply.TabStop = false;
            this.toggle_AutoApply.Text = "Off";
            this.metroToolTip.SetToolTip(this.toggle_AutoApply, "데이터 변경 시 프로세스 메모리에 자동으로 반영되도록 합니다.");
            this.toggle_AutoApply.UseSelectable = true;
            // 
            // lbl_AutoApply
            // 
            this.lbl_AutoApply.Location = new System.Drawing.Point(6, 87);
            this.lbl_AutoApply.Name = "lbl_AutoApply";
            this.lbl_AutoApply.Size = new System.Drawing.Size(150, 29);
            this.lbl_AutoApply.TabIndex = 30;
            this.lbl_AutoApply.Text = "프로세스 자동 적용";
            this.lbl_AutoApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBox_Style
            // 
            this.cBox_Style.FormattingEnabled = true;
            this.cBox_Style.ItemHeight = 23;
            this.cBox_Style.Items.AddRange(new object[] {
            "BLACK",
            "WHITE",
            "SILVER",
            "BLUE",
            "GREEN",
            "LIME",
            "TEAL",
            "ORANE",
            "BROWN",
            "PINK",
            "MAGENTA",
            "PURPLE",
            "RED",
            "YELLOW"});
            this.cBox_Style.Location = new System.Drawing.Point(162, 52);
            this.cBox_Style.Name = "cBox_Style";
            this.cBox_Style.Size = new System.Drawing.Size(100, 29);
            this.cBox_Style.TabIndex = 29;
            this.cBox_Style.TabStop = false;
            this.metroToolTip.SetToolTip(this.cBox_Style, "프로그램의 스타일을 설정합니다.");
            this.cBox_Style.UseSelectable = true;
            this.cBox_Style.SelectedIndexChanged += new System.EventHandler(this.cBox_Style_SelectedIndexChanged);
            // 
            // lbl_Style
            // 
            this.lbl_Style.Location = new System.Drawing.Point(6, 52);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(150, 29);
            this.lbl_Style.TabIndex = 28;
            this.lbl_Style.Text = "스타일";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toggle_DarkMode
            // 
            this.toggle_DarkMode.Location = new System.Drawing.Point(162, 17);
            this.toggle_DarkMode.Name = "toggle_DarkMode";
            this.toggle_DarkMode.Size = new System.Drawing.Size(100, 29);
            this.toggle_DarkMode.TabIndex = 27;
            this.toggle_DarkMode.TabStop = false;
            this.toggle_DarkMode.Text = "Off";
            this.metroToolTip.SetToolTip(this.toggle_DarkMode, "프로그램의 테마를 변경합니다.");
            this.toggle_DarkMode.UseSelectable = true;
            this.toggle_DarkMode.CheckedChanged += new System.EventHandler(this.toggle_DarkMode_CheckedChanged);
            // 
            // lbl_DarkMode
            // 
            this.lbl_DarkMode.Location = new System.Drawing.Point(6, 17);
            this.lbl_DarkMode.Name = "lbl_DarkMode";
            this.lbl_DarkMode.Size = new System.Drawing.Size(150, 29);
            this.lbl_DarkMode.TabIndex = 26;
            this.lbl_DarkMode.Text = "다크 모드";
            this.lbl_DarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBox_Game
            // 
            this.gBox_Game.BackColor = System.Drawing.Color.Transparent;
            this.gBox_Game.Controls.Add(this.lbl_FOVPSG1);
            this.gBox_Game.Controls.Add(this.tBox_FOVPSG1);
            this.gBox_Game.Controls.Add(this.lbl_FOVAUG);
            this.gBox_Game.Controls.Add(this.tBox_FOVAUG);
            this.gBox_Game.Controls.Add(this.lbl_FOVNormal);
            this.gBox_Game.Controls.Add(this.tBox_FOVNormal);
            this.gBox_Game.Controls.Add(this.lbl_ClippingNearFar);
            this.gBox_Game.Controls.Add(this.tBox_ClippingPlaneFar);
            this.gBox_Game.Controls.Add(this.lbl_ClippingPlaneNear);
            this.gBox_Game.Controls.Add(this.tBox_ClippingPlaneNear);
            this.gBox_Game.Controls.Add(this.lbl_AutoDepthStencilFormat);
            this.gBox_Game.Controls.Add(this.cBox_AutoDepthStencilFormat);
            this.gBox_Game.Controls.Add(this.tBox_GameVersion);
            this.gBox_Game.Controls.Add(this.lbl_GameVersion);
            this.gBox_Game.Controls.Add(this.lbl_GameName);
            this.gBox_Game.Controls.Add(this.tBox_GameName);
            this.gBox_Game.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gBox_Game.Location = new System.Drawing.Point(0, 45);
            this.gBox_Game.Name = "gBox_Game";
            this.gBox_Game.Size = new System.Drawing.Size(340, 424);
            this.gBox_Game.TabIndex = 9;
            this.gBox_Game.TabStop = false;
            this.gBox_Game.Text = "게임 설정";
            // 
            // lbl_FOVPSG1
            // 
            this.lbl_FOVPSG1.Location = new System.Drawing.Point(6, 262);
            this.lbl_FOVPSG1.Name = "lbl_FOVPSG1";
            this.lbl_FOVPSG1.Size = new System.Drawing.Size(150, 29);
            this.lbl_FOVPSG1.TabIndex = 25;
            this.lbl_FOVPSG1.Text = "PSG1 확대율";
            this.lbl_FOVPSG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_FOVPSG1
            // 
            // 
            // 
            // 
            this.tBox_FOVPSG1.CustomButton.Image = null;
            this.tBox_FOVPSG1.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tBox_FOVPSG1.CustomButton.Name = "";
            this.tBox_FOVPSG1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_FOVPSG1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_FOVPSG1.CustomButton.TabIndex = 1;
            this.tBox_FOVPSG1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_FOVPSG1.CustomButton.UseSelectable = true;
            this.tBox_FOVPSG1.CustomButton.Visible = false;
            this.tBox_FOVPSG1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_FOVPSG1.Lines = new string[0];
            this.tBox_FOVPSG1.Location = new System.Drawing.Point(162, 262);
            this.tBox_FOVPSG1.MaxLength = 32767;
            this.tBox_FOVPSG1.Name = "tBox_FOVPSG1";
            this.tBox_FOVPSG1.PasswordChar = '\0';
            this.tBox_FOVPSG1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_FOVPSG1.SelectedText = "";
            this.tBox_FOVPSG1.SelectionLength = 0;
            this.tBox_FOVPSG1.SelectionStart = 0;
            this.tBox_FOVPSG1.ShortcutsEnabled = true;
            this.tBox_FOVPSG1.Size = new System.Drawing.Size(150, 29);
            this.tBox_FOVPSG1.TabIndex = 24;
            this.tBox_FOVPSG1.TabStop = false;
            this.tBox_FOVPSG1.Tag = "FOVPSG1";
            this.tBox_FOVPSG1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_FOVPSG1, "PSG1의 확대율을 설정합니다.");
            this.tBox_FOVPSG1.UseSelectable = true;
            this.tBox_FOVPSG1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_FOVPSG1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_FOVPSG1.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // lbl_FOVAUG
            // 
            this.lbl_FOVAUG.Location = new System.Drawing.Point(6, 227);
            this.lbl_FOVAUG.Name = "lbl_FOVAUG";
            this.lbl_FOVAUG.Size = new System.Drawing.Size(150, 29);
            this.lbl_FOVAUG.TabIndex = 23;
            this.lbl_FOVAUG.Text = "AUG 확대율";
            this.lbl_FOVAUG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_FOVAUG
            // 
            // 
            // 
            // 
            this.tBox_FOVAUG.CustomButton.Image = null;
            this.tBox_FOVAUG.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tBox_FOVAUG.CustomButton.Name = "";
            this.tBox_FOVAUG.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_FOVAUG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_FOVAUG.CustomButton.TabIndex = 1;
            this.tBox_FOVAUG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_FOVAUG.CustomButton.UseSelectable = true;
            this.tBox_FOVAUG.CustomButton.Visible = false;
            this.tBox_FOVAUG.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_FOVAUG.Lines = new string[0];
            this.tBox_FOVAUG.Location = new System.Drawing.Point(162, 227);
            this.tBox_FOVAUG.MaxLength = 32767;
            this.tBox_FOVAUG.Name = "tBox_FOVAUG";
            this.tBox_FOVAUG.PasswordChar = '\0';
            this.tBox_FOVAUG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_FOVAUG.SelectedText = "";
            this.tBox_FOVAUG.SelectionLength = 0;
            this.tBox_FOVAUG.SelectionStart = 0;
            this.tBox_FOVAUG.ShortcutsEnabled = true;
            this.tBox_FOVAUG.Size = new System.Drawing.Size(150, 29);
            this.tBox_FOVAUG.TabIndex = 22;
            this.tBox_FOVAUG.TabStop = false;
            this.tBox_FOVAUG.Tag = "FOVAUG";
            this.tBox_FOVAUG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_FOVAUG, "AUG의 확대율을 설정합니다.");
            this.tBox_FOVAUG.UseSelectable = true;
            this.tBox_FOVAUG.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_FOVAUG.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_FOVAUG.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // lbl_FOVNormal
            // 
            this.lbl_FOVNormal.Location = new System.Drawing.Point(6, 192);
            this.lbl_FOVNormal.Name = "lbl_FOVNormal";
            this.lbl_FOVNormal.Size = new System.Drawing.Size(150, 29);
            this.lbl_FOVNormal.TabIndex = 21;
            this.lbl_FOVNormal.Text = "일반 시야각";
            this.lbl_FOVNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_FOVNormal
            // 
            // 
            // 
            // 
            this.tBox_FOVNormal.CustomButton.Image = null;
            this.tBox_FOVNormal.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tBox_FOVNormal.CustomButton.Name = "";
            this.tBox_FOVNormal.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_FOVNormal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_FOVNormal.CustomButton.TabIndex = 1;
            this.tBox_FOVNormal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_FOVNormal.CustomButton.UseSelectable = true;
            this.tBox_FOVNormal.CustomButton.Visible = false;
            this.tBox_FOVNormal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_FOVNormal.Lines = new string[0];
            this.tBox_FOVNormal.Location = new System.Drawing.Point(162, 192);
            this.tBox_FOVNormal.MaxLength = 32767;
            this.tBox_FOVNormal.Name = "tBox_FOVNormal";
            this.tBox_FOVNormal.PasswordChar = '\0';
            this.tBox_FOVNormal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_FOVNormal.SelectedText = "";
            this.tBox_FOVNormal.SelectionLength = 0;
            this.tBox_FOVNormal.SelectionStart = 0;
            this.tBox_FOVNormal.ShortcutsEnabled = true;
            this.tBox_FOVNormal.Size = new System.Drawing.Size(150, 29);
            this.tBox_FOVNormal.TabIndex = 20;
            this.tBox_FOVNormal.TabStop = false;
            this.tBox_FOVNormal.Tag = "FOVNormal";
            this.tBox_FOVNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_FOVNormal, "일반 시야각을 설정합니다.");
            this.tBox_FOVNormal.UseSelectable = true;
            this.tBox_FOVNormal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_FOVNormal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_FOVNormal.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // lbl_ClippingNearFar
            // 
            this.lbl_ClippingNearFar.Location = new System.Drawing.Point(6, 157);
            this.lbl_ClippingNearFar.Name = "lbl_ClippingNearFar";
            this.lbl_ClippingNearFar.Size = new System.Drawing.Size(150, 29);
            this.lbl_ClippingNearFar.TabIndex = 19;
            this.lbl_ClippingNearFar.Text = "클리핑 평면 장거리";
            this.lbl_ClippingNearFar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_ClippingPlaneFar
            // 
            // 
            // 
            // 
            this.tBox_ClippingPlaneFar.CustomButton.Image = null;
            this.tBox_ClippingPlaneFar.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tBox_ClippingPlaneFar.CustomButton.Name = "";
            this.tBox_ClippingPlaneFar.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_ClippingPlaneFar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_ClippingPlaneFar.CustomButton.TabIndex = 1;
            this.tBox_ClippingPlaneFar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_ClippingPlaneFar.CustomButton.UseSelectable = true;
            this.tBox_ClippingPlaneFar.CustomButton.Visible = false;
            this.tBox_ClippingPlaneFar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_ClippingPlaneFar.Lines = new string[0];
            this.tBox_ClippingPlaneFar.Location = new System.Drawing.Point(162, 157);
            this.tBox_ClippingPlaneFar.MaxLength = 32767;
            this.tBox_ClippingPlaneFar.Name = "tBox_ClippingPlaneFar";
            this.tBox_ClippingPlaneFar.PasswordChar = '\0';
            this.tBox_ClippingPlaneFar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_ClippingPlaneFar.SelectedText = "";
            this.tBox_ClippingPlaneFar.SelectionLength = 0;
            this.tBox_ClippingPlaneFar.SelectionStart = 0;
            this.tBox_ClippingPlaneFar.ShortcutsEnabled = true;
            this.tBox_ClippingPlaneFar.Size = new System.Drawing.Size(150, 29);
            this.tBox_ClippingPlaneFar.TabIndex = 18;
            this.tBox_ClippingPlaneFar.TabStop = false;
            this.tBox_ClippingPlaneFar.Tag = "ClippingPlaneFar";
            this.tBox_ClippingPlaneFar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_ClippingPlaneFar, "클리핑 평면 장거리의 값을 설정합니다.");
            this.tBox_ClippingPlaneFar.UseSelectable = true;
            this.tBox_ClippingPlaneFar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_ClippingPlaneFar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_ClippingPlaneFar.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // lbl_ClippingPlaneNear
            // 
            this.lbl_ClippingPlaneNear.Location = new System.Drawing.Point(6, 122);
            this.lbl_ClippingPlaneNear.Name = "lbl_ClippingPlaneNear";
            this.lbl_ClippingPlaneNear.Size = new System.Drawing.Size(150, 29);
            this.lbl_ClippingPlaneNear.TabIndex = 17;
            this.lbl_ClippingPlaneNear.Text = "클리핑 평면 단거리";
            this.lbl_ClippingPlaneNear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_ClippingPlaneNear
            // 
            // 
            // 
            // 
            this.tBox_ClippingPlaneNear.CustomButton.Image = null;
            this.tBox_ClippingPlaneNear.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tBox_ClippingPlaneNear.CustomButton.Name = "";
            this.tBox_ClippingPlaneNear.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_ClippingPlaneNear.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_ClippingPlaneNear.CustomButton.TabIndex = 1;
            this.tBox_ClippingPlaneNear.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_ClippingPlaneNear.CustomButton.UseSelectable = true;
            this.tBox_ClippingPlaneNear.CustomButton.Visible = false;
            this.tBox_ClippingPlaneNear.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_ClippingPlaneNear.Lines = new string[0];
            this.tBox_ClippingPlaneNear.Location = new System.Drawing.Point(162, 122);
            this.tBox_ClippingPlaneNear.MaxLength = 32767;
            this.tBox_ClippingPlaneNear.Name = "tBox_ClippingPlaneNear";
            this.tBox_ClippingPlaneNear.PasswordChar = '\0';
            this.tBox_ClippingPlaneNear.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_ClippingPlaneNear.SelectedText = "";
            this.tBox_ClippingPlaneNear.SelectionLength = 0;
            this.tBox_ClippingPlaneNear.SelectionStart = 0;
            this.tBox_ClippingPlaneNear.ShortcutsEnabled = true;
            this.tBox_ClippingPlaneNear.Size = new System.Drawing.Size(150, 29);
            this.tBox_ClippingPlaneNear.TabIndex = 16;
            this.tBox_ClippingPlaneNear.TabStop = false;
            this.tBox_ClippingPlaneNear.Tag = "ClippingPlaneNear";
            this.tBox_ClippingPlaneNear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_ClippingPlaneNear, "클리핑 평면 단거리의 값을 설정합니다.");
            this.tBox_ClippingPlaneNear.UseSelectable = true;
            this.tBox_ClippingPlaneNear.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_ClippingPlaneNear.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_ClippingPlaneNear.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // lbl_AutoDepthStencilFormat
            // 
            this.lbl_AutoDepthStencilFormat.Location = new System.Drawing.Point(6, 87);
            this.lbl_AutoDepthStencilFormat.Name = "lbl_AutoDepthStencilFormat";
            this.lbl_AutoDepthStencilFormat.Size = new System.Drawing.Size(150, 29);
            this.lbl_AutoDepthStencilFormat.TabIndex = 15;
            this.lbl_AutoDepthStencilFormat.Text = "깊이 스텐실 포맷";
            this.lbl_AutoDepthStencilFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBox_AutoDepthStencilFormat
            // 
            this.cBox_AutoDepthStencilFormat.FormattingEnabled = true;
            this.cBox_AutoDepthStencilFormat.ItemHeight = 23;
            this.cBox_AutoDepthStencilFormat.Location = new System.Drawing.Point(162, 87);
            this.cBox_AutoDepthStencilFormat.Name = "cBox_AutoDepthStencilFormat";
            this.cBox_AutoDepthStencilFormat.Size = new System.Drawing.Size(150, 29);
            this.cBox_AutoDepthStencilFormat.TabIndex = 14;
            this.cBox_AutoDepthStencilFormat.TabStop = false;
            this.cBox_AutoDepthStencilFormat.Tag = "AutoDepthStencilFormat";
            this.metroToolTip.SetToolTip(this.cBox_AutoDepthStencilFormat, "깊이 스텐실 버퍼 포맷을 설정합니다.");
            this.cBox_AutoDepthStencilFormat.UseSelectable = true;
            this.cBox_AutoDepthStencilFormat.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // tBox_GameVersion
            // 
            // 
            // 
            // 
            this.tBox_GameVersion.CustomButton.Image = null;
            this.tBox_GameVersion.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tBox_GameVersion.CustomButton.Name = "";
            this.tBox_GameVersion.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_GameVersion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_GameVersion.CustomButton.TabIndex = 1;
            this.tBox_GameVersion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_GameVersion.CustomButton.UseSelectable = true;
            this.tBox_GameVersion.CustomButton.Visible = false;
            this.tBox_GameVersion.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_GameVersion.Lines = new string[0];
            this.tBox_GameVersion.Location = new System.Drawing.Point(162, 52);
            this.tBox_GameVersion.MaxLength = 32767;
            this.tBox_GameVersion.Name = "tBox_GameVersion";
            this.tBox_GameVersion.PasswordChar = '\0';
            this.tBox_GameVersion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_GameVersion.SelectedText = "";
            this.tBox_GameVersion.SelectionLength = 0;
            this.tBox_GameVersion.SelectionStart = 0;
            this.tBox_GameVersion.ShortcutsEnabled = true;
            this.tBox_GameVersion.Size = new System.Drawing.Size(150, 29);
            this.tBox_GameVersion.TabIndex = 12;
            this.tBox_GameVersion.TabStop = false;
            this.tBox_GameVersion.Tag = "GameVersion";
            this.tBox_GameVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_GameVersion, "게임의 버전입니다.");
            this.tBox_GameVersion.UseSelectable = true;
            this.tBox_GameVersion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_GameVersion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_GameVersion.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // lbl_GameVersion
            // 
            this.lbl_GameVersion.Location = new System.Drawing.Point(6, 52);
            this.lbl_GameVersion.Name = "lbl_GameVersion";
            this.lbl_GameVersion.Size = new System.Drawing.Size(150, 29);
            this.lbl_GameVersion.TabIndex = 13;
            this.lbl_GameVersion.Text = "게임 버전";
            this.lbl_GameVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GameName
            // 
            this.lbl_GameName.Location = new System.Drawing.Point(6, 17);
            this.lbl_GameName.Name = "lbl_GameName";
            this.lbl_GameName.Size = new System.Drawing.Size(150, 29);
            this.lbl_GameName.TabIndex = 11;
            this.lbl_GameName.Text = "게임 이름";
            this.lbl_GameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBox_GameName
            // 
            // 
            // 
            // 
            this.tBox_GameName.CustomButton.Image = null;
            this.tBox_GameName.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tBox_GameName.CustomButton.Name = "";
            this.tBox_GameName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_GameName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_GameName.CustomButton.TabIndex = 1;
            this.tBox_GameName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_GameName.CustomButton.UseSelectable = true;
            this.tBox_GameName.CustomButton.Visible = false;
            this.tBox_GameName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_GameName.Lines = new string[0];
            this.tBox_GameName.Location = new System.Drawing.Point(162, 17);
            this.tBox_GameName.MaxLength = 32767;
            this.tBox_GameName.Name = "tBox_GameName";
            this.tBox_GameName.PasswordChar = '\0';
            this.tBox_GameName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_GameName.SelectedText = "";
            this.tBox_GameName.SelectionLength = 0;
            this.tBox_GameName.SelectionStart = 0;
            this.tBox_GameName.ShortcutsEnabled = true;
            this.tBox_GameName.Size = new System.Drawing.Size(150, 29);
            this.tBox_GameName.TabIndex = 10;
            this.tBox_GameName.TabStop = false;
            this.tBox_GameName.Tag = "GameName";
            this.tBox_GameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_GameName, "게임의 이름입니다.");
            this.tBox_GameName.UseSelectable = true;
            this.tBox_GameName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_GameName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_GameName.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_EXEPath
            // 
            // 
            // 
            // 
            this.tBox_EXEPath.CustomButton.Image = null;
            this.tBox_EXEPath.CustomButton.Location = new System.Drawing.Point(1118, 1);
            this.tBox_EXEPath.CustomButton.Name = "";
            this.tBox_EXEPath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_EXEPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_EXEPath.CustomButton.TabIndex = 1;
            this.tBox_EXEPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_EXEPath.CustomButton.UseSelectable = true;
            this.tBox_EXEPath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_EXEPath.Lines = new string[0];
            this.tBox_EXEPath.Location = new System.Drawing.Point(0, 13);
            this.tBox_EXEPath.MaxLength = 32767;
            this.tBox_EXEPath.Name = "tBox_EXEPath";
            this.tBox_EXEPath.PasswordChar = '\0';
            this.tBox_EXEPath.ReadOnly = true;
            this.tBox_EXEPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_EXEPath.SelectedText = "";
            this.tBox_EXEPath.SelectionLength = 0;
            this.tBox_EXEPath.SelectionStart = 0;
            this.tBox_EXEPath.ShortcutsEnabled = true;
            this.tBox_EXEPath.ShowButton = true;
            this.tBox_EXEPath.Size = new System.Drawing.Size(1146, 29);
            this.tBox_EXEPath.TabIndex = 2;
            this.tBox_EXEPath.TabStop = false;
            this.metroToolTip.SetToolTip(this.tBox_EXEPath, "X Operations 실행 파일의 경로입니다.");
            this.tBox_EXEPath.UseSelectable = true;
            this.tBox_EXEPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_EXEPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_EXEPath.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.tBox_EXEPath_ButtonClick);
            // 
            // tabPage_Weapon
            // 
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponVelocity2);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponReloadTime2);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponSpeed2);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponAccuracyMax);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponAccuracyMin);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponReloadTime);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponVelocity);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponNameLength);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponName);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponShellMovementPositionY);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponShellMovementPositionX);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponShellMovementPosition);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponShellPositionZ);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponShellPositionY);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponShellPositionX);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponShellPosition);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponMFlashPositionZ);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponMFlashPositionY);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponMFlashPositionX);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponMFlashPosition);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponPositionZ);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponPositionY);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponPositionX);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponPosition);
            this.tabPage_Weapon.Controls.Add(this.toggle_WeaponSilencer);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponSilencer);
            this.tabPage_Weapon.Controls.Add(this.tBar_WeaponSoundVolume);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponSoundVolume);
            this.tabPage_Weapon.Controls.Add(this.cBox_WeaponSoundID);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponSoundID);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponSize);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponSize);
            this.tabPage_Weapon.Controls.Add(this.cBox_WeaponModel);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponModel);
            this.tabPage_Weapon.Controls.Add(this.cBox_WeaponTexture);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponTexture);
            this.tabPage_Weapon.Controls.Add(this.cBox_WeaponScopeMode);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponScopeMode);
            this.tabPage_Weapon.Controls.Add(this.cBox_WeaponFireMode);
            this.tabPage_Weapon.Controls.Add(this.btn_FireMode);
            this.tabPage_Weapon.Controls.Add(this.cBox_WeaponArms);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponArms);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponAccuracy);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponReaction);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponReaction);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponReloadTime);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponAmmo);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponAmmo);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponVelocity);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponSpeed);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponSpeed);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponPenetration);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponPenetration);
            this.tabPage_Weapon.Controls.Add(this.tBox_WeaponDamage);
            this.tabPage_Weapon.Controls.Add(this.btn_WeaponDamage);
            this.tabPage_Weapon.Controls.Add(this.pBox_WeaponImage);
            this.tabPage_Weapon.Controls.Add(this.lBox_WeaponList);
            this.tabPage_Weapon.HorizontalScrollbarBarColor = true;
            this.tabPage_Weapon.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage_Weapon.HorizontalScrollbarSize = 10;
            this.tabPage_Weapon.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Weapon.Name = "tabPage_Weapon";
            this.tabPage_Weapon.Size = new System.Drawing.Size(1146, 472);
            this.tabPage_Weapon.TabIndex = 1;
            this.tabPage_Weapon.Text = "무기";
            this.tabPage_Weapon.VerticalScrollbarBarColor = true;
            this.tabPage_Weapon.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage_Weapon.VerticalScrollbarSize = 10;
            // 
            // tBox_WeaponVelocity2
            // 
            // 
            // 
            // 
            this.tBox_WeaponVelocity2.CustomButton.Image = null;
            this.tBox_WeaponVelocity2.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.tBox_WeaponVelocity2.CustomButton.Name = "";
            this.tBox_WeaponVelocity2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponVelocity2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponVelocity2.CustomButton.TabIndex = 1;
            this.tBox_WeaponVelocity2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponVelocity2.CustomButton.UseSelectable = true;
            this.tBox_WeaponVelocity2.CustomButton.Visible = false;
            this.tBox_WeaponVelocity2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponVelocity2.Lines = new string[0];
            this.tBox_WeaponVelocity2.Location = new System.Drawing.Point(971, 73);
            this.tBox_WeaponVelocity2.MaxLength = 32767;
            this.tBox_WeaponVelocity2.Name = "tBox_WeaponVelocity2";
            this.tBox_WeaponVelocity2.PasswordChar = '\0';
            this.tBox_WeaponVelocity2.ReadOnly = true;
            this.tBox_WeaponVelocity2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponVelocity2.SelectedText = "";
            this.tBox_WeaponVelocity2.SelectionLength = 0;
            this.tBox_WeaponVelocity2.SelectionStart = 0;
            this.tBox_WeaponVelocity2.ShortcutsEnabled = true;
            this.tBox_WeaponVelocity2.Size = new System.Drawing.Size(45, 29);
            this.tBox_WeaponVelocity2.TabIndex = 121;
            this.tBox_WeaponVelocity2.TabStop = false;
            this.tBox_WeaponVelocity2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponVelocity2.UseSelectable = true;
            this.tBox_WeaponVelocity2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponVelocity2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tBox_WeaponReloadTime2
            // 
            // 
            // 
            // 
            this.tBox_WeaponReloadTime2.CustomButton.Image = null;
            this.tBox_WeaponReloadTime2.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.tBox_WeaponReloadTime2.CustomButton.Name = "";
            this.tBox_WeaponReloadTime2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponReloadTime2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponReloadTime2.CustomButton.TabIndex = 1;
            this.tBox_WeaponReloadTime2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponReloadTime2.CustomButton.UseSelectable = true;
            this.tBox_WeaponReloadTime2.CustomButton.Visible = false;
            this.tBox_WeaponReloadTime2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponReloadTime2.Lines = new string[0];
            this.tBox_WeaponReloadTime2.Location = new System.Drawing.Point(653, 143);
            this.tBox_WeaponReloadTime2.MaxLength = 32767;
            this.tBox_WeaponReloadTime2.Name = "tBox_WeaponReloadTime2";
            this.tBox_WeaponReloadTime2.PasswordChar = '\0';
            this.tBox_WeaponReloadTime2.ReadOnly = true;
            this.tBox_WeaponReloadTime2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponReloadTime2.SelectedText = "";
            this.tBox_WeaponReloadTime2.SelectionLength = 0;
            this.tBox_WeaponReloadTime2.SelectionStart = 0;
            this.tBox_WeaponReloadTime2.ShortcutsEnabled = true;
            this.tBox_WeaponReloadTime2.Size = new System.Drawing.Size(45, 29);
            this.tBox_WeaponReloadTime2.TabIndex = 120;
            this.tBox_WeaponReloadTime2.TabStop = false;
            this.tBox_WeaponReloadTime2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponReloadTime2.UseSelectable = true;
            this.tBox_WeaponReloadTime2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponReloadTime2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tBox_WeaponSpeed2
            // 
            // 
            // 
            // 
            this.tBox_WeaponSpeed2.CustomButton.Image = null;
            this.tBox_WeaponSpeed2.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.tBox_WeaponSpeed2.CustomButton.Name = "";
            this.tBox_WeaponSpeed2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponSpeed2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponSpeed2.CustomButton.TabIndex = 1;
            this.tBox_WeaponSpeed2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponSpeed2.CustomButton.UseSelectable = true;
            this.tBox_WeaponSpeed2.CustomButton.Visible = false;
            this.tBox_WeaponSpeed2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponSpeed2.Lines = new string[0];
            this.tBox_WeaponSpeed2.Location = new System.Drawing.Point(865, 73);
            this.tBox_WeaponSpeed2.MaxLength = 32767;
            this.tBox_WeaponSpeed2.Name = "tBox_WeaponSpeed2";
            this.tBox_WeaponSpeed2.PasswordChar = '\0';
            this.tBox_WeaponSpeed2.ReadOnly = true;
            this.tBox_WeaponSpeed2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponSpeed2.SelectedText = "";
            this.tBox_WeaponSpeed2.SelectionLength = 0;
            this.tBox_WeaponSpeed2.SelectionStart = 0;
            this.tBox_WeaponSpeed2.ShortcutsEnabled = true;
            this.tBox_WeaponSpeed2.Size = new System.Drawing.Size(45, 29);
            this.tBox_WeaponSpeed2.TabIndex = 119;
            this.tBox_WeaponSpeed2.TabStop = false;
            this.tBox_WeaponSpeed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponSpeed2.UseSelectable = true;
            this.tBox_WeaponSpeed2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponSpeed2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tBox_WeaponAccuracyMax
            // 
            // 
            // 
            // 
            this.tBox_WeaponAccuracyMax.CustomButton.Image = null;
            this.tBox_WeaponAccuracyMax.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.tBox_WeaponAccuracyMax.CustomButton.Name = "";
            this.tBox_WeaponAccuracyMax.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponAccuracyMax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponAccuracyMax.CustomButton.TabIndex = 1;
            this.tBox_WeaponAccuracyMax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponAccuracyMax.CustomButton.UseSelectable = true;
            this.tBox_WeaponAccuracyMax.CustomButton.Visible = false;
            this.tBox_WeaponAccuracyMax.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponAccuracyMax.Lines = new string[0];
            this.tBox_WeaponAccuracyMax.Location = new System.Drawing.Point(865, 143);
            this.tBox_WeaponAccuracyMax.MaxLength = 32767;
            this.tBox_WeaponAccuracyMax.Name = "tBox_WeaponAccuracyMax";
            this.tBox_WeaponAccuracyMax.PasswordChar = '\0';
            this.tBox_WeaponAccuracyMax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponAccuracyMax.SelectedText = "";
            this.tBox_WeaponAccuracyMax.SelectionLength = 0;
            this.tBox_WeaponAccuracyMax.SelectionStart = 0;
            this.tBox_WeaponAccuracyMax.ShortcutsEnabled = true;
            this.tBox_WeaponAccuracyMax.Size = new System.Drawing.Size(45, 29);
            this.tBox_WeaponAccuracyMax.TabIndex = 118;
            this.tBox_WeaponAccuracyMax.Tag = "WeaponAccuracyMax";
            this.tBox_WeaponAccuracyMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponAccuracyMax.UseSelectable = true;
            this.tBox_WeaponAccuracyMax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponAccuracyMax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponAccuracyMax.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponAccuracyMin
            // 
            // 
            // 
            // 
            this.tBox_WeaponAccuracyMin.CustomButton.Image = null;
            this.tBox_WeaponAccuracyMin.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.tBox_WeaponAccuracyMin.CustomButton.Name = "";
            this.tBox_WeaponAccuracyMin.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponAccuracyMin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponAccuracyMin.CustomButton.TabIndex = 1;
            this.tBox_WeaponAccuracyMin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponAccuracyMin.CustomButton.UseSelectable = true;
            this.tBox_WeaponAccuracyMin.CustomButton.Visible = false;
            this.tBox_WeaponAccuracyMin.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponAccuracyMin.Lines = new string[0];
            this.tBox_WeaponAccuracyMin.Location = new System.Drawing.Point(810, 143);
            this.tBox_WeaponAccuracyMin.MaxLength = 32767;
            this.tBox_WeaponAccuracyMin.Name = "tBox_WeaponAccuracyMin";
            this.tBox_WeaponAccuracyMin.PasswordChar = '\0';
            this.tBox_WeaponAccuracyMin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponAccuracyMin.SelectedText = "";
            this.tBox_WeaponAccuracyMin.SelectionLength = 0;
            this.tBox_WeaponAccuracyMin.SelectionStart = 0;
            this.tBox_WeaponAccuracyMin.ShortcutsEnabled = true;
            this.tBox_WeaponAccuracyMin.Size = new System.Drawing.Size(45, 29);
            this.tBox_WeaponAccuracyMin.TabIndex = 117;
            this.tBox_WeaponAccuracyMin.TabStop = false;
            this.tBox_WeaponAccuracyMin.Tag = "WeaponAccuracyMin";
            this.tBox_WeaponAccuracyMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponAccuracyMin.UseSelectable = true;
            this.tBox_WeaponAccuracyMin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponAccuracyMin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponAccuracyMin.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponReloadTime
            // 
            // 
            // 
            // 
            this.tBox_WeaponReloadTime.CustomButton.Image = null;
            this.tBox_WeaponReloadTime.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.tBox_WeaponReloadTime.CustomButton.Name = "";
            this.tBox_WeaponReloadTime.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponReloadTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponReloadTime.CustomButton.TabIndex = 1;
            this.tBox_WeaponReloadTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponReloadTime.CustomButton.UseSelectable = true;
            this.tBox_WeaponReloadTime.CustomButton.Visible = false;
            this.tBox_WeaponReloadTime.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponReloadTime.Lines = new string[0];
            this.tBox_WeaponReloadTime.Location = new System.Drawing.Point(598, 143);
            this.tBox_WeaponReloadTime.MaxLength = 32767;
            this.tBox_WeaponReloadTime.Name = "tBox_WeaponReloadTime";
            this.tBox_WeaponReloadTime.PasswordChar = '\0';
            this.tBox_WeaponReloadTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponReloadTime.SelectedText = "";
            this.tBox_WeaponReloadTime.SelectionLength = 0;
            this.tBox_WeaponReloadTime.SelectionStart = 0;
            this.tBox_WeaponReloadTime.ShortcutsEnabled = true;
            this.tBox_WeaponReloadTime.Size = new System.Drawing.Size(45, 29);
            this.tBox_WeaponReloadTime.TabIndex = 115;
            this.tBox_WeaponReloadTime.TabStop = false;
            this.tBox_WeaponReloadTime.Tag = "WeaponReloadTime";
            this.tBox_WeaponReloadTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponReloadTime.UseSelectable = true;
            this.tBox_WeaponReloadTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponReloadTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponReloadTime.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponVelocity
            // 
            // 
            // 
            // 
            this.tBox_WeaponVelocity.CustomButton.Image = null;
            this.tBox_WeaponVelocity.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.tBox_WeaponVelocity.CustomButton.Name = "";
            this.tBox_WeaponVelocity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponVelocity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponVelocity.CustomButton.TabIndex = 1;
            this.tBox_WeaponVelocity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponVelocity.CustomButton.UseSelectable = true;
            this.tBox_WeaponVelocity.CustomButton.Visible = false;
            this.tBox_WeaponVelocity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponVelocity.Lines = new string[0];
            this.tBox_WeaponVelocity.Location = new System.Drawing.Point(916, 73);
            this.tBox_WeaponVelocity.MaxLength = 32767;
            this.tBox_WeaponVelocity.Name = "tBox_WeaponVelocity";
            this.tBox_WeaponVelocity.PasswordChar = '\0';
            this.tBox_WeaponVelocity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponVelocity.SelectedText = "";
            this.tBox_WeaponVelocity.SelectionLength = 0;
            this.tBox_WeaponVelocity.SelectionStart = 0;
            this.tBox_WeaponVelocity.ShortcutsEnabled = true;
            this.tBox_WeaponVelocity.Size = new System.Drawing.Size(45, 29);
            this.tBox_WeaponVelocity.TabIndex = 113;
            this.tBox_WeaponVelocity.TabStop = false;
            this.tBox_WeaponVelocity.Tag = "WeaponVelocity";
            this.tBox_WeaponVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponVelocity.UseSelectable = true;
            this.tBox_WeaponVelocity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponVelocity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponVelocity.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponNameLength
            // 
            // 
            // 
            // 
            this.tBox_WeaponNameLength.CustomButton.Image = null;
            this.tBox_WeaponNameLength.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tBox_WeaponNameLength.CustomButton.Name = "";
            this.tBox_WeaponNameLength.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponNameLength.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponNameLength.CustomButton.TabIndex = 1;
            this.tBox_WeaponNameLength.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponNameLength.CustomButton.UseSelectable = true;
            this.tBox_WeaponNameLength.CustomButton.Visible = false;
            this.tBox_WeaponNameLength.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponNameLength.Lines = new string[0];
            this.tBox_WeaponNameLength.Location = new System.Drawing.Point(916, 3);
            this.tBox_WeaponNameLength.MaxLength = 32767;
            this.tBox_WeaponNameLength.Name = "tBox_WeaponNameLength";
            this.tBox_WeaponNameLength.PasswordChar = '\0';
            this.tBox_WeaponNameLength.ReadOnly = true;
            this.tBox_WeaponNameLength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponNameLength.SelectedText = "";
            this.tBox_WeaponNameLength.SelectionLength = 0;
            this.tBox_WeaponNameLength.SelectionStart = 0;
            this.tBox_WeaponNameLength.ShortcutsEnabled = true;
            this.tBox_WeaponNameLength.Size = new System.Drawing.Size(206, 29);
            this.tBox_WeaponNameLength.TabIndex = 111;
            this.tBox_WeaponNameLength.TabStop = false;
            this.tBox_WeaponNameLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponNameLength.UseSelectable = true;
            this.tBox_WeaponNameLength.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponNameLength.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tBox_WeaponName
            // 
            // 
            // 
            // 
            this.tBox_WeaponName.CustomButton.Image = null;
            this.tBox_WeaponName.CustomButton.Location = new System.Drawing.Point(284, 1);
            this.tBox_WeaponName.CustomButton.Name = "";
            this.tBox_WeaponName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponName.CustomButton.TabIndex = 1;
            this.tBox_WeaponName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponName.CustomButton.UseSelectable = true;
            this.tBox_WeaponName.CustomButton.Visible = false;
            this.tBox_WeaponName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponName.Lines = new string[0];
            this.tBox_WeaponName.Location = new System.Drawing.Point(598, 3);
            this.tBox_WeaponName.MaxLength = 15;
            this.tBox_WeaponName.Name = "tBox_WeaponName";
            this.tBox_WeaponName.PasswordChar = '\0';
            this.tBox_WeaponName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponName.SelectedText = "";
            this.tBox_WeaponName.SelectionLength = 0;
            this.tBox_WeaponName.SelectionStart = 0;
            this.tBox_WeaponName.ShortcutsEnabled = true;
            this.tBox_WeaponName.Size = new System.Drawing.Size(312, 29);
            this.tBox_WeaponName.TabIndex = 110;
            this.tBox_WeaponName.TabStop = false;
            this.tBox_WeaponName.Tag = "WeaponName";
            this.tBox_WeaponName.UseSelectable = true;
            this.tBox_WeaponName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponName.TextChanged += new System.EventHandler(this.TextBoxChangedEvent);
            this.tBox_WeaponName.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponShellMovementPositionY
            // 
            // 
            // 
            // 
            this.tBox_WeaponShellMovementPositionY.CustomButton.Image = null;
            this.tBox_WeaponShellMovementPositionY.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponShellMovementPositionY.CustomButton.Name = "";
            this.tBox_WeaponShellMovementPositionY.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponShellMovementPositionY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponShellMovementPositionY.CustomButton.TabIndex = 1;
            this.tBox_WeaponShellMovementPositionY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponShellMovementPositionY.CustomButton.UseSelectable = true;
            this.tBox_WeaponShellMovementPositionY.CustomButton.Visible = false;
            this.tBox_WeaponShellMovementPositionY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponShellMovementPositionY.Lines = new string[0];
            this.tBox_WeaponShellMovementPositionY.Location = new System.Drawing.Point(916, 440);
            this.tBox_WeaponShellMovementPositionY.MaxLength = 32767;
            this.tBox_WeaponShellMovementPositionY.Name = "tBox_WeaponShellMovementPositionY";
            this.tBox_WeaponShellMovementPositionY.PasswordChar = '\0';
            this.tBox_WeaponShellMovementPositionY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponShellMovementPositionY.SelectedText = "";
            this.tBox_WeaponShellMovementPositionY.SelectionLength = 0;
            this.tBox_WeaponShellMovementPositionY.SelectionStart = 0;
            this.tBox_WeaponShellMovementPositionY.ShortcutsEnabled = true;
            this.tBox_WeaponShellMovementPositionY.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponShellMovementPositionY.TabIndex = 108;
            this.tBox_WeaponShellMovementPositionY.TabStop = false;
            this.tBox_WeaponShellMovementPositionY.Tag = "WeaponShellMovementPositionY";
            this.tBox_WeaponShellMovementPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponShellMovementPositionY.UseSelectable = true;
            this.tBox_WeaponShellMovementPositionY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponShellMovementPositionY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponShellMovementPositionY.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponShellMovementPositionX
            // 
            // 
            // 
            // 
            this.tBox_WeaponShellMovementPositionX.CustomButton.Image = null;
            this.tBox_WeaponShellMovementPositionX.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponShellMovementPositionX.CustomButton.Name = "";
            this.tBox_WeaponShellMovementPositionX.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponShellMovementPositionX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponShellMovementPositionX.CustomButton.TabIndex = 1;
            this.tBox_WeaponShellMovementPositionX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponShellMovementPositionX.CustomButton.UseSelectable = true;
            this.tBox_WeaponShellMovementPositionX.CustomButton.Visible = false;
            this.tBox_WeaponShellMovementPositionX.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponShellMovementPositionX.Lines = new string[0];
            this.tBox_WeaponShellMovementPositionX.Location = new System.Drawing.Point(810, 440);
            this.tBox_WeaponShellMovementPositionX.MaxLength = 32767;
            this.tBox_WeaponShellMovementPositionX.Name = "tBox_WeaponShellMovementPositionX";
            this.tBox_WeaponShellMovementPositionX.PasswordChar = '\0';
            this.tBox_WeaponShellMovementPositionX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponShellMovementPositionX.SelectedText = "";
            this.tBox_WeaponShellMovementPositionX.SelectionLength = 0;
            this.tBox_WeaponShellMovementPositionX.SelectionStart = 0;
            this.tBox_WeaponShellMovementPositionX.ShortcutsEnabled = true;
            this.tBox_WeaponShellMovementPositionX.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponShellMovementPositionX.TabIndex = 107;
            this.tBox_WeaponShellMovementPositionX.TabStop = false;
            this.tBox_WeaponShellMovementPositionX.Tag = "WeaponShellMovementPositionX";
            this.tBox_WeaponShellMovementPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponShellMovementPositionX.UseSelectable = true;
            this.tBox_WeaponShellMovementPositionX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponShellMovementPositionX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponShellMovementPositionX.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponShellMovementPosition
            // 
            this.btn_WeaponShellMovementPosition.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponShellMovementPosition.Location = new System.Drawing.Point(598, 440);
            this.btn_WeaponShellMovementPosition.Name = "btn_WeaponShellMovementPosition";
            this.btn_WeaponShellMovementPosition.Size = new System.Drawing.Size(206, 29);
            this.btn_WeaponShellMovementPosition.TabIndex = 106;
            this.btn_WeaponShellMovementPosition.TabStop = false;
            this.btn_WeaponShellMovementPosition.Tag = "WeaponShellMovementPosition";
            this.btn_WeaponShellMovementPosition.Text = "탄피 이동 좌표";
            this.btn_WeaponShellMovementPosition.UseSelectable = true;
            this.btn_WeaponShellMovementPosition.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponShellPositionZ
            // 
            // 
            // 
            // 
            this.tBox_WeaponShellPositionZ.CustomButton.Image = null;
            this.tBox_WeaponShellPositionZ.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponShellPositionZ.CustomButton.Name = "";
            this.tBox_WeaponShellPositionZ.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponShellPositionZ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponShellPositionZ.CustomButton.TabIndex = 1;
            this.tBox_WeaponShellPositionZ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponShellPositionZ.CustomButton.UseSelectable = true;
            this.tBox_WeaponShellPositionZ.CustomButton.Visible = false;
            this.tBox_WeaponShellPositionZ.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponShellPositionZ.Lines = new string[0];
            this.tBox_WeaponShellPositionZ.Location = new System.Drawing.Point(1022, 405);
            this.tBox_WeaponShellPositionZ.MaxLength = 32767;
            this.tBox_WeaponShellPositionZ.Name = "tBox_WeaponShellPositionZ";
            this.tBox_WeaponShellPositionZ.PasswordChar = '\0';
            this.tBox_WeaponShellPositionZ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponShellPositionZ.SelectedText = "";
            this.tBox_WeaponShellPositionZ.SelectionLength = 0;
            this.tBox_WeaponShellPositionZ.SelectionStart = 0;
            this.tBox_WeaponShellPositionZ.ShortcutsEnabled = true;
            this.tBox_WeaponShellPositionZ.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponShellPositionZ.TabIndex = 105;
            this.tBox_WeaponShellPositionZ.TabStop = false;
            this.tBox_WeaponShellPositionZ.Tag = "WeaponShellPositionZ";
            this.tBox_WeaponShellPositionZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponShellPositionZ.UseSelectable = true;
            this.tBox_WeaponShellPositionZ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponShellPositionZ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponShellPositionZ.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponShellPositionY
            // 
            // 
            // 
            // 
            this.tBox_WeaponShellPositionY.CustomButton.Image = null;
            this.tBox_WeaponShellPositionY.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponShellPositionY.CustomButton.Name = "";
            this.tBox_WeaponShellPositionY.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponShellPositionY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponShellPositionY.CustomButton.TabIndex = 1;
            this.tBox_WeaponShellPositionY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponShellPositionY.CustomButton.UseSelectable = true;
            this.tBox_WeaponShellPositionY.CustomButton.Visible = false;
            this.tBox_WeaponShellPositionY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponShellPositionY.Lines = new string[0];
            this.tBox_WeaponShellPositionY.Location = new System.Drawing.Point(916, 405);
            this.tBox_WeaponShellPositionY.MaxLength = 32767;
            this.tBox_WeaponShellPositionY.Name = "tBox_WeaponShellPositionY";
            this.tBox_WeaponShellPositionY.PasswordChar = '\0';
            this.tBox_WeaponShellPositionY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponShellPositionY.SelectedText = "";
            this.tBox_WeaponShellPositionY.SelectionLength = 0;
            this.tBox_WeaponShellPositionY.SelectionStart = 0;
            this.tBox_WeaponShellPositionY.ShortcutsEnabled = true;
            this.tBox_WeaponShellPositionY.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponShellPositionY.TabIndex = 104;
            this.tBox_WeaponShellPositionY.TabStop = false;
            this.tBox_WeaponShellPositionY.Tag = "WeaponShellPositionY";
            this.tBox_WeaponShellPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponShellPositionY.UseSelectable = true;
            this.tBox_WeaponShellPositionY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponShellPositionY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponShellPositionY.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponShellPositionX
            // 
            // 
            // 
            // 
            this.tBox_WeaponShellPositionX.CustomButton.Image = null;
            this.tBox_WeaponShellPositionX.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponShellPositionX.CustomButton.Name = "";
            this.tBox_WeaponShellPositionX.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponShellPositionX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponShellPositionX.CustomButton.TabIndex = 1;
            this.tBox_WeaponShellPositionX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponShellPositionX.CustomButton.UseSelectable = true;
            this.tBox_WeaponShellPositionX.CustomButton.Visible = false;
            this.tBox_WeaponShellPositionX.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponShellPositionX.Lines = new string[0];
            this.tBox_WeaponShellPositionX.Location = new System.Drawing.Point(810, 405);
            this.tBox_WeaponShellPositionX.MaxLength = 32767;
            this.tBox_WeaponShellPositionX.Name = "tBox_WeaponShellPositionX";
            this.tBox_WeaponShellPositionX.PasswordChar = '\0';
            this.tBox_WeaponShellPositionX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponShellPositionX.SelectedText = "";
            this.tBox_WeaponShellPositionX.SelectionLength = 0;
            this.tBox_WeaponShellPositionX.SelectionStart = 0;
            this.tBox_WeaponShellPositionX.ShortcutsEnabled = true;
            this.tBox_WeaponShellPositionX.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponShellPositionX.TabIndex = 103;
            this.tBox_WeaponShellPositionX.TabStop = false;
            this.tBox_WeaponShellPositionX.Tag = "WeaponShellPositionX";
            this.tBox_WeaponShellPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponShellPositionX.UseSelectable = true;
            this.tBox_WeaponShellPositionX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponShellPositionX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponShellPositionX.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponShellPosition
            // 
            this.btn_WeaponShellPosition.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponShellPosition.Location = new System.Drawing.Point(598, 405);
            this.btn_WeaponShellPosition.Name = "btn_WeaponShellPosition";
            this.btn_WeaponShellPosition.Size = new System.Drawing.Size(206, 29);
            this.btn_WeaponShellPosition.TabIndex = 102;
            this.btn_WeaponShellPosition.TabStop = false;
            this.btn_WeaponShellPosition.Tag = "WeaponShellPosition";
            this.btn_WeaponShellPosition.Text = "탄피 배출 좌표";
            this.btn_WeaponShellPosition.UseSelectable = true;
            this.btn_WeaponShellPosition.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponMFlashPositionZ
            // 
            // 
            // 
            // 
            this.tBox_WeaponMFlashPositionZ.CustomButton.Image = null;
            this.tBox_WeaponMFlashPositionZ.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponMFlashPositionZ.CustomButton.Name = "";
            this.tBox_WeaponMFlashPositionZ.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponMFlashPositionZ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponMFlashPositionZ.CustomButton.TabIndex = 1;
            this.tBox_WeaponMFlashPositionZ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponMFlashPositionZ.CustomButton.UseSelectable = true;
            this.tBox_WeaponMFlashPositionZ.CustomButton.Visible = false;
            this.tBox_WeaponMFlashPositionZ.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponMFlashPositionZ.Lines = new string[0];
            this.tBox_WeaponMFlashPositionZ.Location = new System.Drawing.Point(1022, 370);
            this.tBox_WeaponMFlashPositionZ.MaxLength = 32767;
            this.tBox_WeaponMFlashPositionZ.Name = "tBox_WeaponMFlashPositionZ";
            this.tBox_WeaponMFlashPositionZ.PasswordChar = '\0';
            this.tBox_WeaponMFlashPositionZ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponMFlashPositionZ.SelectedText = "";
            this.tBox_WeaponMFlashPositionZ.SelectionLength = 0;
            this.tBox_WeaponMFlashPositionZ.SelectionStart = 0;
            this.tBox_WeaponMFlashPositionZ.ShortcutsEnabled = true;
            this.tBox_WeaponMFlashPositionZ.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponMFlashPositionZ.TabIndex = 101;
            this.tBox_WeaponMFlashPositionZ.TabStop = false;
            this.tBox_WeaponMFlashPositionZ.Tag = "WeaponMFlashPositionZ";
            this.tBox_WeaponMFlashPositionZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponMFlashPositionZ.UseSelectable = true;
            this.tBox_WeaponMFlashPositionZ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponMFlashPositionZ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponMFlashPositionZ.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponMFlashPositionY
            // 
            // 
            // 
            // 
            this.tBox_WeaponMFlashPositionY.CustomButton.Image = null;
            this.tBox_WeaponMFlashPositionY.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponMFlashPositionY.CustomButton.Name = "";
            this.tBox_WeaponMFlashPositionY.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponMFlashPositionY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponMFlashPositionY.CustomButton.TabIndex = 1;
            this.tBox_WeaponMFlashPositionY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponMFlashPositionY.CustomButton.UseSelectable = true;
            this.tBox_WeaponMFlashPositionY.CustomButton.Visible = false;
            this.tBox_WeaponMFlashPositionY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponMFlashPositionY.Lines = new string[0];
            this.tBox_WeaponMFlashPositionY.Location = new System.Drawing.Point(916, 370);
            this.tBox_WeaponMFlashPositionY.MaxLength = 32767;
            this.tBox_WeaponMFlashPositionY.Name = "tBox_WeaponMFlashPositionY";
            this.tBox_WeaponMFlashPositionY.PasswordChar = '\0';
            this.tBox_WeaponMFlashPositionY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponMFlashPositionY.SelectedText = "";
            this.tBox_WeaponMFlashPositionY.SelectionLength = 0;
            this.tBox_WeaponMFlashPositionY.SelectionStart = 0;
            this.tBox_WeaponMFlashPositionY.ShortcutsEnabled = true;
            this.tBox_WeaponMFlashPositionY.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponMFlashPositionY.TabIndex = 100;
            this.tBox_WeaponMFlashPositionY.TabStop = false;
            this.tBox_WeaponMFlashPositionY.Tag = "WeaponMFlashPositionY";
            this.tBox_WeaponMFlashPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponMFlashPositionY.UseSelectable = true;
            this.tBox_WeaponMFlashPositionY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponMFlashPositionY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponMFlashPositionY.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponMFlashPositionX
            // 
            // 
            // 
            // 
            this.tBox_WeaponMFlashPositionX.CustomButton.Image = null;
            this.tBox_WeaponMFlashPositionX.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponMFlashPositionX.CustomButton.Name = "";
            this.tBox_WeaponMFlashPositionX.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponMFlashPositionX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponMFlashPositionX.CustomButton.TabIndex = 1;
            this.tBox_WeaponMFlashPositionX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponMFlashPositionX.CustomButton.UseSelectable = true;
            this.tBox_WeaponMFlashPositionX.CustomButton.Visible = false;
            this.tBox_WeaponMFlashPositionX.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponMFlashPositionX.Lines = new string[0];
            this.tBox_WeaponMFlashPositionX.Location = new System.Drawing.Point(810, 370);
            this.tBox_WeaponMFlashPositionX.MaxLength = 32767;
            this.tBox_WeaponMFlashPositionX.Name = "tBox_WeaponMFlashPositionX";
            this.tBox_WeaponMFlashPositionX.PasswordChar = '\0';
            this.tBox_WeaponMFlashPositionX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponMFlashPositionX.SelectedText = "";
            this.tBox_WeaponMFlashPositionX.SelectionLength = 0;
            this.tBox_WeaponMFlashPositionX.SelectionStart = 0;
            this.tBox_WeaponMFlashPositionX.ShortcutsEnabled = true;
            this.tBox_WeaponMFlashPositionX.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponMFlashPositionX.TabIndex = 99;
            this.tBox_WeaponMFlashPositionX.TabStop = false;
            this.tBox_WeaponMFlashPositionX.Tag = "WeaponMFlashPositionX";
            this.tBox_WeaponMFlashPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponMFlashPositionX.UseSelectable = true;
            this.tBox_WeaponMFlashPositionX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponMFlashPositionX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponMFlashPositionX.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponMFlashPosition
            // 
            this.btn_WeaponMFlashPosition.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponMFlashPosition.Location = new System.Drawing.Point(598, 370);
            this.btn_WeaponMFlashPosition.Name = "btn_WeaponMFlashPosition";
            this.btn_WeaponMFlashPosition.Size = new System.Drawing.Size(206, 29);
            this.btn_WeaponMFlashPosition.TabIndex = 98;
            this.btn_WeaponMFlashPosition.TabStop = false;
            this.btn_WeaponMFlashPosition.Tag = "WeaponMFlashPosition";
            this.btn_WeaponMFlashPosition.Text = "머즐플래시 좌표";
            this.btn_WeaponMFlashPosition.UseSelectable = true;
            this.btn_WeaponMFlashPosition.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponPositionZ
            // 
            // 
            // 
            // 
            this.tBox_WeaponPositionZ.CustomButton.Image = null;
            this.tBox_WeaponPositionZ.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponPositionZ.CustomButton.Name = "";
            this.tBox_WeaponPositionZ.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponPositionZ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponPositionZ.CustomButton.TabIndex = 1;
            this.tBox_WeaponPositionZ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponPositionZ.CustomButton.UseSelectable = true;
            this.tBox_WeaponPositionZ.CustomButton.Visible = false;
            this.tBox_WeaponPositionZ.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponPositionZ.Lines = new string[0];
            this.tBox_WeaponPositionZ.Location = new System.Drawing.Point(1022, 335);
            this.tBox_WeaponPositionZ.MaxLength = 32767;
            this.tBox_WeaponPositionZ.Name = "tBox_WeaponPositionZ";
            this.tBox_WeaponPositionZ.PasswordChar = '\0';
            this.tBox_WeaponPositionZ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponPositionZ.SelectedText = "";
            this.tBox_WeaponPositionZ.SelectionLength = 0;
            this.tBox_WeaponPositionZ.SelectionStart = 0;
            this.tBox_WeaponPositionZ.ShortcutsEnabled = true;
            this.tBox_WeaponPositionZ.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponPositionZ.TabIndex = 97;
            this.tBox_WeaponPositionZ.TabStop = false;
            this.tBox_WeaponPositionZ.Tag = "WeaponPositionZ";
            this.tBox_WeaponPositionZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponPositionZ.UseSelectable = true;
            this.tBox_WeaponPositionZ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponPositionZ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponPositionZ.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponPositionY
            // 
            // 
            // 
            // 
            this.tBox_WeaponPositionY.CustomButton.Image = null;
            this.tBox_WeaponPositionY.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponPositionY.CustomButton.Name = "";
            this.tBox_WeaponPositionY.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponPositionY.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponPositionY.CustomButton.TabIndex = 1;
            this.tBox_WeaponPositionY.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponPositionY.CustomButton.UseSelectable = true;
            this.tBox_WeaponPositionY.CustomButton.Visible = false;
            this.tBox_WeaponPositionY.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponPositionY.Lines = new string[0];
            this.tBox_WeaponPositionY.Location = new System.Drawing.Point(916, 335);
            this.tBox_WeaponPositionY.MaxLength = 32767;
            this.tBox_WeaponPositionY.Name = "tBox_WeaponPositionY";
            this.tBox_WeaponPositionY.PasswordChar = '\0';
            this.tBox_WeaponPositionY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponPositionY.SelectedText = "";
            this.tBox_WeaponPositionY.SelectionLength = 0;
            this.tBox_WeaponPositionY.SelectionStart = 0;
            this.tBox_WeaponPositionY.ShortcutsEnabled = true;
            this.tBox_WeaponPositionY.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponPositionY.TabIndex = 96;
            this.tBox_WeaponPositionY.TabStop = false;
            this.tBox_WeaponPositionY.Tag = "WeaponPositionY";
            this.tBox_WeaponPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponPositionY.UseSelectable = true;
            this.tBox_WeaponPositionY.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponPositionY.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponPositionY.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_WeaponPositionX
            // 
            // 
            // 
            // 
            this.tBox_WeaponPositionX.CustomButton.Image = null;
            this.tBox_WeaponPositionX.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponPositionX.CustomButton.Name = "";
            this.tBox_WeaponPositionX.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponPositionX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponPositionX.CustomButton.TabIndex = 1;
            this.tBox_WeaponPositionX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponPositionX.CustomButton.UseSelectable = true;
            this.tBox_WeaponPositionX.CustomButton.Visible = false;
            this.tBox_WeaponPositionX.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponPositionX.Lines = new string[0];
            this.tBox_WeaponPositionX.Location = new System.Drawing.Point(810, 335);
            this.tBox_WeaponPositionX.MaxLength = 32767;
            this.tBox_WeaponPositionX.Name = "tBox_WeaponPositionX";
            this.tBox_WeaponPositionX.PasswordChar = '\0';
            this.tBox_WeaponPositionX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponPositionX.SelectedText = "";
            this.tBox_WeaponPositionX.SelectionLength = 0;
            this.tBox_WeaponPositionX.SelectionStart = 0;
            this.tBox_WeaponPositionX.ShortcutsEnabled = true;
            this.tBox_WeaponPositionX.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponPositionX.TabIndex = 95;
            this.tBox_WeaponPositionX.TabStop = false;
            this.tBox_WeaponPositionX.Tag = "WeaponPositionX";
            this.tBox_WeaponPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponPositionX.UseSelectable = true;
            this.tBox_WeaponPositionX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponPositionX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponPositionX.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponPosition
            // 
            this.btn_WeaponPosition.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponPosition.Location = new System.Drawing.Point(598, 335);
            this.btn_WeaponPosition.Name = "btn_WeaponPosition";
            this.btn_WeaponPosition.Size = new System.Drawing.Size(206, 29);
            this.btn_WeaponPosition.TabIndex = 94;
            this.btn_WeaponPosition.TabStop = false;
            this.btn_WeaponPosition.Tag = "WeaponPosition";
            this.btn_WeaponPosition.Text = "좌표";
            this.btn_WeaponPosition.UseSelectable = true;
            this.btn_WeaponPosition.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // toggle_WeaponSilencer
            // 
            this.toggle_WeaponSilencer.Location = new System.Drawing.Point(704, 283);
            this.toggle_WeaponSilencer.Name = "toggle_WeaponSilencer";
            this.toggle_WeaponSilencer.Size = new System.Drawing.Size(100, 29);
            this.toggle_WeaponSilencer.TabIndex = 93;
            this.toggle_WeaponSilencer.TabStop = false;
            this.toggle_WeaponSilencer.Text = "Off";
            this.toggle_WeaponSilencer.UseSelectable = true;
            this.toggle_WeaponSilencer.CheckedChanged += new System.EventHandler(this.toggle_WeaponSilencer_CheckedChanged);
            // 
            // btn_WeaponSilencer
            // 
            this.btn_WeaponSilencer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponSilencer.Location = new System.Drawing.Point(704, 248);
            this.btn_WeaponSilencer.Name = "btn_WeaponSilencer";
            this.btn_WeaponSilencer.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponSilencer.TabIndex = 92;
            this.btn_WeaponSilencer.TabStop = false;
            this.btn_WeaponSilencer.Tag = "WeaponSilencer";
            this.btn_WeaponSilencer.Text = "소음기";
            this.btn_WeaponSilencer.UseSelectable = true;
            this.btn_WeaponSilencer.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBar_WeaponSoundVolume
            // 
            this.tBar_WeaponSoundVolume.BackColor = System.Drawing.Color.Transparent;
            this.tBar_WeaponSoundVolume.Location = new System.Drawing.Point(598, 283);
            this.tBar_WeaponSoundVolume.Name = "tBar_WeaponSoundVolume";
            this.tBar_WeaponSoundVolume.Size = new System.Drawing.Size(100, 29);
            this.tBar_WeaponSoundVolume.TabIndex = 91;
            this.tBar_WeaponSoundVolume.TabStop = false;
            this.tBar_WeaponSoundVolume.Text = "metroTrackBar1";
            this.tBar_WeaponSoundVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tBar_WeaponSoundVolume_Scroll);
            // 
            // btn_WeaponSoundVolume
            // 
            this.btn_WeaponSoundVolume.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponSoundVolume.Location = new System.Drawing.Point(598, 248);
            this.btn_WeaponSoundVolume.Name = "btn_WeaponSoundVolume";
            this.btn_WeaponSoundVolume.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponSoundVolume.TabIndex = 90;
            this.btn_WeaponSoundVolume.TabStop = false;
            this.btn_WeaponSoundVolume.Tag = "WeaponVolume";
            this.btn_WeaponSoundVolume.Text = "음량";
            this.btn_WeaponSoundVolume.UseSelectable = true;
            this.btn_WeaponSoundVolume.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // cBox_WeaponSoundID
            // 
            this.cBox_WeaponSoundID.FormattingEnabled = true;
            this.cBox_WeaponSoundID.ItemHeight = 23;
            this.cBox_WeaponSoundID.Location = new System.Drawing.Point(1022, 213);
            this.cBox_WeaponSoundID.Name = "cBox_WeaponSoundID";
            this.cBox_WeaponSoundID.Size = new System.Drawing.Size(100, 29);
            this.cBox_WeaponSoundID.TabIndex = 89;
            this.cBox_WeaponSoundID.TabStop = false;
            this.cBox_WeaponSoundID.Tag = "WeaponSound";
            this.cBox_WeaponSoundID.UseSelectable = true;
            this.cBox_WeaponSoundID.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // btn_WeaponSoundID
            // 
            this.btn_WeaponSoundID.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponSoundID.Location = new System.Drawing.Point(1022, 178);
            this.btn_WeaponSoundID.Name = "btn_WeaponSoundID";
            this.btn_WeaponSoundID.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponSoundID.TabIndex = 88;
            this.btn_WeaponSoundID.TabStop = false;
            this.btn_WeaponSoundID.Tag = "WeaponSound";
            this.btn_WeaponSoundID.Text = "발사음";
            this.btn_WeaponSoundID.UseSelectable = true;
            this.btn_WeaponSoundID.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponSize
            // 
            // 
            // 
            // 
            this.tBox_WeaponSize.CustomButton.Image = null;
            this.tBox_WeaponSize.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponSize.CustomButton.Name = "";
            this.tBox_WeaponSize.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponSize.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponSize.CustomButton.TabIndex = 1;
            this.tBox_WeaponSize.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponSize.CustomButton.UseSelectable = true;
            this.tBox_WeaponSize.CustomButton.Visible = false;
            this.tBox_WeaponSize.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponSize.Lines = new string[0];
            this.tBox_WeaponSize.Location = new System.Drawing.Point(916, 213);
            this.tBox_WeaponSize.MaxLength = 32767;
            this.tBox_WeaponSize.Name = "tBox_WeaponSize";
            this.tBox_WeaponSize.PasswordChar = '\0';
            this.tBox_WeaponSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponSize.SelectedText = "";
            this.tBox_WeaponSize.SelectionLength = 0;
            this.tBox_WeaponSize.SelectionStart = 0;
            this.tBox_WeaponSize.ShortcutsEnabled = true;
            this.tBox_WeaponSize.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponSize.TabIndex = 87;
            this.tBox_WeaponSize.TabStop = false;
            this.tBox_WeaponSize.Tag = "WeaponSize";
            this.tBox_WeaponSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponSize.UseSelectable = true;
            this.tBox_WeaponSize.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponSize.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxChangedEvent);
            this.tBox_WeaponSize.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponSize
            // 
            this.btn_WeaponSize.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponSize.Location = new System.Drawing.Point(916, 178);
            this.btn_WeaponSize.Name = "btn_WeaponSize";
            this.btn_WeaponSize.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponSize.TabIndex = 86;
            this.btn_WeaponSize.TabStop = false;
            this.btn_WeaponSize.Tag = "WeaponSize";
            this.btn_WeaponSize.Text = "크기";
            this.btn_WeaponSize.UseSelectable = true;
            this.btn_WeaponSize.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // cBox_WeaponModel
            // 
            this.cBox_WeaponModel.FormattingEnabled = true;
            this.cBox_WeaponModel.ItemHeight = 23;
            this.cBox_WeaponModel.Location = new System.Drawing.Point(810, 213);
            this.cBox_WeaponModel.Name = "cBox_WeaponModel";
            this.cBox_WeaponModel.Size = new System.Drawing.Size(100, 29);
            this.cBox_WeaponModel.TabIndex = 85;
            this.cBox_WeaponModel.TabStop = false;
            this.cBox_WeaponModel.Tag = "WeaponModel";
            this.cBox_WeaponModel.UseSelectable = true;
            this.cBox_WeaponModel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // btn_WeaponModel
            // 
            this.btn_WeaponModel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponModel.Location = new System.Drawing.Point(810, 178);
            this.btn_WeaponModel.Name = "btn_WeaponModel";
            this.btn_WeaponModel.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponModel.TabIndex = 84;
            this.btn_WeaponModel.TabStop = false;
            this.btn_WeaponModel.Tag = "WeaponModel";
            this.btn_WeaponModel.Text = "모델";
            this.btn_WeaponModel.UseSelectable = true;
            this.btn_WeaponModel.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // cBox_WeaponTexture
            // 
            this.cBox_WeaponTexture.FormattingEnabled = true;
            this.cBox_WeaponTexture.ItemHeight = 23;
            this.cBox_WeaponTexture.Location = new System.Drawing.Point(704, 213);
            this.cBox_WeaponTexture.Name = "cBox_WeaponTexture";
            this.cBox_WeaponTexture.Size = new System.Drawing.Size(100, 29);
            this.cBox_WeaponTexture.TabIndex = 83;
            this.cBox_WeaponTexture.TabStop = false;
            this.cBox_WeaponTexture.Tag = "WeaponTexture";
            this.cBox_WeaponTexture.UseSelectable = true;
            this.cBox_WeaponTexture.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // btn_WeaponTexture
            // 
            this.btn_WeaponTexture.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponTexture.Location = new System.Drawing.Point(704, 178);
            this.btn_WeaponTexture.Name = "btn_WeaponTexture";
            this.btn_WeaponTexture.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponTexture.TabIndex = 82;
            this.btn_WeaponTexture.TabStop = false;
            this.btn_WeaponTexture.Tag = "WeaponTexture";
            this.btn_WeaponTexture.Text = "텍스쳐";
            this.btn_WeaponTexture.UseSelectable = true;
            this.btn_WeaponTexture.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // cBox_WeaponScopeMode
            // 
            this.cBox_WeaponScopeMode.FormattingEnabled = true;
            this.cBox_WeaponScopeMode.ItemHeight = 23;
            this.cBox_WeaponScopeMode.Location = new System.Drawing.Point(598, 213);
            this.cBox_WeaponScopeMode.Name = "cBox_WeaponScopeMode";
            this.cBox_WeaponScopeMode.Size = new System.Drawing.Size(100, 29);
            this.cBox_WeaponScopeMode.TabIndex = 81;
            this.cBox_WeaponScopeMode.TabStop = false;
            this.cBox_WeaponScopeMode.Tag = "WeaponScopeMode";
            this.cBox_WeaponScopeMode.UseSelectable = true;
            this.cBox_WeaponScopeMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // btn_WeaponScopeMode
            // 
            this.btn_WeaponScopeMode.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponScopeMode.Location = new System.Drawing.Point(598, 178);
            this.btn_WeaponScopeMode.Name = "btn_WeaponScopeMode";
            this.btn_WeaponScopeMode.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponScopeMode.TabIndex = 80;
            this.btn_WeaponScopeMode.TabStop = false;
            this.btn_WeaponScopeMode.Tag = "WeaponScopeMode";
            this.btn_WeaponScopeMode.Text = "스코프 모드";
            this.btn_WeaponScopeMode.UseSelectable = true;
            this.btn_WeaponScopeMode.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // cBox_WeaponFireMode
            // 
            this.cBox_WeaponFireMode.FormattingEnabled = true;
            this.cBox_WeaponFireMode.ItemHeight = 23;
            this.cBox_WeaponFireMode.Location = new System.Drawing.Point(1022, 143);
            this.cBox_WeaponFireMode.Name = "cBox_WeaponFireMode";
            this.cBox_WeaponFireMode.Size = new System.Drawing.Size(100, 29);
            this.cBox_WeaponFireMode.TabIndex = 79;
            this.cBox_WeaponFireMode.TabStop = false;
            this.cBox_WeaponFireMode.Tag = "WeaponFireMode";
            this.cBox_WeaponFireMode.UseSelectable = true;
            this.cBox_WeaponFireMode.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // btn_FireMode
            // 
            this.btn_FireMode.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_FireMode.Location = new System.Drawing.Point(1022, 108);
            this.btn_FireMode.Name = "btn_FireMode";
            this.btn_FireMode.Size = new System.Drawing.Size(100, 29);
            this.btn_FireMode.TabIndex = 78;
            this.btn_FireMode.TabStop = false;
            this.btn_FireMode.Tag = "WeaponFireMode";
            this.btn_FireMode.Text = "발사 모드";
            this.btn_FireMode.UseSelectable = true;
            this.btn_FireMode.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // cBox_WeaponArms
            // 
            this.cBox_WeaponArms.FormattingEnabled = true;
            this.cBox_WeaponArms.ItemHeight = 23;
            this.cBox_WeaponArms.Location = new System.Drawing.Point(916, 143);
            this.cBox_WeaponArms.Name = "cBox_WeaponArms";
            this.cBox_WeaponArms.Size = new System.Drawing.Size(100, 29);
            this.cBox_WeaponArms.TabIndex = 77;
            this.cBox_WeaponArms.TabStop = false;
            this.cBox_WeaponArms.Tag = "WeaponArms";
            this.cBox_WeaponArms.UseSelectable = true;
            this.cBox_WeaponArms.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // btn_WeaponArms
            // 
            this.btn_WeaponArms.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponArms.Location = new System.Drawing.Point(916, 108);
            this.btn_WeaponArms.Name = "btn_WeaponArms";
            this.btn_WeaponArms.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponArms.TabIndex = 76;
            this.btn_WeaponArms.TabStop = false;
            this.btn_WeaponArms.Tag = "WeaponArms";
            this.btn_WeaponArms.Text = "팔 유형";
            this.btn_WeaponArms.UseSelectable = true;
            this.btn_WeaponArms.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // btn_WeaponAccuracy
            // 
            this.btn_WeaponAccuracy.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponAccuracy.Location = new System.Drawing.Point(810, 108);
            this.btn_WeaponAccuracy.Name = "btn_WeaponAccuracy";
            this.btn_WeaponAccuracy.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponAccuracy.TabIndex = 74;
            this.btn_WeaponAccuracy.TabStop = false;
            this.btn_WeaponAccuracy.Tag = "WeaponAccuracy";
            this.btn_WeaponAccuracy.Text = "정확도";
            this.btn_WeaponAccuracy.UseSelectable = true;
            this.btn_WeaponAccuracy.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponReaction
            // 
            // 
            // 
            // 
            this.tBox_WeaponReaction.CustomButton.Image = null;
            this.tBox_WeaponReaction.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponReaction.CustomButton.Name = "";
            this.tBox_WeaponReaction.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponReaction.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponReaction.CustomButton.TabIndex = 1;
            this.tBox_WeaponReaction.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponReaction.CustomButton.UseSelectable = true;
            this.tBox_WeaponReaction.CustomButton.Visible = false;
            this.tBox_WeaponReaction.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponReaction.Lines = new string[0];
            this.tBox_WeaponReaction.Location = new System.Drawing.Point(704, 143);
            this.tBox_WeaponReaction.MaxLength = 32767;
            this.tBox_WeaponReaction.Name = "tBox_WeaponReaction";
            this.tBox_WeaponReaction.PasswordChar = '\0';
            this.tBox_WeaponReaction.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponReaction.SelectedText = "";
            this.tBox_WeaponReaction.SelectionLength = 0;
            this.tBox_WeaponReaction.SelectionStart = 0;
            this.tBox_WeaponReaction.ShortcutsEnabled = true;
            this.tBox_WeaponReaction.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponReaction.TabIndex = 73;
            this.tBox_WeaponReaction.TabStop = false;
            this.tBox_WeaponReaction.Tag = "WeaponReaction";
            this.tBox_WeaponReaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponReaction.UseSelectable = true;
            this.tBox_WeaponReaction.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponReaction.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponReaction.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponReaction
            // 
            this.btn_WeaponReaction.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponReaction.Location = new System.Drawing.Point(704, 108);
            this.btn_WeaponReaction.Name = "btn_WeaponReaction";
            this.btn_WeaponReaction.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponReaction.TabIndex = 72;
            this.btn_WeaponReaction.TabStop = false;
            this.btn_WeaponReaction.Tag = "WeaponReaction";
            this.btn_WeaponReaction.Text = "반동";
            this.btn_WeaponReaction.UseSelectable = true;
            this.btn_WeaponReaction.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // btn_WeaponReloadTime
            // 
            this.btn_WeaponReloadTime.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponReloadTime.Location = new System.Drawing.Point(598, 108);
            this.btn_WeaponReloadTime.Name = "btn_WeaponReloadTime";
            this.btn_WeaponReloadTime.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponReloadTime.TabIndex = 70;
            this.btn_WeaponReloadTime.TabStop = false;
            this.btn_WeaponReloadTime.Tag = "WeaponReloadTime";
            this.btn_WeaponReloadTime.Text = "재장전 시간";
            this.btn_WeaponReloadTime.UseSelectable = true;
            this.btn_WeaponReloadTime.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponAmmo
            // 
            // 
            // 
            // 
            this.tBox_WeaponAmmo.CustomButton.Image = null;
            this.tBox_WeaponAmmo.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponAmmo.CustomButton.Name = "";
            this.tBox_WeaponAmmo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponAmmo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponAmmo.CustomButton.TabIndex = 1;
            this.tBox_WeaponAmmo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponAmmo.CustomButton.UseSelectable = true;
            this.tBox_WeaponAmmo.CustomButton.Visible = false;
            this.tBox_WeaponAmmo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponAmmo.Lines = new string[0];
            this.tBox_WeaponAmmo.Location = new System.Drawing.Point(1022, 73);
            this.tBox_WeaponAmmo.MaxLength = 32767;
            this.tBox_WeaponAmmo.Name = "tBox_WeaponAmmo";
            this.tBox_WeaponAmmo.PasswordChar = '\0';
            this.tBox_WeaponAmmo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponAmmo.SelectedText = "";
            this.tBox_WeaponAmmo.SelectionLength = 0;
            this.tBox_WeaponAmmo.SelectionStart = 0;
            this.tBox_WeaponAmmo.ShortcutsEnabled = true;
            this.tBox_WeaponAmmo.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponAmmo.TabIndex = 69;
            this.tBox_WeaponAmmo.TabStop = false;
            this.tBox_WeaponAmmo.Tag = "WeaponAmmo";
            this.tBox_WeaponAmmo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponAmmo.UseSelectable = true;
            this.tBox_WeaponAmmo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponAmmo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponAmmo.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponAmmo
            // 
            this.btn_WeaponAmmo.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponAmmo.Location = new System.Drawing.Point(1022, 38);
            this.btn_WeaponAmmo.Name = "btn_WeaponAmmo";
            this.btn_WeaponAmmo.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponAmmo.TabIndex = 68;
            this.btn_WeaponAmmo.TabStop = false;
            this.btn_WeaponAmmo.Tag = "WeaponAmmo";
            this.btn_WeaponAmmo.Text = "장탄수";
            this.btn_WeaponAmmo.UseSelectable = true;
            this.btn_WeaponAmmo.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // btn_WeaponVelocity
            // 
            this.btn_WeaponVelocity.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponVelocity.Location = new System.Drawing.Point(916, 38);
            this.btn_WeaponVelocity.Name = "btn_WeaponVelocity";
            this.btn_WeaponVelocity.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponVelocity.TabIndex = 66;
            this.btn_WeaponVelocity.TabStop = false;
            this.btn_WeaponVelocity.Tag = "WeaponVelocity";
            this.btn_WeaponVelocity.Text = "탄속";
            this.btn_WeaponVelocity.UseSelectable = true;
            this.btn_WeaponVelocity.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponSpeed
            // 
            // 
            // 
            // 
            this.tBox_WeaponSpeed.CustomButton.Image = null;
            this.tBox_WeaponSpeed.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.tBox_WeaponSpeed.CustomButton.Name = "";
            this.tBox_WeaponSpeed.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponSpeed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponSpeed.CustomButton.TabIndex = 1;
            this.tBox_WeaponSpeed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponSpeed.CustomButton.UseSelectable = true;
            this.tBox_WeaponSpeed.CustomButton.Visible = false;
            this.tBox_WeaponSpeed.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponSpeed.Lines = new string[0];
            this.tBox_WeaponSpeed.Location = new System.Drawing.Point(810, 73);
            this.tBox_WeaponSpeed.MaxLength = 32767;
            this.tBox_WeaponSpeed.Name = "tBox_WeaponSpeed";
            this.tBox_WeaponSpeed.PasswordChar = '\0';
            this.tBox_WeaponSpeed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponSpeed.SelectedText = "";
            this.tBox_WeaponSpeed.SelectionLength = 0;
            this.tBox_WeaponSpeed.SelectionStart = 0;
            this.tBox_WeaponSpeed.ShortcutsEnabled = true;
            this.tBox_WeaponSpeed.Size = new System.Drawing.Size(45, 29);
            this.tBox_WeaponSpeed.TabIndex = 65;
            this.tBox_WeaponSpeed.TabStop = false;
            this.tBox_WeaponSpeed.Tag = "WeaponSpeed";
            this.tBox_WeaponSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponSpeed.UseSelectable = true;
            this.tBox_WeaponSpeed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponSpeed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponSpeed.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponSpeed
            // 
            this.btn_WeaponSpeed.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponSpeed.Location = new System.Drawing.Point(810, 38);
            this.btn_WeaponSpeed.Name = "btn_WeaponSpeed";
            this.btn_WeaponSpeed.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponSpeed.TabIndex = 64;
            this.btn_WeaponSpeed.TabStop = false;
            this.btn_WeaponSpeed.Tag = "WeaponSpeed";
            this.btn_WeaponSpeed.Text = "발사 속도";
            this.btn_WeaponSpeed.UseSelectable = true;
            this.btn_WeaponSpeed.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponPenetration
            // 
            // 
            // 
            // 
            this.tBox_WeaponPenetration.CustomButton.Image = null;
            this.tBox_WeaponPenetration.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponPenetration.CustomButton.Name = "";
            this.tBox_WeaponPenetration.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponPenetration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponPenetration.CustomButton.TabIndex = 1;
            this.tBox_WeaponPenetration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponPenetration.CustomButton.UseSelectable = true;
            this.tBox_WeaponPenetration.CustomButton.Visible = false;
            this.tBox_WeaponPenetration.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponPenetration.Lines = new string[0];
            this.tBox_WeaponPenetration.Location = new System.Drawing.Point(704, 73);
            this.tBox_WeaponPenetration.MaxLength = 32767;
            this.tBox_WeaponPenetration.Name = "tBox_WeaponPenetration";
            this.tBox_WeaponPenetration.PasswordChar = '\0';
            this.tBox_WeaponPenetration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponPenetration.SelectedText = "";
            this.tBox_WeaponPenetration.SelectionLength = 0;
            this.tBox_WeaponPenetration.SelectionStart = 0;
            this.tBox_WeaponPenetration.ShortcutsEnabled = true;
            this.tBox_WeaponPenetration.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponPenetration.TabIndex = 63;
            this.tBox_WeaponPenetration.TabStop = false;
            this.tBox_WeaponPenetration.Tag = "WeaponPenetration";
            this.tBox_WeaponPenetration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponPenetration.UseSelectable = true;
            this.tBox_WeaponPenetration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponPenetration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponPenetration.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponPenetration
            // 
            this.btn_WeaponPenetration.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponPenetration.Location = new System.Drawing.Point(704, 38);
            this.btn_WeaponPenetration.Name = "btn_WeaponPenetration";
            this.btn_WeaponPenetration.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponPenetration.TabIndex = 62;
            this.btn_WeaponPenetration.TabStop = false;
            this.btn_WeaponPenetration.Tag = "WeaponPenetration";
            this.btn_WeaponPenetration.Text = "관통력";
            this.btn_WeaponPenetration.UseSelectable = true;
            this.btn_WeaponPenetration.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // tBox_WeaponDamage
            // 
            // 
            // 
            // 
            this.tBox_WeaponDamage.CustomButton.Image = null;
            this.tBox_WeaponDamage.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.tBox_WeaponDamage.CustomButton.Name = "";
            this.tBox_WeaponDamage.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_WeaponDamage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_WeaponDamage.CustomButton.TabIndex = 1;
            this.tBox_WeaponDamage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_WeaponDamage.CustomButton.UseSelectable = true;
            this.tBox_WeaponDamage.CustomButton.Visible = false;
            this.tBox_WeaponDamage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_WeaponDamage.Lines = new string[0];
            this.tBox_WeaponDamage.Location = new System.Drawing.Point(598, 73);
            this.tBox_WeaponDamage.MaxLength = 32767;
            this.tBox_WeaponDamage.Name = "tBox_WeaponDamage";
            this.tBox_WeaponDamage.PasswordChar = '\0';
            this.tBox_WeaponDamage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_WeaponDamage.SelectedText = "";
            this.tBox_WeaponDamage.SelectionLength = 0;
            this.tBox_WeaponDamage.SelectionStart = 0;
            this.tBox_WeaponDamage.ShortcutsEnabled = true;
            this.tBox_WeaponDamage.Size = new System.Drawing.Size(100, 29);
            this.tBox_WeaponDamage.TabIndex = 61;
            this.tBox_WeaponDamage.TabStop = false;
            this.tBox_WeaponDamage.Tag = "WeaponDamage";
            this.tBox_WeaponDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox_WeaponDamage.UseSelectable = true;
            this.tBox_WeaponDamage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_WeaponDamage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_WeaponDamage.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // btn_WeaponDamage
            // 
            this.btn_WeaponDamage.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_WeaponDamage.Location = new System.Drawing.Point(598, 38);
            this.btn_WeaponDamage.Name = "btn_WeaponDamage";
            this.btn_WeaponDamage.Size = new System.Drawing.Size(100, 29);
            this.btn_WeaponDamage.TabIndex = 60;
            this.btn_WeaponDamage.TabStop = false;
            this.btn_WeaponDamage.Tag = "WeaponDamage";
            this.btn_WeaponDamage.Text = "공격력";
            this.btn_WeaponDamage.UseSelectable = true;
            this.btn_WeaponDamage.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // pBox_WeaponImage
            // 
            this.pBox_WeaponImage.BackColor = System.Drawing.Color.Transparent;
            this.pBox_WeaponImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_WeaponImage.Location = new System.Drawing.Point(126, 3);
            this.pBox_WeaponImage.Name = "pBox_WeaponImage";
            this.pBox_WeaponImage.Size = new System.Drawing.Size(466, 466);
            this.pBox_WeaponImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_WeaponImage.TabIndex = 59;
            this.pBox_WeaponImage.TabStop = false;
            this.metroToolTip.SetToolTip(this.pBox_WeaponImage, "무기의 이미지입니다.");
            // 
            // lBox_WeaponList
            // 
            this.lBox_WeaponList.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lBox_WeaponList.FormattingEnabled = true;
            this.lBox_WeaponList.ItemHeight = 21;
            this.lBox_WeaponList.Location = new System.Drawing.Point(0, 3);
            this.lBox_WeaponList.Name = "lBox_WeaponList";
            this.lBox_WeaponList.ScrollAlwaysVisible = true;
            this.lBox_WeaponList.Size = new System.Drawing.Size(120, 466);
            this.lBox_WeaponList.TabIndex = 2;
            this.lBox_WeaponList.TabStop = false;
            this.metroToolTip.SetToolTip(this.lBox_WeaponList, "설정할 수 있는 무기 목록입니다.");
            this.lBox_WeaponList.SelectedIndexChanged += new System.EventHandler(this.lBox_WeaponList_SelectedIndexChanged);
            // 
            // tabPage_Character
            // 
            this.tabPage_Character.Controls.Add(this.metroButton7);
            this.tabPage_Character.Controls.Add(this.metroButton6);
            this.tabPage_Character.Controls.Add(this.metroButton5);
            this.tabPage_Character.Controls.Add(this.metroButton4);
            this.tabPage_Character.Controls.Add(this.cBox_CharacterAILevel);
            this.tabPage_Character.Controls.Add(this.metroButton3);
            this.tabPage_Character.Controls.Add(this.metroButton2);
            this.tabPage_Character.Controls.Add(this.metroButton1);
            this.tabPage_Character.Controls.Add(this.pBox_CharacterTexture);
            this.tabPage_Character.Controls.Add(this.cBox_CharacterType);
            this.tabPage_Character.Controls.Add(this.cBox_CharacterSecondaryWeapon);
            this.tabPage_Character.Controls.Add(this.cBox_CharacterPrimaryWeapon);
            this.tabPage_Character.Controls.Add(this.tBox_CharacterHP);
            this.tabPage_Character.Controls.Add(this.cBox_CharacterModel);
            this.tabPage_Character.Controls.Add(this.cBox_CharacterTexture);
            this.tabPage_Character.Controls.Add(this.lBox_CharacterList);
            this.tabPage_Character.HorizontalScrollbarBarColor = true;
            this.tabPage_Character.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage_Character.HorizontalScrollbarSize = 10;
            this.tabPage_Character.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Character.Name = "tabPage_Character";
            this.tabPage_Character.Size = new System.Drawing.Size(1146, 472);
            this.tabPage_Character.TabIndex = 2;
            this.tabPage_Character.Text = "캐릭터";
            this.tabPage_Character.VerticalScrollbarBarColor = true;
            this.tabPage_Character.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage_Character.VerticalScrollbarSize = 10;
            // 
            // metroButton7
            // 
            this.metroButton7.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton7.Location = new System.Drawing.Point(728, 213);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(100, 29);
            this.metroButton7.TabIndex = 75;
            this.metroButton7.TabStop = false;
            this.metroButton7.Tag = "CharacterType";
            this.metroButton7.Text = "유형";
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton6
            // 
            this.metroButton6.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton6.Location = new System.Drawing.Point(728, 108);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(100, 29);
            this.metroButton6.TabIndex = 74;
            this.metroButton6.TabStop = false;
            this.metroButton6.Tag = "CharacterPrimaryWeapon";
            this.metroButton6.Text = "주무기";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton5
            // 
            this.metroButton5.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton5.Location = new System.Drawing.Point(728, 178);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(100, 29);
            this.metroButton5.TabIndex = 73;
            this.metroButton5.TabStop = false;
            this.metroButton5.Tag = "CharacterHP";
            this.metroButton5.Text = "체력";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton4
            // 
            this.metroButton4.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton4.Location = new System.Drawing.Point(728, 143);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(100, 29);
            this.metroButton4.TabIndex = 72;
            this.metroButton4.TabStop = false;
            this.metroButton4.Tag = "CharacterSecondaryWeapon";
            this.metroButton4.Text = "보조무기";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // cBox_CharacterAILevel
            // 
            this.cBox_CharacterAILevel.FormattingEnabled = true;
            this.cBox_CharacterAILevel.ItemHeight = 23;
            this.cBox_CharacterAILevel.Location = new System.Drawing.Point(834, 73);
            this.cBox_CharacterAILevel.Name = "cBox_CharacterAILevel";
            this.cBox_CharacterAILevel.Size = new System.Drawing.Size(150, 29);
            this.cBox_CharacterAILevel.TabIndex = 71;
            this.cBox_CharacterAILevel.TabStop = false;
            this.cBox_CharacterAILevel.Tag = "CharacterAILevel";
            this.metroToolTip.SetToolTip(this.cBox_CharacterAILevel, "캐릭터의 모델을 설정합니다.");
            this.cBox_CharacterAILevel.UseSelectable = true;
            this.cBox_CharacterAILevel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // metroButton3
            // 
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton3.Location = new System.Drawing.Point(728, 73);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(100, 29);
            this.metroButton3.TabIndex = 70;
            this.metroButton3.TabStop = false;
            this.metroButton3.Tag = "CharacterAILevel";
            this.metroButton3.Text = "AI 수준";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton2
            // 
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(728, 38);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(100, 29);
            this.metroButton2.TabIndex = 69;
            this.metroButton2.TabStop = false;
            this.metroButton2.Tag = "CharacterModel";
            this.metroButton2.Text = "모델";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(728, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 29);
            this.metroButton1.TabIndex = 68;
            this.metroButton1.TabStop = false;
            this.metroButton1.Tag = "CharacterTexture";
            this.metroButton1.Text = "텍스쳐";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // pBox_CharacterTexture
            // 
            this.pBox_CharacterTexture.BackColor = System.Drawing.Color.Transparent;
            this.pBox_CharacterTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_CharacterTexture.Location = new System.Drawing.Point(256, 3);
            this.pBox_CharacterTexture.Name = "pBox_CharacterTexture";
            this.pBox_CharacterTexture.Size = new System.Drawing.Size(466, 466);
            this.pBox_CharacterTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_CharacterTexture.TabIndex = 67;
            this.pBox_CharacterTexture.TabStop = false;
            // 
            // cBox_CharacterType
            // 
            this.cBox_CharacterType.FormattingEnabled = true;
            this.cBox_CharacterType.ItemHeight = 23;
            this.cBox_CharacterType.Location = new System.Drawing.Point(834, 213);
            this.cBox_CharacterType.Name = "cBox_CharacterType";
            this.cBox_CharacterType.Size = new System.Drawing.Size(150, 29);
            this.cBox_CharacterType.TabIndex = 65;
            this.cBox_CharacterType.TabStop = false;
            this.cBox_CharacterType.Tag = "CharacterType";
            this.metroToolTip.SetToolTip(this.cBox_CharacterType, "캐릭터의 유형을 설정합니다.");
            this.cBox_CharacterType.UseSelectable = true;
            this.cBox_CharacterType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // cBox_CharacterSecondaryWeapon
            // 
            this.cBox_CharacterSecondaryWeapon.FormattingEnabled = true;
            this.cBox_CharacterSecondaryWeapon.ItemHeight = 23;
            this.cBox_CharacterSecondaryWeapon.Location = new System.Drawing.Point(834, 143);
            this.cBox_CharacterSecondaryWeapon.Name = "cBox_CharacterSecondaryWeapon";
            this.cBox_CharacterSecondaryWeapon.Size = new System.Drawing.Size(150, 29);
            this.cBox_CharacterSecondaryWeapon.TabIndex = 63;
            this.cBox_CharacterSecondaryWeapon.TabStop = false;
            this.cBox_CharacterSecondaryWeapon.Tag = "CharacterSecondaryWeapon";
            this.metroToolTip.SetToolTip(this.cBox_CharacterSecondaryWeapon, "캐릭터의 보조무기를 설정합니다.");
            this.cBox_CharacterSecondaryWeapon.UseSelectable = true;
            this.cBox_CharacterSecondaryWeapon.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // cBox_CharacterPrimaryWeapon
            // 
            this.cBox_CharacterPrimaryWeapon.FormattingEnabled = true;
            this.cBox_CharacterPrimaryWeapon.ItemHeight = 23;
            this.cBox_CharacterPrimaryWeapon.Location = new System.Drawing.Point(834, 108);
            this.cBox_CharacterPrimaryWeapon.Name = "cBox_CharacterPrimaryWeapon";
            this.cBox_CharacterPrimaryWeapon.Size = new System.Drawing.Size(150, 29);
            this.cBox_CharacterPrimaryWeapon.TabIndex = 61;
            this.cBox_CharacterPrimaryWeapon.TabStop = false;
            this.cBox_CharacterPrimaryWeapon.Tag = "CharacterPrimaryWeapon";
            this.metroToolTip.SetToolTip(this.cBox_CharacterPrimaryWeapon, "캐릭터의 주무기를 설정합니다.");
            this.cBox_CharacterPrimaryWeapon.UseSelectable = true;
            this.cBox_CharacterPrimaryWeapon.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // tBox_CharacterHP
            // 
            // 
            // 
            // 
            this.tBox_CharacterHP.CustomButton.Image = null;
            this.tBox_CharacterHP.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tBox_CharacterHP.CustomButton.Name = "";
            this.tBox_CharacterHP.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_CharacterHP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_CharacterHP.CustomButton.TabIndex = 1;
            this.tBox_CharacterHP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_CharacterHP.CustomButton.UseSelectable = true;
            this.tBox_CharacterHP.CustomButton.Visible = false;
            this.tBox_CharacterHP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_CharacterHP.Lines = new string[0];
            this.tBox_CharacterHP.Location = new System.Drawing.Point(834, 178);
            this.tBox_CharacterHP.MaxLength = 32767;
            this.tBox_CharacterHP.Name = "tBox_CharacterHP";
            this.tBox_CharacterHP.PasswordChar = '\0';
            this.tBox_CharacterHP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_CharacterHP.SelectedText = "";
            this.tBox_CharacterHP.SelectionLength = 0;
            this.tBox_CharacterHP.SelectionStart = 0;
            this.tBox_CharacterHP.ShortcutsEnabled = true;
            this.tBox_CharacterHP.Size = new System.Drawing.Size(150, 29);
            this.tBox_CharacterHP.TabIndex = 34;
            this.tBox_CharacterHP.TabStop = false;
            this.tBox_CharacterHP.Tag = "CharacterHP";
            this.tBox_CharacterHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_CharacterHP, "캐릭터의 체력을 설정합니다.");
            this.tBox_CharacterHP.UseSelectable = true;
            this.tBox_CharacterHP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_CharacterHP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_CharacterHP.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // cBox_CharacterModel
            // 
            this.cBox_CharacterModel.FormattingEnabled = true;
            this.cBox_CharacterModel.ItemHeight = 23;
            this.cBox_CharacterModel.Location = new System.Drawing.Point(834, 38);
            this.cBox_CharacterModel.Name = "cBox_CharacterModel";
            this.cBox_CharacterModel.Size = new System.Drawing.Size(150, 29);
            this.cBox_CharacterModel.TabIndex = 32;
            this.cBox_CharacterModel.TabStop = false;
            this.cBox_CharacterModel.Tag = "CharacterModel";
            this.metroToolTip.SetToolTip(this.cBox_CharacterModel, "캐릭터의 모델을 설정합니다.");
            this.cBox_CharacterModel.UseSelectable = true;
            this.cBox_CharacterModel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // cBox_CharacterTexture
            // 
            this.cBox_CharacterTexture.FormattingEnabled = true;
            this.cBox_CharacterTexture.ItemHeight = 23;
            this.cBox_CharacterTexture.Location = new System.Drawing.Point(834, 3);
            this.cBox_CharacterTexture.Name = "cBox_CharacterTexture";
            this.cBox_CharacterTexture.Size = new System.Drawing.Size(150, 29);
            this.cBox_CharacterTexture.TabIndex = 30;
            this.cBox_CharacterTexture.TabStop = false;
            this.cBox_CharacterTexture.Tag = "CharacterTexture";
            this.metroToolTip.SetToolTip(this.cBox_CharacterTexture, "캐릭터의 텍스쳐를 설정합니다.");
            this.cBox_CharacterTexture.UseSelectable = true;
            this.cBox_CharacterTexture.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // lBox_CharacterList
            // 
            this.lBox_CharacterList.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lBox_CharacterList.FormattingEnabled = true;
            this.lBox_CharacterList.ItemHeight = 21;
            this.lBox_CharacterList.Location = new System.Drawing.Point(0, 3);
            this.lBox_CharacterList.Name = "lBox_CharacterList";
            this.lBox_CharacterList.ScrollAlwaysVisible = true;
            this.lBox_CharacterList.Size = new System.Drawing.Size(250, 466);
            this.lBox_CharacterList.TabIndex = 3;
            this.lBox_CharacterList.TabStop = false;
            this.lBox_CharacterList.SelectedIndexChanged += new System.EventHandler(this.lBox_CharacterList_SelectedIndexChanged);
            // 
            // tabPage_SmallObject
            // 
            this.tabPage_SmallObject.Controls.Add(this.metroButton13);
            this.tabPage_SmallObject.Controls.Add(this.metroButton12);
            this.tabPage_SmallObject.Controls.Add(this.metroButton11);
            this.tabPage_SmallObject.Controls.Add(this.metroButton10);
            this.tabPage_SmallObject.Controls.Add(this.metroButton9);
            this.tabPage_SmallObject.Controls.Add(this.metroButton8);
            this.tabPage_SmallObject.Controls.Add(this.pBox_SmallObjectTexture);
            this.tabPage_SmallObject.Controls.Add(this.tBox_SmallObjectHP);
            this.tabPage_SmallObject.Controls.Add(this.tBox_SmallObjectCollisionRange);
            this.tabPage_SmallObject.Controls.Add(this.cBox_SmallObjectSound);
            this.tabPage_SmallObject.Controls.Add(this.tBox_SmallObjectJump);
            this.tabPage_SmallObject.Controls.Add(this.cBox_SmallObjectModel);
            this.tabPage_SmallObject.Controls.Add(this.cBox_SmallObjectTexture);
            this.tabPage_SmallObject.Controls.Add(this.lbox_SmallObjectList);
            this.tabPage_SmallObject.HorizontalScrollbarBarColor = true;
            this.tabPage_SmallObject.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage_SmallObject.HorizontalScrollbarSize = 10;
            this.tabPage_SmallObject.Location = new System.Drawing.Point(4, 38);
            this.tabPage_SmallObject.Name = "tabPage_SmallObject";
            this.tabPage_SmallObject.Size = new System.Drawing.Size(1146, 472);
            this.tabPage_SmallObject.TabIndex = 3;
            this.tabPage_SmallObject.Text = "소품";
            this.tabPage_SmallObject.VerticalScrollbarBarColor = true;
            this.tabPage_SmallObject.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage_SmallObject.VerticalScrollbarSize = 10;
            // 
            // metroButton13
            // 
            this.metroButton13.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton13.Location = new System.Drawing.Point(678, 178);
            this.metroButton13.Name = "metroButton13";
            this.metroButton13.Size = new System.Drawing.Size(100, 29);
            this.metroButton13.TabIndex = 91;
            this.metroButton13.TabStop = false;
            this.metroButton13.Tag = "SmallObjectSound";
            this.metroButton13.Text = "피격음";
            this.metroButton13.UseSelectable = true;
            this.metroButton13.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton12
            // 
            this.metroButton12.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton12.Location = new System.Drawing.Point(678, 143);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(100, 29);
            this.metroButton12.TabIndex = 90;
            this.metroButton12.TabStop = false;
            this.metroButton12.Tag = "SmallObjectHP";
            this.metroButton12.Text = "체력";
            this.metroButton12.UseSelectable = true;
            this.metroButton12.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton11
            // 
            this.metroButton11.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton11.Location = new System.Drawing.Point(678, 108);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(100, 29);
            this.metroButton11.TabIndex = 89;
            this.metroButton11.TabStop = false;
            this.metroButton11.Tag = "SmallObjectCollisionRange";
            this.metroButton11.Text = "충돌 범위";
            this.metroButton11.UseSelectable = true;
            this.metroButton11.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton10
            // 
            this.metroButton10.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton10.Location = new System.Drawing.Point(678, 73);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(100, 29);
            this.metroButton10.TabIndex = 88;
            this.metroButton10.TabStop = false;
            this.metroButton10.Tag = "SmallObjectTexture";
            this.metroButton10.Text = "텍스쳐";
            this.metroButton10.UseSelectable = true;
            this.metroButton10.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton9
            // 
            this.metroButton9.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton9.Location = new System.Drawing.Point(678, 38);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(100, 29);
            this.metroButton9.TabIndex = 87;
            this.metroButton9.TabStop = false;
            this.metroButton9.Tag = "SmallObjectModel";
            this.metroButton9.Text = "모델";
            this.metroButton9.UseSelectable = true;
            this.metroButton9.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // metroButton8
            // 
            this.metroButton8.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton8.Location = new System.Drawing.Point(678, 3);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(100, 29);
            this.metroButton8.TabIndex = 86;
            this.metroButton8.TabStop = false;
            this.metroButton8.Tag = "SmallObjectJump";
            this.metroButton8.Text = "튀는 높이";
            this.metroButton8.UseSelectable = true;
            this.metroButton8.Click += new System.EventHandler(this.ButtonClickEvent);
            // 
            // pBox_SmallObjectTexture
            // 
            this.pBox_SmallObjectTexture.BackColor = System.Drawing.Color.Transparent;
            this.pBox_SmallObjectTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_SmallObjectTexture.Location = new System.Drawing.Point(206, 3);
            this.pBox_SmallObjectTexture.Name = "pBox_SmallObjectTexture";
            this.pBox_SmallObjectTexture.Size = new System.Drawing.Size(466, 466);
            this.pBox_SmallObjectTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_SmallObjectTexture.TabIndex = 85;
            this.pBox_SmallObjectTexture.TabStop = false;
            // 
            // tBox_SmallObjectHP
            // 
            // 
            // 
            // 
            this.tBox_SmallObjectHP.CustomButton.Image = null;
            this.tBox_SmallObjectHP.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.tBox_SmallObjectHP.CustomButton.Name = "";
            this.tBox_SmallObjectHP.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_SmallObjectHP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_SmallObjectHP.CustomButton.TabIndex = 1;
            this.tBox_SmallObjectHP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_SmallObjectHP.CustomButton.UseSelectable = true;
            this.tBox_SmallObjectHP.CustomButton.Visible = false;
            this.tBox_SmallObjectHP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_SmallObjectHP.Lines = new string[0];
            this.tBox_SmallObjectHP.Location = new System.Drawing.Point(784, 143);
            this.tBox_SmallObjectHP.MaxLength = 32767;
            this.tBox_SmallObjectHP.Name = "tBox_SmallObjectHP";
            this.tBox_SmallObjectHP.PasswordChar = '\0';
            this.tBox_SmallObjectHP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_SmallObjectHP.SelectedText = "";
            this.tBox_SmallObjectHP.SelectionLength = 0;
            this.tBox_SmallObjectHP.SelectionStart = 0;
            this.tBox_SmallObjectHP.ShortcutsEnabled = true;
            this.tBox_SmallObjectHP.Size = new System.Drawing.Size(120, 29);
            this.tBox_SmallObjectHP.TabIndex = 83;
            this.tBox_SmallObjectHP.TabStop = false;
            this.tBox_SmallObjectHP.Tag = "SmallObjectHP";
            this.tBox_SmallObjectHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_SmallObjectHP, "소품의 체력을 설정합니다.");
            this.tBox_SmallObjectHP.UseSelectable = true;
            this.tBox_SmallObjectHP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_SmallObjectHP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_SmallObjectHP.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // tBox_SmallObjectCollisionRange
            // 
            // 
            // 
            // 
            this.tBox_SmallObjectCollisionRange.CustomButton.Image = null;
            this.tBox_SmallObjectCollisionRange.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.tBox_SmallObjectCollisionRange.CustomButton.Name = "";
            this.tBox_SmallObjectCollisionRange.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_SmallObjectCollisionRange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_SmallObjectCollisionRange.CustomButton.TabIndex = 1;
            this.tBox_SmallObjectCollisionRange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_SmallObjectCollisionRange.CustomButton.UseSelectable = true;
            this.tBox_SmallObjectCollisionRange.CustomButton.Visible = false;
            this.tBox_SmallObjectCollisionRange.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_SmallObjectCollisionRange.Lines = new string[0];
            this.tBox_SmallObjectCollisionRange.Location = new System.Drawing.Point(784, 108);
            this.tBox_SmallObjectCollisionRange.MaxLength = 32767;
            this.tBox_SmallObjectCollisionRange.Name = "tBox_SmallObjectCollisionRange";
            this.tBox_SmallObjectCollisionRange.PasswordChar = '\0';
            this.tBox_SmallObjectCollisionRange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_SmallObjectCollisionRange.SelectedText = "";
            this.tBox_SmallObjectCollisionRange.SelectionLength = 0;
            this.tBox_SmallObjectCollisionRange.SelectionStart = 0;
            this.tBox_SmallObjectCollisionRange.ShortcutsEnabled = true;
            this.tBox_SmallObjectCollisionRange.Size = new System.Drawing.Size(120, 29);
            this.tBox_SmallObjectCollisionRange.TabIndex = 81;
            this.tBox_SmallObjectCollisionRange.TabStop = false;
            this.tBox_SmallObjectCollisionRange.Tag = "SmallObjectCollisionRange";
            this.tBox_SmallObjectCollisionRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_SmallObjectCollisionRange, "소품의 충돌 범위를 설정합니다.");
            this.tBox_SmallObjectCollisionRange.UseSelectable = true;
            this.tBox_SmallObjectCollisionRange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_SmallObjectCollisionRange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_SmallObjectCollisionRange.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // cBox_SmallObjectSound
            // 
            this.cBox_SmallObjectSound.FormattingEnabled = true;
            this.cBox_SmallObjectSound.ItemHeight = 23;
            this.cBox_SmallObjectSound.Location = new System.Drawing.Point(784, 178);
            this.cBox_SmallObjectSound.Name = "cBox_SmallObjectSound";
            this.cBox_SmallObjectSound.Size = new System.Drawing.Size(120, 29);
            this.cBox_SmallObjectSound.TabIndex = 79;
            this.cBox_SmallObjectSound.TabStop = false;
            this.cBox_SmallObjectSound.Tag = "SmallObjectSound";
            this.metroToolTip.SetToolTip(this.cBox_SmallObjectSound, "소품의 피격음을 설정합니다.");
            this.cBox_SmallObjectSound.UseSelectable = true;
            this.cBox_SmallObjectSound.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // tBox_SmallObjectJump
            // 
            // 
            // 
            // 
            this.tBox_SmallObjectJump.CustomButton.Image = null;
            this.tBox_SmallObjectJump.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.tBox_SmallObjectJump.CustomButton.Name = "";
            this.tBox_SmallObjectJump.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.tBox_SmallObjectJump.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_SmallObjectJump.CustomButton.TabIndex = 1;
            this.tBox_SmallObjectJump.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_SmallObjectJump.CustomButton.UseSelectable = true;
            this.tBox_SmallObjectJump.CustomButton.Visible = false;
            this.tBox_SmallObjectJump.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBox_SmallObjectJump.Lines = new string[0];
            this.tBox_SmallObjectJump.Location = new System.Drawing.Point(784, 3);
            this.tBox_SmallObjectJump.MaxLength = 32767;
            this.tBox_SmallObjectJump.Name = "tBox_SmallObjectJump";
            this.tBox_SmallObjectJump.PasswordChar = '\0';
            this.tBox_SmallObjectJump.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_SmallObjectJump.SelectedText = "";
            this.tBox_SmallObjectJump.SelectionLength = 0;
            this.tBox_SmallObjectJump.SelectionStart = 0;
            this.tBox_SmallObjectJump.ShortcutsEnabled = true;
            this.tBox_SmallObjectJump.Size = new System.Drawing.Size(120, 29);
            this.tBox_SmallObjectJump.TabIndex = 71;
            this.tBox_SmallObjectJump.TabStop = false;
            this.tBox_SmallObjectJump.Tag = "SmallObjectJump";
            this.tBox_SmallObjectJump.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip.SetToolTip(this.tBox_SmallObjectJump, "소품의 튀는 높이를 설정합니다.");
            this.tBox_SmallObjectJump.UseSelectable = true;
            this.tBox_SmallObjectJump.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_SmallObjectJump.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBox_SmallObjectJump.Leave += new System.EventHandler(this.TextBoxChangedEvent);
            // 
            // cBox_SmallObjectModel
            // 
            this.cBox_SmallObjectModel.FormattingEnabled = true;
            this.cBox_SmallObjectModel.ItemHeight = 23;
            this.cBox_SmallObjectModel.Location = new System.Drawing.Point(784, 38);
            this.cBox_SmallObjectModel.Name = "cBox_SmallObjectModel";
            this.cBox_SmallObjectModel.Size = new System.Drawing.Size(120, 29);
            this.cBox_SmallObjectModel.TabIndex = 69;
            this.cBox_SmallObjectModel.TabStop = false;
            this.cBox_SmallObjectModel.Tag = "SmallObjectModel";
            this.metroToolTip.SetToolTip(this.cBox_SmallObjectModel, "소품의 모델을 설정합니다.");
            this.cBox_SmallObjectModel.UseSelectable = true;
            this.cBox_SmallObjectModel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // cBox_SmallObjectTexture
            // 
            this.cBox_SmallObjectTexture.FormattingEnabled = true;
            this.cBox_SmallObjectTexture.ItemHeight = 23;
            this.cBox_SmallObjectTexture.Location = new System.Drawing.Point(784, 73);
            this.cBox_SmallObjectTexture.Name = "cBox_SmallObjectTexture";
            this.cBox_SmallObjectTexture.Size = new System.Drawing.Size(120, 29);
            this.cBox_SmallObjectTexture.TabIndex = 67;
            this.cBox_SmallObjectTexture.TabStop = false;
            this.cBox_SmallObjectTexture.Tag = "SmallObjectTexture";
            this.metroToolTip.SetToolTip(this.cBox_SmallObjectTexture, "소품의 텍스쳐를 설정합니다.");
            this.cBox_SmallObjectTexture.UseSelectable = true;
            this.cBox_SmallObjectTexture.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChangedEvent);
            // 
            // lbox_SmallObjectList
            // 
            this.lbox_SmallObjectList.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbox_SmallObjectList.FormattingEnabled = true;
            this.lbox_SmallObjectList.ItemHeight = 21;
            this.lbox_SmallObjectList.Location = new System.Drawing.Point(0, 3);
            this.lbox_SmallObjectList.Name = "lbox_SmallObjectList";
            this.lbox_SmallObjectList.ScrollAlwaysVisible = true;
            this.lbox_SmallObjectList.Size = new System.Drawing.Size(200, 466);
            this.lbox_SmallObjectList.TabIndex = 3;
            this.lbox_SmallObjectList.TabStop = false;
            this.lbox_SmallObjectList.SelectedIndexChanged += new System.EventHandler(this.lbox_SmallObjectList_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "EXE 파일|*.exe";
            this.openFileDialog.Title = "X Operations 실행 파일을 선택해주세요.";
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // metroContextMenu
            // 
            this.metroContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.프로세스찾기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.종료ToolStripMenuItem});
            this.metroContextMenu.Name = "metroContextMenu";
            this.metroContextMenu.Size = new System.Drawing.Size(194, 104);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.열기ToolStripMenuItem.Tag = "Open";
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 프로세스찾기ToolStripMenuItem
            // 
            this.프로세스찾기ToolStripMenuItem.Name = "프로세스찾기ToolStripMenuItem";
            this.프로세스찾기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.프로세스찾기ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.프로세스찾기ToolStripMenuItem.Tag = "Find";
            this.프로세스찾기ToolStripMenuItem.Text = "프로세스 찾기";
            this.프로세스찾기ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.저장ToolStripMenuItem.Tag = "Save";
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.종료ToolStripMenuItem.Tag = "Exit";
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.MenuClickEvent);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "EXE 파일|*.exe";
            this.saveFileDialog.Title = "X Operations 실행 파일을 선택해주세요.";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.ContextMenuStrip = this.metroContextMenu;
            this.Controls.Add(this.tabCtrl_Main);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "X Operations Mod Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.tabCtrl_Main.ResumeLayout(false);
            this.tabPage_Setting.ResumeLayout(false);
            this.gBox_Program.ResumeLayout(false);
            this.gBox_Game.ResumeLayout(false);
            this.tabPage_Weapon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_WeaponImage)).EndInit();
            this.tabPage_Character.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CharacterTexture)).EndInit();
            this.tabPage_SmallObject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_SmallObjectTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabCtrl_Main;
        private MetroFramework.Controls.MetroTabPage tabPage_Setting;
        private MetroFramework.Controls.MetroTabPage tabPage_Weapon;
        private MetroFramework.Controls.MetroTabPage tabPage_Character;
        private MetroFramework.Controls.MetroTabPage tabPage_SmallObject;
        private MetroFramework.Controls.MetroTextBox tBox_EXEPath;
        private System.Windows.Forms.GroupBox gBox_Game;
        private MetroFramework.Controls.MetroLabel lbl_GameVersion;
        private MetroFramework.Controls.MetroLabel lbl_GameName;
        private MetroFramework.Controls.MetroLabel lbl_AutoDepthStencilFormat;
        private MetroFramework.Controls.MetroComboBox cBox_AutoDepthStencilFormat;
        private MetroFramework.Controls.MetroLabel lbl_ClippingNearFar;
        private MetroFramework.Controls.MetroTextBox tBox_ClippingPlaneFar;
        private MetroFramework.Controls.MetroLabel lbl_ClippingPlaneNear;
        private MetroFramework.Controls.MetroTextBox tBox_ClippingPlaneNear;
        private MetroFramework.Controls.MetroLabel lbl_FOVPSG1;
        private MetroFramework.Controls.MetroTextBox tBox_FOVPSG1;
        private MetroFramework.Controls.MetroLabel lbl_FOVAUG;
        private MetroFramework.Controls.MetroTextBox tBox_FOVAUG;
        private MetroFramework.Controls.MetroLabel lbl_FOVNormal;
        private MetroFramework.Controls.MetroTextBox tBox_FOVNormal;
        private System.Windows.Forms.ListBox lBox_WeaponList;
        private System.Windows.Forms.GroupBox gBox_Program;
        private MetroFramework.Controls.MetroToggle toggle_DarkMode;
        private MetroFramework.Controls.MetroLabel lbl_DarkMode;
        private MetroFramework.Controls.MetroComboBox cBox_Style;
        private MetroFramework.Controls.MetroLabel lbl_Style;
        private MetroFramework.Controls.MetroToggle toggle_AutoApply;
        private MetroFramework.Controls.MetroLabel lbl_AutoApply;
        private System.Windows.Forms.ListBox lBox_CharacterList;
        private MetroFramework.Controls.MetroComboBox cBox_CharacterType;
        private MetroFramework.Controls.MetroComboBox cBox_CharacterSecondaryWeapon;
        private MetroFramework.Controls.MetroComboBox cBox_CharacterPrimaryWeapon;
        private MetroFramework.Controls.MetroTextBox tBox_CharacterHP;
        private MetroFramework.Controls.MetroComboBox cBox_CharacterModel;
        private MetroFramework.Controls.MetroComboBox cBox_CharacterTexture;
        private System.Windows.Forms.ListBox lbox_SmallObjectList;
        private MetroFramework.Controls.MetroTextBox tBox_SmallObjectHP;
        private MetroFramework.Controls.MetroTextBox tBox_SmallObjectCollisionRange;
        private MetroFramework.Controls.MetroComboBox cBox_SmallObjectSound;
        private MetroFramework.Controls.MetroTextBox tBox_SmallObjectJump;
        private MetroFramework.Controls.MetroComboBox cBox_SmallObjectModel;
        private MetroFramework.Controls.MetroComboBox cBox_SmallObjectTexture;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private System.Windows.Forms.PictureBox pBox_WeaponImage;
        private MetroFramework.Controls.MetroButton btn_WeaponDamage;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponDamage;
        private MetroFramework.Controls.MetroToggle toggle_WeaponSilencer;
        private MetroFramework.Controls.MetroButton btn_WeaponSilencer;
        private MetroFramework.Controls.MetroTrackBar tBar_WeaponSoundVolume;
        private MetroFramework.Controls.MetroButton btn_WeaponSoundVolume;
        private MetroFramework.Controls.MetroComboBox cBox_WeaponSoundID;
        private MetroFramework.Controls.MetroButton btn_WeaponSoundID;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponSize;
        private MetroFramework.Controls.MetroButton btn_WeaponSize;
        private MetroFramework.Controls.MetroComboBox cBox_WeaponModel;
        private MetroFramework.Controls.MetroButton btn_WeaponModel;
        private MetroFramework.Controls.MetroComboBox cBox_WeaponTexture;
        private MetroFramework.Controls.MetroButton btn_WeaponTexture;
        private MetroFramework.Controls.MetroComboBox cBox_WeaponScopeMode;
        private MetroFramework.Controls.MetroButton btn_WeaponScopeMode;
        private MetroFramework.Controls.MetroComboBox cBox_WeaponFireMode;
        private MetroFramework.Controls.MetroButton btn_FireMode;
        private MetroFramework.Controls.MetroComboBox cBox_WeaponArms;
        private MetroFramework.Controls.MetroButton btn_WeaponArms;
        private MetroFramework.Controls.MetroButton btn_WeaponAccuracy;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponReaction;
        private MetroFramework.Controls.MetroButton btn_WeaponReaction;
        private MetroFramework.Controls.MetroButton btn_WeaponReloadTime;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponAmmo;
        private MetroFramework.Controls.MetroButton btn_WeaponAmmo;
        private MetroFramework.Controls.MetroButton btn_WeaponVelocity;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponSpeed;
        private MetroFramework.Controls.MetroButton btn_WeaponSpeed;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponPenetration;
        private MetroFramework.Controls.MetroButton btn_WeaponPenetration;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponNameLength;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponShellMovementPositionY;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponShellMovementPositionX;
        private MetroFramework.Controls.MetroButton btn_WeaponShellMovementPosition;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponShellPositionZ;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponShellPositionY;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponShellPositionX;
        private MetroFramework.Controls.MetroButton btn_WeaponShellPosition;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponMFlashPositionZ;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponMFlashPositionY;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponMFlashPositionX;
        private MetroFramework.Controls.MetroButton btn_WeaponMFlashPosition;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponPositionZ;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponPositionY;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponPositionX;
        private MetroFramework.Controls.MetroButton btn_WeaponPosition;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponVelocity;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponReloadTime;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponAccuracyMax;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponAccuracyMin;
        private System.Windows.Forms.PictureBox pBox_CharacterTexture;
        private System.Windows.Forms.PictureBox pBox_SmallObjectTexture;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroComboBox cBox_CharacterAILevel;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton13;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton11;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroButton metroButton8;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu;
        private System.Windows.Forms.ToolStripMenuItem 프로세스찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public MetroFramework.Controls.MetroTextBox tBox_GameVersion;
        public MetroFramework.Controls.MetroTextBox tBox_GameName;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponName;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponVelocity2;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponReloadTime2;
        private MetroFramework.Controls.MetroTextBox tBox_WeaponSpeed2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}
