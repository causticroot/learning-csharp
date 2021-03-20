namespace StructType
{
    public struct RetanguloStruct
    {
        public RetanguloStruct(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double largura;
        public double altura;

        public double AreaDoRetangulo()
        {
            return altura * largura;
        }
    }
}