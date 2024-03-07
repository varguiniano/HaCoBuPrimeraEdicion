using System;
using UnityEngine;

namespace DataStructures
{
    /// <summary>
    /// Clase que almacena los ajustes de dificultad del juego.
    /// </summary>
    [Serializable]
    public class DifficultySettings
    {
        /// <summary>
        /// Ratio de aparición de los objetos en el juego.
        /// Medido como un float entre 0 y 1.
        /// 0 representará la velocidad de aparición más lenta, siendo más fácil capturar los objetos,
        /// y 1 representará la más rápida.
        /// </summary>
        [Range(0, 1)]
        public float SpawnRatio;

        /// <summary>
        /// Tamaño de los objetos.
        /// Medido como un float entre 0 y 1.
        /// 0 representará los objetos más pequeños, siendo más difícil capturarlos, y 1 los más grandes.
        /// </summary>
        [Range(0, 1)]
        public float ObjectSize;

        /// <summary>
        /// Distancia al jugador de los objetos.
        /// Medido como un float entre 0 y 1.
        /// 0 representará la distancia más cercana al jugador, siendo más fácil capturarlo, y 1 la más lejana.
        /// Esta variable debería afectar a la generación aleatoria, no aparecer todos a exáctamente la misma distancia.
        /// </summary>
        [Range(0, 1)]
        public float DistanceToPlayer;

        /// <summary>
        /// Ratio de recompensa de los objetos.
        /// Medido como un float entre -1 y 1.
        /// Representará la proporción de objetos que aparecen con diferentes puntuaciones.
        /// -1 implicará que aparecerán más objetos con puntuaciones más bajas (o negativas), siendo más difícil.
        /// 1 representará objetos con puntuaciones más altas, siendo más fácil.
        /// </summary>
        [Range(-1, 1)]
        public float RewardRatio;
    }
}