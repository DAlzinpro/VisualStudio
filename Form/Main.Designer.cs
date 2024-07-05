namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.userDataField = new System.Windows.Forms.ListBox();
            this.checkSessionBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.onlineUsersField = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendLogDataBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.logDataField = new Guna.UI2.WinForms.Guna2TextBox();
            this.setUserVarBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fetchGlobalVariableBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.fetchUserVarBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.varDataField = new Guna.UI2.WinForms.Guna2TextBox();
            this.varField = new Guna.UI2.WinForms.Guna2TextBox();
            this.webhookID = new Guna.UI2.WinForms.Guna2TextBox();
            this.webhookBaseURL = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendWebhookBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1170, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox1_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1125, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = null;
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = this;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.guna2MessageDialog1.Text = null;
            // 
            // userDataField
            // 
            this.userDataField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.userDataField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userDataField.ForeColor = System.Drawing.Color.White;
            this.userDataField.FormattingEnabled = true;
            this.userDataField.Location = new System.Drawing.Point(884, 124);
            this.userDataField.Name = "userDataField";
            this.userDataField.Size = new System.Drawing.Size(323, 119);
            this.userDataField.TabIndex = 62;
            // 
            // checkSessionBtn
            // 
            this.checkSessionBtn.BorderColor = System.Drawing.Color.Gray;
            this.checkSessionBtn.BorderRadius = 8;
            this.checkSessionBtn.BorderThickness = 1;
            this.checkSessionBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.checkSessionBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.checkSessionBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkSessionBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.checkSessionBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.checkSessionBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.checkSessionBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.checkSessionBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkSessionBtn.ForeColor = System.Drawing.Color.White;
            this.checkSessionBtn.Location = new System.Drawing.Point(20, 482);
            this.checkSessionBtn.Name = "checkSessionBtn";
            this.checkSessionBtn.Size = new System.Drawing.Size(323, 36);
            this.checkSessionBtn.TabIndex = 63;
            this.checkSessionBtn.Text = "Check Session";
            this.checkSessionBtn.Click += new System.EventHandler(this.checkSessionBtn_Click);
            // 
            // onlineUsersField
            // 
            this.onlineUsersField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.onlineUsersField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.onlineUsersField.ForeColor = System.Drawing.Color.White;
            this.onlineUsersField.FormattingEnabled = true;
            this.onlineUsersField.Items.AddRange(new object[] {
            "Online Users:",
            ""});
            this.onlineUsersField.Location = new System.Drawing.Point(884, 249);
            this.onlineUsersField.Name = "onlineUsersField";
            this.onlineUsersField.Size = new System.Drawing.Size(323, 106);
            this.onlineUsersField.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "KeyAuth Official C# Example";
            // 
            // sendLogDataBtn
            // 
            this.sendLogDataBtn.BorderColor = System.Drawing.Color.Gray;
            this.sendLogDataBtn.BorderRadius = 8;
            this.sendLogDataBtn.BorderThickness = 1;
            this.sendLogDataBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendLogDataBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendLogDataBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendLogDataBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendLogDataBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendLogDataBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.sendLogDataBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.sendLogDataBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendLogDataBtn.ForeColor = System.Drawing.Color.White;
            this.sendLogDataBtn.Location = new System.Drawing.Point(20, 407);
            this.sendLogDataBtn.Name = "sendLogDataBtn";
            this.sendLogDataBtn.Size = new System.Drawing.Size(323, 36);
            this.sendLogDataBtn.TabIndex = 68;
            this.sendLogDataBtn.Text = "Send Log";
            this.sendLogDataBtn.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // logDataField
            // 
            this.logDataField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.logDataField.BorderRadius = 8;
            this.logDataField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logDataField.DefaultText = "";
            this.logDataField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.logDataField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.logDataField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logDataField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.logDataField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.logDataField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logDataField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logDataField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logDataField.Location = new System.Drawing.Point(20, 365);
            this.logDataField.Name = "logDataField";
            this.logDataField.PasswordChar = '\0';
            this.logDataField.PlaceholderText = "Log Data Here";
            this.logDataField.SelectedText = "";
            this.logDataField.Size = new System.Drawing.Size(323, 36);
            this.logDataField.TabIndex = 69;
            this.logDataField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setUserVarBtn
            // 
            this.setUserVarBtn.BorderColor = System.Drawing.Color.Gray;
            this.setUserVarBtn.BorderRadius = 8;
            this.setUserVarBtn.BorderThickness = 1;
            this.setUserVarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.setUserVarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.setUserVarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.setUserVarBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.setUserVarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.setUserVarBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.setUserVarBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.setUserVarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.setUserVarBtn.ForeColor = System.Drawing.Color.White;
            this.setUserVarBtn.Location = new System.Drawing.Point(20, 249);
            this.setUserVarBtn.Name = "setUserVarBtn";
            this.setUserVarBtn.Size = new System.Drawing.Size(155, 36);
            this.setUserVarBtn.TabIndex = 58;
            this.setUserVarBtn.Text = "Set User Variable";
            this.setUserVarBtn.Click += new System.EventHandler(this.setUserVarBtn_Click);
            // 
            // fetchGlobalVariableBtn
            // 
            this.fetchGlobalVariableBtn.BorderColor = System.Drawing.Color.Gray;
            this.fetchGlobalVariableBtn.BorderRadius = 8;
            this.fetchGlobalVariableBtn.BorderThickness = 1;
            this.fetchGlobalVariableBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fetchGlobalVariableBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fetchGlobalVariableBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fetchGlobalVariableBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fetchGlobalVariableBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fetchGlobalVariableBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.fetchGlobalVariableBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.fetchGlobalVariableBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fetchGlobalVariableBtn.ForeColor = System.Drawing.Color.White;
            this.fetchGlobalVariableBtn.Location = new System.Drawing.Point(20, 291);
            this.fetchGlobalVariableBtn.Name = "fetchGlobalVariableBtn";
            this.fetchGlobalVariableBtn.Size = new System.Drawing.Size(323, 36);
            this.fetchGlobalVariableBtn.TabIndex = 60;
            this.fetchGlobalVariableBtn.Text = "Fetch Global Variable";
            this.fetchGlobalVariableBtn.Click += new System.EventHandler(this.fetchGlobalVariableBtn_Click);
            // 
            // fetchUserVarBtn
            // 
            this.fetchUserVarBtn.BorderColor = System.Drawing.Color.Gray;
            this.fetchUserVarBtn.BorderRadius = 8;
            this.fetchUserVarBtn.BorderThickness = 1;
            this.fetchUserVarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fetchUserVarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fetchUserVarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fetchUserVarBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fetchUserVarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fetchUserVarBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.fetchUserVarBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.fetchUserVarBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fetchUserVarBtn.ForeColor = System.Drawing.Color.White;
            this.fetchUserVarBtn.Location = new System.Drawing.Point(188, 249);
            this.fetchUserVarBtn.Name = "fetchUserVarBtn";
            this.fetchUserVarBtn.Size = new System.Drawing.Size(155, 36);
            this.fetchUserVarBtn.TabIndex = 59;
            this.fetchUserVarBtn.Text = "Fetch User Variable";
            this.fetchUserVarBtn.Click += new System.EventHandler(this.fetchUserVarBtn_Click);
            // 
            // varDataField
            // 
            this.varDataField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.varDataField.BorderRadius = 8;
            this.varDataField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.varDataField.DefaultText = "";
            this.varDataField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.varDataField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.varDataField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.varDataField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.varDataField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.varDataField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varDataField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.varDataField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varDataField.Location = new System.Drawing.Point(20, 207);
            this.varDataField.Name = "varDataField";
            this.varDataField.PasswordChar = '\0';
            this.varDataField.PlaceholderText = "User Variable Data Here";
            this.varDataField.SelectedText = "";
            this.varDataField.Size = new System.Drawing.Size(323, 36);
            this.varDataField.TabIndex = 61;
            this.varDataField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // varField
            // 
            this.varField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.varField.BorderRadius = 8;
            this.varField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.varField.DefaultText = "";
            this.varField.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.varField.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.varField.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.varField.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.varField.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.varField.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.varField.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.varField.Location = new System.Drawing.Point(20, 164);
            this.varField.Name = "varField";
            this.varField.PasswordChar = '\0';
            this.varField.PlaceholderText = "User Variable Here";
            this.varField.SelectedText = "";
            this.varField.Size = new System.Drawing.Size(323, 36);
            this.varField.TabIndex = 57;
            this.varField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webhookID
            // 
            this.webhookID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.webhookID.BorderRadius = 8;
            this.webhookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.webhookID.DefaultText = "";
            this.webhookID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.webhookID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.webhookID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhookID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhookID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.webhookID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhookID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.webhookID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhookID.Location = new System.Drawing.Point(20, 39);
            this.webhookID.Name = "webhookID";
            this.webhookID.PasswordChar = '\0';
            this.webhookID.PlaceholderText = "Webhook ID";
            this.webhookID.SelectedText = "";
            this.webhookID.Size = new System.Drawing.Size(98, 36);
            this.webhookID.TabIndex = 65;
            this.webhookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // webhookBaseURL
            // 
            this.webhookBaseURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.webhookBaseURL.BorderRadius = 8;
            this.webhookBaseURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.webhookBaseURL.DefaultText = "";
            this.webhookBaseURL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.webhookBaseURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.webhookBaseURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhookBaseURL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.webhookBaseURL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.webhookBaseURL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhookBaseURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.webhookBaseURL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.webhookBaseURL.Location = new System.Drawing.Point(124, 39);
            this.webhookBaseURL.Name = "webhookBaseURL";
            this.webhookBaseURL.PasswordChar = '\0';
            this.webhookBaseURL.PlaceholderText = "Base URL";
            this.webhookBaseURL.SelectedText = "";
            this.webhookBaseURL.Size = new System.Drawing.Size(219, 36);
            this.webhookBaseURL.TabIndex = 67;
            this.webhookBaseURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sendWebhookBtn
            // 
            this.sendWebhookBtn.BorderColor = System.Drawing.Color.Gray;
            this.sendWebhookBtn.BorderRadius = 8;
            this.sendWebhookBtn.BorderThickness = 1;
            this.sendWebhookBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendWebhookBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendWebhookBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendWebhookBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendWebhookBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendWebhookBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.sendWebhookBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.sendWebhookBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sendWebhookBtn.ForeColor = System.Drawing.Color.White;
            this.sendWebhookBtn.Location = new System.Drawing.Point(20, 81);
            this.sendWebhookBtn.Name = "sendWebhookBtn";
            this.sendWebhookBtn.Size = new System.Drawing.Size(323, 36);
            this.sendWebhookBtn.TabIndex = 66;
            this.sendWebhookBtn.Text = "Send Webhook";
            this.sendWebhookBtn.Click += new System.EventHandler(this.sendWebhookBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1219, 543);
            this.Controls.Add(this.logDataField);
            this.Controls.Add(this.sendLogDataBtn);
            this.Controls.Add(this.webhookBaseURL);
            this.Controls.Add(this.sendWebhookBtn);
            this.Controls.Add(this.webhookID);
            this.Controls.Add(this.onlineUsersField);
            this.Controls.Add(this.checkSessionBtn);
            this.Controls.Add(this.userDataField);
            this.Controls.Add(this.varDataField);
            this.Controls.Add(this.fetchGlobalVariableBtn);
            this.Controls.Add(this.fetchUserVarBtn);
            this.Controls.Add(this.setUserVarBtn);
            this.Controls.Add(this.varField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.ListBox userDataField;
        private Guna.UI2.WinForms.Guna2GradientButton checkSessionBtn;
        private System.Windows.Forms.ListBox onlineUsersField;
        private Guna.UI2.WinForms.Guna2TextBox logDataField;
        private Guna.UI2.WinForms.Guna2GradientButton sendLogDataBtn;
        private Guna.UI2.WinForms.Guna2TextBox webhookBaseURL;
        private Guna.UI2.WinForms.Guna2GradientButton sendWebhookBtn;
        private Guna.UI2.WinForms.Guna2TextBox webhookID;
        private Guna.UI2.WinForms.Guna2TextBox varDataField;
        private Guna.UI2.WinForms.Guna2GradientButton fetchGlobalVariableBtn;
        private Guna.UI2.WinForms.Guna2GradientButton fetchUserVarBtn;
        private Guna.UI2.WinForms.Guna2GradientButton setUserVarBtn;
        private Guna.UI2.WinForms.Guna2TextBox varField;
        private System.Windows.Forms.Label label2;
    }
}
