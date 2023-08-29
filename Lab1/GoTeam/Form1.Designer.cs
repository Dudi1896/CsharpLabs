namespace Lab1
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
            this.GoTeamBtn = new System.Windows.Forms.Button();
            this.HelloLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoTeamBtn
            // 
            this.GoTeamBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GoTeamBtn.Location = new System.Drawing.Point(220, 360);
            this.GoTeamBtn.Name = "GoTeamBtn";
            this.GoTeamBtn.Size = new System.Drawing.Size(75, 23);
            this.GoTeamBtn.TabIndex = 0;
            this.GoTeamBtn.Text = "GoTeam";
            this.GoTeamBtn.UseVisualStyleBackColor = false;
            this.GoTeamBtn.Click += new System.EventHandler(this.goTeam_Click);
            // 
            // HelloLbl
            // 
            this.HelloLbl.AutoSize = true;
            this.HelloLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HelloLbl.Location = new System.Drawing.Point(334, 34);
            this.HelloLbl.Name = "HelloLbl";
            this.HelloLbl.Size = new System.Drawing.Size(62, 13);
            this.HelloLbl.TabIndex = 1;
            this.HelloLbl.Text = "Hello World";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ExitBtn.Location = new System.Drawing.Point(460, 360);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 441);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.HelloLbl);
            this.Controls.Add(this.GoTeamBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoTeamBtn;
        private System.Windows.Forms.Label HelloLbl;
        private System.Windows.Forms.Button ExitBtn;
    }
}

