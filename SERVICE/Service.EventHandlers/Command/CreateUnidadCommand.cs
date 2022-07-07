﻿using MediatR;

namespace Service.EventHandlers.Command
{
    public class CreateUnidadCommand : INotification
    {
        public string NroUnidad { get; set; }
        public string Dominio { get; set; }
        public string Motor { get; set; }
        public string Chasis { get; set; }
        public string Titular { get; set; }
        public int idEstadoUnidad { get; set; }
        public int idModelo { get; set; }
        public int idSituacionUnidad { get; set; }
    }
}
