
namespace Kурсов_Проект
{
    partial class FormOrders
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
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.labelPersonName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFilmName = new System.Windows.Forms.Label();
            this.labelTickets = new System.Windows.Forms.Label();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.labelOrders = new System.Windows.Forms.Label();
            this.labelAvgPrc = new System.Windows.Forms.Label();
            this.labelAveragePrice = new System.Windows.Forms.Label();
            this.labelFilm = new System.Windows.Forms.Label();
            this.labelMostWatchedFilm = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelUniCode = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 20;
            this.listBoxOrders.Location = new System.Drawing.Point(284, 41);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(184, 244);
            this.listBoxOrders.TabIndex = 0;
            this.listBoxOrders.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOrders_MouseClick);
            this.listBoxOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOrders_SelectedIndexChanged);
            this.listBoxOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOrders_MouseDoubleClick);
            // 
            // labelPersonName
            // 
            this.labelPersonName.AutoSize = true;
            this.labelPersonName.Location = new System.Drawing.Point(65, 53);
            this.labelPersonName.Name = "labelPersonName";
            this.labelPersonName.Size = new System.Drawing.Size(92, 20);
            this.labelPersonName.TabIndex = 1;
            this.labelPersonName.Text = "PersonName";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(65, 99);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(50, 20);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "Phone";
            // 
            // labelFilmName
            // 
            this.labelFilmName.AutoSize = true;
            this.labelFilmName.Location = new System.Drawing.Point(65, 148);
            this.labelFilmName.Name = "labelFilmName";
            this.labelFilmName.Size = new System.Drawing.Size(77, 20);
            this.labelFilmName.TabIndex = 3;
            this.labelFilmName.Text = "FilmName";
            // 
            // labelTickets
            // 
            this.labelTickets.AutoSize = true;
            this.labelTickets.Location = new System.Drawing.Point(65, 225);
            this.labelTickets.Name = "labelTickets";
            this.labelTickets.Size = new System.Drawing.Size(54, 20);
            this.labelTickets.TabIndex = 4;
            this.labelTickets.Text = "Tickets";
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Location = new System.Drawing.Point(65, 269);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(71, 20);
            this.labelTotalCost.TabIndex = 5;
            this.labelTotalCost.Text = "TotalCost";
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Location = new System.Drawing.Point(284, 9);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(53, 20);
            this.labelOrders.TabIndex = 6;
            this.labelOrders.Text = "Orders";
            // 
            // labelAvgPrc
            // 
            this.labelAvgPrc.AutoSize = true;
            this.labelAvgPrc.Location = new System.Drawing.Point(300, 389);
            this.labelAvgPrc.Name = "labelAvgPrc";
            this.labelAvgPrc.Size = new System.Drawing.Size(108, 20);
            this.labelAvgPrc.TabIndex = 7;
            this.labelAvgPrc.Text = "Average price: ";
            // 
            // labelAveragePrice
            // 
            this.labelAveragePrice.AutoSize = true;
            this.labelAveragePrice.Location = new System.Drawing.Point(432, 389);
            this.labelAveragePrice.Name = "labelAveragePrice";
            this.labelAveragePrice.Size = new System.Drawing.Size(0, 20);
            this.labelAveragePrice.TabIndex = 8;
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Location = new System.Drawing.Point(37, 389);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(135, 20);
            this.labelFilm.TabIndex = 9;
            this.labelFilm.Text = "Most watched film:";
            // 
            // labelMostWatchedFilm
            // 
            this.labelMostWatchedFilm.AutoSize = true;
            this.labelMostWatchedFilm.Location = new System.Drawing.Point(98, 424);
            this.labelMostWatchedFilm.Name = "labelMostWatchedFilm";
            this.labelMostWatchedFilm.Size = new System.Drawing.Size(0, 20);
            this.labelMostWatchedFilm.TabIndex = 10;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(65, 326);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 32);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete Order";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelUniCode
            // 
            this.labelUniCode.AutoSize = true;
            this.labelUniCode.Location = new System.Drawing.Point(65, 188);
            this.labelUniCode.Name = "labelUniCode";
            this.labelUniCode.Size = new System.Drawing.Size(66, 20);
            this.labelUniCode.TabIndex = 12;
            this.labelUniCode.Text = "UniCode";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(366, 437);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(102, 25);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 474);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelUniCode);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelMostWatchedFilm);
            this.Controls.Add(this.labelFilm);
            this.Controls.Add(this.labelAveragePrice);
            this.Controls.Add(this.labelAvgPrc);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.labelTickets);
            this.Controls.Add(this.labelFilmName);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelPersonName);
            this.Controls.Add(this.listBoxOrders);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Label labelPersonName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelFilmName;
        private System.Windows.Forms.Label labelTickets;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.Label labelAvgPrc;
        private System.Windows.Forms.Label labelAveragePrice;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.Label labelMostWatchedFilm;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelUniCode;
        private System.Windows.Forms.Button buttonBack;
    }
}