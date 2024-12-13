FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:35792ea4ad1db051981f62b313f1be3b46b1f45cadbaa3c288cd0d3056eefb83 AS base

WORKDIR /app

COPY ./src ./src
COPY ./tests ./tests
COPY *.sln .

FROM base AS test
RUN dotnet test

FROM base AS publish
RUN dotnet clean ./src/ChatApp --output ./bin
RUN dotnet publish ./src/ChatApp --configuration Release --output ./bin
WORKDIR /app/bin
ENTRYPOINT ["dotnet", "ChatApp.dll"]
