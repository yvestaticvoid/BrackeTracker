namespace BrackeTrackerUI
{
    partial class TeamCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamCreationForm));
            ctDeleteSelected = new Button();
            ctPlayersView = new ListBox();
            ctPlayersViewHead = new Label();
            label5 = new Label();
            ctcmButton = new Button();
            ctText = new Label();
            ctSelectMemberLabel = new Label();
            ctNameValue = new TextBox();
            ctAddMemberButton = new Button();
            ctSelectMemberDrop = new ComboBox();
            ctLabel = new Label();
            ctHead = new Label();
            label1 = new Label();
            ctCreateMemberHead = new Label();
            ctcmNameValue = new TextBox();
            ctcmNameLabel = new Label();
            ctcmLastNameLabel = new Label();
            ctcmLastNameValue = new TextBox();
            ctcmEmailLabel = new Label();
            ctcmEmailValue = new TextBox();
            ctcmPhoneNumberLabel = new Label();
            ctcmPhoneNumberValue = new TextBox();
            ctButton = new Button();
            SuspendLayout();
            // 
            // ctDeleteSelected
            // 
            ctDeleteSelected.Location = new Point(612, 480);
            ctDeleteSelected.Name = "ctDeleteSelected";
            ctDeleteSelected.Size = new Size(139, 23);
            ctDeleteSelected.TabIndex = 43;
            ctDeleteSelected.Text = "DELETE SELECTED";
            ctDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // ctPlayersView
            // 
            ctPlayersView.FormattingEnabled = true;
            ctPlayersView.ItemHeight = 15;
            ctPlayersView.Location = new Point(429, 111);
            ctPlayersView.Name = "ctPlayersView";
            ctPlayersView.Size = new Size(322, 349);
            ctPlayersView.TabIndex = 42;
            // 
            // ctPlayersViewHead
            // 
            ctPlayersViewHead.AutoSize = true;
            ctPlayersViewHead.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctPlayersViewHead.ForeColor = SystemColors.ControlDarkDark;
            ctPlayersViewHead.Location = new Point(420, 60);
            ctPlayersViewHead.Name = "ctPlayersViewHead";
            ctPlayersViewHead.Size = new Size(128, 30);
            ctPlayersViewHead.TabIndex = 41;
            ctPlayersViewHead.Text = "Players View";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(384, -5);
            label5.Name = "label5";
            label5.Size = new Size(10, 737);
            label5.TabIndex = 40;
            // 
            // ctcmButton
            // 
            ctcmButton.Location = new Point(244, 668);
            ctcmButton.Name = "ctcmButton";
            ctcmButton.Size = new Size(80, 23);
            ctcmButton.TabIndex = 37;
            ctcmButton.Text = "CREATE";
            ctcmButton.UseVisualStyleBackColor = true;
            // 
            // ctText
            // 
            ctText.AutoSize = true;
            ctText.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            ctText.ForeColor = SystemColors.WindowFrame;
            ctText.Location = new Point(47, 277);
            ctText.Name = "ctText";
            ctText.Size = new Size(121, 15);
            ctText.TabIndex = 36;
            ctText.Text = "Can't find your team?";
            // 
            // ctSelectMemberLabel
            // 
            ctSelectMemberLabel.AutoSize = true;
            ctSelectMemberLabel.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctSelectMemberLabel.ForeColor = SystemColors.WindowFrame;
            ctSelectMemberLabel.Location = new Point(42, 205);
            ctSelectMemberLabel.Name = "ctSelectMemberLabel";
            ctSelectMemberLabel.Size = new Size(151, 30);
            ctSelectMemberLabel.TabIndex = 35;
            ctSelectMemberLabel.Text = "Select Member";
            ctSelectMemberLabel.Click += SelectTeamLabel_Click;
            // 
            // ctNameValue
            // 
            ctNameValue.Location = new Point(47, 164);
            ctNameValue.Name = "ctNameValue";
            ctNameValue.Size = new Size(180, 23);
            ctNameValue.TabIndex = 32;
            // 
            // ctAddMemberButton
            // 
            ctAddMemberButton.Location = new Point(244, 242);
            ctAddMemberButton.Name = "ctAddMemberButton";
            ctAddMemberButton.Size = new Size(49, 23);
            ctAddMemberButton.TabIndex = 31;
            ctAddMemberButton.Text = "ADD";
            ctAddMemberButton.UseVisualStyleBackColor = true;
            ctAddMemberButton.Click += AddTeamButton_Click;
            // 
            // ctSelectMemberDrop
            // 
            ctSelectMemberDrop.FormattingEnabled = true;
            ctSelectMemberDrop.Location = new Point(47, 242);
            ctSelectMemberDrop.Name = "ctSelectMemberDrop";
            ctSelectMemberDrop.Size = new Size(180, 23);
            ctSelectMemberDrop.TabIndex = 30;
            ctSelectMemberDrop.SelectedIndexChanged += SelectTeamDropdown_SelectedIndexChanged;
            // 
            // ctLabel
            // 
            ctLabel.AutoSize = true;
            ctLabel.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctLabel.ForeColor = SystemColors.ControlDarkDark;
            ctLabel.Location = new Point(42, 127);
            ctLabel.Name = "ctLabel";
            ctLabel.Size = new Size(68, 30);
            ctLabel.TabIndex = 29;
            ctLabel.Text = "Name";
            // 
            // ctHead
            // 
            ctHead.AutoSize = true;
            ctHead.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ctHead.Location = new Point(39, 48);
            ctHead.Name = "ctHead";
            ctHead.Size = new Size(196, 45);
            ctHead.TabIndex = 28;
            ctHead.Text = "Create Team";
            ctHead.Click += CreateTournamentLabel_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(-16, 341);
            label1.Name = "label1";
            label1.Size = new Size(400, 10);
            label1.TabIndex = 46;
            label1.Click += label1_Click;
            // 
            // ctCreateMemberHead
            // 
            ctCreateMemberHead.AutoSize = true;
            ctCreateMemberHead.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctCreateMemberHead.ForeColor = SystemColors.ControlText;
            ctCreateMemberHead.Location = new Point(47, 325);
            ctCreateMemberHead.Name = "ctCreateMemberHead";
            ctCreateMemberHead.Size = new Size(156, 30);
            ctCreateMemberHead.TabIndex = 47;
            ctCreateMemberHead.Text = "Create Member";
            // 
            // ctcmNameValue
            // 
            ctcmNameValue.Location = new Point(47, 413);
            ctcmNameValue.Name = "ctcmNameValue";
            ctcmNameValue.Size = new Size(180, 23);
            ctcmNameValue.TabIndex = 49;
            // 
            // ctcmNameLabel
            // 
            ctcmNameLabel.AutoSize = true;
            ctcmNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ctcmNameLabel.ForeColor = SystemColors.ControlDarkDark;
            ctcmNameLabel.Location = new Point(44, 386);
            ctcmNameLabel.Name = "ctcmNameLabel";
            ctcmNameLabel.Size = new Size(52, 21);
            ctcmNameLabel.TabIndex = 50;
            ctcmNameLabel.Text = "Name";
            // 
            // ctcmLastNameLabel
            // 
            ctcmLastNameLabel.AutoSize = true;
            ctcmLastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ctcmLastNameLabel.ForeColor = SystemColors.ControlDarkDark;
            ctcmLastNameLabel.Location = new Point(44, 454);
            ctcmLastNameLabel.Name = "ctcmLastNameLabel";
            ctcmLastNameLabel.Size = new Size(84, 21);
            ctcmLastNameLabel.TabIndex = 52;
            ctcmLastNameLabel.Text = "Last Name";
            // 
            // ctcmLastNameValue
            // 
            ctcmLastNameValue.Location = new Point(47, 481);
            ctcmLastNameValue.Name = "ctcmLastNameValue";
            ctcmLastNameValue.Size = new Size(180, 23);
            ctcmLastNameValue.TabIndex = 51;
            // 
            // ctcmEmailLabel
            // 
            ctcmEmailLabel.AutoSize = true;
            ctcmEmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ctcmEmailLabel.ForeColor = SystemColors.ControlDarkDark;
            ctcmEmailLabel.Location = new Point(44, 525);
            ctcmEmailLabel.Name = "ctcmEmailLabel";
            ctcmEmailLabel.Size = new Size(48, 21);
            ctcmEmailLabel.TabIndex = 54;
            ctcmEmailLabel.Text = "Email";
            // 
            // ctcmEmailValue
            // 
            ctcmEmailValue.Location = new Point(47, 552);
            ctcmEmailValue.Name = "ctcmEmailValue";
            ctcmEmailValue.Size = new Size(180, 23);
            ctcmEmailValue.TabIndex = 53;
            // 
            // ctcmPhoneNumberLabel
            // 
            ctcmPhoneNumberLabel.AutoSize = true;
            ctcmPhoneNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ctcmPhoneNumberLabel.ForeColor = SystemColors.ControlDarkDark;
            ctcmPhoneNumberLabel.Location = new Point(44, 595);
            ctcmPhoneNumberLabel.Name = "ctcmPhoneNumberLabel";
            ctcmPhoneNumberLabel.Size = new Size(116, 21);
            ctcmPhoneNumberLabel.TabIndex = 56;
            ctcmPhoneNumberLabel.Text = "Phone Number";
            // 
            // ctcmPhoneNumberValue
            // 
            ctcmPhoneNumberValue.Location = new Point(47, 622);
            ctcmPhoneNumberValue.Name = "ctcmPhoneNumberValue";
            ctcmPhoneNumberValue.Size = new Size(180, 23);
            ctcmPhoneNumberValue.TabIndex = 55;
            // 
            // ctButton
            // 
            ctButton.Location = new Point(671, 668);
            ctButton.Name = "ctButton";
            ctButton.Size = new Size(80, 23);
            ctButton.TabIndex = 57;
            ctButton.Text = "CREATE";
            ctButton.UseVisualStyleBackColor = true;
            // 
            // TeamCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 724);
            Controls.Add(ctButton);
            Controls.Add(ctcmPhoneNumberLabel);
            Controls.Add(ctcmPhoneNumberValue);
            Controls.Add(ctcmEmailLabel);
            Controls.Add(ctcmEmailValue);
            Controls.Add(ctcmLastNameLabel);
            Controls.Add(ctcmLastNameValue);
            Controls.Add(ctcmNameLabel);
            Controls.Add(ctcmNameValue);
            Controls.Add(ctCreateMemberHead);
            Controls.Add(label1);
            Controls.Add(ctDeleteSelected);
            Controls.Add(ctPlayersView);
            Controls.Add(ctPlayersViewHead);
            Controls.Add(label5);
            Controls.Add(ctcmButton);
            Controls.Add(ctText);
            Controls.Add(ctSelectMemberLabel);
            Controls.Add(ctNameValue);
            Controls.Add(ctAddMemberButton);
            Controls.Add(ctSelectMemberDrop);
            Controls.Add(ctLabel);
            Controls.Add(ctHead);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TeamCreationForm";
            Text = "TeamCreationForm";
            Load += TeamCreationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PrizesViewLabel;
        private Button ctDeleteSelected;
        private ListBox ctPlayersView;
        private Label ctPlayersViewHead;
        private Label label5;
        private Button CreateNewPrizeButton;
        private Label CreateNewPrizeLabel;
        private Button ctcmButton;
        private Label ctText;
        private Label ctSelectMemberLabel;
        private TextBox ctNameValue;
        private Button ctAddMemberButton;
        private ComboBox ctSelectMemberDrop;
        private Label ctLabel;
        private Label ctHead;
        private Label label1;
        private Label ctCreateMemberHead;
        private TextBox ctcmNameValue;
        private Label ctcmNameLabel;
        private Label ctcmLastNameLabel;
        private TextBox ctcmLastNameValue;
        private Label ctcmEmailLabel;
        private TextBox ctcmEmailValue;
        private Label ctcmPhoneNumberLabel;
        private TextBox ctcmPhoneNumberValue;
        private Button ctButton;
    }
}