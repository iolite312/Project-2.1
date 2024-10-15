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
            OpenTicketPanel();
            ClosedTicketsPanel();
            ResolvedTicketPanel();
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

        Panel openTicketPanel;
        Panel closedTicketsPanel;
        Panel resolvedTicketsPanel;

        private void ClosedTicketsPanel()
        {
            // Panel for past deadline incidents
            closedTicketsPanel = new Panel();
            closedTicketsPanel.Location = new Point(150 + 150+30, 150);
            closedTicketsPanel.Size = new Size(150, 150);
            closedTicketsPanel.Tag = Opentickets;
            closedTicketsPanel.ForeColor = Color.Orange;
            closedTicketsPanel.Paint += CircularProgressBarMaker;
            this.Controls.Add(closedTicketsPanel);
        }
        
        private void OpenTicketPanel()
        {
            // Panel for unresolved incidents
            openTicketPanel = new Panel();
            openTicketPanel.Location = new Point(30, 150);
            openTicketPanel.Size = new Size(150, 150);
            openTicketPanel.Tag = Opentickets;
            openTicketPanel.ForeColor = Color.Red;
            openTicketPanel.Paint += CircularProgressBarMaker;
            this.Controls.Add(openTicketPanel);
        }
        private void ResolvedTicketPanel()
        {
            // Panel for unresolved incidents
            resolvedTicketsPanel = new Panel();
            resolvedTicketsPanel.Location = new Point(250, 150);
            resolvedTicketsPanel.Size = new Size(150, 150);
            resolvedTicketsPanel.Tag = Opentickets;
            resolvedTicketsPanel.ForeColor = Color.Red;
            resolvedTicketsPanel.Paint += CircularProgressBarMaker;
            this.Controls.Add(resolvedTicketsPanel);
        }
        private void CircularProgressBarMaker(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            DrawCircularProgressBar(e.Graphics, (int)panel.Tag, AllTickets, panel.ForeColor, panel.Width, panel.Height);
        }
       
       
        private void DrawCircularProgressBar(Graphics g, int current, int total, Color color, int width, int height)
        {
            // Calculate percentage
            float percentage = (float)current / total;
            float sweepAngle = percentage * 360;

            // Draw background circle
            g.FillEllipse(new SolidBrush(Color.LightGray), 0, 0, width, height);

            // Draw progress arc
            g.FillPie(new SolidBrush(color), 0, 0, width, height, -90, sweepAngle);

            // Draw inner circle to make it look like a ring
            int innerSize = (int)(width * 0.7);
            g.FillEllipse(new SolidBrush(Color.White), width / 2 - innerSize / 2, height / 2 - innerSize / 2, innerSize, innerSize);

            // Prepare the text to draw
            string text = $"{current}/{total}";
            Font font = new Font("Arial", 20, FontStyle.Bold);
            SizeF textSize = g.MeasureString(text, font);

            // Calculate the position to center the text in the inner circle
            float textX = (width / 2) - (textSize.Width / 2);
            float textY = (height / 2) - (textSize.Height / 2);

            // Draw the text
            g.DrawString(text, font, new SolidBrush(Color.Black), textX, textY);
        }
    }
}