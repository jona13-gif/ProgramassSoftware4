using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ModeloIATuristico
{
    public class AgentService
    {
        private readonly string _apiKey = "AQ.Ab8RN6I_VRx-SWuQHYJA8fjRUIYR5nAgIFfhb3TY2saLV9wsIw";
        private readonly HttpClient _httpClient;

        // Memoria temporal de la sesión de conversación
        private readonly List<object> _historialMensajes = new();

        public AgentService()
        {
            _httpClient = new HttpClient();
        }

        public void ReiniciarSesion()
        {
            _historialMensajes.Clear();

            // System Prompt para el Agente Turístico de Panamá
            _historialMensajes.Add(new
            {
                role = "user",
                parts = new[] { new { text = "Eres TravelPlan AI, un agente inteligente experto en planificar itinerarios turísticos en Panamá. Tu objetivo es analizar el destino, tiempo disponible y preferencias del usuario. Haz preguntas para aclarar gustos si es necesario, propón itinerarios realistas y calcula siempre los tiempos para asegurarte de que sean viables." } }
            });
            _historialMensajes.Add(new
            {
                role = "model",
                parts = new[] { new { text = "Entendido. Estoy listo para ayudarte a planificar tu viaje por Panamá." } }
            });
        }

        public async Task<string> EnviarMensajeAsync(string mensajeUsuario)
        {
            // Agregar consulta del usuario a la memoria de sesión
            _historialMensajes.Add(new
            {
                role = "user",
                parts = new[] { new { text = mensajeUsuario } }
            });

            // Usamos el modelo actualizado de Gemini (gemini-2.5-flash o gemini-1.5-flash-latest)
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.5-flash:generateContent?key={_apiKey}";

            var requestBody = new { contents = _historialMensajes };
            string jsonBody = JsonSerializer.Serialize(requestBody);

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync(url, content);
                string responseJson = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    // Muestra el código exacto de error que devuelve Google para saber qué falló
                    return $"Error de API ({response.StatusCode}): {responseJson}";
                }

                using var doc = JsonDocument.Parse(responseJson);

                string respuestaTexto = doc.RootElement
                    .GetProperty("candidates")[0]
                    .GetProperty("content")
                    .GetProperty("parts")[0]
                    .GetProperty("text")
                    .GetString() ?? "Sin respuesta.";

                // Guardar respuesta del modelo en la memoria
                _historialMensajes.Add(new
                {
                    role = "model",
                    parts = new[] { new { text = respuestaTexto } }
                });

                return respuestaTexto;
            }
            catch (Exception ex)
            {
                return $"Excepción local: {ex.Message}";
            }
        }
    }
}
