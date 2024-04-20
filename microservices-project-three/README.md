# .NET Microservices Project Three

This Project is from the [.NET Microservices](https://www.youtube.com/watch?v=DgVjEo3OGBI).
It will include two services `Platform service` and `Command service`.

> This Microservice projects is mostly focused on the `docker`, `k8s`. <br/>

> For now, InMemo DB is used for both services.

## Tech Stacks

-   MySql
-   Docker
-   Kubernetes
-   gRPC
-   RabbitMQ

## Solution Architecture

![Solution Architecture](examples/solution-architecture.png)

## Platform service Architecture

![Platform service Architecture](examples/platform-service-architecture.png)

## Kubernetes Architecture

![Kubernetes Architecture](examples/kubernetes-architecture.png)

## Command service Architecture

![Command service Architecture](examples/command-service-architecture.png)

## Synchronous Messaging

![Synchronous Messaging](examples/synchronous-messaging.png)

## Asynchronous Messaging

![Asynchronous Messaging](examples/asynchronous-messaging.png)

## Message Bus

![Asynchronous Messaging](examples/message-bus.png)

## RabbitMQ Topic Exchange

![RabbitMQ Topic Exchange](examples/rabbitmq-topic-exchange.png)

## gRPC

![gRPC](examples/grpc.png)

## Commands

-   [Commands Here](./Commands.md)

### Deployed NodePort Services

**Platforms Service (replace with your NodePort)**

> http://localhost:32208/swagger/index.html <br/>

**Platforms Service (replace with your NodePort)**

> http://localhost:32136/swagger/index.html <br/>

**RabbitMQ**

> http://localhost:15672/
