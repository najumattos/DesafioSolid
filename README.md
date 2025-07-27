# Desafio SOLID - Trilha Backend FDEVS

Este repositório documenta um desafio de programação focado nos princípios SOLID (Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, Dependency Inversion). Para cada princípio, apresento um exemplo de violação e a respectiva correção, demonstrando a aplicação das boas práticas de design de software.

## Princípios SOLID Abordados

### S - Single Responsibility Principle (SRP)

* **Violação:** Um método que inicialmente violava o princípio por ter duas responsabilidades: `CalcularClassificarIMC()`.
* **Correção:** O método foi refatorado para que cada responsabilidade (cálculo e classificação) seja tratada separadamente, garantindo que a classe tenha apenas um motivo para mudar.

### O - Open/Closed Principle (OCP)

* **Violação:** A classe `Restaurante` recebia inicialmente uma função, mas quando mais funções eram atribuídas, era preciso modificar o método existente, violando o princípio.
* **Correção:** A estrutura foi ajustada para que novas funcionalidades possam ser adicionadas por extensão (criando novas implementações de interfaces), sem a necessidade de modificar o código já existente.

### L - Liskov Substitution Principle (LSP)

* **Violação:** Inicialmente, todas as funções de funcionários estavam contidas em uma única interface `IFuncionario`. Isso gerou problemas quando subclasses como `Vendedor` não podiam executar todos os métodos herdados, tornando-o inapto para substituir sua classe pai de forma consistente.
* **Correção:** A interface `IFuncionario` foi segregada em interfaces menores e mais específicas, permitindo que cada tipo de funcionário implemente apenas as capacidades que realmente possui, garantindo a substituibilidade adequada.

### I - Interface Segregation Principle (ISP)

* **Violação:** Nesse exemplo, o princípio era violado pois a classe `Vendedora` era obrigada a depender de métodos contidos em uma interface `IFuncionario` genérica que ela não utilizava.
* **Correção:** A interface `IFuncionario` foi dividida em interfaces mais coesas (ex: `IVender`), para que a `Vendedora` implemente apenas os métodos relevantes para sua função, evitando dependências desnecessárias.

### D - Dependency Inversion Principle (DIP)

* **Violação:** Nesse exemplo, a classe `ProjetoCasa` implementava `EletrecistaAna` diretamente, criando um acoplamento forte com uma implementação concreta, em vez de usar um "contrato" (abstração) entre eles.
* **Correção:** `ProjetoCasa` agora depende de uma abstração (`IEletrecista`), e as implementações concretas (`EletrecistaAna`, `EletrecistaJulia`) dependem dessa mesma abstração, invertendo a direção da dependência e aumentando a flexibilidade.

## Como Visualizar os Exemplos

Cada princípio possui uma pasta ou arquivo correspondente que demonstra a violação e a correção em código em C#. Você pode navegar pelos arquivos para entender as implementações.

## Uso de Inteligência Artificial
Foi utilizado como um assistente interativo para aprimorar o entendimento dos princípios SOLID e refinar a estrutura desse ´README´ 
