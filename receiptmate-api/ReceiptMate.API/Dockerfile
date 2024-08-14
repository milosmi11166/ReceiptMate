FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ReceiptMate.API/ReceiptMate.API.csproj", "ReceiptMate.API/"]
RUN dotnet restore "ReceiptMate.API/ReceiptMate.API.csproj"
COPY . .
WORKDIR "/src/ReceiptMate.API"
RUN dotnet build "ReceiptMate.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ReceiptMate.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ReceiptMate.API.dll"]