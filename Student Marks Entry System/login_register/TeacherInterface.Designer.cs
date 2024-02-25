
namespace marks_entry
{
    partial class TeacherInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.enterMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.particularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(837, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Marks Entry System";
            // 
            // enterMarksToolStripMenuItem
            // 
            this.enterMarksToolStripMenuItem.Name = "enterMarksToolStripMenuItem";
            this.enterMarksToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.enterMarksToolStripMenuItem.Text = "Enter_Marks";
            this.enterMarksToolStripMenuItem.Click += new System.EventHandler(this.enterMarksToolStripMenuItem_Click);
            // 
            // updateMarksToolStripMenuItem
            // 
            this.updateMarksToolStripMenuItem.Name = "updateMarksToolStripMenuItem";
            this.updateMarksToolStripMenuItem.Size = new System.Drawing.Size(152, 32);
            this.updateMarksToolStripMenuItem.Text = "Update_Marks";
            this.updateMarksToolStripMenuItem.Click += new System.EventHandler(this.updateMarksToolStripMenuItem_Click);
            // 
            // viewMarksToolStripMenuItem
            // 
            this.viewMarksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.particularToolStripMenuItem});
            this.viewMarksToolStripMenuItem.Name = "viewMarksToolStripMenuItem";
            this.viewMarksToolStripMenuItem.Size = new System.Drawing.Size(128, 32);
            this.viewMarksToolStripMenuItem.Text = "View_Marks";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // particularToolStripMenuItem
            // 
            this.particularToolStripMenuItem.Name = "particularToolStripMenuItem";
            this.particularToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.particularToolStripMenuItem.Text = "Particular";
            this.particularToolStripMenuItem.Click += new System.EventHandler(this.particularToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterMarksToolStripMenuItem,
            this.updateMarksToolStripMenuItem,
            this.viewMarksToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(548, 130);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Size = new System.Drawing.Size(568, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1371, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mainPanel.Location = new System.Drawing.Point(12, 186);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1473, 565);
            this.mainPanel.TabIndex = 3;
            // 
            // TeacherInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1497, 763);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(339, 0);
            this.Name = "TeacherInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherInterface";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem enterMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem particularToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mainPanel;
    }
}