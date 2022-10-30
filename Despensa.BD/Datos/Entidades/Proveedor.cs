﻿
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Despensa.BD.Datos.Entidades
{
    public class Proveedor
    {

        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
      

        [Required]
        public string CorreoElectronico { get; set; }


        [Required]

        public string NumeroTelefono { get; set; }

        [JsonIgnore]
        public List<Producto?> Productos { get; set; }

        [JsonIgnore]
        public int? AdministradorId { get; set; }

        [JsonIgnore]
        public Administrador? administrador { get; set; }

    }
}