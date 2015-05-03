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
        bool closeFlag;             //true代表是用户点击了窗体的x键关闭的，否则是点击其他按键之后自动关闭的

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
            closeFlag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print();
            closeFlag = false;
            Close();
        }

        private void OpenNewApplication(Word.Document OldDocument)
        {
            object oMissing = System.Reflection.Missing.Value;
            WordApp.Documents.Open(ref FileName,
               ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
               ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
               ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);  //新的程序打开原文档
            OldDocument.Close();  
        }

        private void Print()
        {
            myThisAddIn.FreePrintFlag = 0;
            WordApp.ActiveDocument.PrintOut();                                             //打印
            myThisAddIn.FreePrintFlag = 1;
            Thread.Sleep(1000);                                                 //给一些打印时间
            OpenNewApplication(WordApp.ActiveDocument);                                              //旧文档关闭
        }

        private void button2_Click(object sender, EventArgs e)
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
            closeFlag = false;
            Close();
        }

        private void ConfirmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if(closeFlag == true)
                {
                    myThisAddIn.FreePrintFlag = 1;
                    WordApp.ActiveDocument.Save();
                    OpenNewApplication(WordApp.ActiveDocument);                       //旧文档关闭
                }
                if(File.Exists(myThisAddIn.TempFilePath))             //删除临时文件
                {
                    File.Delete(myThisAddIn.TempFilePath);
                }
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Print();
            closeFlag = false;
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
            closeFlag = false;
            Close();
        }
    }
}
