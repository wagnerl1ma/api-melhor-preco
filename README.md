# 🏷️ MelhorPreco

Projeto de monitoramento de preços com API REST em .NET, arquitetura escalável e integrações modernas.  
Foco em automação, notificações e arquitetura limpa.

## 📋 Sumário

- [Visão Geral](#visão-geral)
- [Funcionalidades](#funcionalidades)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Contribuição](#contribuição)
- [Licença](#licença)

---

## 🚀 Visão Geral

O **MelhorPreco** é uma solução backend para monitoramento de preços de produtos, oferecendo endpoints REST protegidos por JWT, notificações por e-mail e arquitetura baseada em microsserviços.

- Controle de histórico de preços
- Notificação automática ao identificar mudanças relevantes
- Estrutura extensível para integrações futuras (RabbitMQ, scraping avançado, etc.)

---

## 🛠️ Funcionalidades

- Cadastro e autenticação de usuários (JWT)
- Monitoramento e consulta de preços
- Histórico de alterações
- Notificação via SendGrid
- Retry inteligente com Polly
- Job scheduling com Hangfire
- Documentação automática com Swagger
- Logging estruturado
- Testes unitários e de integração

---

## 🏗️ Estrutura do Projeto

```text
MelhorPreco
│
├── MelhorPreco.Api         → API REST (.NET, Controllers, Swagger, Hangfire, JWT)
├── MelhorPreco.Business    → Serviços de Negócio (Monitoramento, Scraping, Notificação via SendGrid, Polly)
├── MelhorPreco.Data        → Persistência (DbContext, Repositórios, Models)
└── MelhorPreco.Tests       → Testes Automatizados (Unitários e Integração)
```

### Estrutura Detalhada

```text
MelhorPreco.Api
│   ├── Controllers           // Endpoints protegidos com JWT (cadastro, consulta, histórico, login)
│   ├── Configuração          // Swagger, Hangfire, Injeção de Dependências, JWT, Polly, Rate Limiting
│   └── Program.cs/Startup    // Bootstrap
MelhorPreco.Business
│   ├── Services              // Lógicas de monitoramento, scraping, notificações, Polly
│   └── DTOs                  // Objetos de transferência de dados
MelhorPreco.Data
│   ├── DbContext             // Contexto do EF Core
│   ├── Repositories          // Padrão repositório
│   └── Models                // Entidades do domínio
MelhorPreco.Tests
│   ├── Unit                  // Testes unitários
│   └── Integration           // Testes de integração
```

---

## 💻 Tecnologias Utilizadas

- [.NET 8+](https://dotnet.microsoft.com/)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/)
- [Hangfire](https://www.hangfire.io/)
- [SendGrid](https://sendgrid.com/)
- [Polly](https://github.com/App-vNext/Polly)
- [Swagger/OpenAPI](https://swagger.io/)
- [JWT Bearer Authentication](https://jwt.io/)
- [xUnit/NUnit](https://xunit.net/), [Moq](https://github.com/moq/moq4)
- [RabbitMQ (Planejado para o futuro)](https://www.rabbitmq.com/)

---

## 🤝 Contribuição

Pull Requests são bem-vindos!  
Abra uma issue para reportar bugs ou sugerir melhorias.

---

## 📜 Licença

Este projeto está licenciado sob a licença MIT.

```bash
# clonar repositório
git clone https://github.com/wagnerl1ma/api-melhor-preco.git
