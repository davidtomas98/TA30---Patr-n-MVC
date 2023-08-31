using System;
using System.Collections.Generic;
using Ejercicio2.Models;

namespace Ejercicio2.Controllers
{
    public class VideoController
    {
        private List<Video> _videos = new List<Video>();

        // Método para crear un nuevo video
        public void CrearVideo(Video video)
        {
            _videos.Add(video);
        }

        // Método para obtener la lista de todos los videos
        public List<Video> ObtenerVideos()
        {
            return _videos;
        }

        // Método para obtener un video por su ID
        public Video ObtenerVideoPorId(int id)
        {
            return _videos.Find(v => v.Id == id);
        }

        // Método para actualizar la información de un video
        public void ActualizarVideo(Video videoActualizado)
        {
            Video videoExistente = _videos.Find(v => v.Id == videoActualizado.Id);
            if (videoExistente != null)
            {
                // Actualizar los datos del video existente con los datos del video actualizado
                videoExistente.Title = videoActualizado.Title;
                videoExistente.Director = videoActualizado.Director;
                videoExistente.ClienteId = videoActualizado.ClienteId;
            }
        }

        // Método para eliminar un video por su ID
        public void EliminarVideo(int id)
        {
            Video videoExistente = _videos.Find(v => v.Id == id);
            if (videoExistente != null)
            {
                // Remover el video de la lista
                _videos.Remove(videoExistente);
            }
        }

        // Método para eliminar un video directamente por objeto
        public void EliminarVideo(Video videoAEliminar)
        {
            _videos.Remove(videoAEliminar);
        }
    }
}
