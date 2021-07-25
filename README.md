Injeção de Dependência Singleton, Scoped e Transient Como utilizar a melhor estratégia com C# .Net

# dotnetcore_dependency_injection
C# .Net Core Depency Injection

Falando de injeção de dependencias.
  
- Singleton objeto unico pra toda aplicação, atua no contexto da aplicação.
- Scoped é do contexto da requisição apenas
- Transient, independente, sempre que chamar um objeto ele trará um novo objeto, que é o inverso do singleton.

Singleton: https://docs.microsoft.com/pt-br/dotnet/api/microsoft.extensions.dependencyinjection.servicecollectionserviceextensions.addsingleton?view=dotnet-plat-ext-3.1
Scoped: https://docs.microsoft.com/pt-br/dotnet/api/microsoft.extensions.dependencyinjection.servicecollectionserviceextensions.addscoped?view=dotnet-plat-ext-3.1
Transient: https://docs.microsoft.com/pt-br/dotnet/api/microsoft.extensions.dependencyinjection.servicecollectionserviceextensions.addtransient?view=dotnet-plat-ext-3.1


#### Link para o vídeo deste exemplo:
https://bit.ly/2FpkDUF
https://www.youtube.com/watch?v=5Q58pBL1ZFM
