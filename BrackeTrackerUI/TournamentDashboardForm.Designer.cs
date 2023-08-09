namespace BrackeTrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            tdViewTournamentsLabel = new Label();
            tdSelectTournamentDropdown = new ComboBox();
            tdLabel = new Label();
            tdOpenTournamentButton = new Button();
            tdCreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // tdViewTournamentsLabel
            // 
            tdViewTournamentsLabel.AutoSize = true;
            tdViewTournamentsLabel.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tdViewTournamentsLabel.ForeColor = SystemColors.WindowFrame;
            tdViewTournamentsLabel.Location = new Point(237, 127);
            tdViewTournamentsLabel.Name = "tdViewTournamentsLabel";
            tdViewTournamentsLabel.Size = new Size(183, 30);
            tdViewTournamentsLabel.TabIndex = 21;
            tdViewTournamentsLabel.Text = "View Tournaments";
            // 
            // tdSelectTournamentDropdown
            // 
            tdSelectTournamentDropdown.FormattingEnabled = true;
            tdSelectTournamentDropdown.Location = new Point(237, 194);
            tdSelectTournamentDropdown.Name = "tdSelectTournamentDropdown";
            tdSelectTournamentDropdown.Size = new Size(180, 23);
            tdSelectTournamentDropdown.TabIndex = 19;
            // 
            // tdLabel
            // 
            tdLabel.AutoSize = true;
            tdLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tdLabel.Location = new Point(147, 77);
            tdLabel.Name = "tdLabel";
            tdLabel.Size = new Size(353, 45);
            tdLabel.TabIndex = 18;
            tdLabel.Text = "Tournament Dashboard";
            // 
            // tdOpenTournamentButton
            // 
            tdOpenTournamentButton.Location = new Point(237, 233);
            tdOpenTournamentButton.Name = "tdOpenTournamentButton";
            tdOpenTournamentButton.Size = new Size(74, 23);
            tdOpenTournamentButton.TabIndex = 22;
            tdOpenTournamentButton.Text = "OPEN";
            tdOpenTournamentButton.UseVisualStyleBackColor = true;
            // 
            // tdCreateTournamentButton
            // 
            tdCreateTournamentButton.Location = new Point(343, 233);
            tdCreateTournamentButton.Name = "tdCreateTournamentButton";
            tdCreateTournamentButton.Size = new Size(74, 23);
            tdCreateTournamentButton.TabIndex = 23;
            tdCreateTournamentButton.Text = "CREATE";
            tdCreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(649, 347);
            Controls.Add(tdCreateTournamentButton);
            Controls.Add(tdOpenTournamentButton);
            Controls.Add(tdViewTournamentsLabel);
            Controls.Add(tdSelectTournamentDropdown);
            Controls.Add(tdLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboard";
            Load += TournamentDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tdViewTournamentsLabel;
        private ComboBox tdSelectTournamentDropdown;
        private Label tdLabel;
        private Button tdOpenTournamentButton;
        private Button tdCreateTournamentButton;
    }
}