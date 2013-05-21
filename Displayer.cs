using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools;

namespace Wexcel
{
    class Displayer
    {
        private static Displayer instance = null;

        private Displayer() 
        {
            workSheet = Globals.ThisAddIn.Application.Worksheets.Add();
            sheetName = workSheet.Name;
        }

        public static Displayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Displayer();
                }
                return instance;
            }
        }

        public Excel.Worksheet workSheet;
        public string sheetName;

        private void EnsureOneSheet()
        {
            if (String.IsNullOrEmpty(sheetName) || !hasSuch(sheetName))
            {
                workSheet = Globals.ThisAddIn.Application.Worksheets.Add();
                sheetName = workSheet.Name;
            }
        }

        private bool hasSuch(string name)
        { 
            foreach (Excel.Worksheet sht in Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets)
            {
                if (name == sht.Name)
                    return true;
            }

            return false;
        }

        public void Clear()
        {
            workSheet.Cells.ClearContents();
        }

        public void display(int row, int col, string message)
        {
            EnsureOneSheet();
            workSheet.Cells.set_Item(row, col, message);
        }
    }
}
