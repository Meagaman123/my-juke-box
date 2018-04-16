namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Genre_List = new System.Windows.Forms.ListBox();
            this.Genre_Title = new System.Windows.Forms.TextBox();
            this.cp = new System.Windows.Forms.TextBox();
            this.Currently_Playing = new System.Windows.Forms.TextBox();
            this.Select_Genre_Hscroll = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Play_List = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Genre_List
            // 
            this.Genre_List.FormattingEnabled = true;
            this.Genre_List.Location = new System.Drawing.Point(87, 113);
            this.Genre_List.Name = "Genre_List";
            this.Genre_List.Size = new System.Drawing.Size(200, 82);
            this.Genre_List.TabIndex = 0;
            this.Genre_List.SelectedIndexChanged += new System.EventHandler(this.Genre_List_SelectedIndexChanged);
            // 
            // Genre_Title
            // 
            this.Genre_Title.Location = new System.Drawing.Point(87, 96);
            this.Genre_Title.Name = "Genre_Title";
            this.Genre_Title.ReadOnly = true;
            this.Genre_Title.Size = new System.Drawing.Size(200, 20);
            this.Genre_Title.TabIndex = 1;
            // 
            // cp
            // 
            this.cp.Location = new System.Drawing.Point(194, 1);
            this.cp.Name = "cp";
            this.cp.Size = new System.Drawing.Size(179, 20);
            this.cp.TabIndex = 2;
            this.cp.Text = "Copyright © 2018 Gianluca Nocivelli";
            this.cp.TextChanged += new System.EventHandler(this.cp_TextChanged);
            // 
            // Currently_Playing
            // 
            this.Currently_Playing.BackColor = System.Drawing.Color.Lime;
            this.Currently_Playing.Location = new System.Drawing.Point(101, 244);
            this.Currently_Playing.Name = "Currently_Playing";
            this.Currently_Playing.ReadOnly = true;
            this.Currently_Playing.Size = new System.Drawing.Size(172, 20);
            this.Currently_Playing.TabIndex = 3;
            this.Currently_Playing.TextChanged += new System.EventHandler(this.Currently_Playing_TextChanged);
            // 
            // Select_Genre_Hscroll
            // 
            this.Select_Genre_Hscroll.LargeChange = 1;
            this.Select_Genre_Hscroll.Location = new System.Drawing.Point(87, 188);
            this.Select_Genre_Hscroll.Name = "Select_Genre_Hscroll";
            this.Select_Genre_Hscroll.Size = new System.Drawing.Size(200, 24);
            this.Select_Genre_Hscroll.TabIndex = 7;
            this.Select_Genre_Hscroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Select_Genre_Hscroll_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 569);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(374, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setUpToolStripMenuItem
            // 
            this.setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            this.setUpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.setUpToolStripMenuItem.Text = "Set up";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Play_List
            // 
            this.Play_List.BackColor = System.Drawing.SystemColors.Info;
            this.Play_List.FormattingEnabled = true;
            this.Play_List.Location = new System.Drawing.Point(87, 291);
            this.Play_List.Name = "Play_List";
            this.Play_List.Size = new System.Drawing.Size(200, 108);
            this.Play_List.TabIndex = 9;
            this.Play_List.SelectedIndexChanged += new System.EventHandler(this.Play_List_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(374, 593);
            this.Controls.Add(this.Play_List);
            this.Controls.Add(this.Select_Genre_Hscroll);
            this.Controls.Add(this.Currently_Playing);
            this.Controls.Add(this.cp);
            this.Controls.Add(this.Genre_Title);
            this.Controls.Add(this.Genre_List);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "My Juke Box v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Genre_Title;
        private System.Windows.Forms.ListBox Genre_List;
        private System.Windows.Forms.TextBox cp;
        private System.Windows.Forms.TextBox Currently_Playing;
        private System.Windows.Forms.HScrollBar Select_Genre_Hscroll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox Play_List;
    }
}

