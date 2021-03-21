# Aprendendo csharp

## Objetivos:

Este repositório foi criado de acordo com a minha necessidade de praticar e fixar a sintaxe da linguagem c#. O objetivo é estimular a prática da programação orientada a objetos e me aproximar do desenvolvimento de jogos. Os estudos abordados aqui não fazem parte do conteúdo acadêmico, portanto o repositório será alimentado de acordo com  a minha disponibilidade diária. 


## Tecnologias usadas
* C#
* .NET Core  `3.1.40`
* Vscode
* Code Wars

## Exercícios
* [Multiples of 3 or 5 (codewars)](https://github.com/causticroot/learning-csharp/blob/master/CodeWars/Multiples/Program.cs); 
* [Categorize New Member (codewars)](https://github.com/causticroot/learning-csharp/blob/master/CodeWars/CategorizeNewMember/Program.cs); 
* [Hells Kitchen (codewars)](https://github.com/causticroot/learning-csharp/blob/master/CodeWars/HellsKitchen/Program.cs); 
* [Fire On The Boat (codewars)](https://github.com/causticroot/learning-csharp/blob/master/CodeWars/FireOnTheBoat/Program.cs); 
* [Zeros To The End (codewars)](https://github.com/causticroot/learning-csharp/blob/master/CodeWars/ZerosToTheEnd/Program.cs); 
* [Don't Give Me Five (codewars)](https://github.com/causticroot/learning-csharp/blob/master/CodeWars/DontGiveMeFive/Program.cs); 
* [Valid Parentheses (codewars)](https://github.com/causticroot/learning-csharp/blob/master/CodeWars/ValidParentheses/Program.cs)


## Learning

### Comandos do CLI (.NET Core)
* dotnet new console - cria um novo projeto '.csproj'
* dotnet run - compila e roda o projeto
* dotnet build - compila o projeto


### .NET framework
##### O dotnet framework consiste em 3 partes:
1. **CLR** - Responsável pela interface entre o código e o sistemas operacional.
2. **Classes do framework** - Todas as linguagens que usam a tecnologia dotnet usam as mesmas classes.
3. **ASP.NET** - Fornece o acesso direto a toda a linguagem VB.NET(VisualBasic) e/ou C# a partir de uma plataforma de scriptação.

##### Funcionamento:
* Todas as linguagens dotnet realizam o mesmo esquema de compilação, gerando um arquivo para a linguagem intermediária "**MSIL** (MicroSoft Intermediate Language)", chamado de Assenbly(.exe ou .dll).
* Namespace funciona como um pacote, com a função de agrupar funcionalidades comuns, visando a organização e evitando conflitos.
* ASP (Active Server Pages) permite  a construção de documentos da web que respondam a solicitações dos clientes
* Toda classe em C# é uma subclasse da classe **[Object](https://docs.microsoft.com/pt-br/dotnet/api/system.object?view=net-5.0)**.


### Conceitos:
* C# é uma linguagem fortemente tipada e semelhante ao java, originou-se do j++.
* C# é uma linguagem **type-safe**
* **Casting** é uma operação que força o compilador a realizar uma conversão.
* **String interpolation** é um literal de cadeia de caracteres que pode conter expressões de interpolação
* **foreach** pode ser usado para criar listas
* **.Sort()** serve para ordenar uma lista
* **NaN** significa Not a Number
* CultureInfo.InvariantCulture é útil quando a localidade do computador não reconhece o '.' de um valor double.
* O compilador sempre verifica se uma classe **[estática](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)** foi instânciada acidentalmente, o compilador garantirá que as instâncias dessa classe não possam ser criadas.
* As **[propriedades](https://docs.microsoft.com/pt-br/dotnet/csharp/properties)** são definições de métodos encapsulados, porém expondo uma sintaxe.
familiar à de atributos e não de métodos. As **[Propriedades autoimplementadas](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties)**.
tratam-se de uma forma simplificada de se declarar propriedades que não necessitam
de lógicas particulares para as operações get e set.
* [Nullable](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/nullable-value-types) é um recurso do c# que permite que  os dados de tipo valor recebam o valor **null**



### Stack x Heap

A **stack** possui um tamanho pequeno, entre 1Mb e 4Mb,  e isto é proposital. Somente alguns tipos primitivos  como, boolean, inteiros e as structs, são armazenados diretamente na memória stack, sendo o valor propriamente dito e não a referência a ele.

Todos os outros tipos, como por exemplo as classes (tipo referência), são armazenados na memória **heap**, que por sua vez possui um espaço de memória maior, porém, menos performance. Todos os objetos da memória heap são acessados por  referência, o que significa que  ao criar um objeto, o compilador não vai diretamente na memória heap procurar por ele,  mas sim na memória stack onde encontra-se uma referência para este mesmo objeto.

Os objetos que precisam ser armazenados na memória heap possuem um custo maior de performance em relação à memória stack, pois, esses objetos precisam ser coletados obrigatoriamente pelo [Garbage Collector](https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/). Sendo assim, o [CLR]() irá até a memória verificar se determinado objeto está sendo utilizado ou não, caso não esteja, o Garbage Collector irá destruí-lo para liberar espaço na memória. Em contrapartida, o Garbage Collector nunca vai até a memória stack. 



![stackxheap](https://1.bp.blogspot.com/-gKWUcwIKWWU/VvPtKUAIFjI/AAAAAAAAFRc/WLCqWfSxlZ4ioocmBuFS3KaRhzs0I13OA/w1200-h630-p-k-no-nu/Difference%2Bbetween%2Bstack%2Band%2Bheap%2Bmemory%2Bin%2BJava.gif)



### Tipo referência vs Tipo valor

**CLASSE (REFERÊNCIA)**   | **STRUCT (VALOR)**
------------------------- | --------------
Vantagem: usufrui de todos recursos OO | Vantagem: mais simples e performático
Variáveis são ponteiros | Variáveis são caixas
Objetos precisam ser instanciados usando 'new', ou apontar para um objeto já existente | Não é preciso instanciar usando 'new', mas é possível
Aceita valor null  | Não aceita valor null
Suporte a herança  | Não suporta herança mas pode implementar interfaces
(Y = X) Y passa a apontar para onde X aponta.  | (Y = X) Y recebe uma cópia de X.
Objetos instanciados no heap  | Objetos instanciados no stack
Objetos não utilizados são desalocados em um momento próximo pelo garbage collector  | "Objetos" são desalocados imediatamente quando seu escopo de execução é finalizado.

### Valores padrão
* Quando um tipo estruturado (classe, struct, array) é alocado, são atribuídos valores padrão aos seus elementos:
    * números: 0
    * bool: False
    * char: **carectere código 0**
    * objeto: **null**

### Structs

Uma variável de um tipo **struct** armazena diretamente os dados da estrutura, enquanto uma variável de tipo classe armazena uma referência a um objeto alocado na memória. Por esse motivo uma struct consome menos memória. Em vez de alocar dinamicamente um objeto no heap gerenciado e retornar uma referência a ele, um construtor  struct simplesmente retorna o próprio valor struct (normalmente em um local temporário na stack), e esse valor é copiado conforme necessário.

São úteis para pequenas estruturas de dados que possuem semântica de valor:  números complexos, pontos em um sistema  de coordenadas ou pares de chave-valor, por exemplo. É recomendável a definição de tipos de estrutura imutáveis.

### Enums

A classe enum fornece a classe base para enumerações e o método Enum.GetNames() que retorna um array de string? . Já o método  GetValues(), irá retornar um array de valores para cada item da enum.

> Em matemática e ciência da computação teórica, a enumeração é a repetição de diversas palavras seguidas de virgula.

### Interfaces

Uma interface define um contrato que pode ser implementado por classes não abstratas e structs, podendo conter métodos, propriedades, eventos e indexadores.

Uma classe não fornece herança como uma classe ou classe abstrata, ela só declara membros que uma classe de implementação  **precisa** implementar. Uma interface também não pode ser instanciada, mas pode ser referenciada pelo objeto da classe que a implementa, além disso, a referência da interface funciona como o objeto de referência  e se comporta como o objeto.  Uma interface pode ser herdada a partir de uma ou mais interfaces,  e uma interface também pode estender outra interface.

**Não podem** conter: constantes, construtores, variáveis de instância, destrutores, membros estáticos ou interfaces aninhadas. Os membro de uma interface não podem conter qualquer modificador de acesso, mesmo o público.

Implicitamente, cada membro de uma interface é público e abstrato, além disso, não é dada a permissão para especificar os membros de uma interface pública e abstratas  ou virtuais.



## Referências

* link

## Autor

* causticroot
