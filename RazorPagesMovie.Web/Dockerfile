FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RazorPagesMovie.Web/RazorPagesMovie.Web.csproj", "RazorPagesMovie.Web/"]
RUN dotnet restore "RazorPagesMovie.Web/RazorPagesMovie.Web.csproj"
COPY . .
WORKDIR "/src/RazorPagesMovie.Web"
RUN dotnet build "RazorPagesMovie.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RazorPagesMovie.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RazorPagesMovie.Web.dll"]
