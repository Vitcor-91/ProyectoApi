FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

COPY ["ProyectoApi.Api/ProyectoApi.Api.csproj", "ProyectoApi.Api/"]
COPY ["ProyectoApi.Application/ProyectoApi.Application.csproj", "ProyectoApi.Application/"]
COPY ["ProyectoApi.Domain/ProyectoApi.Domain.csproj", "ProyectoApi.Domain/"]
COPY ["ProyectoApi.Infrastructure/ProyectoApi.Infrastructure.csproj", "ProyectoApi.Infrastructure/"]

RUN dotnet restore "ProyectoApi.Api/ProyectoApi.Api.csproj"

COPY . .

WORKDIR "/src/ProyectoApi.Api"
RUN dotnet publish "ProyectoApi.Api.csproj" \
    -c Release \
    -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "ProyectoApi.Api.dll"]