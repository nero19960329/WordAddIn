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
        Word.Document OldDocument;
        object FileName;
        bool isCancelFlag;              //判断用户在退出该窗体时是否是通过点击“否”而退出的
        Thread ClosePrintPreviewThread;

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
            OldDocument = WordApp.ActiveDocument;
            isCancelFlag = false;
            ClosePrintPreviewThread = new Thread(new ThreadStart(ClosePrintPreviewListener));
            ClosePrintPreviewThread.Start();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            CopiesForm myCopiesForm = new CopiesForm(myThisAddIn, WordApp, FileName);
            myCopiesForm.ShowDialog();
            Close();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            isCancelFlag = true;
            Close();
        }

        private void ConfirmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                ClosePrintPreviewThread.Abort();
                myThisAddIn.FreePrintFlag = 1;
                Tools.SetFileReadOnly(myThisAddIn.TempFilePath, false);
                OldDocument.Save();
                OldDocument.ClosePrintPreview();
                OldDocument.Close();
                Tools.OpenNewApplication(WordApp, FileName);

                if(isCancelFlag == true)
                {
                    myThisAddIn.FreePrintFlag = 0;
                    WordApp.ActiveDocument.PrintOut();
                    myThisAddIn.FreePrintFlag = 1;
                }

                if(File.Exists(myThisAddIn.TempFilePath))                              //删除临时文件
                {
                    File.Delete(myThisAddIn.TempFilePath);
                }
            }
        }

        public void ClosePrintPreviewListener()
        {
            while (true)
            {
                if (WordApp.PrintPreview == false)
                {
                    WordApp.PrintPreview = true;
                }
                Thread.Sleep(100);
            }
        }
    }
}
