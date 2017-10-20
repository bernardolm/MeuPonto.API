#FROM microsoft/aspnetcore-build
#EXPOSE 4321
#WORKDIR /app
#COPY . .
#RUN dotnet restore
#ENTRYPOINT ["dotnet", "run"]

####################################################

#FROM microsoft/dotnet:sdk AS build-env
#WORKDIR /app

# copy csproj and restore as distinct layers
#COPY *.csproj ./
#RUN dotnet restore

# copy everything else and build
#COPY . ./
#RUN dotnet publish -c Release -o out

# build runtime image
#FROM microsoft/dotnet:runtime
#WORKDIR /app
#COPY --from=build-env /app/out ./
#ENTRYPOINT ["dotnet", "dotnetapp.dll"]

####################################################

FROM mono
WORKDIR /app

# Instalar a feature do IIS
RUN Add-WindowsFeature Web-server, NET-Framework-45-ASPNET, Web-Asp-Net45
RUN Enable-WindowsOptionalFeature -Online -FeatureName IIS-ApplicationDevelopment,IIS-ASPNET45,IIS-BasicAuthentication...

# Adicionar o site mvc no IIS
#COPY aspnet-mvc /websites/aspnet-mvc
#RUN New-Website -Name 'aspnet-mvc' -PhysicalPath "C:\websites\aspnet-mvc" -Port 8081 -Force
#EXPOSE 8081

# Adicionar o site webapi no IIS
COPY aspnet-webapi /websites/aspnet-webapi
RUN New-Website -Name 'aspnet-webapi' -PhysicalPath "C:\websites\aspnet-webapi" -Port 8082 -Force
EXPOSE 8082

