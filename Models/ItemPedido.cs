namespace atividade_ii.Models
{
    public class ItemPedido
    {
         public string descricao;
        public double precoUni ;
        public int qtd ;
        public ItemPedido(string d, double p, int q){
            descricao = d;
            precoUni = p;  
            qtd = q;
        }
    }
}