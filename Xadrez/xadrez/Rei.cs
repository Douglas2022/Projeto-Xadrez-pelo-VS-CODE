using tabuleiro;
namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            
        }
        override public string ToString()
        {
            return "R";
        }
    }
}