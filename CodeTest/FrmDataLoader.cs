using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CodeTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        const string FILE_FILTER = "CSV Files (*.csv)|*.csv";
        const string COMBO_DATA_FILE = "combo_example.csv";

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFlDia = new OpenFileDialog();
            openFlDia.Filter = FILE_FILTER;
            openFlDia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFlDia.Title = MessagesObj.SelectFile;
            if (openFlDia.ShowDialog(this) == DialogResult.OK)
            {
                // populate the data grid
                string flName = openFlDia.FileName;
                lblStatus.Text = MessagesObj.LoadingExcelData;
                populateDataGrid(flName);
                lblStatus.Text = flName; 
            }
        }


        private void populateDataGrid(string fileFullPath)
        {
            try
            {
                // extract the name of the spreadsheet file (we want to extract the name to use in the SQL Statement as the sheet name corresponds with the file name)
                string sheetName = parseFileName(fileFullPath);

                


                // connect to the spreadsheet and pull the datatable
                ExcelDataManager excelDbMan = new ExcelDataManager(fileFullPath);
                excelDbMan.openWorkBook(sheetName);

                DataTable d = excelDbMan.getDataTable();

                dgExcelData.DataSource = d;

                excelDbMan.killExcel();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(MessagesObj.UnexpectedException + e.Message);
            }
        }

        private string parseFileName(string filePath)
        {
            string[] brk = filePath.Split('\\');
            return brk[brk.GetUpperBound(0)].Replace(".csv", string.Empty);

        }

        Messages MessagesObj;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // load the messages info (we default to english). I didn't create any other lanuage lookups but just to give an idea (would likely use .xml or even have
                // the  messages for all languages sitting in a db table)
                // load the combo box data...
                loadMessageData();
                string comboBoxDataFile = AppDomain.CurrentDomain.BaseDirectory + COMBO_DATA_FILE;
                if (File.Exists(comboBoxDataFile))
                {
                    lblStatus.Text = MessagesObj.LoadingCombo + comboBoxDataFile + "...";
                    string sheetName = parseFileName(COMBO_DATA_FILE);

                    // connect to the spreadsheet and pull the datatable
                    ExcelDataManager excelDbMan = new ExcelDataManager(comboBoxDataFile);
                    excelDbMan.openWorkBook(sheetName);

                    DataTable d = excelDbMan.getDataTable();
                    cmbAggregate.ComboBox.DataSource = d;
                    cmbAggregate.ComboBox.DisplayMember = "Name";
                    cmbAggregate.ComboBox.ValueMember = "id";

                    excelDbMan.killExcel();
                }
                else
                {
                    MessageBox.Show(comboBoxDataFile + MessagesObj.DoesNotExist);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(MessagesObj.UnexpectedException + ex.Message);
            }
            finally
            {
                lblStatus.Text = string.Empty;
            }
        }

        private void loadMessageData()
        {
            MessagesObj = new Messages(Messages.eLanguage.english); // default to english for this example but we would have a lookup in a data table or other config setting to determine what language we're gathering for
            MessagesObj.getMessages();
        }


        int selectedGridColumnIndex = -1;

        
        private void dgExcelData_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            selectedGridColumnIndex = e.ColumnIndex;
            // highlight the cells in the selected column
            foreach (DataGridViewRow dr in dgExcelData.Rows)
            {
                foreach (DataGridViewCell dc in dr.Cells)
                {
                    if (dc.ColumnIndex == e.ColumnIndex)
                    {
                        dc.Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dc.Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void btnUpdateText_Click(object sender, EventArgs e)
        {
            // change "a" to "@" for values in selected column
            foreach (DataGridViewRow dr in dgExcelData.Rows)
            {
                foreach (DataGridViewCell dc in dr.Cells)
                {
                    if (dc.ColumnIndex == selectedGridColumnIndex && dc.Value != null)
                    {
                        dc.Value = dc.Value.ToString().Replace("a", "@");
                    }
                }
            }
        }

        private void cmbAggregate_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelectedComboIndex.Text = cmbAggregate.ComboBox.SelectedValue.ToString();
            
        }
    }
}
