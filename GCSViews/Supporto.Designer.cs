namespace MissionPlanner.GCSViews
{
    partial class Supporto
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
            this.browserSupporto = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // browserSupporto
            // 
            this.browserSupporto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserSupporto.Location = new System.Drawing.Point(0, 0);
            this.browserSupporto.MinimumSize = new System.Drawing.Size(20, 20);
            this.browserSupporto.Name = "browserSupporto";
            this.browserSupporto.ScriptErrorsSuppressed = true;
            this.browserSupporto.Size = new System.Drawing.Size(896, 469);
            this.browserSupporto.TabIndex = 0;
            this.browserSupporto.Url = new System.Uri("http://www.flytop.it/supporto-tecnico", System.UriKind.Absolute);
            this.browserSupporto.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browserSupporto_DocumentCompleted);
            this.browserSupporto.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.ItemBrowser_Navigating);
            this.browserSupporto.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.browserSupporto_ControlAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::MissionPlanner.Properties.Resources.supporto50;
            this.button1.Location = new System.Drawing.Point(826, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(896, 10);
            this.progressBar.TabIndex = 3;
            // 
            // Supporto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browserSupporto);
            this.Name = "Supporto";
            this.Size = new System.Drawing.Size(896, 469);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browserSupporto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}