# LHFD .NET Clean Architecture Template

Template de projeto para **.NET 10.0** estruturado sob os princípios da **Clean Architecture**, com implementação nativa dos padrões **Repository** e **Unit of Work (UoW)** integrados ao Entity Framework Core.

## 🎯 Objetivo

Fornecer uma base sólida e desacoplada para APIs Web, eliminando o *boilerplate* inicial e garantindo consistência transacional, manutenibilidade e separação clara de responsabilidades desde o primeiro commit.

## 🛠️ O que está Implementado

- **Padrão Repository & Unit of Work:** Abstração completa da camada de dados. O `Unit of Work` centraliza o gerenciamento de transações e garante a consistência das operações de escrita (SaveChanges unificado), enquanto os repositórios encapsulam as consultas.
- **Estrutura em Camadas Desacopladas:**
  - `Domain`: Entidades de negócio puras, objetos de valor e contratos de repositório.
  - `Application`: Casos de uso, DTOs e regras de negócio orquestradas.
  - `Infrastructure`: Implementação do EF Core, mapeamentos, contextos de banco de dados, repositórios concretos e o padrão UoW.
  - `API`: Endpoints otimizados, injeção de dependência e tratamento global de exceções.
- **Base CRUD Pronta:** Operações essenciais estruturadas aplicando os padrões arquiteturais da solução.

## 🚀 Instalação

Instale o pacote globalmente via CLI do .NET:

```bash
dotnet new install LHFD.CleanArch.Template