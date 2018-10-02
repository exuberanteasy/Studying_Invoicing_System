using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing_Go
{
    public partial class ModifyData : Form
    {
        public ModifyData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //步驟1 定義要修改的 DataRow 物件
            DataRow drModifyProduct;

            //步驟2 將要修改的 DataRow 取出來
            drModifyProduct = dtProduct.Rows[2];

            //Step 3 開始修改
            drModifyProduct.BeginEdit();

            //Step 4 修改欄位的值
            drModifyProduct["ProductID"] = "XD14002";
            drModifyProduct["ProductName"] = "Access 2013 進銷存管理系統實作 ";

            //Step 4 Save or cancel
            if (MessageBox.Show("儲存所做的修改? ", "修改", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //儲存變更
                drModifyProduct.EndEdit();
            }
            else
            {
                //放棄變更
                drModifyProduct.CancelEdit();
            }
        }
    }
}
