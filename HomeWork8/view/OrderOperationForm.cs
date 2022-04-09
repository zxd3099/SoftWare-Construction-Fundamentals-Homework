using Service;
using System;
using System.Windows.Forms;

namespace HomeWork8
{
    public delegate void setOrderValue(string orderId, string clientname, OrderDetail orderDetails);

    public partial class OrderOperationForm : Form
    {
        public event setOrderValue setMainFormOrderValue;
        public string orderID { get; set; }
        public string clientName { get; set; }
        public string vipShip { get; set; }
        public string address { get; set; }
        public string goodsName { get; set; }
        public string goodsID { get; set; }
        public double price { get; set; }
        public int amount { get; set; }


        public OrderOperationForm()
        {
            InitializeComponent();
            OrderIDtextBox.DataBindings.Add("Text", this, "orderId");

            //bug：最后传递给主窗口的clientName是“OrderOperationForm”
            //ClientNametextBox.DataBindings.Add("Text", this, "clientName");

            goodsNamecomboBox.DataBindings.Add("SelectedItem", this, "goodsName");

            //bug:当点击另处时，id和price的显示重新变回默认值
            //goodsIDValueLabel.DataBindings.Add("Text", this, "goodsID");
            //goodsPriceValueLabel.DataBindings.Add("Text", this, "price");
            AmountnumericUpDown.DataBindings.Add("Value", this, "amount");

        }

        private void goodsNamecomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (goodsNamecomboBox.SelectedItem.ToString() == "哈利波特")
            {
                goodsIDValueLabel.Text = "1";
                goodsPriceValueLabel.Text = "12";
            }
            else if (goodsNamecomboBox.SelectedItem.ToString() == "理想国")
            {
                goodsIDValueLabel.Text = "2";
                goodsPriceValueLabel.Text = "15";
            }
            else if (goodsNamecomboBox.SelectedItem.ToString() == "百年孤独")
            {
                goodsIDValueLabel.Text = "3";
                goodsPriceValueLabel.Text = "18";
            }

        }

        private void operateOrderBtn_Click(object sender, EventArgs e)
        {
            goodsID = goodsIDValueLabel.Text.ToString();
            price = Convert.ToInt32(goodsPriceValueLabel.Text.ToString());
            Name = ClientNametextBox.Text.ToString();
            OrderDetail orderDetail = new OrderDetail(new Goods(goodsID, goodsName, price), amount);

            setMainFormOrderValue(orderID, Name, orderDetail);
            this.Close();
        }

        private void OrderIDtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
