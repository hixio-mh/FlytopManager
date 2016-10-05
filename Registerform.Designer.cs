namespace MissionPlanner
{
    partial class Registerform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registerform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OwnerBox = new System.Windows.Forms.TextBox();
            this.MacBox = new System.Windows.Forms.TextBox();
            this.licenseBox = new System.Windows.Forms.TextBox();
            this.cancelRegistration = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.imageLabel1 = new MissionPlanner.Controls.ImageLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Società";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAC Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chiave attivazione";
            // 
            // OwnerBox
            // 
            this.OwnerBox.Enabled = false;
            this.OwnerBox.Location = new System.Drawing.Point(167, 36);
            this.OwnerBox.Name = "OwnerBox";
            this.OwnerBox.Size = new System.Drawing.Size(300, 20);
            this.OwnerBox.TabIndex = 3;
            // 
            // MacBox
            // 
            this.MacBox.Enabled = false;
            this.MacBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MacBox.Location = new System.Drawing.Point(167, 78);
            this.MacBox.Name = "MacBox";
            this.MacBox.Size = new System.Drawing.Size(300, 22);
            this.MacBox.TabIndex = 4;
            // 
            // licenseBox
            // 
            this.licenseBox.Location = new System.Drawing.Point(167, 121);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.Size = new System.Drawing.Size(300, 20);
            this.licenseBox.TabIndex = 5;
            // 
            // cancelRegistration
            // 
            this.cancelRegistration.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelRegistration.Location = new System.Drawing.Point(311, 165);
            this.cancelRegistration.Name = "cancelRegistration";
            this.cancelRegistration.Size = new System.Drawing.Size(75, 23);
            this.cancelRegistration.TabIndex = 6;
            this.cancelRegistration.Text = "annulla";
            this.cancelRegistration.UseVisualStyleBackColor = true;
            this.cancelRegistration.Click += new System.EventHandler(this.cancelRegistration_Click);
            // 
            // register
            // 
            this.register.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.register.Location = new System.Drawing.Point(392, 165);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 7;
            this.register.Text = "attiva";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // imageLabel1
            // 
            this.imageLabel1.Image = global::MissionPlanner.Properties.Resources.logo;
            this.imageLabel1.Location = new System.Drawing.Point(-35, 144);
            this.imageLabel1.Name = "imageLabel1";
            this.imageLabel1.Size = new System.Drawing.Size(265, 216);
            this.imageLabel1.TabIndex = 8;
            // 
            // Registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 261);
            this.Controls.Add(this.imageLabel1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.cancelRegistration);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.MacBox);
            this.Controls.Add(this.OwnerBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registerform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrazione Prodotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OwnerBox;
        private System.Windows.Forms.TextBox MacBox;
        private System.Windows.Forms.TextBox licenseBox;
        private System.Windows.Forms.Button cancelRegistration;
        private System.Windows.Forms.Button register;
        private Controls.ImageLabel imageLabel1;
    }
}