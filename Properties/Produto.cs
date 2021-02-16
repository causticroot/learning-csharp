namespace Properties
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;


        //Properties
        //Value é o parâmetro "nome" que seria recebido pela função.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0.0)
                {
                    _preco = value;
                }
            }
        }

        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                _quantidade = value;
            }
        }

        
    }
}