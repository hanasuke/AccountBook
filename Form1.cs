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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void AddData()
        {
            ItemForm frmItem = new ItemForm(categoryDataSet);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                    frmItem.monCalendar.SelectionRange.Start,
                    frmItem.cmbCategory.Text,
                    frmItem.txtItem.Text,
                    int.Parse(frmItem.txtMoney.Text),
                    frmItem.txtRemarks.Text);
            }
        }

        public void SaveData()
        {
            // .abd is AccountBookData format
            // abd is csv format;
            string path = "AccountBook.abd";
            string strData = "";

            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                path,false,System.Text.Encoding.UTF8
                );

            foreach (MoneyDataSet.moneyDataTableRow drMoney in moneyDataSet.moneyDataTable)
            {
                strData = drMoney.日付.ToShortDateString()+","
                    + drMoney.分類+"," 
                    + drMoney.品名+"," 
                    + drMoney.金額.ToString() +"," 
                    + drMoney.備考 ;
                Console.WriteLine(strData);
                sw.WriteLine(strData);
            }
            sw.Close();
        }

        public void LoadData()
        {
            // .abd is AccountBookData format
            // abd is csv format;
            string path = "AccountBook.abd";
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] strData;
            string strLine;
            bool fileExists = System.IO.File.Exists(path);

            if (fileExists)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(path, System.Text.Encoding.Default);

                while (sr.Peek() >= 0)
                {
                    strLine = sr.ReadLine();
                    strData = strLine.Split(delimiter);

                    moneyDataSet.moneyDataTable.AddmoneyDataTableRow(DateTime.Parse(strData[0]), strData[1], strData[2], int.Parse(strData[3]), strData[4]);
                }
                sr.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categoryDataSet._CategoryDataSet.AddCategoryDataSetRow("給料", "入金");
            categoryDataSet._CategoryDataSet.AddCategoryDataSetRow("食費", "出金");
            categoryDataSet._CategoryDataSet.AddCategoryDataSetRow("雑費", "出金");
            categoryDataSet._CategoryDataSet.AddCategoryDataSetRow("住居", "出金");
        }

        private void addAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
