using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Net;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Web.Services.Description;

namespace Project_ZOPZZ
{
    public partial class Logger : UserControl
    {
        private delegate string CurrentLabelCallback();
        private readonly Enemy enemyLogger = new Enemy();

        private const string FilePath = "enemy_logs.json";

        private readonly LogHandler _logHandler = new LogHandler();
        public Logger()
        {
            InitializeComponent();

        }
        private void Logger_Load(object sender, EventArgs e)
        {
            enemyLogger.LoadLogsIntoDataGridView(dataGridView1);       
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendAttackBTN_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnnouncementBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void message_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TargetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void searchData(string valueToFind)
        {

        }
        private void host_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                Clipboard.SetText(CurrentEXT());
            }
            catch
            {
            }
        }
        private delegate string CurrentEXTCallback();
        private string CurrentEXT()
        {
            string value = "";
            try
            {
                if (!dataGridView1.InvokeRequired)
                {
                    value = (string)dataGridView1.SelectedRows[0].Cells[1].Value;
                }
                else
                {
                    CurrentEXTCallback currentEXTCallback = new CurrentEXTCallback(CurrentEXT);
                    value = (string)base.Invoke(currentEXTCallback);
                }
            }
            catch
            {
                value = "Error";
            }
            return value;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                int selectedColumnIndex = dataGridView1.SelectedCells[0].ColumnIndex;

                // Get the value from the selected cell
                object cellValue = dataGridView1[selectedColumnIndex, selectedRowIndex].Value;

                // Copy the value to the clipboard
                if (cellValue != null)
                {
                    Clipboard.SetText(cellValue.ToString());
                }
            }
        }
        private void updateLogGrid()
        {
            LogHandler handler = new LogHandler();
            handler.LoadLogsIntoDataGridView(dataGridView1);
        }
        private void guna2Button18_Click(object sender, EventArgs e)
        {

        }

        private void labeltb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            EnemyLog newLog = new EnemyLog
            {
                IP = labeltb.Text,
                Label = gamertagtb.Text,
                DateSent = DateTime.Now.ToString()
            };

            // Save the new log
            enemyLogger.SaveLog(newLog);

            // Refresh the DataGridView
            enemyLogger.LoadLogsIntoDataGridView(dataGridView1);
        }

        private void copyGamertagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 1)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[1].RowIndex;
                int selectedColumnIndex = dataGridView1.SelectedCells[1].ColumnIndex;

                // Get the value from the selected cell
                object cellValue = dataGridView1[selectedColumnIndex, selectedRowIndex].Value;

                // Copy the value to the clipboard
                if (cellValue != null)
                {
                    Clipboard.SetText(cellValue.ToString());
                }
            }
        }
    }
}
