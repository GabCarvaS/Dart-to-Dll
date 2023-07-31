# Dart to Dll

## Descrição

Este repositório contém uma prova de conceito (POC) que demonstra o processo de criação de uma Dynamic Link Library (DLL) usando como base um código escrito em Dart. O objetivo principal dessa POC é mostrar como é possível utilizar um código Dart em uma biblioteca compartilhada (DLL) que pode ser utilizada em outros projetos.

## Funcionamento

Compilação do Código Dart: Inicialmente, o código Dart é compilado e transformado em um executável independente. Isso pode ser realizado usando o compilador Dart padrão ou outra ferramenta de compilação apropriada.

Integração com C#: Em seguida, um programa C# é desenvolvido para incorporar o executável Dart gerado na etapa anterior. O programa C# é responsável por chamar o executável Dart e capturar sua saída.

Transformação em DLL: Após confirmar que a solução atende aos requisitos do projeto, o programa C# pode ser transformado em uma DLL para ser utilizada em outros projetos C# como uma biblioteca.

## Pontos de Atenção

Desempenho: A abordagem de execução externa do código Dart pode impactar o desempenho, principalmente se a comunicação com o executável for frequente ou exigir muita interação.

Dependências: A solução introduz uma dependência externa ao executável Dart, o que requer garantir que o mesmo esteja presente e acessível no ambiente de execução do programa C#.

Comunicação: A comunicação entre os programas C# e Dart pode ser mais complexa de gerenciar do que se estivesse lidando diretamente com uma DLL.

Manutenção: Qualquer alteração no código Dart exigirá a recompilação do executável e a atualização do programa C# correspondente.

## Considerações Finais

Esta solução pode ser adequada para projetos específicos que demandam a incorporação de código Dart em um ambiente C#. No entanto, é importante avaliar cuidadosamente os pontos de atenção mencionados e considerar outras alternativas antes de decidir pela implementação desta solução. A escolha deve ser baseada nos requisitos, desempenho esperado e necessidades de manutenção do projeto em questão

## Desenvolvedor

| [<img src="https://avatars.githubusercontent.com/u/58979991?v=4" width=115><br><sub>Gabriel Carvalho</sub>](https://github.com/GabCarvaS) |
| :---------------------------------------------------------------------------------------------------------------------------------------:
