namespace ObjectAndToString
{
    public class Personagem
    {
        //Constantes
        private const int NivelInicial = 1;
        private const double VidaInicial = 1.0;
        private const double ManaInicial = 1.0;

       //Atributos 
       public string Nome;
       public double Vida;
       public double Mana;
       public int Nivel;
    

        //Métodos
        public override string ToString()
        {
            return "Nome: " + this.Nome + " | " +
                   "Vida: " + this.Vida + " | " + 
                   "Mana: " + this.Mana + " | " +
                   "Nivel: " + this.Nivel;
        }


        //Construtores
        public Personagem(string nome, double vida, double mana)
        {
            this.Nome = nome;
            this.Vida = vida;
            this.Mana = mana;
            this.Nivel = NivelInicial;
        }

        public Personagem()
        {
            this.Nome = "Default";
            this.Vida = VidaInicial;
            this.Mana = ManaInicial;
            this.Nivel = NivelInicial;
        }
    
    }
}