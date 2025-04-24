using Newtonsoft.Json;
using StoryMolly.Modelos;
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

namespace StoryMolly
{
    public partial class FormLeitura : Form
    {

        private List<Capitulo> capitulos;
        private int indiceAtual = 0;

        public FormLeitura()
        {
            InitializeComponent();
            CarregarCapitulos();
            ExibirCapitulo(indiceAtual);
        }

        private void CarregarCapitulos()
        {
            string caminhoJson = Path.Combine(Application.StartupPath, "Data", "capitulos.json");
            string json = File.ReadAllText(caminhoJson);
            capitulos = JsonConvert.DeserializeObject<List<Capitulo>>(json);
        }

        private void ExibirCapitulo(int indice)
        {
            if (indice < 0 || indice >= capitulos.Count) return;
            var cap = capitulos[indice];
            lblTitulo.Text = cap.Titulo;
            rtbTexto.Text = cap.Texto;

            string caminhoImagem = Path.Combine(Application.StartupPath, "Assets", "Imagens", cap.Imagem);
            if (File.Exists(caminhoImagem))
            {
                pbImagem.Image = Image.FromFile(caminhoImagem);
                pbImagem.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbImagem.Image = null;
            }

            btnAnterior.Enabled = indice > 0;
            btnProximo.Enabled = indice < capitulos.Count - 1;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (indiceAtual < capitulos.Count - 1)
            {
                indiceAtual++;
                ExibirCapitulo(indiceAtual);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceAtual > 0)
            {
                indiceAtual--;
                ExibirCapitulo(indiceAtual);
            }
        }
    }
}
