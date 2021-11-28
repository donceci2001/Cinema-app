
namespace Kурсов_Проект
{
    partial class FormInformation
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
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonChangeOrder = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(16, 28);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(304, 20);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Please write your name and a phone number";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(75, 86);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(242, 27);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 86);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(16, 151);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(53, 20);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(75, 148);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(205, 27);
            this.textBoxPhone.TabIndex = 4;
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(16, 283);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(109, 45);
            this.buttonPayment.TabIndex = 6;
            this.buttonPayment.Text = "Pay";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // buttonChangeOrder
            // 
            this.buttonChangeOrder.Location = new System.Drawing.Point(197, 283);
            this.buttonChangeOrder.Name = "buttonChangeOrder";
            this.buttonChangeOrder.Size = new System.Drawing.Size(126, 45);
            this.buttonChangeOrder.TabIndex = 7;
            this.buttonChangeOrder.Text = "Change Order";
            this.buttonChangeOrder.UseVisualStyleBackColor = true;
            this.buttonChangeOrder.Click += new System.EventHandler(this.buttonChangeOrder_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(25, 217);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price:";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(86, 217);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(0, 20);
            this.labelTotalCost.TabIndex = 9;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 344);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonChangeOrder);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonChangeOrder;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTotalCost;
    }
}