namespace Zad4Win
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listResult = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtDiscr2 = new System.Windows.Forms.TextBox();
            this.txtPrice2 = new System.Windows.Forms.TextBox();
            this.txtWeight2 = new System.Windows.Forms.TextBox();
            this.cbType2 = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDiscr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(241, 370);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(131, 48);
            this.btnFind.TabIndex = 29;
            this.btnFind.Text = "Намери ястие";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowAll.Location = new System.Drawing.Point(383, 370);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(131, 48);
            this.btnShowAll.TabIndex = 28;
            this.btnShowAll.Text = "Покажи всички";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.HorizontalScrollbar = true;
            this.listResult.Location = new System.Drawing.Point(580, 91);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(208, 303);
            this.listResult.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.txtName2);
            this.groupBox2.Controls.Add(this.txtDiscr2);
            this.groupBox2.Controls.Add(this.txtPrice2);
            this.groupBox2.Controls.Add(this.txtWeight2);
            this.groupBox2.Controls.Add(this.cbType2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(314, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 219);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирай ястие:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Тип:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Грамаж:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Цена:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Описание:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Име:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(60, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(193, 24);
            this.txtId.TabIndex = 16;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(76, 184);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 27);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(69, 45);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(184, 24);
            this.txtName2.TabIndex = 9;
            // 
            // txtDiscr2
            // 
            this.txtDiscr2.Location = new System.Drawing.Point(112, 72);
            this.txtDiscr2.Name = "txtDiscr2";
            this.txtDiscr2.Size = new System.Drawing.Size(141, 24);
            this.txtDiscr2.TabIndex = 10;
            // 
            // txtPrice2
            // 
            this.txtPrice2.Location = new System.Drawing.Point(76, 98);
            this.txtPrice2.Name = "txtPrice2";
            this.txtPrice2.Size = new System.Drawing.Size(177, 24);
            this.txtPrice2.TabIndex = 11;
            // 
            // txtWeight2
            // 
            this.txtWeight2.Location = new System.Drawing.Point(94, 124);
            this.txtWeight2.Name = "txtWeight2";
            this.txtWeight2.Size = new System.Drawing.Size(159, 24);
            this.txtWeight2.TabIndex = 12;
            // 
            // cbType2
            // 
            this.cbType2.DisplayMember = "TypeName";
            this.cbType2.FormattingEnabled = true;
            this.cbType2.Location = new System.Drawing.Point(67, 152);
            this.cbType2.Name = "cbType2";
            this.cbType2.Size = new System.Drawing.Size(186, 26);
            this.cbType2.TabIndex = 13;
            this.cbType2.ValueMember = "Id";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDel.Location = new System.Drawing.Point(95, 370);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(131, 48);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "Изтрий";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Редактор на меню";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtDiscr);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(30, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 219);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Създай ястие:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(87, 124);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(164, 24);
            this.txtWeight.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(65, 95);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 24);
            this.txtPrice.TabIndex = 8;
            // 
            // txtDiscr
            // 
            this.txtDiscr.Location = new System.Drawing.Point(101, 65);
            this.txtDiscr.Name = "txtDiscr";
            this.txtDiscr.Size = new System.Drawing.Size(149, 24);
            this.txtDiscr.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(58, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 24);
            this.txtName.TabIndex = 6;
            // 
            // cbType
            // 
            this.cbType.DisplayMember = "TypeName";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(54, 152);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(197, 26);
            this.cbType.TabIndex = 5;
            this.cbType.ValueMember = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Тип:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Грамаж:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Описание:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(65, 184);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Въведи";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име:";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtDiscr2;
        private System.Windows.Forms.TextBox txtPrice2;
        private System.Windows.Forms.TextBox txtWeight2;
        private System.Windows.Forms.ComboBox cbType2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDiscr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
    }
}

