using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
/////Add the references (new)
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
namespace StudentManagement.BS_Layer
{
    class ResultExport
    {
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }
        //string pathImage = null;
        //object filename, object savaAs, object image,string studentid,string fullname, string nees,string oop,string dbms,string caal,string nmlt,string score,string result,string rating
        public void CreateWordDocument(object filename, object savaAs, string studentid, string fullname, string nees, string oop, string dbms, string caal, string nmlt, string score, string result, string rating)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            //string tempPath = null;

            Word.Application wordApp = new Word.Application();

            Word.Document aDoc = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false; //default
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);

                aDoc.Activate();

                //Find and replace:
                this.FindAndReplace(wordApp, "<studentid>", studentid);
                this.FindAndReplace(wordApp, "<fullname>", fullname);
                this.FindAndReplace(wordApp, "<nees>", nees);
                this.FindAndReplace(wordApp, "<oop>", oop);
                this.FindAndReplace(wordApp, "<dbms>", dbms);
                this.FindAndReplace(wordApp, "<caal>", caal);
                this.FindAndReplace(wordApp, "<nmlt>", nmlt);
                this.FindAndReplace(wordApp, "<score>", score);
                this.FindAndReplace(wordApp, "<result>", result);
                this.FindAndReplace(wordApp, "<rating>", rating);

                //insert the picture:
                //Image img = resizeImage(pathImage, new Size(200, 90));
                //tempPath = System.Windows.Forms.Application.StartupPath + "\\Images\\~Temp\\temp.jpg";
                //img.Save(tempPath);

                Object oMissed = aDoc.Paragraphs[1].Range; //the position you want to insert
                Object oLinkToFile = false;  //default
                Object oSaveWithDocument = true;//default
                //aDoc.InlineShapes.AddPicture(tempPath, ref oLinkToFile, ref oSaveWithDocument, ref oMissed);

                #region Print Document :
                /*object copies = "1";
                object pages = "1";
                object range = Word.WdPrintOutRange.wdPrintCurrentPage;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;

                Word.Document document = aDoc;
                object nullobj = Missing.Value;
                int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref nullobj);
                wordApp.Visible = false;
                if (dialogResult == 1)
                {
                    document.PrintOut(
                    ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                    ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                    ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
                }
                */
                #endregion

            }
            else
            {
                MessageBox.Show("Template path is corrupted!", "Export Student Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Save as: filename
            aDoc.SaveAs2(ref savaAs, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            //Close Document:
            //aDoc.Close(ref missing, ref missing, ref missing);
            //File.Delete(tempPath);
            MessageBox.Show("File created successfully!", "Export Student Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);
        }
        
        

        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }


        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }
    }
}
