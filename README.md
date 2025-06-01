# 🏷️ MelhorPreco

Projeto de monitoramento de preços com API REST em .NET, arquitetura escalável e integrações modernas.  
Foco em automação, notificações e arquitetura limpa.

## 📋 Sumário

- [Visão Geral](#visão-geral)
- [Funcionalidades](#funcionalidades)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Como Executar](#como-executar)
- [Checklist e Boas Práticas](#checklist-e-boas-práticas)
- [Melhorias Futuras](#melhorias-futuras)
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

## ▶️ Como Executar

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/seu-usuario/MelhorPreco.git
   ```

2. **Configure as variáveis de ambiente** no arquivo `appsettings.Development.json`  
   (SendGrid, ConnectionString, JWT, etc.)

3. **Execute as migrações do banco:**
   ```bash
   dotnet ef database update --project MelhorPreco.Data
   ```

4. **Inicie a aplicação:**
   ```bash
   dotnet run --project MelhorPreco.Api
   ```

5. **Acesse a documentação via Swagger:**  
   `https://localhost:5001/swagger`

---

## ☑️ Checklist e Boas Práticas

- [x] API RESTful documentada e protegida por JWT
- [x] Notificações via SendGrid
- [x] Retry inteligente e resiliência com Polly
- [x] Jobs agendados com Hangfire
- [x] Logging estruturado
- [x] Testes automatizados
- [x] Fluxo de scraping desacoplado (pronto para escalar)
- [ ] Integração com RabbitMQ (backlog)
- [ ] Scraping avançado (backlog)
- [ ] Front-end (backlog)

---

## 🔎 Melhorias Futuras

- Adicionar cache distribuído (Redis)
- Dashboard para acompanhamento de status dos jobs
- Módulo de scraping com estratégias customizáveis
- Monitoramento com Prometheus + Grafana
- Integração com outros canais de notificação

---

## 🤝 Contribuição

Pull Requests são bem-vindos!  
Abra uma issue para reportar bugs ou sugerir melhorias.

---

## 📜 Licença

Este projeto está licenciado sob a licença MIT.

---
