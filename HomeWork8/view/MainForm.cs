using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace HomeWork8
{
    public partial class MainForm : Form
    {
        private OrderService orderService = new OrderService();

        public MainForm()
        {
            InitializeComponent();

            Client client1 = new Client("xyf");
            Client client2 = new Client("zzx");
            Client client3 = new Client("lbr");

            Goods goods1 = new Goods("1", "哈利波特", 12);
            Goods goods2 = new Goods("2", "理想国", 15);
            Goods goods3 = new Goods("3", "百年孤独", 18);

            orderService.AddOrder(new Order("001", client1, new List<OrderDetail> { new OrderDetail(goods1, 2) }));
            orderService.AddOrder(new Order("002", client1, new List<OrderDetail> { new OrderDetail(goods2, 3) }));
            orderService.AddOrder(new Order("003", client2, new List<OrderDetail> { new OrderDetail(goods3, 1) }));
            orderService.AddOrder(new Order("004", client2, new List<OrderDetail> { new OrderDetail(goods3, 1), new OrderDetail(goods1, 2) }));
            orderService.AddOrder(new Order("005", client3, new List<OrderDetail> { new OrderDetail(goods1, 2),
                new OrderDetail(goods2, 2), new OrderDetail(goods3, 1)}));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (QuerycomboBox.SelectedItem.ToString() == "全部")
                QuerytextBox.Visible = false;
            OrderdataGridView.DataSource = orderService.GetOrders();

        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                switch (QuerycomboBox.SelectedItem.ToString())
                {
                    case "全部": 
                        OrderdataGridView.DataSource = orderService.GetOrders(); 
                        break;
                    case "订单号": 
                        OrderdataGridView.DataSource = new Order[] { orderService.QueryById(QuerytextBox.Text) };
                        break;
                    case "客户名":
                        OrderdataGridView.DataSource = orderService.QueryByClient(QuerytextBox.Text);
                        break;
                    case "总金额":
                        OrderdataGridView.DataSource = orderService.QueryByAmount(Convert.ToDouble(QuerytextBox.Text));
                        break;
                    case "商品名":
                        OrderdataGridView.DataSource = orderService.QueryByName(QuerytextBox.Text);
                        break;
                }
            }catch(ArgumentException exception)
            {
                MessageBox.Show("没有该订单，请确认输入条件是否正确");
            }catch(FormatException exception)
            {
                MessageBox.Show("请输入正确的数字格式");
            }
           
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                orderService.DelOrderById(DeletetextBox.Text);
            }catch(ArgumentException exption)
            {
                MessageBox.Show("没有该订单，请确认订单号是否正确");
            }
        }

        private void QuerycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuerytextBox.Visible = true;
            QuerytextBox.Clear();
            if (QuerycomboBox.SelectedItem.ToString() == "全部")
                QuerytextBox.Visible = false;
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderOperationForm addForm = new OrderOperationForm();
            
            addForm.setMainFormOrderValue += getOrderValueAndAdd;
            addForm.Show();
        }

        private void ModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderOperationForm modifyForm = new OrderOperationForm();
            modifyForm.Text = "修改订单";
            modifyForm.operateOrderBtn.Text = "修改订单";

            modifyForm.setMainFormOrderValue += getOrderValueAndModify;
            modifyForm.Show();
        }

        public void getOrderValueAndAdd(string orderId, string clientname, OrderDetail orderDetails)
        {
            try
            {
                Order newOrder = new Order();
                newOrder.OrderID = orderId;
                newOrder.OrderClient = new Client(clientname);
                
                newOrder.Detail.Add(orderDetails);
                orderService.AddOrder(newOrder);
                MessageBox.Show("添加订单成功！");

            }catch(ArgumentException exception)
            {
                MessageBox.Show("该订单信息错误，请重新核对");
            }
        }

        public void getOrderValueAndModify(string orderId, string clientname, OrderDetail orderDetails)
        {
            try
            {
                Order newOrder = new Order();
                newOrder.OrderID = orderId;
                newOrder.OrderClient = new Client(clientname);
                newOrder.Detail.Add(orderDetails);

                orderService.ModifyOrder(newOrder);
                MessageBox.Show("修改订单成功！");

            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("该订单信息错误，请重新核对");
            }
        }

        /// <summary>
        /// 点击订单表项目，订单明细表显示对应明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取目标订单号
            string targetOrderId = OrderdataGridView.CurrentRow.Cells[0].Value as String;
            if (targetOrderId != null)
            {
                Order targetOrder = orderService.QueryById(targetOrderId);

                //新映射一个表，显示明细详细信息，同时修改OrderDetailDataGridView各列绑定的属性
                var targetList = targetOrder.Detail.Select(
                    o => new
                    {
                        goodsID = o.OrderGoods.GoodID,
                        goodsName = o.OrderGoods.GoodName,
                        goodsPrice = o.OrderGoods.Price,
                        o.Quantity,
                        o.Money
                    });
                orderDetailDataGridView.DataSource = targetList.ToList();
            }

        }

        private void export_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //获取文件完整路径
                string localFilePath = saveFileDialog.FileName.ToString();

                //获取文件名
                string fileName = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
                //获取文件夹路径
                string fileDirPath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

                orderService.Export(fileDirPath, fileName);
            }
        }

        private void import_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //获取文件完整路径
                string localFilePath = openFileDialog.FileName.ToString();

                orderService.Import(localFilePath);
            }
        }

        private void OrderdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 操作订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
