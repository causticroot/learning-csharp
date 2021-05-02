
// Em matemática , o fatorial de um número inteiro não negativo n , denotado por n ! , é o produto de todos os inteiros positivos menores ou iguais a n :

// {\ displaystyle n! = n \ cdot (n-1) \ cdot (n-2) \ cdot (n-3) \ cdot \ cdots \ cdot 3 \ cdot 2 \ cdot 1 \ ,.}{\ displaystyle n! = n \ cdot (n-1) \ cdot (n-2) \ cdot (n-3) \ cdot \ cdots \ cdot 3 \ cdot 2 \ cdot 1 \ ,.}
// Por exemplo,

// {\ displaystyle 5! = 5 \ cdot 4 \ cdot 3 \ cdot 2 \ cdot 1 = 120 \ ,.}{\ displaystyle 5! = 5 \ cdot 4 \ cdot 3 \ cdot 2 \ cdot 1 = 120 \ ,.}
// O valor de 0! é 1, de acordo com a convenção para um produto vazio . [1]

// A operação fatorial é encontrada em muitas áreas da matemática, principalmente em combinatória , álgebra e análise matemática . Seu uso mais básico conta as possíveis sequências distintas - as permutações - de n objetos distintos: há n ! .

// A função fatorial também pode ser estendida para argumentos não inteiros enquanto retém suas propriedades mais importantes ao definir x ! = Γ ( x + 1) , onde Γ é a função gama ; isso é indefinido quando x é um número inteiro negativo.

using System;
using System.Linq;

namespace Factorial
{
    public static class Program
    {
        public static int factorial(int n)
        {       
            return Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item);
        }
    }
}
