namespace app_text_to_speech
{
    partial class text_to_speech
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
        if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(text_to_speech));
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notify_menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.notify_menu_changeGender = new System.Windows.Forms.ToolStripMenuItem();
            this.notify_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.notify_menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Text to Speech";
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // notify_menu
            // 
            this.notify_menu.AllowDrop = true;
            this.notify_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notify_menu_exit,
            this.notify_menu_changeGender});
            this.notify_menu.Name = "notify_menu";
            this.notify_menu.Size = new System.Drawing.Size(159, 48);
            this.notify_menu.DragDrop += new System.Windows.Forms.DragEventHandler(this.notify_menu_DragDrop);
            // 
            // notify_menu_exit
            // 
            this.notify_menu_exit.Name = "notify_menu_exit";
            this.notify_menu_exit.Size = new System.Drawing.Size(158, 22);
            this.notify_menu_exit.Text = "Exit";
            this.notify_menu_exit.Click += new System.EventHandler(this.notify_menu_exit_Click);
            // 
            // notify_menu_changeGender
            // 
            this.notify_menu_changeGender.Name = "notify_menu_changeGender";
            this.notify_menu_changeGender.Size = new System.Drawing.Size(158, 22);
            this.notify_menu_changeGender.Text = "Change to Male";
            this.notify_menu_changeGender.Click += new System.EventHandler(this.notify_menu_changeGender_Click);
            // 
            // text_to_speech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 148);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "text_to_speech";
            this.Text = "Text to Speech";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.text_to_speech_Load);
            this.notify_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip notify_menu;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_exit;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_changeGender;
    }
}

