namespace ChatApp
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.layoutClientForm = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblClientTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelLeft = new Guna.UI2.WinForms.Guna2Panel();
            this.picUserAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHelp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSettings = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnChat = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrCurrentReceiver = new ChatApp.Controls.UserOnlineControl();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEmotionThink = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnEmotionHungry = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnEmotionSmile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnEmotionLove = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnEmotionSad = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnSendFile = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSend = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.layoutMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.documentMessageControl1 = new ChatApp.Controls.DocumentMessageControl();
            this.iconMessageControl1 = new ChatApp.Controls.IconMessageControl();
            this.pictureMessageControl1 = new ChatApp.Controls.PictureMessageControl();
            this.videoMessageControl1 = new ChatApp.Controls.VideoMessageControl();
            this.pnlUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.userOnlineControl2 = new ChatApp.Controls.UserOnlineControl();
            this.userOnlineControl3 = new ChatApp.Controls.UserOnlineControl();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.layoutClientForm.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.panelMain.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionThink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionHungry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionSmile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionSad)).BeginInit();
            this.layoutMessages.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutClientForm
            // 
            this.layoutClientForm.ColumnCount = 3;
            this.layoutClientForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 221F));
            this.layoutClientForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutClientForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 286F));
            this.layoutClientForm.Controls.Add(this.pnlTitle, 1, 0);
            this.layoutClientForm.Controls.Add(this.panelLeft, 0, 0);
            this.layoutClientForm.Controls.Add(this.panelMain, 1, 1);
            this.layoutClientForm.Controls.Add(this.pnlUsers, 2, 1);
            this.layoutClientForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutClientForm.Location = new System.Drawing.Point(0, 0);
            this.layoutClientForm.Margin = new System.Windows.Forms.Padding(0);
            this.layoutClientForm.Name = "layoutClientForm";
            this.layoutClientForm.RowCount = 2;
            this.layoutClientForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.layoutClientForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutClientForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutClientForm.Size = new System.Drawing.Size(1147, 694);
            this.layoutClientForm.TabIndex = 0;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.SlateBlue;
            this.layoutClientForm.SetColumnSpan(this.pnlTitle, 2);
            this.pnlTitle.Controls.Add(this.guna2ControlBox1);
            this.pnlTitle.Controls.Add(this.lblClientTitle);
            this.pnlTitle.Location = new System.Drawing.Point(221, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(926, 50);
            this.pnlTitle.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(875, 10);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(41, 30);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // lblClientTitle
            // 
            this.lblClientTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblClientTitle.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblClientTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClientTitle.Location = new System.Drawing.Point(21, 12);
            this.lblClientTitle.Name = "lblClientTitle";
            this.lblClientTitle.Size = new System.Drawing.Size(86, 21);
            this.lblClientTitle.TabIndex = 2;
            this.lblClientTitle.Text = "Chat Client ";
            this.lblClientTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelLeft.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.panelLeft.Controls.Add(this.picUserAvatar);
            this.panelLeft.Controls.Add(this.lblEmail);
            this.panelLeft.Controls.Add(this.btnExit);
            this.panelLeft.Controls.Add(this.btnHelp);
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Controls.Add(this.btnChat);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeft.Name = "panelLeft";
            this.layoutClientForm.SetRowSpan(this.panelLeft, 2);
            this.panelLeft.Size = new System.Drawing.Size(221, 694);
            this.panelLeft.TabIndex = 1;
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picUserAvatar.Image")));
            this.picUserAvatar.ImageRotate = 0F;
            this.picUserAvatar.Location = new System.Drawing.Point(37, 30);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picUserAvatar.Size = new System.Drawing.Size(122, 125);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserAvatar.TabIndex = 0;
            this.picUserAvatar.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(13, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(160, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "john@gmail.com";
            this.lblEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Fuchsia;
            this.btnExit.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnExit.Font = new System.Drawing.Font("Arial", 12.5F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(0, 640);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Logout";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelp.FillColor = System.Drawing.Color.Fuchsia;
            this.btnHelp.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 12.5F);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHelp.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHelp.Location = new System.Drawing.Point(1, 374);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(221, 47);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help (Author)";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.Fuchsia;
            this.btnSettings.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 12.5F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSettings.Location = new System.Drawing.Point(3, 321);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(219, 47);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnChat
            // 
            this.btnChat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChat.FillColor = System.Drawing.Color.Fuchsia;
            this.btnChat.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnChat.Font = new System.Drawing.Font("Arial", 12.5F);
            this.btnChat.ForeColor = System.Drawing.Color.White;
            this.btnChat.Image = ((System.Drawing.Image)(resources.GetObject("btnChat.Image")));
            this.btnChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChat.ImageSize = new System.Drawing.Size(35, 35);
            this.btnChat.Location = new System.Drawing.Point(1, 268);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(221, 47);
            this.btnChat.TabIndex = 2;
            this.btnChat.Text = "Chat";
            // 
            // btnHome
            // 
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Fuchsia;
            this.btnHome.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnHome.Font = new System.Drawing.Font("Arial", 12.5F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHome.Location = new System.Drawing.Point(3, 215);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(219, 47);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMain.Controls.Add(this.ctrCurrentReceiver);
            this.panelMain.Controls.Add(this.guna2Panel1);
            this.panelMain.Controls.Add(this.btnSend);
            this.panelMain.Controls.Add(this.txtMessage);
            this.panelMain.Controls.Add(this.layoutMessages);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(221, 50);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(640, 644);
            this.panelMain.TabIndex = 2;
            // 
            // ctrCurrentReceiver
            // 
            this.ctrCurrentReceiver.BackColor = System.Drawing.Color.DarkCyan;
            this.ctrCurrentReceiver.Location = new System.Drawing.Point(0, 0);
            this.ctrCurrentReceiver.Name = "ctrCurrentReceiver";
            this.ctrCurrentReceiver.Size = new System.Drawing.Size(641, 56);
            this.ctrCurrentReceiver.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnEmotionThink);
            this.guna2Panel1.Controls.Add(this.btnEmotionHungry);
            this.guna2Panel1.Controls.Add(this.btnEmotionSmile);
            this.guna2Panel1.Controls.Add(this.btnEmotionLove);
            this.guna2Panel1.Controls.Add(this.btnEmotionSad);
            this.guna2Panel1.Controls.Add(this.btnSendFile);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 522);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(640, 54);
            this.guna2Panel1.TabIndex = 3;
            // 
            // btnEmotionThink
            // 
            this.btnEmotionThink.BackColor = System.Drawing.Color.Transparent;
            this.btnEmotionThink.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotionThink.Image")));
            this.btnEmotionThink.ImageRotate = 0F;
            this.btnEmotionThink.Location = new System.Drawing.Point(487, 8);
            this.btnEmotionThink.Name = "btnEmotionThink";
            this.btnEmotionThink.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEmotionThink.Size = new System.Drawing.Size(54, 41);
            this.btnEmotionThink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmotionThink.TabIndex = 1;
            this.btnEmotionThink.TabStop = false;
            this.btnEmotionThink.UseTransparentBackground = true;
            this.btnEmotionThink.Click += new System.EventHandler(this.btnEmotionThink_Click);
            // 
            // btnEmotionHungry
            // 
            this.btnEmotionHungry.BackColor = System.Drawing.Color.Transparent;
            this.btnEmotionHungry.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotionHungry.Image")));
            this.btnEmotionHungry.ImageRotate = 0F;
            this.btnEmotionHungry.Location = new System.Drawing.Point(412, 8);
            this.btnEmotionHungry.Name = "btnEmotionHungry";
            this.btnEmotionHungry.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEmotionHungry.Size = new System.Drawing.Size(54, 41);
            this.btnEmotionHungry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmotionHungry.TabIndex = 1;
            this.btnEmotionHungry.TabStop = false;
            this.btnEmotionHungry.UseTransparentBackground = true;
            this.btnEmotionHungry.Click += new System.EventHandler(this.btnEmotionHungry_Click);
            // 
            // btnEmotionSmile
            // 
            this.btnEmotionSmile.BackColor = System.Drawing.Color.Transparent;
            this.btnEmotionSmile.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotionSmile.Image")));
            this.btnEmotionSmile.ImageRotate = 0F;
            this.btnEmotionSmile.Location = new System.Drawing.Point(339, 8);
            this.btnEmotionSmile.Name = "btnEmotionSmile";
            this.btnEmotionSmile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEmotionSmile.Size = new System.Drawing.Size(54, 41);
            this.btnEmotionSmile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmotionSmile.TabIndex = 1;
            this.btnEmotionSmile.TabStop = false;
            this.btnEmotionSmile.UseTransparentBackground = true;
            this.btnEmotionSmile.Click += new System.EventHandler(this.btnEmotionSmile_Click);
            // 
            // btnEmotionLove
            // 
            this.btnEmotionLove.BackColor = System.Drawing.Color.Transparent;
            this.btnEmotionLove.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotionLove.Image")));
            this.btnEmotionLove.ImageRotate = 0F;
            this.btnEmotionLove.Location = new System.Drawing.Point(265, 8);
            this.btnEmotionLove.Name = "btnEmotionLove";
            this.btnEmotionLove.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEmotionLove.Size = new System.Drawing.Size(54, 41);
            this.btnEmotionLove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmotionLove.TabIndex = 1;
            this.btnEmotionLove.TabStop = false;
            this.btnEmotionLove.UseTransparentBackground = true;
            this.btnEmotionLove.Click += new System.EventHandler(this.btnEmotionLove_Click);
            // 
            // btnEmotionSad
            // 
            this.btnEmotionSad.BackColor = System.Drawing.Color.Transparent;
            this.btnEmotionSad.Image = ((System.Drawing.Image)(resources.GetObject("btnEmotionSad.Image")));
            this.btnEmotionSad.ImageRotate = 0F;
            this.btnEmotionSad.Location = new System.Drawing.Point(194, 8);
            this.btnEmotionSad.Name = "btnEmotionSad";
            this.btnEmotionSad.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEmotionSad.Size = new System.Drawing.Size(54, 41);
            this.btnEmotionSad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmotionSad.TabIndex = 1;
            this.btnEmotionSad.TabStop = false;
            this.btnEmotionSad.UseTransparentBackground = true;
            this.btnEmotionSad.Click += new System.EventHandler(this.btnEmotionSad_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendFile.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendFile.Font = new System.Drawing.Font("Arial", 12.5F);
            this.btnSendFile.ForeColor = System.Drawing.Color.White;
            this.btnSendFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSendFile.Image")));
            this.btnSendFile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSendFile.Location = new System.Drawing.Point(3, 3);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(178, 48);
            this.btnSendFile.TabIndex = 0;
            this.btnSendFile.Text = "Gửi tập tin";
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Teal;
            this.btnSend.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSend.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnSend.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSend.ImageRotate = 0F;
            this.btnSend.Location = new System.Drawing.Point(534, 577);
            this.btnSend.Name = "btnSend";
            this.btnSend.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSend.Size = new System.Drawing.Size(97, 60);
            this.btnSend.TabIndex = 2;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.Silver;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Arial", 13.5F);
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(3, 576);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderText = "Type here";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(525, 61);
            this.txtMessage.TabIndex = 1;
            // 
            // layoutMessages
            // 
            this.layoutMessages.AutoScroll = true;
            this.layoutMessages.BackColor = System.Drawing.Color.LightSeaGreen;
            this.layoutMessages.Controls.Add(this.documentMessageControl1);
            this.layoutMessages.Controls.Add(this.iconMessageControl1);
            this.layoutMessages.Controls.Add(this.pictureMessageControl1);
            this.layoutMessages.Controls.Add(this.videoMessageControl1);
            this.layoutMessages.Location = new System.Drawing.Point(0, 55);
            this.layoutMessages.Name = "layoutMessages";
            this.layoutMessages.Size = new System.Drawing.Size(641, 470);
            this.layoutMessages.TabIndex = 0;
            // 
            // documentMessageControl1
            // 
            this.documentMessageControl1.Location = new System.Drawing.Point(3, 3);
            this.documentMessageControl1.Name = "documentMessageControl1";
            this.documentMessageControl1.Size = new System.Drawing.Size(625, 48);
            this.documentMessageControl1.TabIndex = 0;
            // 
            // iconMessageControl1
            // 
            this.iconMessageControl1.Location = new System.Drawing.Point(3, 57);
            this.iconMessageControl1.Name = "iconMessageControl1";
            this.iconMessageControl1.Size = new System.Drawing.Size(545, 47);
            this.iconMessageControl1.TabIndex = 1;
            // 
            // pictureMessageControl1
            // 
            this.pictureMessageControl1.Location = new System.Drawing.Point(3, 110);
            this.pictureMessageControl1.Name = "pictureMessageControl1";
            this.pictureMessageControl1.Size = new System.Drawing.Size(612, 141);
            this.pictureMessageControl1.TabIndex = 2;
            // 
            // videoMessageControl1
            // 
            this.videoMessageControl1.Location = new System.Drawing.Point(3, 257);
            this.videoMessageControl1.Name = "videoMessageControl1";
            this.videoMessageControl1.Size = new System.Drawing.Size(612, 168);
            this.videoMessageControl1.TabIndex = 3;
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlUsers.Controls.Add(this.userOnlineControl2);
            this.pnlUsers.Controls.Add(this.userOnlineControl3);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsers.Location = new System.Drawing.Point(861, 50);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(286, 644);
            this.pnlUsers.TabIndex = 3;
            // 
            // userOnlineControl2
            // 
            this.userOnlineControl2.Location = new System.Drawing.Point(3, 3);
            this.userOnlineControl2.Name = "userOnlineControl2";
            this.userOnlineControl2.Size = new System.Drawing.Size(271, 53);
            this.userOnlineControl2.TabIndex = 0;
            // 
            // userOnlineControl3
            // 
            this.userOnlineControl3.Location = new System.Drawing.Point(3, 62);
            this.userOnlineControl3.Name = "userOnlineControl3";
            this.userOnlineControl3.Size = new System.Drawing.Size(271, 53);
            this.userOnlineControl3.TabIndex = 0;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlTitle;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 694);
            this.Controls.Add(this.layoutClientForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ClientForm_KeyDown);
            this.layoutClientForm.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionThink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionHungry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionSmile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmotionSad)).EndInit();
            this.layoutMessages.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutClientForm;
        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel panelLeft;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton btnHelp;
        private Guna.UI2.WinForms.Guna2GradientButton btnSettings;
        private Guna.UI2.WinForms.Guna2GradientButton btnChat;
        private Guna.UI2.WinForms.Guna2GradientButton btnHome;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel pnlUsers;
        private Guna.UI2.WinForms.Guna2ImageButton btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private System.Windows.Forms.FlowLayoutPanel layoutMessages;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picUserAvatar;
        private Controls.UserOnlineControl ctrCurrentReceiver;
        private Controls.UserOnlineControl userOnlineControl2;
        private Controls.UserOnlineControl userOnlineControl3;
        private Controls.DocumentMessageControl documentMessageControl1;
        private Controls.IconMessageControl iconMessageControl1;
        private Controls.PictureMessageControl pictureMessageControl1;
        private Controls.VideoMessageControl videoMessageControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSendFile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnEmotionThink;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnEmotionHungry;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnEmotionSmile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnEmotionLove;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnEmotionSad;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClientTitle;
        private Guna.UI2.WinForms.Guna2GradientButton btnExit;
    }
}

