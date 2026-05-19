# 1. Etapa de Construcción (SDK)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiamos el archivo de proyecto y restauramos las dependencias
COPY ["StickersWebApp.csproj", "./"]
RUN dotnet restore "StickersWebApp.csproj"

# Copiamos todo el código fuente
COPY . .

# Compilamos y publicamos la aplicación en modo Release
RUN dotnet publish "StickersWebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

# 2. Etapa de Ejecución (Runtime) - Imagen más ligera para producción
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copiamos los archivos compilados desde la etapa anterior
COPY --from=build /app/publish .

# Cloud Run usa por defecto el puerto 8080, que es también el default en .NET 8
EXPOSE 8080

# Punto de entrada de la aplicación
ENTRYPOINT ["dotnet", "StickersWebApp.dll"]
