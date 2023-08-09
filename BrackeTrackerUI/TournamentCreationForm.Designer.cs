namespace BrackeTrackerUI
{
    partial class TournamentCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentCreationForm));
            ctourSelectTeamAdd = new Button();
            ctourSelectTeamDropdown = new ComboBox();
            ctourNameLabel = new Label();
            ctourHead = new Label();
            ctourNameValue = new TextBox();
            ctourEntryFeeValue = new TextBox();
            ctourEntryFeeLabel = new Label();
            ctourSelectTeamLabel = new Label();
            ctourCreateTeamCTA = new Label();
            ctourCreateTeamButton = new Button();
            ctourCreatePrizeButton = new Button();
            ctourCreatePrizeCTA = new Label();
            label5 = new Label();
            ctourTeamsViewHead = new Label();
            ctourTeamsView = new ListBox();
            ctourTeamsViewDeleteButton = new Button();
            ctourPrizesViewDeleteButton = new Button();
            ctourPrizesView = new ListBox();
            ctourPrizesViewHead = new Label();
            ctourButton = new Button();
            SuspendLayout();
            // 
            // ctourSelectTeamAdd
            // 
            ctourSelectTeamAdd.Location = new Point(240, 318);
            ctourSelectTeamAdd.Name = "ctourSelectTeamAdd";
            ctourSelectTeamAdd.Size = new Size(49, 23);
            ctourSelectTeamAdd.TabIndex = 13;
            ctourSelectTeamAdd.Text = "ADD";
            ctourSelectTeamAdd.UseVisualStyleBackColor = true;
            // 
            // ctourSelectTeamDropdown
            // 
            ctourSelectTeamDropdown.FormattingEnabled = true;
            ctourSelectTeamDropdown.Location = new Point(43, 318);
            ctourSelectTeamDropdown.Name = "ctourSelectTeamDropdown";
            ctourSelectTeamDropdown.Size = new Size(180, 23);
            ctourSelectTeamDropdown.TabIndex = 12;
            // 
            // ctourNameLabel
            // 
            ctourNameLabel.AutoSize = true;
            ctourNameLabel.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctourNameLabel.ForeColor = SystemColors.ControlDarkDark;
            ctourNameLabel.Location = new Point(38, 128);
            ctourNameLabel.Name = "ctourNameLabel";
            ctourNameLabel.Size = new Size(68, 30);
            ctourNameLabel.TabIndex = 11;
            ctourNameLabel.Text = "Name";
            ctourNameLabel.Click += RoundLabel_Click;
            // 
            // ctourHead
            // 
            ctourHead.AutoSize = true;
            ctourHead.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ctourHead.Location = new Point(35, 49);
            ctourHead.Name = "ctourHead";
            ctourHead.Size = new Size(291, 45);
            ctourHead.TabIndex = 10;
            ctourHead.Text = "Create Tournament";
            ctourHead.Click += TournamentLabel_Click;
            // 
            // ctourNameValue
            // 
            ctourNameValue.Location = new Point(43, 165);
            ctourNameValue.Name = "ctourNameValue";
            ctourNameValue.Size = new Size(180, 23);
            ctourNameValue.TabIndex = 14;
            // 
            // ctourEntryFeeValue
            // 
            ctourEntryFeeValue.Location = new Point(43, 240);
            ctourEntryFeeValue.Name = "ctourEntryFeeValue";
            ctourEntryFeeValue.PlaceholderText = "0";
            ctourEntryFeeValue.Size = new Size(180, 23);
            ctourEntryFeeValue.TabIndex = 16;
            // 
            // ctourEntryFeeLabel
            // 
            ctourEntryFeeLabel.AutoSize = true;
            ctourEntryFeeLabel.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctourEntryFeeLabel.ForeColor = SystemColors.ControlDarkDark;
            ctourEntryFeeLabel.Location = new Point(38, 203);
            ctourEntryFeeLabel.Name = "ctourEntryFeeLabel";
            ctourEntryFeeLabel.Size = new Size(99, 30);
            ctourEntryFeeLabel.TabIndex = 15;
            ctourEntryFeeLabel.Text = "Entry Fee";
            // 
            // ctourSelectTeamLabel
            // 
            ctourSelectTeamLabel.AutoSize = true;
            ctourSelectTeamLabel.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctourSelectTeamLabel.ForeColor = SystemColors.WindowFrame;
            ctourSelectTeamLabel.Location = new Point(38, 281);
            ctourSelectTeamLabel.Name = "ctourSelectTeamLabel";
            ctourSelectTeamLabel.Size = new Size(123, 30);
            ctourSelectTeamLabel.TabIndex = 17;
            ctourSelectTeamLabel.Text = "Select Team";
            // 
            // ctourCreateTeamCTA
            // 
            ctourCreateTeamCTA.AutoSize = true;
            ctourCreateTeamCTA.ForeColor = SystemColors.WindowFrame;
            ctourCreateTeamCTA.Location = new Point(43, 376);
            ctourCreateTeamCTA.Name = "ctourCreateTeamCTA";
            ctourCreateTeamCTA.Size = new Size(121, 15);
            ctourCreateTeamCTA.TabIndex = 18;
            ctourCreateTeamCTA.Text = "Can't find your team?";
            // 
            // ctourCreateTeamButton
            // 
            ctourCreateTeamButton.Location = new Point(43, 399);
            ctourCreateTeamButton.Name = "ctourCreateTeamButton";
            ctourCreateTeamButton.Size = new Size(158, 23);
            ctourCreateTeamButton.TabIndex = 19;
            ctourCreateTeamButton.Text = "CREATE NEW TEAM";
            ctourCreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // ctourCreatePrizeButton
            // 
            ctourCreatePrizeButton.Location = new Point(43, 459);
            ctourCreatePrizeButton.Name = "ctourCreatePrizeButton";
            ctourCreatePrizeButton.Size = new Size(158, 23);
            ctourCreatePrizeButton.TabIndex = 21;
            ctourCreatePrizeButton.Text = "CREATE PRIZE";
            ctourCreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // ctourCreatePrizeCTA
            // 
            ctourCreatePrizeCTA.AutoSize = true;
            ctourCreatePrizeCTA.ForeColor = SystemColors.WindowFrame;
            ctourCreatePrizeCTA.Location = new Point(43, 436);
            ctourCreatePrizeCTA.Name = "ctourCreatePrizeCTA";
            ctourCreatePrizeCTA.Size = new Size(114, 15);
            ctourCreatePrizeCTA.TabIndex = 20;
            ctourCreatePrizeCTA.Text = "Want to add a prize?";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(380, -4);
            label5.Name = "label5";
            label5.Size = new Size(10, 699);
            label5.TabIndex = 22;
            // 
            // ctourTeamsViewHead
            // 
            ctourTeamsViewHead.AutoSize = true;
            ctourTeamsViewHead.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctourTeamsViewHead.ForeColor = SystemColors.ControlDarkDark;
            ctourTeamsViewHead.Location = new Point(416, 61);
            ctourTeamsViewHead.Name = "ctourTeamsViewHead";
            ctourTeamsViewHead.Size = new Size(121, 30);
            ctourTeamsViewHead.TabIndex = 23;
            ctourTeamsViewHead.Text = "Teams View";
            // 
            // ctourTeamsView
            // 
            ctourTeamsView.FormattingEnabled = true;
            ctourTeamsView.ItemHeight = 15;
            ctourTeamsView.Location = new Point(425, 112);
            ctourTeamsView.Name = "ctourTeamsView";
            ctourTeamsView.Size = new Size(322, 199);
            ctourTeamsView.TabIndex = 24;
            // 
            // ctourTeamsViewDeleteButton
            // 
            ctourTeamsViewDeleteButton.Location = new Point(608, 329);
            ctourTeamsViewDeleteButton.Name = "ctourTeamsViewDeleteButton";
            ctourTeamsViewDeleteButton.Size = new Size(139, 23);
            ctourTeamsViewDeleteButton.TabIndex = 25;
            ctourTeamsViewDeleteButton.Text = "DELETE SELECTED";
            ctourTeamsViewDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ctourPrizesViewDeleteButton
            // 
            ctourPrizesViewDeleteButton.Location = new Point(608, 639);
            ctourPrizesViewDeleteButton.Name = "ctourPrizesViewDeleteButton";
            ctourPrizesViewDeleteButton.Size = new Size(139, 23);
            ctourPrizesViewDeleteButton.TabIndex = 28;
            ctourPrizesViewDeleteButton.Text = "DELETE SELECTED";
            ctourPrizesViewDeleteButton.UseVisualStyleBackColor = true;
            // 
            // ctourPrizesView
            // 
            ctourPrizesView.FormattingEnabled = true;
            ctourPrizesView.ItemHeight = 15;
            ctourPrizesView.Location = new Point(425, 422);
            ctourPrizesView.Name = "ctourPrizesView";
            ctourPrizesView.Size = new Size(322, 199);
            ctourPrizesView.TabIndex = 27;
            // 
            // ctourPrizesViewHead
            // 
            ctourPrizesViewHead.AutoSize = true;
            ctourPrizesViewHead.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ctourPrizesViewHead.ForeColor = SystemColors.ControlDarkDark;
            ctourPrizesViewHead.Location = new Point(416, 371);
            ctourPrizesViewHead.Name = "ctourPrizesViewHead";
            ctourPrizesViewHead.Size = new Size(117, 30);
            ctourPrizesViewHead.TabIndex = 26;
            ctourPrizesViewHead.Text = "Prizes View";
            ctourPrizesViewHead.Click += label7_Click;
            // 
            // ctourButton
            // 
            ctourButton.Location = new Point(43, 639);
            ctourButton.Name = "ctourButton";
            ctourButton.Size = new Size(158, 23);
            ctourButton.TabIndex = 29;
            ctourButton.Text = "CREATE TOURNAMENT";
            ctourButton.UseVisualStyleBackColor = true;
            // 
            // TournamentCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 689);
            Controls.Add(ctourButton);
            Controls.Add(ctourPrizesViewDeleteButton);
            Controls.Add(ctourPrizesView);
            Controls.Add(ctourPrizesViewHead);
            Controls.Add(ctourTeamsViewDeleteButton);
            Controls.Add(ctourTeamsView);
            Controls.Add(ctourTeamsViewHead);
            Controls.Add(label5);
            Controls.Add(ctourCreatePrizeButton);
            Controls.Add(ctourCreatePrizeCTA);
            Controls.Add(ctourCreateTeamButton);
            Controls.Add(ctourCreateTeamCTA);
            Controls.Add(ctourSelectTeamLabel);
            Controls.Add(ctourEntryFeeValue);
            Controls.Add(ctourEntryFeeLabel);
            Controls.Add(ctourNameValue);
            Controls.Add(ctourSelectTeamAdd);
            Controls.Add(ctourSelectTeamDropdown);
            Controls.Add(ctourNameLabel);
            Controls.Add(ctourHead);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TournamentCreationForm";
            Text = "TournamentCreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ctourSelectTeamAdd;
        private ComboBox ctourSelectTeamDropdown;
        private Label ctourNameLabel;
        private Label ctourHead;
        private TextBox ctourNameValue;
        private TextBox ctourEntryFeeValue;
        private Label ctourEntryFeeLabel;
        private Label ctourSelectTeamLabel;
        private Label ctourCreateTeamCTA;
        private Button ctourCreateTeamButton;
        private Button ctourCreatePrizeButton;
        private Label ctourCreatePrizeCTA;
        private Label label5;
        private Label ctourTeamsViewHead;
        private ListBox ctourTeamsView;
        private Button ctourTeamsViewDeleteButton;
        private Button ctourPrizesViewDeleteButton;
        private ListBox ctourPrizesView;
        private Label ctourPrizesViewHead;
        private Button ctourButton;
    }
}