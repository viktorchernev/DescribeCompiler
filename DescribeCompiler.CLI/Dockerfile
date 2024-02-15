#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DescribeCompiler.CLI/DescribeCompiler.CLI.csproj", "DescribeCompiler.CLI/"]
COPY ["DescribeCompiler.API/DescribeCompiler.API.csproj", "DescribeCompiler.API/"]
COPY ["GoldParserEngine/GoldParserEngine.csproj", "GoldParserEngine/"]
RUN dotnet restore "DescribeCompiler.CLI/DescribeCompiler.CLI.csproj"
COPY . .
WORKDIR "/src/DescribeCompiler.CLI"
RUN dotnet build "DescribeCompiler.CLI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DescribeCompiler.CLI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DescribeCompiler.CLI.dll"]