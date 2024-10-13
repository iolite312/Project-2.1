using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UI.DashboardUI
{
    public partial class Dashboard : Form
    {
        Employee Employee;
        public Dashboard(Employee employee)
        {
            this.Employee = employee;
            InitializeComponent();
            unresolvedIncidentsPanel(150);
            pastDeadlineIncidentsPanel(150);
        }
        private void pastDeadlineIncidentsPanel(int size)
        {
            // Panel for past deadline incidents
            pastDeadlinePanel = new Panel();
            pastDeadlinePanel.Location = new Point(size+180, 150);
            pastDeadlinePanel.Size = new Size(size, size);
            pastDeadlinePanel.Paint += PastDeadlinePanel_Paint;
            this.Controls.Add(pastDeadlinePanel);
        }
        private void unresolvedIncidentsPanel(int size)
        {
            // Panel for unresolved incidents
            unresolvedPanel = new Panel();
            unresolvedPanel.Location = new Point(30, 150);
            unresolvedPanel.Size = new Size(size, size);
            unresolvedPanel.Paint += UnresolvedPanel_Paint;
            this.Controls.Add(unresolvedPanel);
        }
        private void UnresolvedPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCircularProgressBar(e.Graphics, 7, 15, Color.Orange, unresolvedPanel.Width, unresolvedPanel.Height);
        }
        private void PastDeadlinePanel_Paint(object sender, PaintEventArgs e)
        {
            DrawCircularProgressBar(e.Graphics, 1, 3, Color.Red, pastDeadlinePanel.Width, pastDeadlinePanel.Height);
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
        private void showListBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
