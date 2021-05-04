namespace gsbcompta.VIEWS
{
    partial class DetailsOffPrice
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
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelMontantOffPrice = new System.Windows.Forms.Label();
            this.labelDateOffPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.labelNameOffPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxVisiteur = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(107, 319);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(204, 22);
            this.textBoxAmount.TabIndex = 0;
            // 
            // labelMontantOffPrice
            // 
            this.labelMontantOffPrice.AutoSize = true;
            this.labelMontantOffPrice.Location = new System.Drawing.Point(36, 322);
            this.labelMontantOffPrice.Name = "labelMontantOffPrice";
            this.labelMontantOffPrice.Size = new System.Drawing.Size(67, 17);
            this.labelMontantOffPrice.TabIndex = 1;
            this.labelMontantOffPrice.Text = "Montant :";
            // 
            // labelDateOffPrice
            // 
            this.labelDateOffPrice.AutoSize = true;
            this.labelDateOffPrice.Location = new System.Drawing.Point(36, 272);
            this.labelDateOffPrice.Name = "labelDateOffPrice";
            this.labelDateOffPrice.Size = new System.Drawing.Size(46, 17);
            this.labelDateOffPrice.TabIndex = 2;
            this.labelDateOffPrice.Text = "Date :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(107, 213);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(204, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Location = new System.Drawing.Point(36, 218);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(57, 17);
            this.labelLibelle.TabIndex = 5;
            this.labelLibelle.Text = "Libellé :";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(107, 165);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.ReadOnly = true;
            this.textBoxMonth.Size = new System.Drawing.Size(204, 22);
            this.textBoxMonth.TabIndex = 6;
            // 
            // labelNameOffPrice
            // 
            this.labelNameOffPrice.AutoSize = true;
            this.labelNameOffPrice.Location = new System.Drawing.Point(36, 168);
            this.labelNameOffPrice.Name = "labelNameOffPrice";
            this.labelNameOffPrice.Size = new System.Drawing.Size(45, 17);
            this.labelNameOffPrice.TabIndex = 7;
            this.labelNameOffPrice.Text = "Mois :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Visiteur :";
            // 
            // textBoxVisiteur
            // 
            this.textBoxVisiteur.Location = new System.Drawing.Point(107, 117);
            this.textBoxVisiteur.Name = "textBoxVisiteur";
            this.textBoxVisiteur.ReadOnly = true;
            this.textBoxVisiteur.Size = new System.Drawing.Size(204, 22);
            this.textBoxVisiteur.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(76, 380);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(189, 33);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Enregistrer";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // DetailsOffPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 479);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxVisiteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNameOffPrice);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDateOffPrice);
            this.Controls.Add(this.labelMontantOffPrice);
            this.Controls.Add(this.textBoxAmount);
            this.Name = "DetailsOffPrice";
            this.Text = "DetailsOffPrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelMontantOffPrice;
        private System.Windows.Forms.Label labelDateOffPrice;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label labelNameOffPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxVisiteur;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}