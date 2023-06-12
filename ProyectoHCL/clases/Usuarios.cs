﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Usuarios
    {
        private int ID_USUARIO;
        private string USUARIO;
        private string NOMBRE_USUARIO;
        private string CONTRASEÑA;
        private string ROL_USUARIO;
        private string EMAIL;
        private DateTime FECHA_CREACION;
        private DateTime FECHA_VENCIMIENTO;
        private string ESTADO_USUARIO;
        private DateTime FECHA_ULT_CONEX;
        private int PREGUNTAS_CONTESTADAS;
        private int PRIMER_INGRESO;


        public int ID_USUARIO1 { get => ID_USUARIO; set => ID_USUARIO = value; }
        public string USUARIO1 { get => USUARIO; set => USUARIO = value; }
        public string NOMBRE1 { get => NOMBRE_USUARIO; set => NOMBRE_USUARIO = value; }
        public string CONTRASEÑA1 { get => CONTRASEÑA; set => CONTRASEÑA = value; }
        public DateTime FECHA_ULT_CONEX1 { get => FECHA_ULT_CONEX; set => FECHA_ULT_CONEX = value; }
        public int PREGUNTAS_CONTESTADAS1 { get => PREGUNTAS_CONTESTADAS; set => PREGUNTAS_CONTESTADAS = value; }
        public int PRIMER_INGRESO1 { get => PRIMER_INGRESO; set => PRIMER_INGRESO = value; }
        public DateTime FECHA_VENCIMIENTO1 { get => FECHA_VENCIMIENTO; set => FECHA_VENCIMIENTO = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
        public string ROL_USUARIO1 { get => ROL_USUARIO; set => ROL_USUARIO = value; }
        public DateTime FECHA_CREACION1 { get => FECHA_CREACION; set => FECHA_CREACION = value; }
        public string ESTADO_USUARIO1 { get => ESTADO_USUARIO; set => ESTADO_USUARIO = value; }
    }
}
