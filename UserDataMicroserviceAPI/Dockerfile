FROM microsoft/dotnet:2.2-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk-stretch AS build
WORKDIR /src
COPY ["UserDataMicroserviceAPI/UserDataMicroserviceAPI.csproj", "UserDataMicroserviceAPI/"]
RUN dotnet restore "UserDataMicroserviceAPI/UserDataMicroserviceAPI.csproj"
COPY . .
WORKDIR "/src/UserDataMicroserviceAPI"
RUN dotnet build "UserDataMicroserviceAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "UserDataMicroserviceAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "UserDataMicroserviceAPI.dll"]