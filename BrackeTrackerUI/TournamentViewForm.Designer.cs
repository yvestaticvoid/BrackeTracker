namespace BrackeTrackerUI
{
    partial class TournamentViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewForm));
            tourHead = new Label();
            tourNameValue = new Label();
            tourRoundLabel = new Label();
            tourRoundDropdown = new ComboBox();
            tourMatchupView = new ListBox();
            tourUnplayedCheckbox = new CheckBox();
            tourTeamNameValue1 = new Label();
            tourTeamScoreLabel1 = new Label();
            tourTeamScoreValue1 = new TextBox();
            tourAddScoreTeamButton1 = new Button();
            tourAddScoreTeamButton2 = new Button();
            tourTeamScoreValue2 = new TextBox();
            tourTeamScoreLabel2 = new Label();
            tourTeamNameValue2 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tourHead
            // 
            tourHead.AutoSize = true;
            tourHead.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tourHead.Location = new Point(39, 39);
            tourHead.Name = "tourHead";
            tourHead.Size = new Size(190, 45);
            tourHead.TabIndex = 0;
            tourHead.Text = "Tournament";
            // 
            // tourNameValue
            // 
            tourNameValue.AutoSize = true;
            tourNameValue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tourNameValue.Location = new Point(219, 39);
            tourNameValue.Name = "tourNameValue";
            tourNameValue.Size = new Size(152, 45);
            tourNameValue.TabIndex = 1;
            tourNameValue.Text = "<NONE>";
            // 
            // tourRoundLabel
            // 
            tourRoundLabel.AutoSize = true;
            tourRoundLabel.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tourRoundLabel.ForeColor = SystemColors.ControlDarkDark;
            tourRoundLabel.Location = new Point(44, 102);
            tourRoundLabel.Name = "tourRoundLabel";
            tourRoundLabel.Size = new Size(72, 30);
            tourRoundLabel.TabIndex = 2;
            tourRoundLabel.Text = "Round";
            // 
            // tourRoundDropdown
            // 
            tourRoundDropdown.FormattingEnabled = true;
            tourRoundDropdown.Location = new Point(49, 138);
            tourRoundDropdown.Name = "tourRoundDropdown";
            tourRoundDropdown.Size = new Size(180, 23);
            tourRoundDropdown.TabIndex = 3;
            // 
            // tourMatchupView
            // 
            tourMatchupView.FormattingEnabled = true;
            tourMatchupView.ItemHeight = 15;
            tourMatchupView.Location = new Point(49, 215);
            tourMatchupView.Name = "tourMatchupView";
            tourMatchupView.Size = new Size(322, 199);
            tourMatchupView.TabIndex = 4;
            // 
            // tourUnplayedCheckbox
            // 
            tourUnplayedCheckbox.AutoSize = true;
            tourUnplayedCheckbox.Checked = true;
            tourUnplayedCheckbox.CheckState = CheckState.Checked;
            tourUnplayedCheckbox.ForeColor = SystemColors.ControlDarkDark;
            tourUnplayedCheckbox.Location = new Point(49, 172);
            tourUnplayedCheckbox.Name = "tourUnplayedCheckbox";
            tourUnplayedCheckbox.Size = new Size(102, 19);
            tourUnplayedCheckbox.TabIndex = 5;
            tourUnplayedCheckbox.Text = "Unplayed only";
            tourUnplayedCheckbox.UseVisualStyleBackColor = true;
            // 
            // tourTeamNameValue1
            // 
            tourTeamNameValue1.AutoSize = true;
            tourTeamNameValue1.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tourTeamNameValue1.ForeColor = SystemColors.ControlText;
            tourTeamNameValue1.Location = new Point(526, 66);
            tourTeamNameValue1.Name = "tourTeamNameValue1";
            tourTeamNameValue1.Size = new Size(178, 30);
            tourTeamNameValue1.TabIndex = 6;
            tourTeamNameValue1.Text = "<Sample Team 1>";
            tourTeamNameValue1.Click += label1_Click;
            // 
            // tourTeamScoreLabel1
            // 
            tourTeamScoreLabel1.AutoSize = true;
            tourTeamScoreLabel1.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tourTeamScoreLabel1.ForeColor = SystemColors.ControlDarkDark;
            tourTeamScoreLabel1.Location = new Point(526, 107);
            tourTeamScoreLabel1.Name = "tourTeamScoreLabel1";
            tourTeamScoreLabel1.Size = new Size(58, 25);
            tourTeamScoreLabel1.TabIndex = 7;
            tourTeamScoreLabel1.Text = "Score";
            // 
            // tourTeamScoreValue1
            // 
            tourTeamScoreValue1.Location = new Point(533, 138);
            tourTeamScoreValue1.Name = "tourTeamScoreValue1";
            tourTeamScoreValue1.Size = new Size(143, 23);
            tourTeamScoreValue1.TabIndex = 8;
            // 
            // tourAddScoreTeamButton1
            // 
            tourAddScoreTeamButton1.Location = new Point(682, 138);
            tourAddScoreTeamButton1.Name = "tourAddScoreTeamButton1";
            tourAddScoreTeamButton1.Size = new Size(49, 23);
            tourAddScoreTeamButton1.TabIndex = 9;
            tourAddScoreTeamButton1.Text = "ADD";
            tourAddScoreTeamButton1.UseVisualStyleBackColor = true;
            // 
            // tourAddScoreTeamButton2
            // 
            tourAddScoreTeamButton2.Location = new Point(682, 350);
            tourAddScoreTeamButton2.Name = "tourAddScoreTeamButton2";
            tourAddScoreTeamButton2.Size = new Size(49, 23);
            tourAddScoreTeamButton2.TabIndex = 13;
            tourAddScoreTeamButton2.Text = "ADD";
            tourAddScoreTeamButton2.UseVisualStyleBackColor = true;
            // 
            // tourTeamScoreValue2
            // 
            tourTeamScoreValue2.Location = new Point(533, 350);
            tourTeamScoreValue2.Name = "tourTeamScoreValue2";
            tourTeamScoreValue2.Size = new Size(143, 23);
            tourTeamScoreValue2.TabIndex = 12;
            // 
            // tourTeamScoreLabel2
            // 
            tourTeamScoreLabel2.AutoSize = true;
            tourTeamScoreLabel2.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tourTeamScoreLabel2.ForeColor = SystemColors.ControlDarkDark;
            tourTeamScoreLabel2.Location = new Point(526, 319);
            tourTeamScoreLabel2.Name = "tourTeamScoreLabel2";
            tourTeamScoreLabel2.Size = new Size(58, 25);
            tourTeamScoreLabel2.TabIndex = 11;
            tourTeamScoreLabel2.Text = "Score";
            // 
            // tourTeamNameValue2
            // 
            tourTeamNameValue2.AutoSize = true;
            tourTeamNameValue2.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tourTeamNameValue2.ForeColor = SystemColors.ControlText;
            tourTeamNameValue2.Location = new Point(526, 278);
            tourTeamNameValue2.Name = "tourTeamNameValue2";
            tourTeamNameValue2.Size = new Size(181, 30);
            tourTeamNameValue2.TabIndex = 10;
            tourTeamNameValue2.Text = "<Sample Team 2>";
            tourTeamNameValue2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(440, -4);
            label1.Name = "label1";
            label1.Size = new Size(2, 455);
            label1.TabIndex = 14;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(440, 215);
            label2.Name = "label2";
            label2.Size = new Size(360, 2);
            label2.TabIndex = 15;
            // 
            // TournamentViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tourAddScoreTeamButton2);
            Controls.Add(tourTeamScoreValue2);
            Controls.Add(tourTeamScoreLabel2);
            Controls.Add(tourTeamNameValue2);
            Controls.Add(tourAddScoreTeamButton1);
            Controls.Add(tourTeamScoreValue1);
            Controls.Add(tourTeamScoreLabel1);
            Controls.Add(tourTeamNameValue1);
            Controls.Add(tourUnplayedCheckbox);
            Controls.Add(tourMatchupView);
            Controls.Add(tourRoundDropdown);
            Controls.Add(tourRoundLabel);
            Controls.Add(tourNameValue);
            Controls.Add(tourHead);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(300, 400);
            Name = "TournamentViewForm";
            Text = "Form1";
            Load += TournamentViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tourHead;
        private Label tourNameValue;
        private Label tourRoundLabel;
        private ComboBox tourRoundDropdown;
        private ListBox tourMatchupView;
        private CheckBox tourUnplayedCheckbox;
        private Label tourTeamNameValue1;
        private Label tourTeamScoreLabel1;
        private TextBox tourTeamScoreValue1;
        private Button tourAddScoreTeamButton1;
        private Button tourAddScoreTeamButton2;
        private TextBox tourTeamScoreValue2;
        private Label tourTeamScoreLabel2;
        private Label tourTeamNameValue2;
        private Label label1;
        private Label label2;
    }
}