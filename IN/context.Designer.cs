namespace IN
{
    partial class context
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.firstItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subFirstItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subSecondItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subThirdItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forthItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fifthItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Here";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstItemToolStripMenuItem,
            this.secondItemToolStripMenuItem,
            this.thirdItemToolStripMenuItem,
            this.forthItemToolStripMenuItem,
            this.fifthItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 124);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // firstItemToolStripMenuItem
            // 
            this.firstItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subFirstItemToolStripMenuItem});
            this.firstItemToolStripMenuItem.Name = "firstItemToolStripMenuItem";
            this.firstItemToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.firstItemToolStripMenuItem.Text = "First Item ";
            // 
            // subFirstItemToolStripMenuItem
            // 
            this.subFirstItemToolStripMenuItem.Name = "subFirstItemToolStripMenuItem";
            this.subFirstItemToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.subFirstItemToolStripMenuItem.Text = "Sub first item ";
            // 
            // secondItemToolStripMenuItem
            // 
            this.secondItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subSecondItemToolStripMenuItem});
            this.secondItemToolStripMenuItem.Name = "secondItemToolStripMenuItem";
            this.secondItemToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.secondItemToolStripMenuItem.Text = "Second Item ";
            // 
            // subSecondItemToolStripMenuItem
            // 
            this.subSecondItemToolStripMenuItem.Name = "subSecondItemToolStripMenuItem";
            this.subSecondItemToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.subSecondItemToolStripMenuItem.Text = "Sub second item ";
            // 
            // thirdItemToolStripMenuItem
            // 
            this.thirdItemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subThirdItemToolStripMenuItem});
            this.thirdItemToolStripMenuItem.Name = "thirdItemToolStripMenuItem";
            this.thirdItemToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.thirdItemToolStripMenuItem.Text = "Third Item";
            // 
            // subThirdItemToolStripMenuItem
            // 
            this.subThirdItemToolStripMenuItem.Name = "subThirdItemToolStripMenuItem";
            this.subThirdItemToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.subThirdItemToolStripMenuItem.Text = "Sub third item ";
            // 
            // forthItemToolStripMenuItem
            // 
            this.forthItemToolStripMenuItem.Name = "forthItemToolStripMenuItem";
            this.forthItemToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.forthItemToolStripMenuItem.Text = "Forth Item ";
            // 
            // fifthItemToolStripMenuItem
            // 
            this.fifthItemToolStripMenuItem.Name = "fifthItemToolStripMenuItem";
            this.fifthItemToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.fifthItemToolStripMenuItem.Text = "Fifth Item ";
            // 
            // context
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(875, 549);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "context";
            this.Text = "context";
            this.Load += new System.EventHandler(this.context_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firstItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subFirstItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subSecondItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirdItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subThirdItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forthItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fifthItemToolStripMenuItem;
    }
}