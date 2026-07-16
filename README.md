# Sistema E-Commerce Modular - .NET 8 & Oracle DB

Este proyecto es una solución modular para un sistema de comercio electrónico basado en los principios de **Clean Architecture** (Arquitectura Limpia). Utiliza **.NET 8** para el desarrollo del ecosistema y **Oracle Database** como motor de persistencia relacional para asegurar transaccionalidad y robustez empresarial.

Actualmente, el proyecto cuenta con la conexión de base de datos totalmente operativa y el flujo completo de lectura de clientes desplegado desde el almacenamiento hasta la interfaz de usuario.

# Arquitectura

La solución está organizada como un **Monolito Modular**, donde cada módulo mantiene separadas sus responsabilidades de negocio.

```
Solution
│
├── Api
├── Blazor
├── Shared
│   ├── Persistence
│   ├── DependencyInjection
│   └── AppDbContext
│
├── Module.Customers
│   ├── Application
│   ├── Domain
│   └── Infrastructure
│
├── Module.Products
│   ├── Application
│   ├── Domain
│   └── Infrastructure
│
├── Module.Orders
│   ├── Application
│   ├── Domain
│   └── Infrastructure
│
└── Tests
```

---

# Decisiones de Diseño

- Arquitectura basada en Monolito Modular.
- Separación de responsabilidades mediante Clean Architecture.
- Cada módulo posee su propio Domain, Application e Infrastructure.
- Se utiliza un único `AppDbContext` compartido para simplificar la infraestructura del ejercicio.
- Entity Framework Core se utiliza como ORM para Oracle.
- Las entidades se encuentran aisladas por módulo.
- Las relaciones entre módulos se realizan mediante identificadores (Ids), evitando dependencias directas entre entidades.

---

# Estado actual

## Implementado

- Estructura completa de la solución.
- Organización modular.
- Clean Architecture por módulo.
- Entidades de dominio.
- Persistencia con Entity Framework Core.
- Configuración de Oracle.
- Docker Compose para Oracle, Redis y RabbitMQ.
- Script SQL para creación de tablas.

## Pendiente

- Endpoints REST.
- Implementación de Repositorios.
- Casos de uso (Application).
- Integración con RabbitMQ.
- Integración con Redis.
- Blazor Server.
- Logging estructurado.
- Pruebas unitarias.
- Health Checks.

---

# Base de Datos

Oracle XE ejecutándose mediante Docker.

La aplicación utiliza Entity Framework Core para acceder a la base de datos.

---

# Infraestructura

Servicios disponibles mediante Docker Compose:

- Oracle XE
- Redis
- RabbitMQ Management

Levantar toda la infraestructura:

```bash
docker compose up -d
```

Detenerla:

```bash
docker compose down
```

---

# Próximas mejoras

- Publicación del evento `OrderCreated` mediante RabbitMQ.
- Consumidor utilizando `BackgroundService`.
- Cache de consultas mediante Redis.
- Health Checks.
- Reintentos utilizando Polly.
- Dead Letter Queue.
- Logging estructurado.

---

# Autor

Desarrollado como solución para una prueba técnica utilizando .NET 8, Blazor Server y Oracle siguiendo una arquitectura de Monolito Modular.

PR: Agregado toda la funcionalidad para cliente hasta el blazor, pude crear las interfaces y las clases necesarias para cada entidad, cree un usuario nuevo llamado ecommerce y las respectivas tablas, conecte la base de datos con el proyecto sin problemas y cada uno con las acciones que estime pertinente para completar el trabajo, no pude agregar REDIS ni RabbitMQ.