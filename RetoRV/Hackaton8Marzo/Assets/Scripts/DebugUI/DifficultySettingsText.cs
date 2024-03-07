using System.Text;
using APICommunication;
using TMPro;
using UnityEngine;

namespace DebugUI
{
    /// <summary>
    /// Encargado de mostrar en el texto de debug los ajustes de dificultad.
    /// </summary>
    [RequireComponent(typeof(TMP_Text))]
    public class DifficultySettingsText : MonoBehaviour
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

            builder.Append("Ratio de aparición: ");
            builder.Append(DifficultyProvider.DifficultySettings.SpawnRatio.ToString("n2"));
            builder.AppendLine("s.");
            builder.Append("Tamaño de los objetos: ");
            builder.Append(DifficultyProvider.DifficultySettings.ObjectSize.ToString("n2"));
            builder.AppendLine(".");
            builder.Append("Distancia al jugador: ");
            builder.Append(DifficultyProvider.DifficultySettings.DistanceToPlayer.ToString("n2"));
            builder.AppendLine(".");
            builder.Append("Ratio de recompensa: ");
            builder.Append(DifficultyProvider.DifficultySettings.RewardRatio.ToString("n2"));
            builder.AppendLine(".");

            Text.SetText(builder);
        }
    }
}