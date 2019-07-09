using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Excelhelper
    {
        private static byte[] GenerateImportTemplate(List<DataTable> tableList)
        {
            try
            {
                var book = new HSSFWorkbook();
                var styleForCell = book.CreateCellStyle();
                //styleForCell.DataFormat = HSSFDataFormat.GetBuiltinFormat("G/通用格式");
                //styleForCell.DataFormat = HSSFDataFormat.GetBuiltinFormat("@");
                int count = 0;
                foreach (var table in tableList)
                {
                    var sheet = book.CreateSheet(table.TableName ?? "系统生成");
                    var titleRow = sheet.CreateRow(0);
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        string titleText = table.Columns[i].ColumnName;
                        var cell = titleRow.CreateCell(i);
                        cell.SetCellValue(titleText);
                        sheet.SetDefaultColumnStyle(i, styleForCell);
                        sheet.SetColumnWidth(i, 100 * 50);
                    }
                    int dataRowStartIndex = 1;
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        var dataRow = sheet.CreateRow(dataRowStartIndex);
                        dataRowStartIndex++;
                        for (int j = 0; j < table.Columns.Count; j++)
                        {
                            dataRow.CreateCell(j).SetCellValue(table.Rows[i][j].ToString());
                        }
                    }
                    count++;
                }

                using (var ms = new MemoryStream())
                {
                    book.Write(ms);
                    return ms.GetBuffer();
                }
            }
            catch (Exception ex)
            {
                //  LogManager.Debug("GenerateImportTemplate", ex);
                return new byte[] { };
            }
        }

        public static void savefile(List<DataTable> tableList, string filename)
        {

            filename = $"D:/{filename }.xls";
            var bytes = GenerateImportTemplate(tableList);
            var s = File.Create(filename);
            foreach (byte item in bytes)
            {
                s.WriteByte(item);
            }
            s.Close();

        }

        private static IWorkbook GetExcel(string path)
        {
            IWorkbook workbook = null;
            try
            {
                var fileExt = Path.GetExtension(path);
                // var byteData = File.ReadAllBytes(path);
                FileStream s = new FileStream(path, FileMode.OpenOrCreate);
                //  s.Close();

                // MemoryStream file = new MemoryStream(byteData);

                if (fileExt == ".xls")
                {
                    workbook = new HSSFWorkbook(s);
                }

                else if (fileExt == ".xlsx")
                {
                    workbook = new NPOI.XSSF.UserModel.XSSFWorkbook(s);
                }
                s.Dispose();
                return workbook;
            }
            catch (Exception e)
            {

                throw new Exception("解析excel文件失败！" + e.ToString());
            }
        }

        public static List<DataTable> GetDtList(string path)
        {
            var workbook = GetExcel(path);
            List<DataTable> list = new List<DataTable>();
            var count = workbook.NumberOfSheets;
            for (int i = 0; i < count; i++)
            {
                var sheet = workbook.GetSheetAt(i);
                var dt = ExcelToDataTable(sheet, true);
                if (!string.IsNullOrEmpty(dt?.TableName) )
                {
                    list.Add(dt);
                }
              
            }

            return list;
        }

        private static DataTable ExcelToDataTable(ISheet sheet, bool isFirstRowColumn)
        {
            var data = new DataTable();
            int startRow = 0;
            try
            {
                if (sheet != null)
                {
                    data.TableName = sheet.SheetName;
                    var firstRow = sheet.GetRow(0);
                    if (firstRow == null)
                        return data;
                    int cellCount = firstRow.LastCellNum; //一行最后一个cell的编号 即总的列数
                    startRow = isFirstRowColumn ? sheet.FirstRowNum + 1 : sheet.FirstRowNum;

                    for (int i = firstRow.FirstCellNum; i < cellCount; i++)
                    {
                        var column = new DataColumn(Convert.ToChar(((int)'A') + i).ToString());//如果没有列头
                        if (isFirstRowColumn)
                        {
                            var cell = firstRow.GetCell(i);
                            if (cell!=null)
                            {
                                var columnName = firstRow.GetCell(i).StringCellValue;
                                column = new DataColumn(columnName);
                            }
                          
                        }
                        data.Columns.Add(column);
                    }
                    //最后一列的标号
                    int rowCount = sheet.LastRowNum;
                    for (int i = startRow; i <= rowCount; ++i)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue; //没有数据的行默认是null　　　　　　　
                        DataRow dataRow = data.NewRow();


                        for (int j = row.FirstCellNum; j < cellCount; ++j)
                        {
                            if (row.GetCell(j) != null)
                            {//同理，没有数据的单元格都默认是nullr
                                var cell3 = row.GetCell(j, MissingCellPolicy.RETURN_NULL_AND_BLANK);
                                if (cell3.CellType == CellType.Numeric && DateUtil.IsCellDateFormatted(cell3))//判断是否是日期类型
                                {
                                    dataRow[j] = cell3.DateCellValue;
                                }
                                else
                                {
                                    dataRow[j] = row.GetCell(j, MissingCellPolicy.RETURN_NULL_AND_BLANK).ToString().Trim();
                                }

                            }
                        }
                        data.Rows.Add(dataRow);
                    }
                    // RemoveLastEmptyRow(data);
                }
                else
                    throw new Exception("指定Sheet页不存在");
                return data;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }
    }
}
