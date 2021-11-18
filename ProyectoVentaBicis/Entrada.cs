using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVentaBicis
{
    class Entrada
    {
        private int idEntrada;
        private DateTime fecha;
        private int idEstado;
        private double total;
        private int[] idEntradaProducto;
        private int[] cantidad;
        private int[] idProducto;
        private double[] costeUnidad;

        public Entrada() { }
        public Entrada(int idEntrada, DateTime fecha, int idEstado, double total)
        {
            this.idEntrada = idEntrada;
            this.fecha = fecha;
            this.idEstado = idEstado;
            this.total = total;
        }
        public Entrada(int idEntrada, DateTime fecha, int idEstado, double total, int[] idEntradaProducto, int[] cantidad, int[] idProducto, double[] costeUnidad)
        {
            this.idEntrada = idEntrada;
            this.fecha = fecha;
            this.idEstado = idEstado;
            this.total = total;
            this.idEntradaProducto = idEntradaProducto;
            this.cantidad = cantidad;
            this.idProducto = idProducto;
            this.costeUnidad = costeUnidad;
        }
        public int getIdEntrada()
        {
            return this.idEntrada;
        }
        public void setIdEntrada(int idEntrada)
        {
            this.idEntrada = idEntrada;
        }
        public DateTime getFecha()
        {
            return this.fecha;
        }
        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }
        public int getIdEstado()
        {
            return this.idEstado;
        }
        public void setIdEstado(int idEstado)
        {
            this.idEstado= idEstado;
        }
        public double getTotal()
        {
            return this.total;
        }
        public void setTotal(double total)
        {
            this.total = total;
        }
        public int[] getIdProducto()
        {
            return this.idProducto;
        }
        public void setIdProducto(int[] idProducto)
        {
            this.idProducto = idProducto;
        }
        public double[] getCosteUnidad()
        {
            return this.costeUnidad;
        }
        public void setCosteUnidad(double[] costeUnidad)
        {
            this.costeUnidad = costeUnidad;
        }
    }
}
