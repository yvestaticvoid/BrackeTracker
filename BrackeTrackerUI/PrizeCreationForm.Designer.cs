namespace BrackeTrackerUI
{
    partial class PrizeCreationForm
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
            cpzAmountLabel = new Label();
            cpzAmountValue = new TextBox();
            cpzNameLabel = new Label();
            cpzNameValue = new TextBox();
            cpzNumberLabel = new Label();
            cpzNumberValue = new TextBox();
            cpzHeader = new Label();
            cpzButton = new Button();
            cpzPercentageCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // cpzAmountLabel
            // 
            cpzAmountLabel.AutoSize = true;
            cpzAmountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpzAmountLabel.ForeColor = SystemColors.ControlDarkDark;
            cpzAmountLabel.Location = new Point(51, 239);
            cpzAmountLabel.Name = "cpzAmountLabel";
            cpzAmountLabel.Size = new Size(104, 21);
            cpzAmountLabel.TabIndex = 64;
            cpzAmountLabel.Text = "Price Amount";
            // 
            // cpzAmountValue
            // 
            cpzAmountValue.Location = new Point(54, 266);
            cpzAmountValue.Name = "cpzAmountValue";
            cpzAmountValue.Size = new Size(180, 23);
            cpzAmountValue.TabIndex = 63;
            // 
            // cpzNameLabel
            // 
            cpzNameLabel.AutoSize = true;
            cpzNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpzNameLabel.ForeColor = SystemColors.ControlDarkDark;
            cpzNameLabel.Location = new Point(51, 168);
            cpzNameLabel.Name = "cpzNameLabel";
            cpzNameLabel.Size = new Size(92, 21);
            cpzNameLabel.TabIndex = 62;
            cpzNameLabel.Text = "Place Name";
            // 
            // cpzNameValue
            // 
            cpzNameValue.Location = new Point(54, 195);
            cpzNameValue.Name = "cpzNameValue";
            cpzNameValue.Size = new Size(180, 23);
            cpzNameValue.TabIndex = 61;
            // 
            // cpzNumberLabel
            // 
            cpzNumberLabel.AutoSize = true;
            cpzNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cpzNumberLabel.ForeColor = SystemColors.ControlDarkDark;
            cpzNumberLabel.Location = new Point(51, 100);
            cpzNumberLabel.Name = "cpzNumberLabel";
            cpzNumberLabel.Size = new Size(108, 21);
            cpzNumberLabel.TabIndex = 60;
            cpzNumberLabel.Text = "Place Number";
            // 
            // cpzNumberValue
            // 
            cpzNumberValue.Location = new Point(54, 127);
            cpzNumberValue.Name = "cpzNumberValue";
            cpzNumberValue.Size = new Size(180, 23);
            cpzNumberValue.TabIndex = 59;
            // 
            // cpzHeader
            // 
            cpzHeader.AutoSize = true;
            cpzHeader.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cpzHeader.ForeColor = SystemColors.ControlText;
            cpzHeader.Location = new Point(50, 39);
            cpzHeader.Name = "cpzHeader";
            cpzHeader.Size = new Size(124, 30);
            cpzHeader.TabIndex = 58;
            cpzHeader.Text = "Create Prize";
            // 
            // cpzButton
            // 
            cpzButton.Location = new Point(251, 382);
            cpzButton.Name = "cpzButton";
            cpzButton.Size = new Size(80, 23);
            cpzButton.TabIndex = 57;
            cpzButton.Text = "CREATE";
            cpzButton.UseVisualStyleBackColor = true;
            // 
            // cpzPercentageCheckbox
            // 
            cpzPercentageCheckbox.AutoSize = true;
            cpzPercentageCheckbox.Checked = true;
            cpzPercentageCheckbox.CheckState = CheckState.Checked;
            cpzPercentageCheckbox.ForeColor = SystemColors.ControlDarkDark;
            cpzPercentageCheckbox.Location = new Point(54, 295);
            cpzPercentageCheckbox.Name = "cpzPercentageCheckbox";
            cpzPercentageCheckbox.Size = new Size(96, 19);
            cpzPercentageCheckbox.TabIndex = 65;
            cpzPercentageCheckbox.Text = "Is percentage";
            cpzPercentageCheckbox.UseVisualStyleBackColor = true;
            // 
            // PrizeCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(379, 450);
            Controls.Add(cpzPercentageCheckbox);
            Controls.Add(cpzAmountLabel);
            Controls.Add(cpzAmountValue);
            Controls.Add(cpzNameLabel);
            Controls.Add(cpzNameValue);
            Controls.Add(cpzNumberLabel);
            Controls.Add(cpzNumberValue);
            Controls.Add(cpzHeader);
            Controls.Add(cpzButton);
            Name = "PrizeCreationForm";
            Text = "PrizeCreationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cpzAmountLabel;
        private TextBox cpzAmountValue;
        private Label cpzNameLabel;
        private TextBox cpzNameValue;
        private Label cpzNumberLabel;
        private TextBox cpzNumberValue;
        private Label cpzHeader;
        private Button cpzButton;
        private CheckBox cpzPercentageCheckbox;
    }
}