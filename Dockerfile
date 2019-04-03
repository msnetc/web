FROM microsoft/dotnet:2.1-aspnetcore-runtime
COPY src /app
WORKDIR /app
#COPY --from=build-env /app/MyApp/out .
ENV ASPNETCORE_URLS http://*:5000
ENTRYPOINT ["dotnet", "MyApp.dll"]
