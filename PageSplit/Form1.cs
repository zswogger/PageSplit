using Microsoft.Office.Interop.Word;
using System;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Threading;

namespace PageSplit
{
    public partial class form_home : Form
    {
        public form_home()
        {
            InitializeComponent();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            SplitAllPages();
        }

        void SplitAllPages()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Open file directory and sort by text files only
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Word Documents|*.docx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                // If an appropriate file is selected
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lbl_message.Text = "Working...";

                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    var appWord = new Microsoft.Office.Interop.Word.Application();
                    if (appWord.Documents != null) // Verify word documents exist
                    {
                        var wordDocument = appWord.Documents.Open(filePath); // Open specified word doc
                        var numberOfPages = wordDocument.ComputeStatistics(WdStatistic.wdStatisticPages, false); // Count number of pages
                        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // Get desktop path
                        string file = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".pdf"; // Get file name w/o extension
                        string path = Path.Combine(desktop, file); // Combine desktop and file path into one file path

                        DirectoryInfo dir = new DirectoryInfo(desktop + "\\Output"); // Create new folder on desktop named "Output"
                        dir.Create();

                        string savepath = Path.Combine(desktop + "\\Output", file); // Create save path

                        if (wordDocument != null) // If word doc is not empty, export as pdf to new output folder
                        {
                            wordDocument.ExportAsFixedFormat(savepath,
                        WdExportFormat.wdExportFormatPDF, false);
                            wordDocument.Close();
                        }

                        appWord.Quit(); // Close word doc

                        // Get a fresh copy of the sample PDF file
                        string filename = Path.GetFileNameWithoutExtension(openFileDialog.FileName) + ".pdf";
                        File.Copy(Path.Combine(desktop + "\\Output", file),
                        Path.Combine(Directory.GetCurrentDirectory(), filename), true);

                        // Open the file
                        PdfDocument inputDocument = PdfReader.Open(filename, PdfDocumentOpenMode.Import);

                        String name = "";
                        savepath = savepath.Replace(".pdf", ""); //Stops pdf from saving as fileName.pdf.pdf
                        for (int idx = 0; idx < inputDocument.PageCount; idx++)
                        {
                            // Create new document
                            PdfDocument outputDocument = new PdfDocument();
                            outputDocument.Version = inputDocument.Version;
                            outputDocument.Info.Creator = inputDocument.Info.Creator;


                            // Add the page and save it
                            outputDocument.AddPage(inputDocument.Pages[idx]);
                            outputDocument.Save(String.Format(savepath + "{0} - Page {1}.pdf", name, idx + 1));
                        }
                        lbl_message.Text = "Successfully created " + (inputDocument.PageCount + 1) + " new PDF documents!";
                    }
                }
            }
        }

        private void btn_Convert_MouseEnter(object sender, EventArgs e)
        {
            btn_Convert.ForeColor = System.Drawing.Color.White;
            btn_Convert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        }

        private void btn_Convert_MouseLeave(object sender, EventArgs e)
        {
            btn_Convert.ForeColor = System.Drawing.Color.Black;
        }
    }
}
