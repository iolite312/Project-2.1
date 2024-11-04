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
            employeeListBtn = new Button();
            currentIncidentsText = new Label();
            openTicketsLabel = new Label();
            closedTicketsLabel = new Label();
            resolvedTicketsLabel = new Label();
            subViewPanel = new Panel();
            createTicketBtn = new Button();
            ticketsListBtn = new Button();
            dashBoardBtn = new Button();
            SuspendLayout();
            // 
            // employeeListBtn
            // 
            employeeListBtn.BackColor = SystemColors.ActiveCaption;
            employeeListBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            employeeListBtn.Location = new Point(787, 43);
            employeeListBtn.Margin = new Padding(0);
            employeeListBtn.Name = "employeeListBtn";
            employeeListBtn.Size = new Size(167, 43);
            employeeListBtn.TabIndex = 0;
            employeeListBtn.Text = "Show employees";
            employeeListBtn.UseVisualStyleBackColor = false;
            employeeListBtn.Click += showListBtn_Click;
            // 
            // currentIncidentsText
            // 
            currentIncidentsText.AutoSize = true;
            currentIncidentsText.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            currentIncidentsText.Location = new Point(10, 43);
            currentIncidentsText.Margin = new Padding(2, 0, 2, 0);
            currentIncidentsText.Name = "currentIncidentsText";
            currentIncidentsText.Size = new Size(238, 37);
            currentIncidentsText.TabIndex = 1;
            currentIncidentsText.Text = "Current Incidents";
            // 
            // openTicketsLabel
            // 
            openTicketsLabel.AutoSize = true;
            openTicketsLabel.Location = new Point(56, 192);
            openTicketsLabel.Margin = new Padding(2, 0, 2, 0);
            openTicketsLabel.Name = "openTicketsLabel";
            openTicketsLabel.Size = new Size(94, 20);
            openTicketsLabel.TabIndex = 2;
            openTicketsLabel.Text = "Open Tickets";
            // 
            // closedTicketsLabel
            // 
            closedTicketsLabel.AutoSize = true;
            closedTicketsLabel.Location = new Point(408, 192);
            closedTicketsLabel.Margin = new Padding(2, 0, 2, 0);
            closedTicketsLabel.Name = "closedTicketsLabel";
            closedTicketsLabel.Size = new Size(103, 20);
            closedTicketsLabel.TabIndex = 3;
            closedTicketsLabel.Text = "Closed Tickets";
            // 
            // resolvedTicketsLabel
            // 
            resolvedTicketsLabel.AutoSize = true;
            resolvedTicketsLabel.Location = new Point(220, 192);
            resolvedTicketsLabel.Margin = new Padding(2, 0, 2, 0);
            resolvedTicketsLabel.Name = "resolvedTicketsLabel";
            resolvedTicketsLabel.Size = new Size(118, 20);
            resolvedTicketsLabel.TabIndex = 3;
            resolvedTicketsLabel.Text = "Resolved Tickets";
            // 
            // subViewPanel
            // 
            subViewPanel.Location = new Point(14, 148);
            subViewPanel.Margin = new Padding(2);
            subViewPanel.Name = "subViewPanel";
            subViewPanel.Size = new Size(1227, 650);
            subViewPanel.TabIndex = 4;
            subViewPanel.Visible = false;
            // 
            // createTicketBtn
            // 
            createTicketBtn.BackColor = SystemColors.ActiveCaption;
            createTicketBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createTicketBtn.Location = new Point(450, 41);
            createTicketBtn.Margin = new Padding(0);
            createTicketBtn.Name = "createTicketBtn";
            createTicketBtn.Size = new Size(139, 45);
            createTicketBtn.TabIndex = 5;
            createTicketBtn.Text = "Create Ticket";
            createTicketBtn.UseVisualStyleBackColor = false;
            createTicketBtn.Click += createTicketBtn_Click;
            // 
            // ticketsListBtn
            // 
            ticketsListBtn.BackColor = SystemColors.ActiveCaption;
            ticketsListBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ticketsListBtn.Location = new Point(605, 43);
            ticketsListBtn.Margin = new Padding(0);
            ticketsListBtn.Name = "ticketsListBtn";
            ticketsListBtn.Size = new Size(156, 43);
            ticketsListBtn.TabIndex = 6;
            ticketsListBtn.Text = "Show Tickets";
            ticketsListBtn.UseVisualStyleBackColor = false;
            ticketsListBtn.Click += ticketsListBtn_Click;
            // 
            // dashBoardBtn
            // 
            dashBoardBtn.BackColor = SystemColors.ActiveCaption;
            dashBoardBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dashBoardBtn.Location = new Point(308, 41);
            dashBoardBtn.Margin = new Padding(0);
            dashBoardBtn.Name = "dashBoardBtn";
            dashBoardBtn.Size = new Size(122, 45);
            dashBoardBtn.TabIndex = 7;
            dashBoardBtn.Text = "Dashboard";
            dashBoardBtn.UseVisualStyleBackColor = false;
            dashBoardBtn.Click += dashBoardBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 630);
            Controls.Add(dashBoardBtn);
            Controls.Add(ticketsListBtn);
            Controls.Add(createTicketBtn);
            Controls.Add(subViewPanel);
            Controls.Add(closedTicketsLabel);
            Controls.Add(resolvedTicketsLabel);
            Controls.Add(openTicketsLabel);
            Controls.Add(currentIncidentsText);
            Controls.Add(employeeListBtn);
            Margin = new Padding(2);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
            ClosedTicketsPanel();
            OpenTicketPanel();
            ResolvedTicketPanel();
        }

        #endregion

        private Button employeeListBtn;
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
        private Button createTicketBtn;
        private Button ticketsListBtn;
        private Button dashBoardBtn;
    }
}