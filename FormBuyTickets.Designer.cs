
namespace Kурсов_Проект
{
    partial class FormBuyTickets
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
            this.comboBoxMovie2D = new System.Windows.Forms.ComboBox();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.panelCinema = new System.Windows.Forms.Panel();
            this.comboBox4D = new System.Windows.Forms.ComboBox();
            this.radioButton4D = new System.Windows.Forms.RadioButton();
            this.comboBoxMovie3D = new System.Windows.Forms.ComboBox();
            this.radioButtonPremium = new System.Windows.Forms.RadioButton();
            this.radioButtonCheap = new System.Windows.Forms.RadioButton();
            this.labelNumberOfTickets = new System.Windows.Forms.Label();
            this.labelPopcorn = new System.Windows.Forms.Label();
            this.numericUpDownPopcorn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTickets = new System.Windows.Forms.NumericUpDown();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelCinema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopcorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMovie2D
            // 
            this.comboBoxMovie2D.FormattingEnabled = true;
            this.comboBoxMovie2D.Location = new System.Drawing.Point(157, 18);
            this.comboBoxMovie2D.Name = "comboBoxMovie2D";
            this.comboBoxMovie2D.Size = new System.Drawing.Size(167, 28);
            this.comboBoxMovie2D.TabIndex = 3;
            this.comboBoxMovie2D.Text = "Movies 2D";
            this.comboBoxMovie2D.Visible = false;
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Location = new System.Drawing.Point(222, 332);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(102, 28);
            this.buttonNextStep.TabIndex = 5;
            this.buttonNextStep.Text = "Next step";
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // panelCinema
            // 
            this.panelCinema.Controls.Add(this.comboBox4D);
            this.panelCinema.Controls.Add(this.radioButton4D);
            this.panelCinema.Controls.Add(this.comboBoxMovie3D);
            this.panelCinema.Controls.Add(this.radioButtonPremium);
            this.panelCinema.Controls.Add(this.radioButtonCheap);
            this.panelCinema.Controls.Add(this.comboBoxMovie2D);
            this.panelCinema.Location = new System.Drawing.Point(12, 3);
            this.panelCinema.Name = "panelCinema";
            this.panelCinema.Size = new System.Drawing.Size(344, 140);
            this.panelCinema.TabIndex = 6;
            // 
            // comboBox4D
            // 
            this.comboBox4D.FormattingEnabled = true;
            this.comboBox4D.Location = new System.Drawing.Point(157, 97);
            this.comboBox4D.Name = "comboBox4D";
            this.comboBox4D.Size = new System.Drawing.Size(167, 28);
            this.comboBox4D.TabIndex = 6;
            this.comboBox4D.Text = "Movies 4D";
            this.comboBox4D.Visible = false;
            // 
            // radioButton4D
            // 
            this.radioButton4D.AutoSize = true;
            this.radioButton4D.Location = new System.Drawing.Point(20, 97);
            this.radioButton4D.Name = "radioButton4D";
            this.radioButton4D.Size = new System.Drawing.Size(93, 24);
            this.radioButton4D.TabIndex = 5;
            this.radioButton4D.TabStop = true;
            this.radioButton4D.Text = "Room 4D";
            this.radioButton4D.UseVisualStyleBackColor = true;
            this.radioButton4D.CheckedChanged += new System.EventHandler(this.radioButton4D_CheckedChanged);
            // 
            // comboBoxMovie3D
            // 
            this.comboBoxMovie3D.FormattingEnabled = true;
            this.comboBoxMovie3D.Location = new System.Drawing.Point(157, 57);
            this.comboBoxMovie3D.Name = "comboBoxMovie3D";
            this.comboBoxMovie3D.Size = new System.Drawing.Size(167, 28);
            this.comboBoxMovie3D.TabIndex = 4;
            this.comboBoxMovie3D.Text = "Movies 3D";
            this.comboBoxMovie3D.Visible = false;
            // 
            // radioButtonPremium
            // 
            this.radioButtonPremium.AutoSize = true;
            this.radioButtonPremium.Location = new System.Drawing.Point(20, 57);
            this.radioButtonPremium.Name = "radioButtonPremium";
            this.radioButtonPremium.Size = new System.Drawing.Size(108, 24);
            this.radioButtonPremium.TabIndex = 1;
            this.radioButtonPremium.TabStop = true;
            this.radioButtonPremium.Text = "Premium3D";
            this.radioButtonPremium.UseVisualStyleBackColor = true;
            this.radioButtonPremium.CheckedChanged += new System.EventHandler(this.radioButtonPremium_CheckedChanged);
            // 
            // radioButtonCheap
            // 
            this.radioButtonCheap.AutoSize = true;
            this.radioButtonCheap.Location = new System.Drawing.Point(20, 18);
            this.radioButtonCheap.Name = "radioButtonCheap";
            this.radioButtonCheap.Size = new System.Drawing.Size(91, 24);
            this.radioButtonCheap.TabIndex = 0;
            this.radioButtonCheap.TabStop = true;
            this.radioButtonCheap.Text = "Cheap2D";
            this.radioButtonCheap.UseVisualStyleBackColor = true;
            this.radioButtonCheap.CheckedChanged += new System.EventHandler(this.radioButtonCheap_CheckedChanged);
            // 
            // labelNumberOfTickets
            // 
            this.labelNumberOfTickets.AutoSize = true;
            this.labelNumberOfTickets.Location = new System.Drawing.Point(31, 222);
            this.labelNumberOfTickets.Name = "labelNumberOfTickets";
            this.labelNumberOfTickets.Size = new System.Drawing.Size(133, 20);
            this.labelNumberOfTickets.TabIndex = 7;
            this.labelNumberOfTickets.Text = "Number of Tickets:";
            // 
            // labelPopcorn
            // 
            this.labelPopcorn.AutoSize = true;
            this.labelPopcorn.Location = new System.Drawing.Point(98, 277);
            this.labelPopcorn.Name = "labelPopcorn";
            this.labelPopcorn.Size = new System.Drawing.Size(66, 20);
            this.labelPopcorn.TabIndex = 9;
            this.labelPopcorn.Text = "Popcorn:";
            this.labelPopcorn.Visible = false;
            // 
            // numericUpDownPopcorn
            // 
            this.numericUpDownPopcorn.Location = new System.Drawing.Point(190, 275);
            this.numericUpDownPopcorn.Name = "numericUpDownPopcorn";
            this.numericUpDownPopcorn.Size = new System.Drawing.Size(153, 27);
            this.numericUpDownPopcorn.TabIndex = 10;
            this.numericUpDownPopcorn.Visible = false;
            // 
            // numericUpDownTickets
            // 
            this.numericUpDownTickets.Location = new System.Drawing.Point(190, 222);
            this.numericUpDownTickets.Name = "numericUpDownTickets";
            this.numericUpDownTickets.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownTickets.TabIndex = 11;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(44, 333);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(81, 27);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(31, 173);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(74, 25);
            this.buttonInfo.TabIndex = 13;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormBuyTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 373);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.numericUpDownTickets);
            this.Controls.Add(this.numericUpDownPopcorn);
            this.Controls.Add(this.labelPopcorn);
            this.Controls.Add(this.labelNumberOfTickets);
            this.Controls.Add(this.panelCinema);
            this.Controls.Add(this.buttonNextStep);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuyTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyTickets";
            this.panelCinema.ResumeLayout(false);
            this.panelCinema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopcorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxMovie2D;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Panel panelCinema;
        private System.Windows.Forms.RadioButton radioButtonPremium;
        private System.Windows.Forms.RadioButton radioButtonCheap;
        private System.Windows.Forms.ComboBox comboBoxMovie3D;
        private System.Windows.Forms.Label labelNumberOfTickets;
        private System.Windows.Forms.Label labelPopcorn;
        private System.Windows.Forms.NumericUpDown numericUpDownPopcorn;
        private System.Windows.Forms.NumericUpDown numericUpDownTickets;
        private System.Windows.Forms.ComboBox comboBox4D;
        private System.Windows.Forms.RadioButton radioButton4D;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonInfo;
    }
}