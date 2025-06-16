using FarmaciaPedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FarmaciaPedidos.Services
{
    public class ResumenPedidoBuilder
    {
        private readonly Dictionary<string, string> _direccionesSucursales = new Dictionary<string, string>
        {
            { "Principal", "Calle de la Rosa n.28" },
            { "Secundaria", "Calle Alcazabilla n.3" }
        };

        public ResumenPedido ConstruirResumen(Pedido pedido)
        {
            if (pedido == null)
                throw new ArgumentNullException(nameof(pedido));

            var resumen = new ResumenPedido
            {
                TituloVentana = $"Pedido al distribuidor {pedido.Distribuidor}",
                DetalleMedicamento = $"{pedido.Cantidad} unidades del {pedido.TipoMedicamento.ToLower()} {pedido.NombreMedicamento}",
                DireccionEntrega = GenerarTextoDireccion(pedido.Sucursales)
            };

            return resumen;
        }

        private string GenerarTextoDireccion(List<string> sucursales)
        {
            if (sucursales == null || sucursales.Count == 0)
                return "Sin dirección de entrega";

            var direcciones = sucursales
                .Where(s => _direccionesSucursales.ContainsKey(s))
                .Select(s => $"para la situada en {_direccionesSucursales[s]}")
                .ToList();

            return $"Para la farmacia situada en {string.Join(" y ", direcciones)}.";
        }
    }
}
