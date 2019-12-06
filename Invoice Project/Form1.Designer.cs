namespace Invoice_Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.download = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtqua = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.download)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(297, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "شاشه الفاتوره\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // download
            // 
            this.download.Image = global::Invoice_Project.Properties.Resources.download;
            this.download.Location = new System.Drawing.Point(15, 13);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(145, 35);
            this.download.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.download.TabIndex = 1;
            this.download.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(220, 59);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(415, 19);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://www.linkedin.com/in/aziza-eltohamy-94474816a/\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "رقم الفاتوره\r\n";
            // 
            // txtitem
            // 
            this.txtitem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitem.ForeColor = System.Drawing.Color.DarkRed;
            this.txtitem.Location = new System.Drawing.Point(209, 108);
            this.txtitem.Multiline = true;
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(377, 27);
            this.txtitem.TabIndex = 4;
            this.txtitem.Text = "222000";
            this.txtitem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtitem.TextChanged += new System.EventHandler(this.txtitem_TextChanged);
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.ForeColor = System.Drawing.Color.DarkRed;
            this.txtdate.Location = new System.Drawing.Point(209, 158);
            this.txtdate.Multiline = true;
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(377, 27);
            this.txtdate.TabIndex = 6;
            this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdate_MouseClick);
            this.txtdate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdate_KeyPress);
            this.txtdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtdate_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "التاريخ";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.DarkRed;
            this.txtname.Location = new System.Drawing.Point(209, 203);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(377, 27);
            this.txtname.TabIndex = 8;
            this.txtname.Text = "الاسم";
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(604, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "اسم الزبون";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(38, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(629, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "_________________________________________________________________________________" +
    "_______________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "الصنف";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(333, 27);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(627, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "السعر";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(431, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "الكميه";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(496, 364);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(109, 25);
            this.txtprice.TabIndex = 14;
            this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtqua
            // 
            this.txtqua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqua.Location = new System.Drawing.Point(289, 364);
            this.txtqua.Multiline = true;
            this.txtqua.Name = "txtqua";
            this.txtqua.Size = new System.Drawing.Size(127, 25);
            this.txtqua.TabIndex = 15;
            this.txtqua.Text = "1";
            this.txtqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtqua.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqua_KeyDown);
            this.txtqua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqua_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItem,
            this.colQua,
            this.colPrice,
            this.colSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(61, 436);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(616, 132);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // colItem
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colItem.DefaultCellStyle = dataGridViewCellStyle1;
            this.colItem.FillWeight = 200F;
            this.colItem.HeaderText = "الصنف";
            this.colItem.Name = "colItem";
            this.colItem.ReadOnly = true;
            // 
            // colQua
            // 
            this.colQua.HeaderText = "الكميه";
            this.colQua.Name = "colQua";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "السعر الوحده";
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "الاجمال الفرعي";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.DarkMagenta;
            this.txttotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(166, 358);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(107, 31);
            this.txttotal.TabIndex = 18;
            this.txttotal.Text = "0";
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotal_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "الاجمالي";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Snow;
            this.btnAdd.Location = new System.Drawing.Point(86, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 61);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "اضافه";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(12, 335);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 61);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "طباعه";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(689, 588);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtqua);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtitem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.download);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاجمالي";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.download)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox download;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtqua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

