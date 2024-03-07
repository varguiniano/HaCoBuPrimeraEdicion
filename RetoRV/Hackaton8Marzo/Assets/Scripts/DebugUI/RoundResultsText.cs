using System.Text;
using APICommunication;
using TMPro;
using UnityEngine;

namespace DebugUI
{
    /// <summary>
    /// Encargado de mostrar en el texto de debug los resultados de la ronda.
    /// </summary>
    [RequireComponent(typeof(TMP_Text))]
    public class RoundResultsText : MonoBehaviour
    {
        /// <summary>
        /// Referencia al proveedor de dificultad.
        /// </summary>
        [SerializeField]
        private DifficultyProvider DifficultyProvider;

        /// <summary>
        /// Reference al texto asociado.
        /// </summary>
        private TMP_Text Text
        {
            get
            {
                if (text == null) text = GetComponent<TMP_Text>();
                return text;
            }
        }

        /// <summary>
        /// Backfield para Text.
        /// </summary>
        private TMP_Text text;

        /// <summary>
        /// Actualizar el texto.
        /// </summary>
        private void Update()
        {
            StringBuilder builder = new("<b>Resultados de la ronda</b>\n");

            builder.Append("Tiempo total: ");
            builder.Append(DifficultyProvider.RoundResults.TotalTime.ToString("n2"));
            builder.AppendLine("s.");
            builder.Append("Puntuación total: ");
            builder.Append(DifficultyProvider.RoundResults.TotalScore.ToString("n2"));
            builder.AppendLine(".");
            builder.Append("Puntuación mínima: ");
            builder.Append(DifficultyProvider.RoundResults.MinScore.ToString("n2"));
            builder.AppendLine(".");
            builder.Append("Puntuación máxima: ");
            builder.Append(DifficultyProvider.RoundResults.MaxScore.ToString("n2"));
            builder.AppendLine(".");
            builder.Append("Objetos capturados: ");
            builder.Append(DifficultyProvider.RoundResults.ObjectsCaught.ToString());
            builder.AppendLine(".");
            builder.Append("Objetos perdidos: ");
            builder.Append(DifficultyProvider.RoundResults.ObjectsLost.ToString());
            builder.AppendLine(".");
            builder.Append("Tiempo de respuesta medio: ");
            builder.Append(DifficultyProvider.RoundResults.ResponseTimeAverage.ToString("n2"));
            builder.AppendLine("s.");
            builder.Append("Tiempo de respuesta mínimo: ");
            builder.Append(DifficultyProvider.RoundResults.ResponseTimeMin.ToString("n2"));
            builder.AppendLine("s.");
            builder.Append("Tiempo de respuesta máximo: ");
            builder.Append(DifficultyProvider.RoundResults.ResponseTimeMax.ToString("n2"));
            builder.AppendLine("s.");

            Text.SetText(builder);
        }
    }
}