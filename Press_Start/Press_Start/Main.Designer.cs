namespace Press_Start
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_manufacture = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_inventory = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_adddis = new System.Windows.Forms.Button();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_create);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.txt_model);
            this.groupBox1.Controls.Add(this.txt_manufacture);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(22, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Gamepad:";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(23, 178);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(183, 86);
            this.txt_description.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(23, 64);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(183, 26);
            this.txt_id.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id:";
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_create.ForeColor = System.Drawing.Color.Black;
            this.btn_create.Location = new System.Drawing.Point(68, 468);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 32);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(20, 423);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(59, 26);
            this.txt_price.TabIndex = 7;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(20, 361);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(47, 26);
            this.txt_stock.TabIndex = 6;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(20, 299);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(183, 26);
            this.txt_model.TabIndex = 5;
            // 
            // txt_manufacture
            // 
            this.txt_manufacture.Location = new System.Drawing.Point(23, 123);
            this.txt_manufacture.Name = "txt_manufacture";
            this.txt_manufacture.Size = new System.Drawing.Size(183, 26);
            this.txt_manufacture.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer:";
            // 
            // lst_inventory
            // 
            this.lst_inventory.FormattingEnabled = true;
            this.lst_inventory.ItemHeight = 19;
            this.lst_inventory.Location = new System.Drawing.Point(25, 50);
            this.lst_inventory.Name = "lst_inventory";
            this.lst_inventory.Size = new System.Drawing.Size(259, 289);
            this.lst_inventory.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.lst_inventory);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox2.Location = new System.Drawing.Point(281, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 373);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gamepad List:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox3.Location = new System.Drawing.Point(635, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 515);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gamepad:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(20, 167);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(502, 86);
            this.textBox7.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Description:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(20, 53);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(502, 26);
            this.textBox8.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Id:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(17, 412);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(96, 26);
            this.textBox9.TabIndex = 20;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(17, 350);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(62, 26);
            this.textBox10.TabIndex = 19;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(17, 288);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(502, 26);
            this.textBox11.TabIndex = 18;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(20, 112);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(502, 26);
            this.textBox12.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Price:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Stock:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Model:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Manufacturer:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Controls.Add(this.btn_adddis);
            this.groupBox4.Controls.Add(this.txt_discount);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox4.Location = new System.Drawing.Point(265, 454);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 136);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add discount:";
            // 
            // btn_adddis
            // 
            this.btn_adddis.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_adddis.ForeColor = System.Drawing.Color.Black;
            this.btn_adddis.Location = new System.Drawing.Point(258, 98);
            this.btn_adddis.Name = "btn_adddis";
            this.btn_adddis.Size = new System.Drawing.Size(75, 32);
            this.btn_adddis.TabIndex = 13;
            this.btn_adddis.Text = "Add";
            this.btn_adddis.UseVisualStyleBackColor = false;
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(16, 60);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(317, 26);
            this.txt_discount.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Discount code:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkOrange;
            this.label14.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(478, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(221, 45);
            this.label14.TabIndex = 11;
            this.label14.Text = "PRESS START";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(718, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "(i)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_manufacture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.ListBox lst_inventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_adddis;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}