using System.Collections.Generic;

namespace atividade_ii.Models
{
    public class Pedido
    {
        private static List<ItemPedido> ItemPedido = new List<ItemPedido>();


        public static void AddItemPedido(ItemPedido item)
        {
            ItemPedido.Add(item);
        }
        public double totalizador()
        {
            double total = 0;

            foreach (var itens in ItemPedido)
            {
                total += itens.precoUni * itens.qtd;
            }

            return total;
        }
    }
}
