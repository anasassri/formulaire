namespace WindowsFormsApp2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.id_input = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.anu_btn = new System.Windows.Forms.Button();
            this.enr_btn = new System.Windows.Forms.Button();
            this.mod_btn = new System.Windows.Forms.Button();
            this.sup_btn = new System.Windows.Forms.Button();
            this.ajout_btn = new System.Windows.Forms.Button();
            this.nom_input = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(182, 172);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(181, 26);
            this.id_input.TabIndex = 1;
            this.id_input.TextChanged += new System.EventHandler(this.id_input_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.anu_btn, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.enr_btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mod_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sup_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ajout_btn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(158, 238);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 94);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // anu_btn
            // 
            this.anu_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anu_btn.Location = new System.Drawing.Point(399, 3);
            this.anu_btn.Name = "anu_btn";
            this.anu_btn.Size = new System.Drawing.Size(96, 88);
            this.anu_btn.TabIndex = 4;
            this.anu_btn.Text = "Annule";
            this.anu_btn.UseVisualStyleBackColor = true;
            this.anu_btn.Click += new System.EventHandler(this.anu_btn_Click);
            // 
            // enr_btn
            // 
            this.enr_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enr_btn.Location = new System.Drawing.Point(300, 3);
            this.enr_btn.Name = "enr_btn";
            this.enr_btn.Size = new System.Drawing.Size(93, 88);
            this.enr_btn.TabIndex = 3;
            this.enr_btn.Text = "Enregister";
            this.enr_btn.UseVisualStyleBackColor = true;
            this.enr_btn.Click += new System.EventHandler(this.enr_btn_Click);
            // 
            // mod_btn
            // 
            this.mod_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mod_btn.Location = new System.Drawing.Point(201, 3);
            this.mod_btn.Name = "mod_btn";
            this.mod_btn.Size = new System.Drawing.Size(93, 88);
            this.mod_btn.TabIndex = 2;
            this.mod_btn.Text = "Modifier";
            this.mod_btn.UseVisualStyleBackColor = true;
            this.mod_btn.Click += new System.EventHandler(this.mod_btn_Click);
            // 
            // sup_btn
            // 
            this.sup_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sup_btn.Location = new System.Drawing.Point(102, 3);
            this.sup_btn.Name = "sup_btn";
            this.sup_btn.Size = new System.Drawing.Size(93, 88);
            this.sup_btn.TabIndex = 1;
            this.sup_btn.Text = "Supprimer";
            this.sup_btn.UseVisualStyleBackColor = true;
            this.sup_btn.Click += new System.EventHandler(this.sup_btn_Click);
            // 
            // ajout_btn
            // 
            this.ajout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ajout_btn.Location = new System.Drawing.Point(3, 3);
            this.ajout_btn.Name = "ajout_btn";
            this.ajout_btn.Size = new System.Drawing.Size(93, 88);
            this.ajout_btn.TabIndex = 0;
            this.ajout_btn.Text = "Ajouter";
            this.ajout_btn.UseVisualStyleBackColor = true;
            this.ajout_btn.BackColorChanged += new System.EventHandler(this.green);
            this.ajout_btn.Click += new System.EventHandler(this.ajout_btn_Click);
            // 
            // nom_input
            // 
            this.nom_input.Location = new System.Drawing.Point(440, 172);
            this.nom_input.Name = "nom_input";
            this.nom_input.Size = new System.Drawing.Size(187, 26);
            this.nom_input.TabIndex = 3;
            this.nom_input.TextChanged += new System.EventHandler(this.nom_input_TextChanged);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(259, 138);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(26, 20);
            this.id_label.TabIndex = 4;
            this.id_label.Text = "ID";
            this.id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Location = new System.Drawing.Point(517, 138);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(45, 20);
            this.nom_label.TabIndex = 5;
            this.nom_label.Text = "NOM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nom_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.nom_input);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.id_input);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button anu_btn;
        private System.Windows.Forms.Button enr_btn;
        private System.Windows.Forms.Button mod_btn;
        private System.Windows.Forms.Button sup_btn;
        private System.Windows.Forms.Button ajout_btn;
        private System.Windows.Forms.TextBox nom_input;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label nom_label;
    }
}

