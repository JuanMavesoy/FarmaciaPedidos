using FarmaciaPedidos.Models;
using System.Collections.Generic;
using System.Linq;


namespace FarmaciaPedidos.Services
{
    public class PedidoValidator
    {
        public List<string> Validar(Pedido pedido)
        {
            var errores = new List<string>();

            if (string.IsNullOrWhiteSpace(pedido.NombreMedicamento) || !TieneAlfanumericos(pedido.NombreMedicamento))
                errores.Add("El nombre del medicamento es obligatorio y debe tener caracteres alfanuméricos.");

            if (string.IsNullOrWhiteSpace(pedido.TipoMedicamento))
                errores.Add("Debe seleccionar un tipo de medicamento.");

            if (pedido.Cantidad <= 0)
                errores.Add("La cantidad debe ser un número entero positivo.");

            if (string.IsNullOrWhiteSpace(pedido.Distribuidor))
                errores.Add("Debe seleccionar un distribuidor.");

            if (pedido.Sucursales == null || !pedido.Sucursales.Any())
                errores.Add("Debe seleccionar al menos una sucursal (principal o secundaria).");

            return errores;
        }

        private bool TieneAlfanumericos(string texto)
        {
            return texto.Any(char.IsLetterOrDigit);
        }
    }
}