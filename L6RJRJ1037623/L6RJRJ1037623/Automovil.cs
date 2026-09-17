using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6RJRJ1037623
{
    internal class Automovil
    {
        private int modelo;
        private double precio;
        private string marca;
        private bool disponible;
        private double tipoCambioDolar;
        private double descuentoAplicado;

        public Automovil()
        {
            modelo = 2023;
            precio = 10000.00;
            marca = "";
            disponible = false;
            tipoCambioDolar = 7.75;
            descuentoAplicado = 0.0;
        }
        
        public void DefinirModelo(int unModelo)
        {
            this.modelo = unModelo;
        }

        public void DefinirPrecio(double unPrecio)
        {
            precio = unPrecio;
        }
        
        public void DefinirMarca (string unamarca)
        {
            marca = unamarca;
        }

        public void DefinirTipoCambio(double unTipoCambio)
        {
            tipoCambioDolar = unTipoCambio;
        }

        public void CambiarDisponibilidad()
        {
            disponible = !disponible;
        }

        string MostrarDisponibilidad()
        {
            if (disponible)
            {
                return "Disponible";
            }
            else
            {
                return "No disponible";
            }
        }

        string MostrarInformacion()
        {
            string informacion = "";
            informacion = "Marca:" + marca + ".Modelo " + modelo.ToString() + ".Precio de venta Q " + precio.ToString() + ". Precio en dolares $" + (precio / tipoCambioDolar).ToString();
            return informacion;
        }

        public void AplicarDescuento(double miDescuento)
        {
            descuentoAplicado = miDescuento;
            DefinirPrecio(precio - descuentoAplicado);
        }
    }
}
