using SA.AUTApp.BLL.Concrete;
using SA.AUTApp.DAL.Concrete;
using Excel = Microsoft.Office.Interop.Excel;
using SA.AUTApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace SA.AUTApp.UI
{
    public partial class Form1 : Form
    {
        UrunService UrunService = new UrunService(new UrunRepo(new DAL.Context.SA_AUTAppDbContext()));
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var urunler = UrunService.GetAll();

            dataGridView1.DataSource = urunler.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i].Value = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    using (FileStream fileStream = new FileStream("DataGridViewExport.xlsx", FileMode.Create))
                    {
                        excelPackage.SaveAs(fileStream);
                    }
                }

                MessageBox.Show("Export successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
