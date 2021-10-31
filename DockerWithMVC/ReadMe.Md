To build the image

docker build -t dockerwithmvc:dev .

to run the project

docker run -it --rm -p 5000:80/tcp dockerwithmvc:dev



to run it with https

Configuring a certificate to support HTTPS in Docker
dotnet dev-certs https --check --verbose
dotnet dev-certs https --clean
dotnet dev-certs https --check --verbose

Now we’ll create a new certificate (with a password of your choosing) and check that the certificate was created successfully.

dotnet dev-certs https -ep ${HOME}/.aspnet/https/core5-website.pfx -p your_password_here
dotnet dev-certs https --trust
dotnet dev-certs https --check --verbose

to run
docker run --rm -it -p 8000:80 -p 8001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password="pa55w0rd!" -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/core5-website.pfx -v ${HOME}/.aspnet/https:/https/ dockerwithmvc:vscode