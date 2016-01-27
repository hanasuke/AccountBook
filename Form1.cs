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
        public string currentLoadFileName;
        public Form1()
        {
            InitializeComponent();
            LoadData(Constants.defaultFileName);
            currentLoadFileName = Constants.defaultFileName;
        }

        private void AddData()
        {
            ItemForm frmItem = new ItemForm(categoryDataSet);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                    //DateTime.Now,
                    //frmItem.monCalendar.SelectionRange.Start,
                    frmItem.dateTimePicker.Value.Date,
                    frmItem.cmbCategory.Text,
                    frmItem.txtItem.Text,
                    int.Parse(frmItem.txtMoney.Text),
                    frmItem.txtRemarks.Text);
            }
        }

        private void AddData(DateTime dateTime)
        {
            ItemForm frmItem = new ItemForm(dateTime);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                    //DateTime.Now,
                    //frmItem.monCalendar.SelectionRange.Start,
                    frmItem.dateTimePicker.Value.Date,
                    frmItem.cmbCategory.Text,
                    frmItem.txtItem.Text,
                    int.Parse(frmItem.txtMoney.Text),
                    frmItem.txtRemarks.Text);
            }
        }

        public void SaveData(string argPath)
        {
            // .abd is AccountBookData format
            // abd is csv format;
            string path = argPath;
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

        public void LoadData(string argPath)
        {
            // .abd is AccountBookData format
            // abd is csv format;
            string path = argPath;
            string delimStr = ",";
            char[] delimiter = delimStr.ToCharArray();
            string[] strData;
            string strLine;
            bool fileExists = System.IO.File.Exists(path);

            if (fileExists)
            {
                moneyDataSet.moneyDataTable.Clear();
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

        public void UpdateData(DataGridView dgv)
        {
            int nowRow = dgv.CurrentRow.Index;
            DateTime oldDate
                = DateTime.Parse(dgv.Rows[nowRow].Cells[0].Value.ToString());
            string oldCategory = dgv.Rows[nowRow].Cells[1].Value.ToString();
            string oldItem = dgv.Rows[nowRow].Cells[2].Value.ToString();
            int oldMoney
                = int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString());
            string oldRemarks = dgv.Rows[nowRow].Cells[4].Value.ToString();
            ItemForm frmItem = new ItemForm(categoryDataSet,
                                            oldDate,
                                            oldCategory,
                                            oldItem,
                                            oldMoney,
                                            oldRemarks);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                //dgv.Rows[nowRow].Cells[0].Value
                   // = frmItem.monCalendar.SelectionRange.Start;
                dgv.Rows[nowRow].Cells[1].Value = frmItem.cmbCategory.Text;
                dgv.Rows[nowRow].Cells[2].Value = frmItem.txtItem.Text;
                dgv.Rows[nowRow].Cells[3].Value = int.Parse(frmItem.txtMoney.Text);
                dgv.Rows[nowRow].Cells[4].Value = frmItem.txtRemarks.Text;
            }
        }

        public void DeleteData(DataGridView dgv)
        {
            int currentRow = dgvTable.CurrentRow.Index;
            dgvTable.Rows.RemoveAt(currentRow);
        }

        private void CalcCurrentMonthTotal()
        {
            int input = 0;
            int output = 0;

            for (int i = 0; i < dgvCal.RowCount; i++)
            {
                if (Convert.ToString(dgvCal[1, i].Value) == "給料")
                {
                    input += Convert.ToInt32(dgvCal[3, i].Value);
                }
                else
                {
                    output += Convert.ToInt32(dgvCal[3, i].Value);
                }
                incomeCal.Text = input + "円";
                outCal.Text = output + "円";
                if (input < output)
                {
                    totalCal.ForeColor = Color.Red;
                }
                totalCal.Text = input - output + "円";
            }
            //foreach (var i in dgvCal.Rows)
            //{
                //if (i.Cell[2].Values == "給料")
                //{
                //    input += (int)i.Cell[2].Values;
                //}
            //}
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

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Account Bookファイル(*.abd)|*.abd|CSVファイル(*.csv)|*.csv";
            ofd.Title = "開くファイルを選択してください";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadData(ofd.FileName);
                currentLoadFileName = ofd.FileName;
            }
        }

        private void updateSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(currentLoadFileName);
        }

        private void renameSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Account Bookファイル(*.abd)|*.abd|CSVファイル(*.csv)|*.csv";
            sfd.Title = "保存先を選択してください";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveData(sfd.FileName);
                currentLoadFileName = sfd.FileName;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            //debugLabel.Text = selectedDate.ToString("yyyy/mm/dd");
            //moneyDataSet.sele
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void buttonChangeTable_Click(object sender, EventArgs e)
        {
            UpdateData(dgvTable);
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            DeleteData(dgvTable);
        }

        private void buttonAddCal_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void buttonChangeCal_Click(object sender, EventArgs e)
        {
            UpdateData(dgvCal);
        }

        private void buttonDeleteCal_Click(object sender, EventArgs e)
        {
            DeleteData(dgvCal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEndTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            AddData(monthCalendar1.SelectionRange.Start);
            CalcCurrentMonthTotal();
        }

        private void dgvCal_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            CalcCurrentMonthTotal();
        }
    }
}
