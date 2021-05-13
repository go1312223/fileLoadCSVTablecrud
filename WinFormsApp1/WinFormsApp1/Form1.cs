using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog path = new OpenFileDialog();
            path.ShowDialog();
            filetext.Text = System.IO.Path.GetFullPath(path.FileName);
            string[] lines = System.IO.File.ReadAllLines(filetext.Text);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (var head in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(head));
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int col = 0;
                    foreach (var head in headerLabels)
                    {
                        dr[head] = data[col++];
                    }
                    dt.DefaultView.Sort = "成績";//依行欄位名稱排序
                    dt.Rows.Add(dr);
                }
                ans.DataSource = dt;
                ans.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void newcol_Click(object sender, EventArgs e)
        {
            if (ans.ColumnCount != 0)
            {
                DataRow toInsert = dt.NewRow();
                dt.Rows.InsertAt(toInsert, ans.Rows.Count);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            ans.AllowUserToAddRows = false;

            foreach (DataGridViewRow row in ans.SelectedRows)//要點最左邊的箭頭才能刪除整列
            {
                ans.Rows.RemoveAt(row.Index);
            }
            ans.AllowUserToAddRows = true;

            ///ans.Rows.RemoveAt(ans.SelectedRows[0].Index);

            //ans.Rows.RemoveAt(ans.Rows.Count - 1);//刪除最後一行
        }
    }
}
