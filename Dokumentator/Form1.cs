using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dokumentator
{
    public partial class Dokumentator : Form
    {
        public Dokumentator()
        {
            InitializeComponent();
        }

        private void btnZus_Click(object sender, EventArgs e)
        {
            if (fldName.Text != string.Empty && fldNip.Text != string.Empty)
            {
                try
                {
                    //Zabijamy worda, jeśli istnieje
                    killWord();
                    //Tworzymy temp kopie
                    System.IO.File.Copy(System.IO.Path.Combine(@"C:\\Dokument\", "pfbZus.doc"), System.IO.Path.Combine(@"C:\\Dokument\", fldName.Text + "_ZUS.doc"), true);
                    //Tworzymy worda i dokument
                    Word.Application wordApp = new Word.Application();
                    Word.Document wordDoc = null;

                    //Tworzymy nazwe obiektu
                    object filename = System.IO.Path.Combine(@"C:\\Dokument\", fldName.Text + "_ZUS.doc");
                    //I ruszamy z koksem - jesli plik jest
                    if (System.IO.File.Exists((string)filename))
                    {
                        //Ustalamy refy
                        object readOnly = false;
                        object isVisible = false;

                        //Robimy niewidzilny word
                        wordApp.Visible = false;

                        //Otwieramy temp
                        wordDoc = wordApp.Documents.Open(ref filename, Type.Missing, ref readOnly, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, ref isVisible, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        wordDoc.Activate();

                        //replacujemy rzeczy
                        FindAndReplace(wordApp, "<nip>", fldNip.Text);
                        FindAndReplace(wordApp, "<data>", fldDate.Value.Date);

                        //Zapisujemy dokument
                        wordDoc.Save();
                        wordDoc.Close(true, Type.Missing, Type.Missing);
                    }
                    else //A jeśli go nie ma?
                    {
                        Console.Out.Write("\n Brak pliku temp!");
                        killWord();
                    }
                }
                catch (Exception ex)
                {
                    Console.Out.Write("\n Blad w wykonaniu. Error: " + ex.Message + "\n");
                }
            }
        }

        private void btnKpir_Click(object sender, EventArgs e)
        {
            if (fldName.Text != string.Empty && fldNip.Text != string.Empty)
            {
                try
                {
                    //Zabijamy worda, jeśli istnieje
                    killWord();
                    //Tworzymy temp kopie
                    System.IO.File.Copy(System.IO.Path.Combine(@"C:\\Dokument\", "pfbKpir.doc"), System.IO.Path.Combine(@"C:\\Dokument\", fldName.Text + "_KPiR.doc"), true);
                    //Tworzymy worda i dokument
                    Word.Application wordApp = new Word.Application();
                    Word.Document wordDoc = null;

                    //Tworzymy nazwe obiektu
                    object filename = System.IO.Path.Combine(@"C:\\Dokument\", fldName.Text + "_KPiR.doc");
                    //I ruszamy z koksem - jesli plik jest
                    if (System.IO.File.Exists((string)filename))
                    {
                        //Ustalamy refy
                        object readOnly = false;
                        object isVisible = false;

                        //Robimy niewidzilny word
                        wordApp.Visible = false;

                        //Otwieramy temp
                        wordDoc = wordApp.Documents.Open(ref filename, Type.Missing, ref readOnly, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, ref isVisible, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        wordDoc.Activate();

                        //replacujemy rzeczy
                        FindAndReplace(wordApp, "<nip>", fldNip.Text);
                        FindAndReplace(wordApp, "<data>", fldDate.Value.Date);

                        //Zapisujemy dokument
                        wordDoc.Save();
                        wordDoc.Close(true, Type.Missing, Type.Missing);
                    }
                    else //A jeśli go nie ma?
                    {
                        Console.Out.Write("\n Brak pliku temp!");
                        killWord();
                    }
                }
                catch (Exception ex)
                {
                    Console.Out.Write("\n Blad w wykonaniu. Error: " + ex.Message + "\n");
                }
            }
        }

        private void btnUpl_Click(object sender, EventArgs e)
        {

        }

        private void btnVatr_Click(object sender, EventArgs e)
        {
            try
            {
                //Zabijamy excela, jeśli istnieje
                killExcel();
                //Tworzymy temp kopie
                System.IO.File.Copy(System.IO.Path.Combine(@"C:\\Dokument\", "pfbVatr.xlsm"), System.IO.Path.Combine(@"C:\\Dokument\", @"C:\\Dokument\", fldName.Text + "_VATR.xlsm"), true);
                //Tworzymy worda i dokument
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelDoc = null;

                //Tworzymy nazwe obiektu
                object filename = System.IO.Path.Combine(@"C:\\Dokument\", @"C:\\Dokument\", fldName.Text + "_VATR.xlsm");
                //I ruszamy z koksem - jesli plik jest
                if (System.IO.File.Exists((string)filename))
                {
                    //Ustalamy refy
                    object readOnly = false;

                    //Robimy niewidzilny excel
                    excelApp.Visible = false;

                    //Otwieramy temp
                    excelDoc = excelApp.Workbooks.Open((string)filename, Type.Missing, (bool)readOnly, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    excelDoc.Activate();

                    //replacujemy rzeczy
                    ReplaceNip(excelApp, "<nip>", fldNip.Text, excelDoc);
                    FindAndReplace(excelApp, "<name>", fldName.Text, excelDoc);
                    FindAndReplace(excelApp, "<pesel>", fldPesel.Text, excelDoc);                    
                    FindAndReplace(excelApp, "<country>", fldCountry.Text, excelDoc);
                    FindAndReplace(excelApp, "<gmina>", fldGmina.Text,excelDoc);
                    FindAndReplace(excelApp, "<street>", fldStreet.Text,excelDoc);
                    FindAndReplace(excelApp, "<city>", fldCity.Text, excelDoc);
                    FindAndReplace(excelApp, "<postal>", fldPostal.Text, excelDoc);
                    FindAndReplace(excelApp, "<powiat>", fldPowiat.Text, excelDoc);
                    FindAndReplace(excelApp, "<poczta>", fldPoczta.Text, excelDoc);
                    FindAndReplace(excelApp, "<nrdom>", fldNrdom.Text, excelDoc);
                    FindAndReplace(excelApp, "<nrmiesz>", fldNrmiesz.Text, excelDoc);
                    InsertBirth(excelApp, "<birth>", excelDoc);
                    SplitName(excelApp, excelDoc);


                    //Zapisujemy dokument
                    excelDoc.Save();
                }
                else //A jeśli go nie ma?
                {
                    Console.Out.Write("\n Brak pliku temp!");
                    killExcel();
                }
            }
            catch (Exception ex)
            {
                Console.Out.Write("\n Blad w wykonaniu. Error: " + ex.Message + "\n");
            }
            finally
            {
         //       killExcel();
            }
        }

        private void btnKwe_Click(object sender, EventArgs e)
        {

        }

        private void chkMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemale.Checked && chkMale.Checked)
                chkFemale.Checked = false;
        }

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMale.Checked && chkFemale.Checked)
                chkMale.Checked = false;
        }

        static private void FindAndReplace(object app, object findText, object replaceText, Excel.Workbook exBook = null)
        {
            if (app is Word.Application)
            {
                object matchCase = true;
                object matchWholeWord = true;
                object matchWildCards = false;
                object matchSoundsLike = false;
                object matchAllWordForms = false;
                object forward = true;
                object format = false;
                object matchKashida = false;
                object matchDiacritics = false;
                object matchAlefhamza = false;
                object matchControl = false;
                object read_only = false;
                object visible = true;
                object replace = 2;
                object wrap = 1;

                Word.Application wordApp = (Word.Application)app;
                wordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord, ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceText, ref replace, ref matchKashida, ref matchDiacritics, ref matchAlefhamza, ref matchControl);
            }
            else if (app is Excel.Application)
            {
                foreach (Excel.Worksheet ws in exBook.Worksheets)
                { 
                    Excel.Range r = ws.UsedRange;

                    bool success = r.Replace((string)findText, (string)replaceText, Excel.XlLookAt.xlWhole, Excel.XlSearchOrder.xlByRows, true, Type.Missing, Type.Missing, Type.Missing);

                    if (success)
                    {
                        exBook.Save();
                        break;
                    }
                }
            }
        }

        static private void ReplaceNip(object app, object findText, object replaceText, Excel.Workbook exBook = null)
        {
            string s = (string)replaceText;
            char[] nipArray = s.ToCharArray();

            string fin = string.Empty;
            for (int i = 0; i < nipArray.Length; i++)
                fin += (nipArray[i] + " ");

            if (app is Excel.Application)
            {
                foreach (Excel.Worksheet ws in exBook.Worksheets)
                {
                    Excel.Range r = ws.UsedRange;

                    bool success = r.Replace((string)findText, (string)replaceText, Excel.XlLookAt.xlWhole, Excel.XlSearchOrder.xlByRows, true, Type.Missing, Type.Missing, Type.Missing);

                    if (success)
                    {
                        exBook.Save();
                        break;
                    }
                }
            }
        }

        private void InsertBirth(object app, object findText, Excel.Workbook exBook = null)
        {
            string day, month, year;

            char[] peselArray = fldPesel.Text.ToArray();

            day = peselArray[4].ToString() + peselArray[5];
            month = peselArray[2].ToString() + peselArray[3];

            int m;
            int.TryParse(month, out m);

            if (m > 12)
                year = "20" + peselArray[0].ToString() + peselArray[1];
            else
                year = "19" + peselArray[0].ToString() + peselArray[1];

            string cmb = day + " " +  month + " " + year;
            char[] arr = cmb.ToArray();

            string fin = string.Empty;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != ' ')
                    fin += (arr[i] + " ");
                else
                    fin += (arr[i]);

            if (app is Word.Application)
            {
                object matchCase = true;
                object matchWholeWord = true;
                object matchWildCards = false;
                object matchSoundsLike = false;
                object matchAllWordForms = false;
                object forward = true;
                object format = false;
                object matchKashida = false;
                object matchDiacritics = false;
                object matchAlefhamza = false;
                object matchControl = false;
                object read_only = false;
                object visible = true;
                object replace = 2;
                object wrap = 1;

                Word.Application wordApp = (Word.Application)app;
                wordApp.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord, ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, fin, ref replace, ref matchKashida, ref matchDiacritics, ref matchAlefhamza, ref matchControl);
            }
            if (app is Excel.Application)
            {
                foreach (Excel.Worksheet ws in exBook.Worksheets)
                {
                    Excel.Range r = ws.UsedRange;

                    bool success = r.Replace((string)findText, fin, Excel.XlLookAt.xlWhole, Excel.XlSearchOrder.xlByRows, true, Type.Missing, Type.Missing, Type.Missing);

                    if (success)
                    {
                        exBook.Save();
                        break;
                    }
                }
            }

        }

        private void SplitName(object app, Excel.Workbook exBook = null)
        {
            string fn = string.Empty;
            string ln = string.Empty;
            int n = 0;

            char[] arr = fldName.Text.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != ' ')
                    fn += arr[i];
                else
                {
                    n = i;
                    break;
                }

            for (int i = n + 1; i < arr.Length; i++)
                ln += arr[i];

            FindAndReplace((Excel.Application)app, "<imie>", fn, exBook);
            FindAndReplace((Excel.Application)app, "<nazwisko>", ln, exBook);
        }

        static private void killWord()
        {
            foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcesses())
            {
                //   Console.Out.WriteLine("Znaleziono proces : " + proc.ProcessName);
                if (proc.ProcessName == "WINWORD")
                {
                    Console.Out.WriteLine("! Word");
                    proc.Kill();
                }
            }
        }

        static private void killExcel()
        {
            foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcesses())
            {
                //   Console.Out.WriteLine("Znaleziono proces : " + proc.ProcessName);
                if (proc.ProcessName == "excel")
                {
                    proc.Kill();
                }
            }
        }
    }
}

