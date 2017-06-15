using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel;

namespace ExcelConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ope = new OpenFileDialog();
            ope.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (ope.ShowDialog() == DialogResult.Cancel)
                return;

            FileStream stream = new FileStream(ope.FileName, FileMode.Open);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataSet result = excelReader.AsDataSet();

            DataClasses1DataContext conn = new DataClasses1DataContext();
            foreach (DataTable table in result.Tables)
            {
                foreach(DataRow dr in table.Rows)
                {
                    BulkData33mm addtable = new BulkData33mm()
                    {
                        Image1 = Convert.ToString(dr[2]),
                        Name = Convert.ToString(dr[1]),
                        CustomerNo = Convert.ToString(dr[0]),
                        ProductType = Convert.ToString(dr[4]),
                        TankSize = Convert.ToString(dr[5]),
                        Supplier = Convert.ToString(dr[6]),
                        MarketSector = Convert.ToString(dr[7]),
                        Address = Convert.ToString(dr[8]),
                        Postcode = Convert.ToString(dr[9]),
                        Place = Convert.ToString(dr[10]),
                        Country = Convert.ToString(dr[11]),
                        CountryCode = Convert.ToString(dr[12]),
                        Latitude = float.Parse(dr[13].ToString()),
                        Longitude = float.Parse(dr[14].ToString()),
                        Remarks = Convert.ToString(dr[15]),
                        Website = Convert.ToString(dr[16]),
                        CylinderRequired = Convert.ToString(dr[17]),
                        BarplusInfo = Convert.ToString(dr[18]),
                        RecordStatus = Convert.ToString(dr[19]),
                        UserLocationId = Convert.ToString(dr[20]),
                        RecordType = Convert.ToString(dr[22])
                    };
                    conn.BulkData33mms.InsertOnSubmit(addtable);
                }
            }
            conn.SubmitChanges();
            excelReader.Close();
            stream.Close();

            MessageBox.Show("ok!");
        }
    }
}
