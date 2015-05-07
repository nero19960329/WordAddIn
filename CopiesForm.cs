using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CCWin;
using System.IO;
using System.Threading;
using Word = Microsoft.Office.Interop.Word;

namespace WordAddIn
{
    public partial class CopiesForm : CCSkinMain
    {
        ThisAddIn myThisAddIn;
        Word.Application WordApp;
        object FileName;
        int copies;

        public CopiesForm(ThisAddIn thisAddIn, Word.Application wordApp, object fileName)
        {
            InitializeComponent();
            myThisAddIn = thisAddIn;
            WordApp = wordApp;
            FileName = fileName;
            copies = 0;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            copies = (int)skinNumericUpDown1.Value;
            Print();
            Close();
        }

        private void Print()
        {
            object oMissing = System.Reflection.Missing.Value;
            myThisAddIn.FreePrintFlag = 0;
            WordApp.ActiveDocument.PrintOut(ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, copies, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing);                                                          //打印
            myThisAddIn.FreePrintFlag = 1;
        }
    }
}
