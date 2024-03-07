using System;
using UnityEngine;

namespace DataStructures
{
    /// <summary>
    /// Clase que almacena los resultados de una ronda del juego.
    /// </summary>
    [Serializable]
    public class RoundResults
    {
        /// <summary>
        /// Tiempo que ha durado la ronda.
        /// Medido como un float, en segundos.
        /// </summary>
        public float TotalTime;

        /// <summary>
        /// Puntuación conseguida total.
        /// Suma de las puntuaciones que le han dado cada uno de los objetos.
        /// Medido como un entero sin límites inferiores o superiores.
        /// </summary>
        public float TotalScore;

        /// <summary>
        /// Puntuación del objeto que menos puntuación le ha dado.
        /// Podría ser negativa si hay objetos que resten. Por ejemplo, pescar algas en un juego de pesca.
        /// Las puntuaciones de los objetos se comunicarán entre la IA y el juego como floats normalizados, entre -1 y 1.
        /// -1 representará la puntuación más baja que un objeto puede dar y 1 la más alta.
        /// </summary>
        [Range(-1, 1)]
        public float MinScore;

        /// <summary>
        /// Puntuación del objeto que más puntuación le ha dado.
        /// Las puntuaciones de los objetos se comunicarán entre la IA y el juego como floats normalizados, entre -1 y 1.
        /// -1 representará la puntuación más baja que un objeto puede dar y 1 la más alta.
        /// </summary>
        [Range(-1, 1)]
        public float MaxScore;

        /// <summary>
        /// Número total de objetos capturados.
        /// Medido como un entero positivo.
        /// </summary>
        public uint ObjectsCaught;

        /// <summary>
        /// Número total  de objetos perdidos.
        /// Medido como un entero positivo.
        /// </summary>
        public uint ObjectsLost;

        /// <summary>
        /// Tiempo de respuesta medio.
        /// Medido como un float.
        /// Tiempo medio que ha tardado un jugador en capturar un objeto desde que aparece.
        /// </summary>
        public float ResponseTimeAverage;

        /// <summary>
        /// Tiempo de respuesta mínimo.
        /// Medido como un float.
        /// Tiempo mínimo que ha tardado un jugador en capturar un objeto desde que ha aparecido.
        /// </summary>
        public float ResponseTimeMin;

        /// <summary>
        /// Tiempo de respuesta máximo.
        /// Medido como un float.
        /// Tiempo máximo que ha tardado un jugador en capturar un objeto desde que ha aparecido. 
        /// No incluye los objetos que se le han escapado.
        /// </summary>
        public float ResponseTimeMax;
    }
}