
namespace Kурсов_Проект
{
    partial class FormInitialPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInitialPage));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pictureBoxTicket = new System.Windows.Forms.PictureBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.ButtonNo = new System.Windows.Forms.Button();
            this.ButtonYes = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTicket)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.Window;
            this.panelTitle.Controls.Add(this.textBoxTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(359, 72);
            this.panelTitle.TabIndex = 0;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(77, 29);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(203, 27);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Text = "Welcome to the Cinema App!";
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.SystemColors.Window;
            this.panelPicture.Controls.Add(this.pictureBoxTicket);
            this.panelPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPicture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelPicture.Location = new System.Drawing.Point(0, 72);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(359, 378);
            this.panelPicture.TabIndex = 1;
            // 
            // pictureBoxTicket
            // 
            this.pictureBoxTicket.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTicket.Image")));
            this.pictureBoxTicket.Location = new System.Drawing.Point(54, 6);
            this.pictureBoxTicket.Name = "pictureBoxTicket";
            this.pictureBoxTicket.Size = new System.Drawing.Size(251, 206);
            this.pictureBoxTicket.TabIndex = 0;
            this.pictureBoxTicket.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.Window;
            this.panelButtons.Controls.Add(this.textBoxQuestion);
            this.panelButtons.Controls.Add(this.ButtonNo);
            this.panelButtons.Controls.Add(this.ButtonYes);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 341);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(359, 109);
            this.panelButtons.TabIndex = 2;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Location = new System.Drawing.Point(92, 21);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(189, 27);
            this.textBoxQuestion.TabIndex = 3;
            this.textBoxQuestion.Text = "Are you watching a movie?";
            // 
            // ButtonNo
            // 
            this.ButtonNo.Location = new System.Drawing.Point(204, 65);
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Size = new System.Drawing.Size(101, 26);
            this.ButtonNo.TabIndex = 2;
            this.ButtonNo.Text = "No";
            this.ButtonNo.UseVisualStyleBackColor = true;
            this.ButtonNo.Click += new System.EventHandler(this.ButtonNo_Click);
            // 
            // ButtonYes
            // 
            this.ButtonYes.Location = new System.Drawing.Point(67, 65);
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Size = new System.Drawing.Size(96, 26);
            this.ButtonYes.TabIndex = 1;
            this.ButtonYes.Text = "YES";
            this.ButtonYes.UseVisualStyleBackColor = true;
            this.ButtonYes.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // FormInitialPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.panelTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInitialPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cinema App";
            this.TopMost = true;
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTicket)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pictureBoxTicket;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button ButtonNo;
        private System.Windows.Forms.Button ButtonYes;
    }
}

