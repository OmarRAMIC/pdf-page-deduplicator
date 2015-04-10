using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Security.Cryptography;

namespace DeduplicatePDF
{
    public partial class Form1 : Form
    {
        private string src, dst;
        private List<string> Files;
        private int e, s;
        public Form1()
        {
            InitializeComponent();
        }


        private void DeDuplicate()
        {
            e = s = 0;

            pgbFiles.Value = 0;
            pgbFiles.Maximum = Files.Count;
            foreach (string File in Files)
            {
                try
                {
                    PdfReader pdfreader = new PdfReader(File);
                    Dictionary<string, PdfImportedPage> pages = new Dictionary<string, PdfImportedPage>();
                    Document document;
                    MemoryStream stream = new MemoryStream();
                    document = new Document(pdfreader.GetPageSizeWithRotation(1));
                    PdfCopy pdfcopy = new PdfCopy(document, stream);
                    document.Open();
                    for (int i = 1; i <= pdfreader.NumberOfPages; i++)
                    {

                        string md5 = f_MD5(pdfreader.GetPageContent(i));
                        if (!pages.ContainsKey(md5))
                        {

                            PdfImportedPage page;
                            page = pdfcopy.GetImportedPage(pdfreader, i);
                            pages.Add(md5, page);
                            pdfcopy.AddPage(page);
                        }

                    }
                    document.Close();

                    string filename = newpath(File);
                    FileStream fstream = new FileStream(filename, FileMode.Create);
                    fstream.Write(stream.ToArray(), 0, stream.ToArray().Length);
                    fstream.Close();
                    s++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message+ " in File " + File);
                    e++;
                }
                pgbFiles.Value++;
            }
            if (e > 0)
            {
                MessageBox.Show("DeDuplicate done with erros");
                
            }
            else
            {
                MessageBox.Show("DeDuplicate Done");
            }
            pgbFiles.Value = 0;
        }

        private string newpath(string s)
        {
            string filesrc = s.Replace(txtSrc.Text,"");
            filesrc = txtDst.Text + filesrc;
            string path = filesrc.Substring(0,filesrc.LastIndexOf('\\'));
            //verify if path exists
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return filesrc;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            src = txtSrc.Text.Trim();
            dst = txtDst.Text.Trim();

            if (src == "" || dst == "")
            {
                MessageBox.Show("Please, select a source and destination directory");
            }
            else
            {
                //find files
                Files = new List<string>();
                foreach (string file in Directory.EnumerateFiles(src, "*.pdf", SearchOption.AllDirectories))
                {
                    Files.Add(file);
                }
                if(Files.Count>0){
                    if (MessageBox.Show(Files.Count + " Files found, deduplicate?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DeDuplicate();
                    }
                }else{
                    MessageBox.Show("Files not found");
                }
            }
        }


        private string f_MD5(byte[] bytes)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void btnSrc_Click(object sender, EventArgs e)
        {
            
            if (DlgFolder.ShowDialog() == DialogResult.OK)
            {
                txtSrc.Text = DlgFolder.SelectedPath;
            }
        }

        private void btnDst_Click(object sender, EventArgs e)
        {
            if (DlgFolder.ShowDialog() == DialogResult.OK)
            {
                txtDst.Text = DlgFolder.SelectedPath;
            }
        }
    }
}
