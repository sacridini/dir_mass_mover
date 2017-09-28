using System;
using System.IO;
using System.Windows.Forms;

namespace dir_mover
{
    public partial class Form1 : Form
    {

        string origem;
        string destino;
        string extensao;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_origem_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                origem = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_destino_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                destino = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_rodar_Click(object sender, EventArgs e)
        {
            var dirs = Directory.GetDirectories(origem);
            dir_mover_engine(dirs);
        }

        private void dir_mover_engine(string[] dirpaths)
        {
            extensao = "*." + txt_extensao.Text;
            foreach (string dir in dirpaths)
            {
                DirectoryInfo di = new DirectoryInfo(dir);
                FileInfo[] filesInfo = di.GetFiles("*.mp3");

                // TODO: 
                // Ignorar arquivos que não se tem acesso! 
                //
                // IList<string> arquivos;
                // FileInfo[] filesInfo;
                // try
                // {
                //     
                //     filesInfo = di.GetFiles("*." + extensao); // .ToList().ForEach(s => arquivos.Add(s));
                //     File.ReadAllText(filesInfo);
                // }
                // catch(UnauthorizedAccessException)
                // {
                //     throw;
                // }

                string dirName = new DirectoryInfo(dir).Name;
                string dest_final_path = destino + "\\" + dirName;

                MessageBox.Show("Iniciando a transferência.");
                if (filesInfo.Length != 0)
                {
                    bool exists = Directory.Exists(dest_final_path);
                    if (!exists)
                    {
                        Directory.Move(dir, dest_final_path);
                        listBox.Items.Add("Movendo "+ dir + " to: " + dest_final_path);
                    }
                    else
                    {
                        MessageBox.Show("O diretório " + dest_final_path + " já existe!");
                    }
                }
            }
            MessageBox.Show("Done.");
        }
    }
}