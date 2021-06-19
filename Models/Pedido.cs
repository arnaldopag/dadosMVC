using System.Collections.Generic;

namespace atividade_ii.Models
{
    public class Pedido
    {
        private static List<ItemPedido> ItemPedido = new List<ItemPedido>();


        public void AddItemPedido(ItemPedido novoItem)
        {
            ItemPedido.Add(novoItem);
        }
        public static double totalizador()
        {
            double total = 0;

            foreach (var itens in ItemPedido)
            {
                total += itens.precoUni * itens.qtd;
            }
            return total;
        }
        public List<ItemPedido> ListaItems(){
            return ItemPedido;
        }
    }   
}
