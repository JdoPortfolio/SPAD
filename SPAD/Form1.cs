using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPAD
{
    public partial class SPADProject : Form
    {
        public SPADProject()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";
                if (dialog.FileName != "")
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable dtNew = new DataTable();
                        dtNew = GetDataTabletFromCSVFile(dialog.FileName);
                        if (Convert.ToString(dtNew.Columns[0]).ToLower() != "stationcode")
                        {
                            MessageBox.Show("Invalid Items File");
                            btnSave.Enabled = false;
                            return;
                        }
                        txtFile.Text = dialog.SafeFileName;
                        SourceURl = dialog.FileName;
                        if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)
                        {
                            dgItems.DataSource = dtNew;
                        }
                        foreach (DataGridViewRow row in dgItems.Rows)
                        {
                            //Me//
                            ImportedRecord += 1;
                            //Me//

                            /*if (Convert.ToString(row.Cells["LookupCode"].Value) == "" || row.Cells["LookupCode"].Value == null || Convert.ToString(row.Cells["ItemName"].Value) == "" || row.Cells["ItemName"].Value == null || Convert.ToString(row.Cells["DeptId"].Value) == "" || row.Cells["DeptId"].Value == null || Convert.ToString(row.Cells["Price"].Value) == "" || row.Cells["Price"].Value == null)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                inValidItem += 1;
                            }
                            else
                            {
                                ImportedRecord += 1;
                            }*/
                        }
                        if (dgItems.Rows.Count == 0)
                        {
                            btnSave.Enabled = false;
                            MessageBox.Show("There is no data in this file", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected File is Invalid, Please Select valid csv file.", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.SetDelimiters(new string[] {
                    ","
                });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column  
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exce " + ex);
            }
            return csvData;
    }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtItem = (DataTable)(dgItems.DataSource);
                /*string Lookup, description, dept, UnitPrice;*/
                string StationCode, isSWMP, DateTimeStamp, Historical, ProvisionalPlus, F_Record, Temp, F_Temp, SpCond, F_SpCond, Sal, F_Sal, DO_Pct, F_DO_Pct, DO_mgl, F_DO_mgl, Depth, F_Depth, cDepth, F_cDepth, Level, F_Level, cLevel, F_cLevel, pH, F_pH, Turb, F_Turb, ChlFluor, F_ChlFluor;
                string InsertItemQry = "";
                int count = 0;
                foreach (DataRow dr in dtItem.Rows)
                {
                    StationCode =Convert.ToString(dr["StationCode"]);
                    isSWMP = Convert.ToString(dr["isSWMP"]);
                    DateTimeStamp = Convert.ToString(dr["DateTimeStamp"]);
                    Historical = Convert.ToString(dr["Historical"]);
                    ProvisionalPlus = Convert.ToString(dr["ProvisionalPlus"]);
                    F_Record = Convert.ToString(dr["F_Record"]);
                    Temp = Convert.ToString(dr["Temp"]);
                    F_Temp = Convert.ToString(dr["F_Temp"]);
                    SpCond = Convert.ToString(dr["SpCond"]);
                    F_SpCond = Convert.ToString(dr["F_SpCond"]);
                    Sal = Convert.ToString(dr["Sal"]);
                    F_Sal = Convert.ToString(dr["F_Sal"]);
                    DO_Pct = Convert.ToString(dr["DO_Pct"]);
                    F_DO_Pct = Convert.ToString(dr["F_DO_Pct"]);
                    DO_mgl = Convert.ToString(dr["DO_mgl"]);
                    F_DO_mgl = Convert.ToString(dr["F_DO_mgl"]);
                    Depth = Convert.ToString(dr["Depth"]);
                    F_Depth = Convert.ToString(dr["F_Depth"]);
                    cDepth = Convert.ToString(dr["cDepth"]);
                    F_cDepth = Convert.ToString(dr["F_cDepth"]);
                    Level =Convert.ToString(dr["Level"]);
                    F_Level = Convert.ToString(dr["F_Level"]);
                    cLevel =Convert.ToString(dr["cLevel"]);
                    F_cLevel =Convert.ToString(dr["F_cLevel"]);
                    pH = Convert.ToString(dr["pH"]);
                    F_pH = Convert.ToString(dr["F_pH"]);
                    Turb = Convert.ToString(dr["Turb"]);
                    F_Turb = Convert.ToString(dr["F_Turb"]);
                    ChlFluor = Convert.ToString(dr["ChlFluor"]);
                    F_ChlFluor = Convert.ToString(dr["F_ChlFluor"]);


                    //Me//
                    InsertItemQry += "Insert into Table_1(StationCode, isSWMP, DateTimeStamp, Historical, Provisional Plus, F_Record, Temp, F_Temp, SpCond, F_SpCond, Sal, F_Sal, DO_Pct, F_DO_Pct, DO_mgl, F_DO_mgl, Depth, F_Depth, cDepth, F_cDepth, Level, F_Level, cLevel, F_cLevel, pH, F_pH, Turb, F_Turb, ChlFluor, F_ChlFluor)Values('" + StationCode + "','" + isSWMP + "','" + DateTimeStamp+ "','" + Historical + "','" + ProvisionalPlus + "','" + F_Record + "','" +Temp+ "','" + F_Temp+ "','" + SpCond + "','" + F_SpCond + "','" + Sal + "','" + F_Sal + "','" + DO_Pct + "','" + F_DO_Pct+ "','" + DO_mgl + "','" + F_DO_mgl+ "','" + Depth + "','" + F_Depth + "','" + cDepth + "','" + F_cDepth + "','" + Level+ "','" + F_Level + "','" + cLevel + "','" + F_cLevel + "','" + pH+ "','" + F_pH + "','" + Turb + "','" + F_Turb + "','" + ChlFluor+ "','" + F_ChlFluor + "');'";
                    count++;
                    //Me//
                    /*Lookup = Convert.ToString(dr["LookupCode"]);
                    description = Convert.ToString(dr["ItemName"]);
                    dept = Convert.ToString(dr["DeptId"]);
                    UnitPrice = Convert.ToString(dr["Price"]);
                    if (Lookup != "" && description != "" && dept != "" && UnitPrice != "")
                    {
                        InsertItemQry += "Insert into tbItem(LookupCode,ItemName,DeptId,CateId,Cost,Price, Quantity, UOM, Weight, TaxID, IsDiscountItem,EntryDate)Values('" + Lookup + "','" + description + "','" + dept + "','" + dr["CateId"] + "','" + dr["Cost"] + "','" + UnitPrice + "'," + dr["Quantity"] + ",'" + dr["UOM"] + "','" + dr["Weight"] + "','" + dr["TaxID"] + "','" + dr["IsDiscountItem"] + "',GETDATE()); ";
                        count++;
                    }*/
                }
                if (InsertItemQry.Length > 0)
                {
                    bool isSuccess = DBAccess.ExecuteQuery(InsertItemQry);
                    if (isSuccess)
                    {
                        MessageBox.Show("Item Imported Successfully, Total Imported Records : " + count + "", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgItems.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
        class DBAccess
        {
            private static SqlConnection objConnection;
            private static SqlDataAdapter objDataAdapter;
            public static string ConnectionString = "Data Source=LAPTOP-3VT892R6\\SQLEXPRESS; Initial Catalog=GautamPOS; User Id=sa; Password=12345678;";
            private static void OpenConnection()
            {
                try
                {
                    if (objConnection == null)
                    {
                        objConnection = new SqlConnection(ConnectionString);
                        objConnection.Open();
                    }
                    else
                    {
                        if (objConnection.State != ConnectionState.Open)
                        {
                            objConnection = new SqlConnection(ConnectionString);
                            objConnection.Open();
                        }
                    }
                }
                catch (Exception ex) { }
            }
            private static void CloseConnection()
            {
                try
                {
                    if (!(objConnection == null))
                    {
                        if (objConnection.State == System.Data.ConnectionState.Open)
                        {
                            objConnection.Close();
                            objConnection.Dispose();
                        }
                    }
                }
                catch { }
            }
            public static bool ExecuteQuery(string query)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
