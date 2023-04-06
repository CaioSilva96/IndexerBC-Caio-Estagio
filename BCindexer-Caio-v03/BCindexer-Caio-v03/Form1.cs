using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BCindexer_Caio_v03
{
    public partial class MainFormIndexter : Form
    {
        //Lembra que hoje vc se sentiu todo perdido mas aos poucos foi se achando dnovo, amanhã acontecerá o mesmo, desiste não
        //06/04/2023 - Perdi muito tempo pesquisando, mas ja me sinto mais orientado.
        // to do 07/04/2023 - Cair de cara no metadataExtrator.

        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        string RootDir; string[] TifFiles;
        int NFiles;
        public MainFormIndexter()
        {
            InitializeComponent();
        }

        public void AbrirPasta()
        {
            try
            {
                //para evitar bugs no app caso o usuario clique em cancelar ou assim
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;

                RootDir = folderBrowserDialog.SelectedPath;
                lblPathDir.Text = RootDir;

                //Usa o SearchOption para percorrer a arvore de arquivos (Demorou mas achei haha) 
                TifFiles = System.IO.Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.tif", SearchOption.AllDirectories);

                //Verifica se há .tif's na arvore de arquivos
                if (TifFiles.Length != 0)
                {
                    //Ordena os arquivos .tif
                    Array.Sort<string>(TifFiles);
                    NFiles = TifFiles.Length;

                    NDir.Text = "Nº de ficheiros: " + NFiles;
                }
                else
                {
                    int num = (int)MessageBox.Show("Esta pasta não contem ficheiros TIF");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir BrowserFolder");
                return;
            }
            
        }

        public void EscolherPasta()
        {
            try
            {

                if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    RootDir = folderBrowserDialog.SelectedPath;
                    lblPathDir.Text = RootDir;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEscolherPasta_Click(object sender, EventArgs e)
        {
            AbrirPasta();
        }
    }
}
