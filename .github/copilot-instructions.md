# Copilot Instructions for lab-nunit

## Visão Geral do Projeto
Este repositório é uma solução .NET composta por dois projetos principais:
- `App.Core`: Contém a lógica de negócio principal, como a classe `Calculadora`.
- `App.Tests`: Projeto de testes unitários utilizando NUnit para validar o comportamento do `App.Core`.

## Estrutura e Fluxo
- Cada projeto possui seu próprio arquivo `.csproj`.
- O fluxo típico é: implementar funcionalidades em `App.Core` e validar com testes em `App.Tests`.
- Os binários e arquivos intermediários são gerados nas pastas `bin/` e `obj/` de cada projeto.

## Convenções Específicas
- Os testes ficam em `App.Tests`, geralmente com nomes de arquivos e métodos que refletem a funcionalidade testada.
- O padrão de nomenclatura para testes segue: `NomeDaClasseTestada_MetodoComportamento_Esperado`.
- Utilize namespaces consistentes entre projetos para facilitar o uso de `using` e evitar conflitos.

## Workflows de Desenvolvimento
- **Build:** Use o comando `dotnet build LabNUnit.sln` na raiz para compilar todos os projetos.
- **Testes:** Execute `dotnet test LabNUnit.sln` para rodar todos os testes unitários.
- **Debug:** O Visual Studio e o VS Code suportam depuração integrada para projetos .NET.

## Integração e Dependências
- Não há dependências externas além do .NET e do NUnit (gerenciado via NuGet nos `.csproj`).
- Para adicionar novas dependências, edite o arquivo `.csproj` correspondente e use `dotnet add package`.

## Exemplos de Padrões
- Implementações de lógica ficam em `App.Core/Calculadora.cs`.
- Testes para essa lógica ficam em `App.Tests/UnitTest1.cs` (ou arquivos nomeados conforme a funcionalidade testada).

## Dicas para Agentes AI
- Sempre mantenha a separação entre código de produção (`App.Core`) e testes (`App.Tests`).
- Siga o padrão de nomenclatura de métodos de teste para clareza e integração com ferramentas de CI.
- Atualize os testes ao modificar a lógica de negócio.
- Consulte os arquivos `.csproj` para entender as dependências e configurações de build.

---

Seções incompletas ou dúvidas? Solicite exemplos de padrões de teste, integração ou fluxos de build específicos deste projeto.