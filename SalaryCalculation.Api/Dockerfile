#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY SalaryCalculation.Api/SalaryCalculation.Api.csproj SalaryCalculation.Api/
COPY SalaryCalculation.Business/SalaryCalculation.Business.csproj SalaryCalculation.Business/
COPY SalaryCalculation.Data/SalaryCalculation.Data.csproj SalaryCalculation.Data/
RUN dotnet restore "SalaryCalculation.Api/SalaryCalculation.Api.csproj"
COPY . .
WORKDIR "/src/SalaryCalculation.Api"
RUN dotnet build "SalaryCalculation.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SalaryCalculation.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SalaryCalculation.Api.dll"]
