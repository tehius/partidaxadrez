using tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(tabuleiro.Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
