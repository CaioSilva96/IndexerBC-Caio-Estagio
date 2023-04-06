using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitMiracle.LibTiff.Classic;



namespace BCindexer_Caio_v01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<string> GetTifFiles(string path)
        {
            // pega os arquivos .tif dentro das pastas e sub
            List<string> tifFiles = new List<string>();
            foreach (string file in Directory.GetFiles(path, "*.tif", SearchOption.AllDirectories))
            {
                tifFiles.Add(file);
            }
            return tifFiles;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // janela para selecionar uma pasta
            using (var dialog = new FolderBrowserDialog())
            {

                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    // quando seleciona a pasta armazena o caminho dela na variável "pathFile"
                    string pathFile = dialog.SelectedPath;

                    // pega os arquivos .tif dentro da pasta e suas subpastas
                    List<string> tifFiles = GetTifFiles(pathFile);

                    // usa StringBuilder para armazenar os dados do arquivo .csv
                    StringBuilder sb = new StringBuilder();

                    // Adiciona os nomes das colunas do arquivo .csv
                    sb.AppendLine("File Name,Date Time,Width,Height");

                    // Percorre todos os arquivos .tif e extrai os metadados de cada um
                    foreach (string file in tifFiles)
                    {
                        // Extrai os metadados do arquivo .tif
                        //var metadata = GetMetadata(file);

                        // Adiciona os metadados ao StringBuilder
                    //    sb.AppendFormat("{0},{1},{2},{3}", metadata.FileName, metadata.DateTime, metadata.Width, metadata.Height);
                        sb.AppendLine();
                    }

                    // Cria o arquivo .csv com os metadados
                    //string csvPath = Path.Combine(path, "metadata.csv");
                    //File.WriteAllText(csvPath, sb.ToString());
                }
            }
        }
    }
}
