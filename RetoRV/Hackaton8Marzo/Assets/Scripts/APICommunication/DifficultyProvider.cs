using System.Collections;
using DataStructures;
using UnityEngine;
using UnityEngine.Networking;

namespace APICommunication
{
    /// <summary>
    /// Encargado de enviar los resultados de la ronda al servidor y recibir de vuelta la dificultad de la siguiente ronda.
    /// Ambas partes se guardarán en las dos estructuras de datos contenidas en este objeto.
    /// </summary>
    public class DifficultyProvider : MonoBehaviour
    {
        /// <summary>
        /// Referencia a los resultados de la ronda.
        /// </summary>
        public RoundResults RoundResults;

        /// <summary>
        /// Referencia a la configuración de dificultad.
        /// </summary>
        public DifficultySettings DifficultySettings;

        /// <summary>
        /// Envía los datos de la ronda al servidor y recibe la dificultad de la siguiente ronda.
        /// </summary>
        public void UpdateDifficulty() => StartCoroutine(UpdateDifficultyRoutine());

        /// <summary>
        /// Envía los datos de la ronda al servidor y recibe la dificultad de la siguiente ronda.
        /// </summary>
        public IEnumerator UpdateDifficultyRoutine()
        {
            string roundResultsJson = JsonUtility.ToJson(RoundResults);

            UnityWebRequest request =
                UnityWebRequest.Post("http://127.0.0.1:8000/inferencia", roundResultsJson, "application/json");

            yield return request.SendWebRequest();

            if (request.result != UnityWebRequest.Result.Success)
                Debug.LogError(request.error);
            else
            {
                string difficultySettingsJson = request.downloadHandler.text;

                DifficultySettings = JsonUtility.FromJson<DifficultySettings>(difficultySettingsJson);
            }
        }
    }
}