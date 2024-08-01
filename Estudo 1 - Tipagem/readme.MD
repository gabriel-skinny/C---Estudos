Referencia: https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/

Definição: Marca para o compilador o tipo de dado que uma variável pode receber

Usos:
- O espaço de armazenamento que uma variável do tipo requer.
- Os valores mínimo e máximo que ele pode representar.
- Os membros (métodos, campos, eventos e etc.) que ele contém.
- O tipo base do qual ele herda.
- A interface implementada.
- Os tipos de operações que são permitidos.

Conceitos do C#:
- Um Tipo: Um plano estrutura de dados que encapsula um conjunto de dados e os comportamentos que são uma unidade lógica. Definidos por Classe ou Struct
- Instanciação de um Tipo: Cria na memória, baseado no tipo mapeado, os dados em tempo de execução.

- Herança: Todos os tipos herdam uma herança de seus tipos base (Ex: object => string)
- CTS(Common-Type-System): Todos os tipos tem por seu tipo base o System.Object. E os seus tipos são divididos em tipo_valor e tipo_referencia
- Tipo de valor: 
    - Cria um novo registro de valor na memoria. 
    - Todos os tipos definidos com Struct (Ex: int, string, ..etc).
    - São usados para valores pequenos 
    - Não há nenhuma alocação de heap separada ou sobrecarga de coleta de lixo
    - Não podem criar heranças
- Tipo de Referencia: 
    - Cria uma referencia na memória que representa aquele conjunto de dados. 
    - Todos os tipos definidos com Class ou Record
    - Usado para encapsular grandes estrutura de dados e para modificar dados já criados 

- Conversão boxin

