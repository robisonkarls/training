FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TrainingTests/TrainingTests.csproj", "TrainingTests/"]
RUN dotnet restore "TrainingTests/TrainingTests.csproj"
COPY . .
WORKDIR "/src/TrainingTests"
RUN dotnet build "TrainingTests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TrainingTests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrainingTests.dll"]
