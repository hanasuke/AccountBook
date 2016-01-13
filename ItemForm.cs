using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public partial class ItemForm : Form
    {
        public ItemForm(CategoryDataSet argCategoryDataSet)
        {
            InitializeComponent();
            categoryDataSet.Merge(argCategoryDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("regist button clicked");
        }

        public MoneyDataSet.moneyDataTableRow monCalender { get; set; }
    }
}
