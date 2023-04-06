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

namespace BCindexer_Caio_v02
{
    public partial class Form1 : Form
    {
        private string GetMetadataName(int id)
        {
            // Obtém o nome da propriedade de acordo com o ID informado
            switch (id)
            {
                case 270:
                    return "ImageDescription";
                case 271:
                    return "EquipMake";
                case 272:
                    return "EquipModel";
                case 282:
                    return "XResolution";
                case 283:
                    return "YResolution";
                case 306:
                    return "DateTime";
                case 315:
                    return "Artist";
                case 36867:
                    return "DateTimeOriginal";
                case 37377:
                    return "ShutterSpeedValue";
                case 37378:
                    return "ApertureValue";
                case 37383:
                    return "MeteringMode";
                case 37384:
                    return "LightSource";
                case 37385:
                    return "Flash";
                case 37386:
                    return "FocalLength";
                case 37500:
                    return "MakerNote";
                default:
                    return "Unknown";
            }
        }
        private List<string> TraverseDirectory(string directory)
        {
            var fileList = new List<string>();
            try
            {
                foreach (string file in Directory.GetFiles(directory, "*.tif"))
                {
                    fileList.Add(file);
                }
                foreach (string subdirectory in Directory.GetDirectories(directory))
                {
                    fileList.AddRange(TraverseDirectory(subdirectory));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao percorrer diretório: " + ex.Message);
            }
            return fileList;
        }
        private Dictionary<string, string> GetImageMetadata(string imagePath)
        {
            var metadata = new Dictionary<string, string>();
            try
            {
                // Abre o arquivo de imagem especificado para leitura dos metadados
                using (var image = Image.FromFile(imagePath))
                {
                    // Obtém as propriedades do arquivo de imagem
                    var properties = image.PropertyItems;

                    // Adiciona cada propriedade à lista de metadados
                    foreach (var prop in properties)
                    {
                        var key = GetMetadataName(prop.Id);
                        var value = Encoding.UTF8.GetString(prop.Value).TrimEnd('\0');
                        metadata.Add(key, value);
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra algum problema ao extrair os metadados
                MessageBox.Show("Erro ao extrair metadados da imagem: " + ex.Message);
            }
            return metadata;
        }
        private void WriteMetadataToCsv(string outputPath, List<Dictionary<string, string>> metadataList)
        {
            try
            {
                using (var writer = new StreamWriter(outputPath))
                {
                    var headers = metadataList.SelectMany(d => d.Keys).Distinct();
                    writer.WriteLine(string.Join(",", headers));
                    foreach (var metadata in metadataList)
                    {
                        var values = headers.Select(h => metadata.ContainsKey(h) ? metadata[h] : "");
                        writer.WriteLine(string.Join(",", values));
                    }
                    System.IO.Directory.GetFiles
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao escrever metadados em arquivo CSV: " + ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolherPasta_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    lblCaminhoPasta.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCaminhoPasta.Text))
            {
                MessageBox.Show("Selecione uma pasta para processar.");
                return;
            }

            var fileList = TraverseDirectory(lblCaminhoPasta.Text);
            if (fileList.Count == 0)
            {
                MessageBox.Show("Não foram encontrados arquivos .tif nesta pasta.");
                return;
            }

            var metadataList = new List<Dictionary<string, string>>();
            foreach (var file in fileList)
            {
                var metadata = GetImageMetadata(file);
                metadataList.Add(metadata);
            }

            if (metadataList.Count == 0)
            {
                MessageBox.Show("Não foram encontrados metadados nas imagens .tif processadas.");
                return;
            }

            var outputPath = Path.Combine(lblCaminhoPasta.Text, "metadata.csv");
            WriteMetadataToCsv(outputPath, metadataList);
            MessageBox.Show("Metadados salvos em: " + outputPath);
        }
    
    }
}

