using CsvHelper;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;
using System.Text.RegularExpressions;
using ClosedXML.Excel;

namespace ManipulateCsv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Render Datagridview1
            List<Elements> records; //import element objects from Elements class as variable records. (requires using System.Collections.Generic)
            using (var reader = new StreamReader(@"Y:\Liverpool projects\Windows form app\Test\Test.csv")) // stream reader identifies file to open (can this be changed to an opendialogue component?)
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) //Generates new csv reader using all objects from file and converts to a list called records
            {
                records = csv.GetRecords<Elements>().ToList();
            }

            dataGridView1.DataSource = records; //display records in datagridview

            records.Add(new Elements() { Name = "Goose", Surname = "GooseyGoosey", Age = "68" }); //Add data manually

            //Render Datagridview 2
            List<HODs> rec; //import element objects from HODs class as variable rec. (requires using System.Collections.Generic)
            using (var reader = new StreamReader(@"Y:\Liverpool projects\Windows form app\Test\HODsTest2.csv")) // stream reader identifies file to open (can this be changed to an opendialogue component?)
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture)) //Generates new csv reader using all objects from file and converts to a list called records
            {
                rec = csv.GetRecords<HODs>().ToList();
            }

            dataGridView2.DataSource = rec; //display records in datagridview

           

        }
        //Create a file HODs.csv in current directory
        private void Btn_CreateFile_Click(object sender, System.EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/HODs.csv";
            if (!File.Exists(path))//check if file exists in given path
            {
                File.CreateText(path);//if file doesnt exist create
                MessageBox.Show("File Created");
            }
                

        }
        //Create a file HODs.csv in current directory and add statement - currently need to run file close and rerun I think this is to do with readonly!
        private void Btn_WriteFile_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/HODs.csv";
            if (!File.Exists(path))//check if file exists in given path
            {
                File.CreateText(path);//if file doesnt exist create
                MessageBox.Show("File Created");
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write("hello");
            }
        }

        //Delete file
        private void Btn_DeleteFile_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/HODs.csv";
            if (File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show("File Deleted");
            }

        }

        //export data in gridview2 to Excel
        private void Btn_ExportExcel_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent(); //Copy data in gridview2 box as variable copydata
            if (copydata != null) Clipboard.SetDataObject(copydata);  //only executes if there is data in datgridview2 otherwise called copydata pathway
            //next step need to add excel as a reference by right clicking Dependencies -> add project reference -> COM -> microsoft Excel 15.0 Object Library
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application(); // I think this is creating the interoperability between datagridview and Excel. xlapp is just a variable name and can be changed
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlworkbook; //name for xcel workbook
            Microsoft.Office.Interop.Excel.Worksheet xlworksheet; //name for xcel worksheet
            object MissingData = System.Reflection.Missing.Value; //Allows for missing data?
            xlworkbook = xlapp.Workbooks.Add(MissingData);//Not sure what this is for????
            xlworksheet = (Microsoft.Office.Interop.Excel.Worksheet)xlworkbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlworksheet.Cells[1, 1];//inputting info into cells vairanble name = xlr [row,column]?
            xlr.Select();
            xlworksheet.PasteSpecial(xlr, true);

        }

        private void Btn_SaveExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"Y:\Liverpool projects\Windows form app\Test";
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Workbooks|*.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                //storing header in excel
                for(int i =1; i < dataGridView1.Columns.Count +1; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;

                }
                // storing each row and column value
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                    }
                    

                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString()); //save to filename being what is specified (line 104 shows this is empty so user specified in popup box)
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"Y:\Liverpool projects\Windows form app\Test";
            saveFileDialog1.Title = "Save Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "csv|*.csv";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                TextWriter writer = new StreamWriter(saveFileDialog1.FileName.ToString());

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)//rows
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)//columns
                    {
                        writer.Write("\t" + dataGridView2.Rows[i].Cells[j].Value.ToString());
                    }
                    writer.Write("");
                }
                writer.Close();
                MessageBox.Show("data saved as table.txt in folder Y:\\Liverpool projects\\Windows form app\\Test");
            }

        }

     
    }
}
