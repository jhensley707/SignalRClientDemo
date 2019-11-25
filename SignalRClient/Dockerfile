FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["SignalRClient/SignalRClient.csproj", "SignalRClient/"]
RUN dotnet restore "SignalRClient/SignalRClient.csproj"
COPY . .
WORKDIR "/src/SignalRClient"
RUN dotnet build "SignalRClient.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SignalRClient.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SignalRClient.dll"]