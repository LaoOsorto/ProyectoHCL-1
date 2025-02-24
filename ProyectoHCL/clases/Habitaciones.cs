﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHCL.clases
{
    public class Habitaciones
    {
        private int ID_HABITACION;
        private string TIPO;
        private int NUMEROHABITACION;
        private string ESTADOHABITACION;
        private int Inicio;
        private int Final;

        public int ID_HABITACION1 { get => ID_HABITACION; set => ID_HABITACION = value; }
        public string TIPO1 { get => TIPO; set => TIPO = value; }
        public int NUMEROHABITACION1 { get => NUMEROHABITACION; set => NUMEROHABITACION = value; }
        public string ESTADOHABITACION1 { get => ESTADOHABITACION; set => ESTADOHABITACION = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        public DataSet PaginacionHabitacion()
        {
            MySqlConnection conn;
            MySqlCommand cmd;
            conn = new MySqlConnection("server=containers-us-west-29.railway.app;port=6844; database = railway; Uid = root; pwd = LpxjPRi2Ckkz7FiKNUHn;");
            conn.Open();

            cmd = new MySqlCommand("PagHabitaciones", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inicio", Inicio1);
            cmd.Parameters.AddWithValue("@final", Final1);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            da.Fill(dt);

            return dt;
        }
    }
}
