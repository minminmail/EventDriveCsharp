step one:

dotnet new classlib --name EventTower.Messages -f netcoreapp3.1

step two:

dotnet new classlib --name EventTower -f netcoreapp3.1

step three:

dotnet add package RabbitMQ.Client
dotnet add package Polly