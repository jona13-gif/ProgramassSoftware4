using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace ProyectoAPI
{
    public partial class Form1 : Form
    {
        string url = "https://v2.jokeapi.dev/joke/Programming?lang=es"; //la variable url tiene el link de la api

        Chiste? chiste; //se crea la variable chiste y de momento no tiene ningun valor

        private static readonly HttpClient cliente = new HttpClient(); //es basicamente la herramienta que usa el programa para comunicarse a internet y ordenar a la api

        public Form1()
        {
            InitializeComponent();

            rdbJson.Checked = true;

            txtChiste.ReadOnly = true;
            txtResultadoEstado.ReadOnly = true;

            txtResultadoEstado.Text = "Esperando..."; 
        }

        private void btnGuardar_Click(object sender, EventArgs e) //si presiona guardar pero sin obtener el chiste te muestra el mensaje
        {
            if (chiste == null)
            {
                txtResultadoEstado.Text = "Primero obtén un chiste.";
                return;
            }

            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                if (rdbJson.Checked)
                {
                    guardar.Filter = "Archivo JSON|*.json";
                    guardar.FileName = "chiste.json";
                }
                else if (rdbTxt.Checked)
                {
                    guardar.Filter = "Archivo de texto|*.txt";
                    guardar.FileName = "chiste.txt";
                }
                else if (rdbCsv.Checked)
                {
                    guardar.Filter = "Archivo CSV|*.csv";
                    guardar.FileName = "chiste.csv";
                }

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (rdbJson.Checked)
                        {
                            string json = JsonSerializer.Serialize(chiste); //pasa de un ojjeto C a jason nuevamente

                            File.WriteAllText(guardar.FileName, json);

                            txtResultadoEstado.Text =
                                "Chiste guardado correctamente en JSON.";
                        }
                        else if (rdbTxt.Checked)
                        {
                            File.WriteAllText(
                                guardar.FileName,
                                txtChiste.Text);

                            txtResultadoEstado.Text =
                                "Chiste guardado correctamente en TXT.";
                        }
                        else if (rdbCsv.Checked)
                        {
                            string chisteTexto =
                                txtChiste.Text.Replace("\"", "\"\"");

                            string csv =
                                "Tipo,Chiste\r\n" +
                                chiste.type + ",\"" +
                                chisteTexto + "\"";

                            File.WriteAllText(guardar.FileName, csv);

                            txtResultadoEstado.Text =
                                "Chiste guardado correctamente en CSV.";
                        }
                    }
                    catch (Exception ex)
                    {
                        txtResultadoEstado.Text =
                            "Error al guardar: " + ex.Message;
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtChiste.Clear();

            txtResultadoEstado.Text = "Resultado limpiado.";

            chiste = null;

            rdbJson.Checked = true;
        }

        private async void btnObtenerChiste_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultadoEstado.Text = "Consultando API...";
                txtChiste.Clear();

                string respuesta = await cliente.GetStringAsync(url); //obtiene los datos de internet

                chiste = JsonSerializer.Deserialize<Chiste>(respuesta); //convierte el jason recibido en un objeto

                if (chiste == null)
                {
                    txtResultadoEstado.Text =
                        "No se pudo procesar la respuesta de la API.";
                    return;
                }

                if (chiste.type == "single")
                {
                    txtChiste.Text = chiste.joke;
                }
                else if (chiste.type == "twopart")
                {
                    txtChiste.Text =
                        chiste.setup + "\r\n\r\n" +
                        chiste.delivery;
                }
                else
                {
                    txtChiste.Text =
                        "La API devolvió un formato desconocido.";
                }

                txtResultadoEstado.Text =
                    "Chiste obtenido correctamente.";
            }
            catch (HttpRequestException)
            {
                txtResultadoEstado.Text =
                    "Error de conexión con la API.";
            }
            catch (JsonException)
            {
                txtResultadoEstado.Text =
                    "Error al procesar la respuesta de la API.";
            }
            catch (Exception ex)
            {
                txtResultadoEstado.Text =
                    "Error: " + ex.Message;
            }
        }
    }

    public class Chiste
    {
        public string? type { get; set; }
        public string? joke { get; set; }
        public string? setup { get; set; }
        public string? delivery { get; set; }
    }
}