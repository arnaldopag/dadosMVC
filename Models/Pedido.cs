using System.Collections.Generic;

namespace atividade_ii.Models
{
    public class Pedido
    {
        private List<ItemPedido> ItemPedido;

        public Pedido()
        {
            ItemPedido = new List<ItemPedido>();
        }
        public void AddItemPedido(ItemPedido item)
        {
            ItemPedido.Add(item);
        }
        public double totalizador()
        {
            double total = 0d;
            double soma = 0d;
            foreach (var i in ItemPedido)
            {
                total = i.precoUni * i.qtd;
                soma += total;
            }

            return soma;
        }
    }
 }
