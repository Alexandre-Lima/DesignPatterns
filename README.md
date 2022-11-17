# DesignPatterns
Projeto a fim de experimento com Design Patterns

________________________________________________________________

# Singleton

Um singleton é uma classe que permite que apenas uma única instância de si seja criada e, geralmente, fornece acesso simples a essa instância.


1 - Um único construtor, que é privado e sem parâmetros ( Isso impede que outras classes o instanciem);
2 - A classe é Sealed ou selada. ( Isso não seria necessário mas pode ajudar o JIT (Just-In-Time) a otimizar o código);
3 - Uma variável estática que contém uma referência à instância única criada, se houver;
4 - Um meio estático público de obter a referência para a única instância criada, criando uma, se necessário;