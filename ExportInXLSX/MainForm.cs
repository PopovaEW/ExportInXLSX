using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ExportInXLSX
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            gridPatient.AutoGenerateColumns = false;
            DataBind();
        }

        private DataTable LoadData()
        {
            DataTable dt = null;
            try {
                dt = new DataTable("ListPatient");
                dt.ReadXmlSchema("Data.xml");
                dt.Columns["DecDate"].DataType = Type.GetType("System.DateTime");
                dt.Columns["SPECDATE"].DataType = typeof(DateTime);
                dt.ReadXml("Data.xml");
            }
            catch (Exception ex) {
                lblErrorMain.Text = ex.Message + "\n";
                lblErrorMain.Visible = true;
                return null;
            }
            
            return dt;
        }

        public void DataBind()
        {
            btnExport.Enabled = false;
            gridPatient.DataSource = LoadData();
            if (gridPatient.DataSource!=null && ((DataTable)gridPatient.DataSource).Rows.Count>0)
                btnExport.Enabled = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Enabled = false;
            XLWorkbook wbook = new XLWorkbook();
            IXLWorksheet ws = wbook.Worksheets.Add("ListPatient");
            int i = 1;
            foreach (DataGridViewColumn col in gridPatient.Columns)
            {
                if (col.Visible && col.HeaderText != "")
                {
                    ws.Cell(1, i).Value = col.HeaderText;
                    ws.Column(i).Width = col.Width / 9;
                    ws.Column(i).Style.DateFormat.Format = col.DefaultCellStyle.Format;
                    ws.Column(i).Style.Alignment.WrapText = true;
                    ws.Cell(1, i).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    ws.Cell(1, i).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    ws.Cell(1, i).Style.Fill.BackgroundColor = XLColor.FromArgb(0, 64, 128);
                    ws.Cell(1, i).Style.Font.FontColor = XLColor.White;
                    ws.Cell(1, i).Style.Font.Bold = true;
                    i++;
                }
            }
            i = 2;
            int j = 1;
            foreach (DataGridViewRow r in gridPatient.Rows)
            {
                j = 1;
                foreach (DataGridViewCell cell in r.Cells)
                {
                    if (gridPatient.Columns[cell.ColumnIndex].Visible && gridPatient.Columns[cell.ColumnIndex].HeaderText != "")
                    {
                        ws.Cell(i, j).Value = cell.Value.ToString();
                        ws.Cell(i, j).Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        ws.Cell(i, j).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                        j++;
                    }
                }
                i++;
            }
            ws.Range(1,1,i-1, j-1).Style.Border.InsideBorder = XLBorderStyleValues.Thin;
            ws.Range(1, 1, i-1,j-1).Style.Border.InsideBorderColor = XLColor.Black;
            ws.Range(1, 1, i-1, j-1).Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            ws.Range(1, 1, i-1, j-1).Style.Border.OutsideBorderColor = XLColor.Black;
            wbook.SaveAs("ListPatient_"+DateTime.Now.ToString("yyyyMMdd_HHmmss")+".xlsx");
            btnExport.Enabled = true;
            MessageBox.Show("Данные экспортированы в Excel успешно!", "Создание файла", MessageBoxButtons.OK);
        }
    }
}
