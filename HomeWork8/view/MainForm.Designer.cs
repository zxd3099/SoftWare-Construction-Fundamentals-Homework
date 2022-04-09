using Service;

namespace HomeWork8
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OrderdataGridView = new System.Windows.Forms.DataGridView();
            this.OrderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.export_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.import_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuerytextBox = new System.Windows.Forms.TextBox();
            this.QuerycomboBox = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.OrderIDlabel = new System.Windows.Forms.Label();
            this.DeletetextBox = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderdataGridView
            // 
            this.OrderdataGridView.AllowUserToAddRows = false;
            this.OrderdataGridView.AllowUserToDeleteRows = false;
            this.OrderdataGridView.AllowUserToResizeColumns = false;
            this.OrderdataGridView.AllowUserToResizeRows = false;
            this.OrderdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderdataGridView.AutoGenerateColumns = false;
            this.OrderdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderClientDataGridViewTextBoxColumn,
            this.OrderAmount});
            this.OrderdataGridView.DataSource = this.OrderbindingSource;
            this.OrderdataGridView.Location = new System.Drawing.Point(0, 128);
            this.OrderdataGridView.Name = "OrderdataGridView";
            this.OrderdataGridView.RowHeadersWidth = 51;
            this.OrderdataGridView.RowTemplate.Height = 27;
            this.OrderdataGridView.Size = new System.Drawing.Size(820, 241);
            this.OrderdataGridView.TabIndex = 0;
            this.OrderdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderdataGridView_CellClick);
            this.OrderdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderdataGridView_CellContentClick);
            // 
            // OrderbindingSource
            // 
            this.OrderbindingSource.DataSource = typeof(Service.Order);
            // 
            // orderDetailDataGridView
            // 
            this.orderDetailDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDetailDataGridView.AutoGenerateColumns = false;
            this.orderDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moneyDataGridViewTextBoxColumn,
            this.GoodsIDDataGridViewTextBoxColumn,
            this.goodsDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn});
            this.orderDetailDataGridView.DataSource = this.orderDetailBindingSource;
            this.orderDetailDataGridView.Location = new System.Drawing.Point(0, 413);
            this.orderDetailDataGridView.Name = "orderDetailDataGridView";
            this.orderDetailDataGridView.RowHeadersWidth = 51;
            this.orderDetailDataGridView.RowTemplate.Height = 27;
            this.orderDetailDataGridView.Size = new System.Drawing.Size(820, 208);
            this.orderDetailDataGridView.TabIndex = 2;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.moneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GoodsIDDataGridViewTextBoxColumn
            // 
            this.GoodsIDDataGridViewTextBoxColumn.DataPropertyName = "goodsID";
            this.GoodsIDDataGridViewTextBoxColumn.HeaderText = "货号";
            this.GoodsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.GoodsIDDataGridViewTextBoxColumn.Name = "GoodsIDDataGridViewTextBoxColumn";
            // 
            // goodsDataGridViewTextBoxColumn
            // 
            this.goodsDataGridViewTextBoxColumn.DataPropertyName = "goodsName";
            this.goodsDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.goodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsDataGridViewTextBoxColumn.Name = "goodsDataGridViewTextBoxColumn";
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "goodsPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.goodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(Service.OrderDetail);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.操作订单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.export_ToolStripMenuItem,
            this.import_ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem1.Text = "文件";
            // 
            // export_ToolStripMenuItem
            // 
            this.export_ToolStripMenuItem.Name = "export_ToolStripMenuItem";
            this.export_ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.export_ToolStripMenuItem.Text = "导出";
            this.export_ToolStripMenuItem.Click += new System.EventHandler(this.export_ToolStripMenuItem_Click);
            // 
            // import_ToolStripMenuItem
            // 
            this.import_ToolStripMenuItem.Name = "import_ToolStripMenuItem";
            this.import_ToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.import_ToolStripMenuItem.Text = "导入";
            this.import_ToolStripMenuItem.Click += new System.EventHandler(this.import_ToolStripMenuItem_Click);
            // 
            // 操作订单ToolStripMenuItem
            // 
            this.操作订单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.ModifyToolStripMenuItem});
            this.操作订单ToolStripMenuItem.Name = "操作订单ToolStripMenuItem";
            this.操作订单ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.操作订单ToolStripMenuItem.Text = "订单操作";
            this.操作订单ToolStripMenuItem.Click += new System.EventHandler(this.操作订单ToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.AddToolStripMenuItem.Text = "新增订单";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // ModifyToolStripMenuItem
            // 
            this.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem";
            this.ModifyToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.ModifyToolStripMenuItem.Text = "修改订单";
            this.ModifyToolStripMenuItem.Click += new System.EventHandler(this.ModifyToolStripMenuItem_Click);
            // 
            // QuerytextBox
            // 
            this.QuerytextBox.Location = new System.Drawing.Point(29, 82);
            this.QuerytextBox.Name = "QuerytextBox";
            this.QuerytextBox.Size = new System.Drawing.Size(149, 25);
            this.QuerytextBox.TabIndex = 1;
            // 
            // QuerycomboBox
            // 
            this.QuerycomboBox.FormattingEnabled = true;
            this.QuerycomboBox.Items.AddRange(new object[] {
            "全部",
            "订单号",
            "客户名",
            "配送地址",
            "总金额"});
            this.QuerycomboBox.Location = new System.Drawing.Point(29, 44);
            this.QuerycomboBox.Name = "QuerycomboBox";
            this.QuerycomboBox.Size = new System.Drawing.Size(108, 23);
            this.QuerycomboBox.TabIndex = 2;
            this.QuerycomboBox.Text = "全部";
            this.QuerycomboBox.SelectedIndexChanged += new System.EventHandler(this.QuerycomboBox_SelectedIndexChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnQuery.Location = new System.Drawing.Point(222, 69);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // OrderIDlabel
            // 
            this.OrderIDlabel.AutoSize = true;
            this.OrderIDlabel.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderIDlabel.Location = new System.Drawing.Point(502, 70);
            this.OrderIDlabel.Name = "OrderIDlabel";
            this.OrderIDlabel.Size = new System.Drawing.Size(76, 17);
            this.OrderIDlabel.TabIndex = 4;
            this.OrderIDlabel.Text = "订单号：";
            // 
            // DeletetextBox
            // 
            this.DeletetextBox.Location = new System.Drawing.Point(571, 68);
            this.DeletetextBox.Name = "DeletetextBox";
            this.DeletetextBox.Size = new System.Drawing.Size(97, 25);
            this.DeletetextBox.TabIndex = 5;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(697, 65);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(96, 30);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "删除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.DeletetextBox);
            this.panel1.Controls.Add(this.OrderIDlabel);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.QuerycomboBox);
            this.panel1.Controls.Add(this.QuerytextBox);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 122);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "订单明细";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.MinimumSize = new System.Drawing.Size(88, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 65);
            this.panel2.TabIndex = 4;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderClientDataGridViewTextBoxColumn
            // 
            this.orderClientDataGridViewTextBoxColumn.DataPropertyName = "OrderClient";
            this.orderClientDataGridViewTextBoxColumn.HeaderText = "客户名";
            this.orderClientDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderClientDataGridViewTextBoxColumn.Name = "orderClientDataGridViewTextBoxColumn";
            // 
            // OrderAmount
            // 
            this.OrderAmount.DataPropertyName = "OrderAmount";
            this.OrderAmount.HeaderText = "金额";
            this.OrderAmount.MinimumWidth = 6;
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(820, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.orderDetailDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrderdataGridView);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OrderdataGridView;
        private System.Windows.Forms.BindingSource OrderbindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView orderDetailDataGridView;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem export_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem import_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyToolStripMenuItem;
        private System.Windows.Forms.TextBox QuerytextBox;
        private System.Windows.Forms.ComboBox QuerycomboBox;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label OrderIDlabel;
        private System.Windows.Forms.TextBox DeletetextBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmount;
    }
}

