using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;

namespace WordAddIn
{
    public partial class ThisAddIn
    {
        private PrintForm myPrintForm;
        public int FreePrintFlag;     //1代表会弹出对话框,0则不会弹出但会打印原版文档,-1代表不会弹对话框也不会打印任何东西
        public string TempFilePath;
        public int pages;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            FreePrintFlag = 1;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        private void Application_DocumentBeforePrint(Word.Document Doc, ref bool Cancel)
        {
            if(pages >= 15 && FreePrintFlag != -1)                              //大于等于15页就不显示提示框
            {
                FreePrintFlag = 0;
            }
            if(Application.ActiveDocument.ProtectionType == Word.WdProtectionType.wdNoProtection)
            {
                Application.ActiveDocument.Save();     //存档
            }
            if (FreePrintFlag == 1)
            {
                Cancel = true;
                FreePrintFlag = -1;
                myPrintForm = new PrintForm(this);
                myPrintForm.Show();
                FreePrintFlag = 1;
            }
            else if(FreePrintFlag == -1)
            {
                Cancel = true;
            }
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
            this.Application.DocumentBeforePrint += new Word.ApplicationEvents4_DocumentBeforePrintEventHandler(Application_DocumentBeforePrint);
        }
        
        #endregion
    }
}
