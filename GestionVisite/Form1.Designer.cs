namespace GestionVisite
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfficher = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaisirComm = new System.Windows.Forms.Button();
            this.grdVisite = new System.Windows.Forms.DataGridView();
            this.affichage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAfficher.Location = new System.Drawing.Point(992, 46);
            this.btnAfficher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(97, 40);
            this.btnAfficher.TabIndex = 0;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(491, 46);
            this.grd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 82;
            this.grd.RowTemplate.Height = 33;
            this.grd.Size = new System.Drawing.Size(478, 202);
            this.grd.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(30, 26);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 17);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Position :  X =                      Y=";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(91, 26);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(68, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(91, 56);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(68, 22);
            this.txtNom.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(135, 85);
            this.txtX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(68, 22);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(237, 85);
            this.txtY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(68, 22);
            this.txtY.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.affichage);
            this.groupBox1.Controls.Add(this.btnSaisirComm);
            this.groupBox1.Controls.Add(this.grdVisite);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.IdLabel);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(34, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(453, 392);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commercial :";
            // 
            // btnSaisirComm
            // 
            this.btnSaisirComm.Location = new System.Drawing.Point(341, 81);
            this.btnSaisirComm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaisirComm.Name = "btnSaisirComm";
            this.btnSaisirComm.Size = new System.Drawing.Size(66, 28);
            this.btnSaisirComm.TabIndex = 2;
            this.btnSaisirComm.Text = "Saisir";
            this.btnSaisirComm.UseVisualStyleBackColor = true;
            this.btnSaisirComm.Click += new System.EventHandler(this.btnSaisirComm_Click);
            // 
            // grdVisite
            // 
            this.grdVisite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisite.Location = new System.Drawing.Point(11, 158);
            this.grdVisite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdVisite.Name = "grdVisite";
            this.grdVisite.RowHeadersWidth = 82;
            this.grdVisite.RowTemplate.Height = 33;
            this.grdVisite.Size = new System.Drawing.Size(428, 174);
            this.grdVisite.TabIndex = 1;
            // 
            // affichage
            // 
            this.affichage.AutoSize = true;
            this.affichage.BackColor = System.Drawing.Color.White;
            this.affichage.Location = new System.Drawing.Point(191, 354);
            this.affichage.Name = "affichage";
            this.affichage.Size = new System.Drawing.Size(44, 17);
            this.affichage.TabIndex = 3;
            this.affichage.Text = "0.000";
            this.affichage.Click += new System.EventHandler(this.affichage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distance Total :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1153, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.btnAfficher);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaisirComm;
        private System.Windows.Forms.DataGridView grdVisite;
        private System.Windows.Forms.Label affichage;
        private System.Windows.Forms.Label label3;
    }
}

