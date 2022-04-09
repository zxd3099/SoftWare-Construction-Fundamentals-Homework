
namespace HomeWork8
{
    partial class OrderOperationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderDetaillabel = new System.Windows.Forms.Label();
            this.orderDetailInfoBox = new System.Windows.Forms.GroupBox();
            this.selectGoodsLabel = new System.Windows.Forms.Label();
            this.AmountnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.goodsNamecomboBox = new System.Windows.Forms.ComboBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.goodsIDLabel = new System.Windows.Forms.Label();
            this.goodsIDValueLabel = new System.Windows.Forms.Label();
            this.goosIDValueLabel = new System.Windows.Forms.Label();
            this.goodsPriceValueLabel = new System.Windows.Forms.Label();
            this.goodsPriceLabel = new System.Windows.Forms.Label();
            this.operateOrderBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClientNametextBox = new System.Windows.Forms.TextBox();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderIDtextBox = new System.Windows.Forms.TextBox();
            this.OrderIDlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.orderDetailInfoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountnumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.operateOrderBtn);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 558);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.OrderDetaillabel);
            this.panel2.Controls.Add(this.orderDetailInfoBox);
            this.panel2.Location = new System.Drawing.Point(9, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 207);
            this.panel2.TabIndex = 16;
            // 
            // OrderDetaillabel
            // 
            this.OrderDetaillabel.AutoSize = true;
            this.OrderDetaillabel.Location = new System.Drawing.Point(15, 10);
            this.OrderDetaillabel.Name = "OrderDetaillabel";
            this.OrderDetaillabel.Size = new System.Drawing.Size(67, 15);
            this.OrderDetaillabel.TabIndex = 4;
            this.OrderDetaillabel.Text = "订单明细";
            // 
            // orderDetailInfoBox
            // 
            this.orderDetailInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDetailInfoBox.Controls.Add(this.selectGoodsLabel);
            this.orderDetailInfoBox.Controls.Add(this.AmountnumericUpDown);
            this.orderDetailInfoBox.Controls.Add(this.goodsNamecomboBox);
            this.orderDetailInfoBox.Controls.Add(this.amountLabel);
            this.orderDetailInfoBox.Controls.Add(this.goodsIDLabel);
            this.orderDetailInfoBox.Controls.Add(this.goodsIDValueLabel);
            this.orderDetailInfoBox.Controls.Add(this.goosIDValueLabel);
            this.orderDetailInfoBox.Controls.Add(this.goodsPriceValueLabel);
            this.orderDetailInfoBox.Controls.Add(this.goodsPriceLabel);
            this.orderDetailInfoBox.Location = new System.Drawing.Point(103, 41);
            this.orderDetailInfoBox.Name = "orderDetailInfoBox";
            this.orderDetailInfoBox.Size = new System.Drawing.Size(434, 91);
            this.orderDetailInfoBox.TabIndex = 14;
            this.orderDetailInfoBox.TabStop = false;
            // 
            // selectGoodsLabel
            // 
            this.selectGoodsLabel.AutoSize = true;
            this.selectGoodsLabel.Location = new System.Drawing.Point(6, 21);
            this.selectGoodsLabel.Name = "selectGoodsLabel";
            this.selectGoodsLabel.Size = new System.Drawing.Size(67, 15);
            this.selectGoodsLabel.TabIndex = 6;
            this.selectGoodsLabel.Text = "货物名：";
            // 
            // AmountnumericUpDown
            // 
            this.AmountnumericUpDown.Location = new System.Drawing.Point(79, 52);
            this.AmountnumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.AmountnumericUpDown.Name = "AmountnumericUpDown";
            this.AmountnumericUpDown.Size = new System.Drawing.Size(120, 25);
            this.AmountnumericUpDown.TabIndex = 13;
            // 
            // goodsNamecomboBox
            // 
            this.goodsNamecomboBox.FormattingEnabled = true;
            this.goodsNamecomboBox.Items.AddRange(new object[] {
            "哈利波特",
            "理想国",
            "百年孤独"});
            this.goodsNamecomboBox.Location = new System.Drawing.Point(79, 18);
            this.goodsNamecomboBox.Name = "goodsNamecomboBox";
            this.goodsNamecomboBox.Size = new System.Drawing.Size(120, 23);
            this.goodsNamecomboBox.TabIndex = 5;
            this.goodsNamecomboBox.SelectedValueChanged += new System.EventHandler(this.goodsNamecomboBox_SelectedValueChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(21, 54);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(52, 15);
            this.amountLabel.TabIndex = 12;
            this.amountLabel.Text = "数量：";
            // 
            // goodsIDLabel
            // 
            this.goodsIDLabel.AutoSize = true;
            this.goodsIDLabel.Location = new System.Drawing.Point(205, 21);
            this.goodsIDLabel.Name = "goodsIDLabel";
            this.goodsIDLabel.Size = new System.Drawing.Size(45, 15);
            this.goodsIDLabel.TabIndex = 7;
            this.goodsIDLabel.Text = "货号:";
            // 
            // goodsIDValueLabel
            // 
            this.goodsIDValueLabel.AutoSize = true;
            this.goodsIDValueLabel.Location = new System.Drawing.Point(256, 21);
            this.goodsIDValueLabel.Name = "goodsIDValueLabel";
            this.goodsIDValueLabel.Size = new System.Drawing.Size(0, 15);
            this.goodsIDValueLabel.TabIndex = 11;
            // 
            // goosIDValueLabel
            // 
            this.goosIDValueLabel.AutoSize = true;
            this.goosIDValueLabel.Location = new System.Drawing.Point(252, 21);
            this.goosIDValueLabel.Name = "goosIDValueLabel";
            this.goosIDValueLabel.Size = new System.Drawing.Size(0, 15);
            this.goosIDValueLabel.TabIndex = 8;
            // 
            // goodsPriceValueLabel
            // 
            this.goodsPriceValueLabel.AutoSize = true;
            this.goodsPriceValueLabel.Location = new System.Drawing.Point(343, 21);
            this.goodsPriceValueLabel.Name = "goodsPriceValueLabel";
            this.goodsPriceValueLabel.Size = new System.Drawing.Size(0, 15);
            this.goodsPriceValueLabel.TabIndex = 10;
            // 
            // goodsPriceLabel
            // 
            this.goodsPriceLabel.AutoSize = true;
            this.goodsPriceLabel.Location = new System.Drawing.Point(293, 21);
            this.goodsPriceLabel.Name = "goodsPriceLabel";
            this.goodsPriceLabel.Size = new System.Drawing.Size(45, 15);
            this.goodsPriceLabel.TabIndex = 9;
            this.goodsPriceLabel.Text = "单价:";
            // 
            // operateOrderBtn
            // 
            this.operateOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.operateOrderBtn.Location = new System.Drawing.Point(472, 518);
            this.operateOrderBtn.Name = "operateOrderBtn";
            this.operateOrderBtn.Size = new System.Drawing.Size(98, 28);
            this.operateOrderBtn.TabIndex = 10;
            this.operateOrderBtn.Text = "添加订单";
            this.operateOrderBtn.UseVisualStyleBackColor = true;
            this.operateOrderBtn.Click += new System.EventHandler(this.operateOrderBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ClientNametextBox);
            this.groupBox3.Controls.Add(this.clientNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(9, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // ClientNametextBox
            // 
            this.ClientNametextBox.Location = new System.Drawing.Point(79, 18);
            this.ClientNametextBox.Name = "ClientNametextBox";
            this.ClientNametextBox.Size = new System.Drawing.Size(120, 25);
            this.ClientNametextBox.TabIndex = 2;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(15, 21);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(67, 15);
            this.clientNameLabel.TabIndex = 1;
            this.clientNameLabel.Text = "顾客名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.OrderIDtextBox);
            this.groupBox2.Controls.Add(this.OrderIDlabel);
            this.groupBox2.Location = new System.Drawing.Point(9, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // OrderIDtextBox
            // 
            this.OrderIDtextBox.Location = new System.Drawing.Point(79, 18);
            this.OrderIDtextBox.Name = "OrderIDtextBox";
            this.OrderIDtextBox.Size = new System.Drawing.Size(120, 25);
            this.OrderIDtextBox.TabIndex = 1;
            this.OrderIDtextBox.TextChanged += new System.EventHandler(this.OrderIDtextBox_TextChanged);
            // 
            // OrderIDlabel
            // 
            this.OrderIDlabel.AutoSize = true;
            this.OrderIDlabel.Location = new System.Drawing.Point(15, 21);
            this.OrderIDlabel.Name = "OrderIDlabel";
            this.OrderIDlabel.Size = new System.Drawing.Size(67, 15);
            this.OrderIDlabel.TabIndex = 0;
            this.OrderIDlabel.Text = "订单号：";
            // 
            // OrderOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 558);
            this.Controls.Add(this.panel1);
            this.Name = "OrderOperationForm";
            this.Text = "添加订单";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.orderDetailInfoBox.ResumeLayout(false);
            this.orderDetailInfoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountnumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OrderDetaillabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ClientNametextBox;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox OrderIDtextBox;
        private System.Windows.Forms.Label OrderIDlabel;
        public System.Windows.Forms.Button operateOrderBtn;
        private System.Windows.Forms.GroupBox orderDetailInfoBox;
        private System.Windows.Forms.Label selectGoodsLabel;
        private System.Windows.Forms.NumericUpDown AmountnumericUpDown;
        private System.Windows.Forms.ComboBox goodsNamecomboBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label goodsIDLabel;
        private System.Windows.Forms.Label goodsIDValueLabel;
        private System.Windows.Forms.Label goosIDValueLabel;
        private System.Windows.Forms.Label goodsPriceValueLabel;
        private System.Windows.Forms.Label goodsPriceLabel;
        private System.Windows.Forms.Panel panel2;
    }
}