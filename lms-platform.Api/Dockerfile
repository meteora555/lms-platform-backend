FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["lms-platform/lms-platform.csproj", "lms-platform/"]
RUN dotnet restore "lms-platform/lms-platform.csproj"
COPY . .
WORKDIR "/src/lms-platform"
RUN dotnet build "lms-platform.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "lms-platform.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lms-platform.dll"]
