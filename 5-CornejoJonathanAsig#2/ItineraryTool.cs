using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ModeloIATuristico
{
    public class Actividad
    {
        public string Nombre { get; set; } = string.Empty;
        public double DuracionHoras { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string HoraInicio { get; set; } = string.Empty;
    }

    public class ResultadoVerificacion
    {
        public int TotalActividades { get; set; }
        public double TiempoRequeridoHoras { get; set; }
        public double TiempoDisponibleHoras { get; set; }
        public double TiempoRestanteHoras { get; set; }
        public bool EsViable { get; set; }
        public string Mensaje { get; set; } = string.Empty;
    }

    public class ItineraryTool
    {
        [Description("Verifica si la suma de duraciones de las actividades no excede el tiempo disponible del usuario.")]
        public ResultadoVerificacion VerificarTiemposItinerario(List<Actividad> actividades, double tiempoDisponibleHoras)
        {
            double tiempoTotal = actividades.Sum(a => a.DuracionHoras);
            bool viable = tiempoTotal <= tiempoDisponibleHoras;
            double restante = tiempoDisponibleHoras - tiempoTotal;

            return new ResultadoVerificacion
            {
                TotalActividades = actividades.Count,
                TiempoRequeridoHoras = tiempoTotal,
                TiempoDisponibleHoras = tiempoDisponibleHoras,
                TiempoRestanteHoras = restante >= 0 ? restante : 0,
                EsViable = viable,
                Mensaje = viable
                    ? "ITINERARIO VIABLE: El tiempo se ajusta perfectamente."
                    : "EXCEDE EL TIEMPO: Reduce la duración o quita alguna actividad."
            };
        }
    }
}
