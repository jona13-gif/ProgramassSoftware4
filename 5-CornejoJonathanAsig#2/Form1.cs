using ModeloIATuristico;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ModeloIATuristico
{
    public partial class Form1 : Form
    {
        private readonly AgentService _agentService;
        private readonly ItineraryTool _itineraryTool;

        public Form1()
        {
            InitializeComponent();
            _agentService = new AgentService();
            _itineraryTool = new ItineraryTool();
            _agentService.ReiniciarSesion();
        }

        // Evento al presionar el botón "Crear itinerario"
        private async void btnCrearItinerario_Click(object sender, EventArgs e)
        {
            string destino = txtDestino.Text.Trim();
            string tiempo = txtTiempoDisponible.Text.Trim();
            string preferencias = txtPreferencias.Text.Trim();
            string ritmo = cmbRitmo.SelectedItem?.ToString() ?? "Tranquilo";

            if (string.IsNullOrEmpty(destino) || string.IsNullOrEmpty(tiempo))
            {
                MessageBox.Show("Por favor ingresa un destino y el tiempo disponible.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string solicitud = $"Quiero visitar {destino} durante {tiempo} horas. " +
                               $"Me interesan: {preferencias}. Ritmo de viaje: {ritmo}. Propón un itinerario inicial.";

            rtbConversacion.AppendText($"Usuario: {solicitud}\n\n");

            btnCrearItinerario.Enabled = false;
            string respuestaIA = await _agentService.EnviarMensajeAsync(solicitud);
            rtbConversacion.AppendText($"Agente: {respuestaIA}\n\n");
            btnCrearItinerario.Enabled = true;

            // Ejemplo de ejecución de la herramienta local para calcular y verificar tiempos
            EjecutarVerificacionHerramientaLocal(double.TryParse(tiempo, out double t) ? t : 6.0);
        }

        // Evento al presionar el botón "Enviar" en la conversación
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string consulta = txtConsulta.Text.Trim();
            if (string.IsNullOrEmpty(consulta)) return;

            rtbConversacion.AppendText($"Usuario: {consulta}\n\n");
            txtConsulta.Clear();

            btnEnviar.Enabled = false;
            string respuestaIA = await _agentService.EnviarMensajeAsync(consulta);

            // Reemplaza saltos de línea escapados si vienen en el JSON
            respuestaIA = respuestaIA.Replace("\\n", "\n");

            rtbConversacion.AppendText($"Agente: {respuestaIA}\n\n");
            btnEnviar.Enabled = true;
        }

        // Evento al presionar "Nueva sesión"
        private void btnNuevaSesion_Click(object sender, EventArgs e)
        {
            _agentService.ReiniciarSesion();
            rtbConversacion.Clear();
            rtbConversacion.AppendText("Sistema: Sesión reiniciada. Memoria temporal activada.\n\n");
        }

        // Ejecución simulada de la herramienta local para actualizar el panel derecho
        private void EjecutarVerificacionHerramientaLocal(double tiempoDisponible)
        {
            // Simulación de actividades extraídas de la respuesta para la herramienta local
            var actividadesEjemplo = new List<Actividad>
            {
                new Actividad { Nombre = "Parque Natural Metropolitano", DuracionHoras = 2.0, Categoria = "Naturaleza" },
                new Actividad { Nombre = "Casco Antiguo", DuracionHoras = 2.0, Categoria = "Historia" },
                new Actividad { Nombre = "Calzada de Amador", DuracionHoras = 1.5, Categoria = "Esparcimiento" }
            };

            ResultadoVerificacion resultado = _itineraryTool.VerificarTiemposItinerario(actividadesEjemplo, tiempoDisponible);

            // Actualizar interfaz con los datos procesados localmente
            lblTiempoUtilizado.Text = $"{resultado.TiempoRequeridoHoras} horas";
            lblTiempoRestante.Text = $"{resultado.TiempoRestanteHoras} horas";
            lblResultadoViabilidad.Text = resultado.EsViable ? "ITINERARIO VIABLE" : "EXCEDIDO";
        }

        private void cmbRitmo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //codigo del combobox
        }

        private void rtbConversacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevaSesion_Click_1(object sender, EventArgs e)
        {

        }
    }
}
