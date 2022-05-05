using System;
using System.Windows.Forms;

namespace Assignment10
{
  public partial class FormDetailEdit : Form {
    public OrderDetail Detail { get; set; }

    public FormDetailEdit() {
      InitializeComponent();
    }

    public FormDetailEdit(OrderDetail detail):this() {
      this.Detail = detail;
      this.bdsDetail.DataSource = detail;
      bdsGoods.Add(new Goods("1", "apple", 100.0));
      bdsGoods.Add(new Goods("2", "egg", 200.0));
    }

    private void btnOK_Click(object sender, EventArgs e) {

    }
  }
}
