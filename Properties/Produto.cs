namespace Properties
{
    public class Produto
    {
        private string _nome;
       
        //Auto Properties, Propriedades autoimplementadas 
       public double Preco { get; private set; }
       public int Quantidade { get; private set; }
       
       
       


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
        
    }
}