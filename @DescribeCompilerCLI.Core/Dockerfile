#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DescribeCompilerCLI.Core/DescribeCompiler.CLI.Core.csproj", "DescribeCompilerCLI.Core/"]
COPY ["DescribeCompilerAPIStandard/DescribeCompiler.API.Standard.csproj", "DescribeCompilerAPIStandard/"]
COPY ["GoldParserEngineStandard/GoldParserEngine.Standard.csproj", "GoldParserEngineStandard/"]
RUN dotnet restore "DescribeCompilerCLI.Core/DescribeCompiler.CLI.Core.csproj"
COPY . .
WORKDIR "/src/DescribeCompilerCLI.Core"
RUN dotnet build "DescribeCompiler.CLI.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DescribeCompiler.CLI.Core.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DescribeCompiler.CLI.Core.dll"]