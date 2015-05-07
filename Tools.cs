using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace WordAddIn
{
    public static class Tools
    {
        public static object oMissing = System.Reflection.Missing.Value;
        public static void OpenNewApplication(Word.Application WordApp, object FileName)
        {
            WordApp.Documents.Open(ref FileName,
               ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
               ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
               ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);  //新的程序打开原文档
        }

        public static void SetFileReadOnly(string FileName, bool SetReadOnly)
        {
            FileInfo fileInfo = new FileInfo(FileName);
            fileInfo.IsReadOnly = SetReadOnly;
        }
    }
}
