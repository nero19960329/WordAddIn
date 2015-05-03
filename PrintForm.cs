using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using CCWin;


namespace WordAddIn
{
    public partial class PrintForm : CCSkinMain
    {
        public ThisAddIn myThisAddIn;
        public bool Done;

        public PrintForm()
        {
            InitializeComponent();
            Done = false;
        }

        public PrintForm(ThisAddIn thisAddIn)
        {
            InitializeComponent();
            //SetShadow();
            myThisAddIn = thisAddIn;
            Done = false;
        }

        public void SetPageHeaderAndFooter(string pPageHeader, string pPageFooter)
        {
            Object oMissing = System.Reflection.Missing.Value;
            foreach (Word.Section wordSection in myThisAddIn.Application.ActiveDocument.Sections)
            {
                Word.Application WordApp = myThisAddIn.Application;

                WordApp.ActiveWindow.View.Type = Word.WdViewType.wdOutlineView;
                WordApp.ActiveWindow.View.SeekView = Word.WdSeekView.wdSeekPrimaryHeader;           //光标移动至页眉处
                WordApp.Selection.WholeStory();
                WordApp.Selection.Delete();
                WordApp.ActiveWindow.ActivePane.Selection.InlineShapes.AddPicture(pPageHeader);

                WordApp.ActiveWindow.View.SeekView = Word.WdSeekView.wdSeekPrimaryFooter;           //光标移动至页脚处
                WordApp.Selection.WholeStory();
                WordApp.Selection.Delete();
                WordApp.ActiveWindow.ActivePane.Selection.InlineShapes.AddPicture(pPageFooter);
                WordApp.ActiveWindow.View.SeekView = Word.WdSeekView.wdSeekMainDocument;            //跳出页眉页脚设置
            }
        }

        private void Logic()
        {
            Object oMissing = System.Reflection.Missing.Value;
            Word.Application WordApp = myThisAddIn.Application;

            Word.Document OldDocument = WordApp.ActiveDocument;
            object FileName = OldDocument.Path + "\\" + OldDocument.Name;
            myThisAddIn.TempFilePath = OldDocument.Path + "\\" + "temp";

            Random random = new Random();
            int maxBit = 10;
            int[] randomNumberArray = new int[maxBit];
            for (int i = 0; i < maxBit; ++i)
            {
                randomNumberArray[i] = random.Next(10);
                myThisAddIn.TempFilePath += randomNumberArray[i];
            }
            myThisAddIn.TempFilePath += ".docx";

            OldDocument.Save();                                                             //旧文档存储
            OldDocument.SaveAs(myThisAddIn.TempFilePath);                                   //另存为一个临时文件

            WordApp.Visible = false;
            WaitForm myWaitForm = new WaitForm();
            myWaitForm.Show();
            SetPageHeaderAndFooter("F:\\pics\\a1.jpg", "F:\\pics\\b1.jpg");                 //加入页眉页脚
            Thread.Sleep(1000);
            myWaitForm.Close();
            WordApp.Visible = true;

            myThisAddIn.FreePrintFlag = -1;
            ConfirmForm myConfirmForm = new ConfirmForm(myThisAddIn, WordApp, FileName);
            myConfirmForm.ShowDialog();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x00020000;
                return cp;
            }
        }

        private void PrintForm_Paint(object sender, PaintEventArgs e)
        {
            FormHelper.SetWindowRegion(this);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Close();
            Logic();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            myThisAddIn.FreePrintFlag = 0;
            myThisAddIn.Application.ActiveDocument.PrintOut();
            myThisAddIn.FreePrintFlag = 1;
            Close();
        }

    }
}
