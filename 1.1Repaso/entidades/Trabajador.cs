using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Repaso.entidades
{
    internal class Trabajador
    {
        //atributos
        int id;
        string nombre;
        string apellidos;
        string dni;
        string fechaNacimiento;
        string titulacionMasAlta;
        int nSS;
        string nCuenta;

        //constructor vacio
        public Trabajador()
        {
        }


        /*
        //constructor lleno
        public Trabajador(int id, string nombre, string apellidos, string dni, string fechaNacimiento, string titulacionMasAlta, int nSS, string nCuenta)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            this.titulacionMasAlta = titulacionMasAlta;
            this.nSS = nSS;
            this.nCuenta = nCuenta;
        }
        */


        //getters y setters
        public int Id { /*get => id;*/ set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Dni { get => dni; set => dni = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TitulacionMasAlta { get => titulacionMasAlta; set => titulacionMasAlta = value; }
        public int NSS { get => nSS; set => nSS = value; }
        public string NCuenta { get => nCuenta; set => nCuenta = value; }



        //ToString
        override
        public string ToString()
        {
            return String.Format("{0},{1},{2},{3},{4},{5},{6},{7}", id, nombre, apellidos, dni, fechaNacimiento, titulacionMasAlta,nSS,nCuenta);            
        }
    }
}
