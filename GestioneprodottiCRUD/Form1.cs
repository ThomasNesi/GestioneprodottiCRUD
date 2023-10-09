using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneprodottiCRUD
{
    public partial class Form1 : Form
    {
        //struct prodotto
        public struct Prodotto
        {
            public string nome;
            public float prezzo;
        }
        public Prodotto[] p;
        public int dim;
        public Form1()
        {
            InitializeComponent();

            p = new Prodotto[100];
            dim = 0;
        }
        //inserire prodotto
        private void inserisci_btn_Click(object sender, EventArgs e)
        {
            p[dim].nome = Nome_box.Text;
            p[dim].prezzo = float.Parse(Prezzo_box.Text);
            dim++;
            visualizza(p);
            MessageBox.Show("Aggiunto");
        }
        public void aggiornaVista(int dim)
        {
            articoli.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                articoli.Items.Add("Nome: " + p[i].nome.ToString() + "      Prezzo: " + p[i].prezzo.ToString() + "£");
            }
        }
        public string prodString(Prodotto p)
        {
            return "Nome: " + p.nome.ToString() + "      Prezzo: " + p.prezzo.ToString() + "£";
        }

        //Aggiungi nella list_box
        public void visualizza(Prodotto[] pp)
        {
            articoli.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                articoli.Items.Add(prodString(pp[i]));
            }
        }

        private void Modifican_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == ricerca_box.Text)
                {
                    p[i].nome = modnome_box.Text;
                    break;
                }
                MessageBox.Show("Modificato");
                aggiornaVista(dim);
            }
        }

        private void Modificap_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo == float.Parse(ricerca_box.Text))
                {
                    p[i].prezzo = float.Parse(modprezzo_box.Text);
                    break;
                }
                MessageBox.Show("Modificato");
                aggiornaVista(dim);
            }
        }

        private void cancella_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dim; i++)
            {

                if (p[i].nome == ricerca_box.Text)
                {
                    for (int j = i; j < dim - 1; j++)
                    {
                        p[j] = p[j + 1];
                    }
                    dim--;

                    aggiornaVista(dim);
                    MessageBox.Show("Cancellato");
                    return;

                }
            }
        }

        private void somma_btn_Click(object sender, EventArgs e)
        {
            float prezzotot = 0;
            for (int i = 0; i < dim; i++)
            {
                prezzotot += p[i].prezzo;
            }
            MessageBox.Show("Prezzo totale: " + prezzotot + "£");
        }

        private void percentuale_btn_Click(object sender, EventArgs e)
        {
            float percentuale = float.Parse(perc_box.Text);

            for (int i = 0; i < dim; i++)
            {
                p[i].prezzo = (percentuale / 100) * p[i].prezzo;
            }
            aggiornaVista(dim);
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            float minore = 100;
            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo < minore)
                {
                    minore = p[i].prezzo;
                }
            }
            MessageBox.Show("Prodotto minimo: " + minore);
        }

        private void max_btn_Click(object sender, EventArgs e)
        {
            float maggiore = 0;
            for (int i = 0; i < dim; i++)
            {
                if (p[i].prezzo > maggiore)
                {
                    maggiore = p[i].prezzo;
                }
            }
            MessageBox.Show("Prodotto minimo: " + maggiore);
        }

        private void ordinamento_btn_Click(object sender, EventArgs e)
        {
            // ordinamento Bubble Sort
            for (int i = 0; i < dim - 1; i++)
            {
                for (int j = 0; j < dim - i - 1; j++)
                {
                    if (string.Compare(p[j].nome, p[j+1].nome) > 0)
                    {
                        // Scambia gli elementi se sono fuori ordine
                        Prodotto temp = p[j];
                        p[j] = p[j + 1];
                        p[j + 1] = temp;
                    }
                }
            }
            articoli.Items.Clear();
            // aggiunta degli elmenti ordinati
            aggiornaVista(dim);
        }
    }
}