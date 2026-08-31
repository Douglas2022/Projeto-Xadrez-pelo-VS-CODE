using tabuleiro;
namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            
        }
        override public string ToString()
        {
            return "T";
        }
    }
}