using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Save
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                // Load DOC document from file.
                this.docDocumentViewer1.LoadFromFile(@"..\..\..\..\..\..\Data\fax.doc");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bntOpen_Click(object sender, EventArgs e)
        {
            //Open a doc document          
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Word97-2003 files(*.doc)|*.doc|Word2007-2010 files (*.docx)|*.docx|All files (*.*)|*.*";
            dialog.Title = "Select a DOC file";
            dialog.Multiselect = false;
            dialog.InitialDirectory = System.IO.Path.GetFullPath(@"..\..\..\..\..\..\Data");

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    this.docDocumentViewer1.LoadFromFile(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.docDocumentViewer1.CloseDocument();
        }

        private void btnSaveToPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Pdf Document(*.pdf)|*.pdf";
            savefile.Title = "Save";

            DialogResult result = savefile.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    //Save PDF documetns
                    this.docDocumentViewer1.SaveAs(savefile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveasToDoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Word97-2003 Document(*.doc)|*.doc";
            savefile.Title = "Save to Word97-2003";

            DialogResult result = savefile.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    //Save as Word97-2003 documetns
                    this.docDocumentViewer1.SaveAs(savefile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveasToDocx_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Word2007-2010 Document(*.docx)|*.docx";
            savefile.Title = "Save to Word2007-2010";

            DialogResult result = savefile.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    //Save as Word2007-2010 documetns
                    this.docDocumentViewer1.SaveAs(savefile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
