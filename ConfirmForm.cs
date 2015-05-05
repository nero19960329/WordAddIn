using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

using CCWin;

namespace WordAddIn
{
    public partial class ConfirmForm : CCSkinMain
    {
        ThisAddIn myThisAddIn;
        Word.Application WordApp;
        object FileName;

        public ConfirmForm()
        {
            InitializeComponent();
        }

        public ConfirmForm(ThisAddIn myThisAddIn, Word.Application WordApp, object FileName)
        {
            InitializeComponent();
            this.myThisAddIn = myThisAddIn;
            this.WordApp = WordApp;
            this.FileName = FileName;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            CopiesForm myCopiesForm = new CopiesForm(myThisAddIn, WordApp, FileName);
            myCopiesForm.ShowDialog();
            Close();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            myThisAddIn.FreePrintFlag = 0;
            object oMissing = System.Reflection.Missing.Value;
            Word.Document OldDocument = WordApp.ActiveDocument;
            WordApp.Documents.Open(ref FileName,
                 ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
             ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
             ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);  //新的程序打开原文档
            OldDocument.Save();
            OldDocument.Close();                                                //旧文档关闭
            WordApp.ActiveDocument.PrintOut();
            myThisAddIn.FreePrintFlag = 1;
            Close();
        }
    }
}
