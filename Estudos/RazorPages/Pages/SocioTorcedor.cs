namespace HelloWord.Pages
{
    public class SocioTorcedor
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set { _idade = value < 0 ? 0 : value; }
        }

        private decimal _mensalidade;
        public decimal Mensalidade
        {
            get { return _mensalidade; }
            set { _mensalidade = value < 45.00m ? 45.00m : value; }
        }
    }
}
