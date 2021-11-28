
namespace Kурсов_Проект
{
    partial class FormDelete
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
            this.labelEnter = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelFilm = new System.Windows.Forms.Label();
            this.textBoxUniCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.Location = new System.Drawing.Point(28, 54);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(53, 20);
            this.labelEnter.TabIndex = 0;
            this.labelEnter.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(109, 51);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(124, 27);
            this.textBoxPhone.TabIndex = 1;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(22, 142);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(92, 30);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(143, 142);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(106, 30);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Location = new System.Drawing.Point(22, 101);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(69, 20);
            this.labelFilm.TabIndex = 4;
            this.labelFilm.Text = "UniCode:";
            // 
            // textBoxUniCode
            // 
            this.textBoxUniCode.Location = new System.Drawing.Point(109, 98);
            this.textBoxUniCode.Name = "textBoxUniCode";
            this.textBoxUniCode.Size = new System.Drawing.Size(124, 27);
            this.textBoxUniCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please enter your data";
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUniCode);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelEnter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.TextBox textBoxUniCode;
        private System.Windows.Forms.Label label1;
    }
}