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
            double total = 0d;
            //double soma = 0d;
            foreach (var itens in ItemPedido)
            {
                total += itens.precoUni * itens.qtd;
               // soma += total;
            }

            return total;
        }
    }
 }
