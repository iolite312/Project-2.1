namespace UI.DashboardUI
{
    partial class Dashboard
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
            shwoListBtn = new Button();
            currentIncidentsText = new Label();
            unresolvedIncidentsLabel = new Label();
            pastDeadlineLabel = new Label();
            SuspendLayout();
            // 
            // shwoListBtn
            // 
            shwoListBtn.BackColor = SystemColors.ActiveCaption;
            shwoListBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            shwoListBtn.Location = new Point(367, 44);
            shwoListBtn.Margin = new Padding(0);
            shwoListBtn.Name = "shwoListBtn";
            shwoListBtn.Size = new Size(150, 50);
            shwoListBtn.TabIndex = 0;
            shwoListBtn.Text = "SHOW LIST";
            shwoListBtn.UseVisualStyleBackColor = false;
            shwoListBtn.Click += showListBtn_Click;
            // 
            // currentIncidentsText
            // 
            currentIncidentsText.AutoSize = true;
            currentIncidentsText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            currentIncidentsText.Location = new Point(12, 54);
            currentIncidentsText.Name = "currentIncidentsText";
            currentIncidentsText.Size = new Size(183, 30);
            currentIncidentsText.TabIndex = 1;
            currentIncidentsText.Text = "Current Incidents";
            // 
            // unresolvedIncidentsLabel
            // 
            unresolvedIncidentsLabel.AutoSize = true;
            unresolvedIncidentsLabel.Location = new Point(34, 117);
            unresolvedIncidentsLabel.Name = "unresolvedIncidentsLabel";
            unresolvedIncidentsLabel.Size = new Size(117, 15);
            unresolvedIncidentsLabel.TabIndex = 2;
            unresolvedIncidentsLabel.Text = "Unresolved Incidents";
            // 
            // pastDeadlineLabel
            // 
            pastDeadlineLabel.AutoSize = true;
            pastDeadlineLabel.Location = new Point(346, 117);
            pastDeadlineLabel.Name = "pastDeadlineLabel";
            pastDeadlineLabel.Size = new Size(128, 15);
            pastDeadlineLabel.TabIndex = 3;
            pastDeadlineLabel.Text = "Incidents past deadline";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 350);
            Controls.Add(pastDeadlineLabel);
            Controls.Add(unresolvedIncidentsLabel);
            Controls.Add(currentIncidentsText);
            Controls.Add(shwoListBtn);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button shwoListBtn;
        private Label currentIncidentsText;
        private Label unresolvedIncidentsLabel;
        private Label pastDeadlineLabel;
    }
}