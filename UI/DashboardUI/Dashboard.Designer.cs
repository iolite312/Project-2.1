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
            openTicketsLabel = new Label();
            closedTicketsLabel = new Label();
            resolvedTicketsLabel = new Label();
            subViewPanel = new Panel();
            SuspendLayout();
            // 
            // shwoListBtn
            // 
            shwoListBtn.BackColor = SystemColors.ActiveCaption;
            shwoListBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            shwoListBtn.Location = new Point(524, 73);
            shwoListBtn.Margin = new Padding(0);
            shwoListBtn.Name = "shwoListBtn";
            shwoListBtn.Size = new Size(214, 83);
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
            // openTicketsLabel
            // 
            openTicketsLabel.AutoSize = true;
            openTicketsLabel.Location = new Point(70, 240);
            openTicketsLabel.Name = "openTicketsLabel";
            openTicketsLabel.Size = new Size(50, 15);
            openTicketsLabel.TabIndex = 2;
            openTicketsLabel.Text = "Open Tickets";
            // 
            // closedTicketsLabel
            // 
            closedTicketsLabel.AutoSize = true;
            closedTicketsLabel.Location = new Point(510, 240);
            closedTicketsLabel.Name = "closedTicketsLabel";
            closedTicketsLabel.Size = new Size(50, 15);
            closedTicketsLabel.TabIndex = 3;
            closedTicketsLabel.Text = "Closed Tickets";
            // 
            // resolvedTicketsLabel
            // 
            resolvedTicketsLabel.AutoSize = true;
            resolvedTicketsLabel.Location = new Point(275, 240);
            resolvedTicketsLabel.Name = "resolvedTicketsLabel";
            resolvedTicketsLabel.Size = new Size(50, 15);
            resolvedTicketsLabel.TabIndex = 3;
            resolvedTicketsLabel.Text = "Resolved Tickets";
            // 
            // subViewPanel
            // 
            subViewPanel.Location = new Point(17, 185);
            subViewPanel.Name = "subViewPanel";
            subViewPanel.Size = new Size(1500, 700);
            subViewPanel.TabIndex = 4;
            subViewPanel.Visible = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 583);
            Controls.Add(subViewPanel);
            Controls.Add(closedTicketsLabel);
            Controls.Add(resolvedTicketsLabel);
            Controls.Add(openTicketsLabel);
            Controls.Add(currentIncidentsText);
            Controls.Add(shwoListBtn);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
            ClosedTicketsPanel();
            OpenTicketPanel();
            ResolvedTicketPanel();
        }

        #endregion

        private Button shwoListBtn;
        private Label currentIncidentsText;
        private Label resolvedTicketsLabel;
        private Label openTicketsLabel;
        private Label closedTicketsLabel;

        Panel openTicketPanel;
        Panel closedTicketsPanel;
        Panel resolvedTicketsPanel;

        private void ClosedTicketsPanel()
        {
            // Panel for past deadline incidents
            closedTicketsPanel = new Panel();
            closedTicketsPanel.Location = new Point(200 + 250+ 20, 275);
            closedTicketsPanel.Size = new Size(200, 200);
            closedTicketsPanel.Tag = closedTickets;
            closedTicketsPanel.ForeColor = Color.Orange;
            closedTicketsPanel.Paint += CircularProgressBarMaker;
            this.Controls.Add(closedTicketsPanel);
        }
        
        private void OpenTicketPanel()
        {
            // Panel for unresolved incidents
            openTicketPanel = new Panel();
            openTicketPanel.Location = new Point(30, 275);
            openTicketPanel.Size = new Size(200, 200);
            openTicketPanel.Tag = openTickets;
            openTicketPanel.ForeColor = Color.Red;
            openTicketPanel.Paint += CircularProgressBarMaker;
            this.Controls.Add(openTicketPanel);
        }
        private void ResolvedTicketPanel()
        {
            // Panel for unresolved incidents
            resolvedTicketsPanel = new Panel();
            resolvedTicketsPanel.Location = new Point(250, 275);
            resolvedTicketsPanel.Size = new Size(200, 200);
            resolvedTicketsPanel.Tag = resolvedTickets;
            resolvedTicketsPanel.ForeColor = Color.Green;
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
            float percentage = (float)current / total;
            float sweepAngle = percentage * 360;

            g.FillEllipse(new SolidBrush(Color.LightGray), 0, 0, width, height);

            g.FillPie(new SolidBrush(color), 0, 0, width, height, -90, sweepAngle);

            int innerSize = (int)(width * 0.7);
            g.FillEllipse(new SolidBrush(Color.White), width / 2 - innerSize / 2, height / 2 - innerSize / 2, innerSize, innerSize);

            string text = $"{percentage * 100:F1}%";
            
            Font font = new Font("Arial", 20, FontStyle.Bold);
            SizeF textSize = g.MeasureString(text, font);

            float textX = (width / 2) - (textSize.Width / 2);
            float textY = (height / 2) - (textSize.Height / 2);

            g.DrawString(text, font, new SolidBrush(Color.Black), textX, textY);
        }

        private Panel subViewPanel;
    }
}