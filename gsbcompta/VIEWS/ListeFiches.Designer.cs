
namespace gsbcompta
{
    partial class ListeFiches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeFiches));
            this.dataGridViewBills = new System.Windows.Forms.DataGridView();
            this.groupBoxFixedFees = new System.Windows.Forms.GroupBox();
            this.buttonFixedFeesUpdate = new System.Windows.Forms.Button();
            this.labelFixedFeesREP = new System.Windows.Forms.Label();
            this.labelFixedFeesNUI = new System.Windows.Forms.Label();
            this.labelFixedFeesKM = new System.Windows.Forms.Label();
            this.textBoxFixedFeesREP = new System.Windows.Forms.TextBox();
            this.textBoxFixedFeesNUI = new System.Windows.Forms.TextBox();
            this.textBoxFixedFeesKM = new System.Windows.Forms.TextBox();
            this.groupBoxOffPrice = new System.Windows.Forms.GroupBox();
            this.dataGridViewOffPrice = new System.Windows.Forms.DataGridView();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonValidationFiche = new System.Windows.Forms.Button();
            this.labelEtatFiche = new System.Windows.Forms.Label();
            this.labelEtat = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).BeginInit();
            this.groupBoxFixedFees.SuspendLayout();
            this.groupBoxOffPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffPrice)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBills
            // 
            this.dataGridViewBills.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBills.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBills.Location = new System.Drawing.Point(0, 91);
            this.dataGridViewBills.MultiSelect = false;
            this.dataGridViewBills.Name = "dataGridViewBills";
            this.dataGridViewBills.RowHeadersWidth = 51;
            this.dataGridViewBills.RowTemplate.Height = 24;
            this.dataGridViewBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBills.Size = new System.Drawing.Size(841, 385);
            this.dataGridViewBills.TabIndex = 0;
            this.dataGridViewBills.SelectionChanged += new System.EventHandler(this.dataGridViewBills_SelectionChanged);
            // 
            // groupBoxFixedFees
            // 
            this.groupBoxFixedFees.Controls.Add(this.buttonFixedFeesUpdate);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesREP);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesNUI);
            this.groupBoxFixedFees.Controls.Add(this.labelFixedFeesKM);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesREP);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesNUI);
            this.groupBoxFixedFees.Controls.Add(this.textBoxFixedFeesKM);
            this.groupBoxFixedFees.Location = new System.Drawing.Point(847, 42);
            this.groupBoxFixedFees.Name = "groupBoxFixedFees";
            this.groupBoxFixedFees.Size = new System.Drawing.Size(444, 132);
            this.groupBoxFixedFees.TabIndex = 1;
            this.groupBoxFixedFees.TabStop = false;
            this.groupBoxFixedFees.Text = "Frais Forfait";
            // 
            // buttonFixedFeesUpdate
            // 
            this.buttonFixedFeesUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFixedFeesUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFixedFeesUpdate.Location = new System.Drawing.Point(302, 83);
            this.buttonFixedFeesUpdate.Name = "buttonFixedFeesUpdate";
            this.buttonFixedFeesUpdate.Size = new System.Drawing.Size(90, 29);
            this.buttonFixedFeesUpdate.TabIndex = 6;
            this.buttonFixedFeesUpdate.Text = "Modifier";
            this.buttonFixedFeesUpdate.UseVisualStyleBackColor = false;
            this.buttonFixedFeesUpdate.Click += new System.EventHandler(this.buttonFixedFeesUpdate_Click);
            // 
            // labelFixedFeesREP
            // 
            this.labelFixedFeesREP.AutoSize = true;
            this.labelFixedFeesREP.Location = new System.Drawing.Point(31, 83);
            this.labelFixedFeesREP.Name = "labelFixedFeesREP";
            this.labelFixedFeesREP.Size = new System.Drawing.Size(49, 17);
            this.labelFixedFeesREP.TabIndex = 5;
            this.labelFixedFeesREP.Text = "Repas";
            // 
            // labelFixedFeesNUI
            // 
            this.labelFixedFeesNUI.AutoSize = true;
            this.labelFixedFeesNUI.Location = new System.Drawing.Point(250, 40);
            this.labelFixedFeesNUI.Name = "labelFixedFeesNUI";
            this.labelFixedFeesNUI.Size = new System.Drawing.Size(33, 17);
            this.labelFixedFeesNUI.TabIndex = 4;
            this.labelFixedFeesNUI.Text = "Nuit";
            // 
            // labelFixedFeesKM
            // 
            this.labelFixedFeesKM.AutoSize = true;
            this.labelFixedFeesKM.Location = new System.Drawing.Point(13, 38);
            this.labelFixedFeesKM.Name = "labelFixedFeesKM";
            this.labelFixedFeesKM.Size = new System.Drawing.Size(74, 17);
            this.labelFixedFeesKM.TabIndex = 3;
            this.labelFixedFeesKM.Text = "Kilomètres";
            // 
            // textBoxFixedFeesREP
            // 
            this.textBoxFixedFeesREP.Location = new System.Drawing.Point(93, 78);
            this.textBoxFixedFeesREP.Name = "textBoxFixedFeesREP";
            this.textBoxFixedFeesREP.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesREP.TabIndex = 2;
            // 
            // textBoxFixedFeesNUI
            // 
            this.textBoxFixedFeesNUI.Location = new System.Drawing.Point(302, 35);
            this.textBoxFixedFeesNUI.Name = "textBoxFixedFeesNUI";
            this.textBoxFixedFeesNUI.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesNUI.TabIndex = 1;
            // 
            // textBoxFixedFeesKM
            // 
            this.textBoxFixedFeesKM.Location = new System.Drawing.Point(93, 35);
            this.textBoxFixedFeesKM.Name = "textBoxFixedFeesKM";
            this.textBoxFixedFeesKM.Size = new System.Drawing.Size(100, 22);
            this.textBoxFixedFeesKM.TabIndex = 0;
            // 
            // groupBoxOffPrice
            // 
            this.groupBoxOffPrice.Controls.Add(this.dataGridViewOffPrice);
            this.groupBoxOffPrice.Location = new System.Drawing.Point(847, 180);
            this.groupBoxOffPrice.Name = "groupBoxOffPrice";
            this.groupBoxOffPrice.Size = new System.Drawing.Size(444, 208);
            this.groupBoxOffPrice.TabIndex = 2;
            this.groupBoxOffPrice.TabStop = false;
            this.groupBoxOffPrice.Text = "Frais Hors Forfait";
            // 
            // dataGridViewOffPrice
            // 
            this.dataGridViewOffPrice.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewOffPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffPrice.Location = new System.Drawing.Point(14, 21);
            this.dataGridViewOffPrice.Name = "dataGridViewOffPrice";
            this.dataGridViewOffPrice.RowHeadersWidth = 51;
            this.dataGridViewOffPrice.RowTemplate.Height = 24;
            this.dataGridViewOffPrice.Size = new System.Drawing.Size(424, 187);
            this.dataGridViewOffPrice.TabIndex = 0;
            this.dataGridViewOffPrice.SelectionChanged += new System.EventHandler(this.dataGridViewOffPrice_SelectionChanged);
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "CR",
            "VA",
            "RB"});
            this.comboBoxState.Location = new System.Drawing.Point(1118, 442);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(121, 24);
            this.comboBoxState.TabIndex = 3;
            this.comboBoxState.UseWaitCursor = true;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(899, 445);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(198, 17);
            this.labelState.TabIndex = 4;
            this.labelState.Text = "Modifier l\'état de la fiche :";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddUser.Location = new System.Drawing.Point(563, 491);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(242, 39);
            this.buttonAddUser.TabIndex = 5;
            this.buttonAddUser.Text = "Ajouter Utilisateur";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonValidationFiche
            // 
            this.buttonValidationFiche.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonValidationFiche.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidationFiche.Location = new System.Drawing.Point(974, 491);
            this.buttonValidationFiche.Name = "buttonValidationFiche";
            this.buttonValidationFiche.Size = new System.Drawing.Size(242, 39);
            this.buttonValidationFiche.TabIndex = 6;
            this.buttonValidationFiche.Text = "Actualiser l\'etat";
            this.buttonValidationFiche.UseVisualStyleBackColor = false;
            this.buttonValidationFiche.Click += new System.EventHandler(this.buttonValidationFiche_Click);
            // 
            // labelEtatFiche
            // 
            this.labelEtatFiche.AutoSize = true;
            this.labelEtatFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtatFiche.Location = new System.Drawing.Point(1001, 408);
            this.labelEtatFiche.Name = "labelEtatFiche";
            this.labelEtatFiche.Size = new System.Drawing.Size(96, 17);
            this.labelEtatFiche.TabIndex = 8;
            this.labelEtatFiche.Text = "Etat actuel :";
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtat.ForeColor = System.Drawing.Color.Red;
            this.labelEtat.Location = new System.Drawing.Point(1146, 408);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(0, 17);
            this.labelEtat.TabIndex = 9;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.Red;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.ForeColor = System.Drawing.Color.Black;
            this.buttonDisconnect.Location = new System.Drawing.Point(32, 491);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(245, 41);
            this.buttonDisconnect.TabIndex = 10;
            this.buttonDisconnect.Text = "Déconnexion";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridViewBills);
            this.panel1.Controls.Add(this.buttonDisconnect);
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 639);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ListeFiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1319, 636);
            this.Controls.Add(this.labelEtat);
            this.Controls.Add(this.labelEtatFiche);
            this.Controls.Add(this.buttonValidationFiche);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.groupBoxOffPrice);
            this.Controls.Add(this.groupBoxFixedFees);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListeFiches";
            this.Text = "ListeFiches";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBills)).EndInit();
            this.groupBoxFixedFees.ResumeLayout(false);
            this.groupBoxFixedFees.PerformLayout();
            this.groupBoxOffPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBills;
        private System.Windows.Forms.GroupBox groupBoxFixedFees;
        private System.Windows.Forms.TextBox textBoxFixedFeesKM;
        private System.Windows.Forms.GroupBox groupBoxOffPrice;
        private System.Windows.Forms.TextBox textBoxFixedFeesREP;
        private System.Windows.Forms.TextBox textBoxFixedFeesNUI;
        private System.Windows.Forms.Label labelFixedFeesREP;
        private System.Windows.Forms.Label labelFixedFeesNUI;
        private System.Windows.Forms.Label labelFixedFeesKM;
        private System.Windows.Forms.DataGridView dataGridViewOffPrice;
        private System.Windows.Forms.Button buttonFixedFeesUpdate;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonValidationFiche;
        private System.Windows.Forms.Label labelEtatFiche;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}