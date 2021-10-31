To build the image

docker build -t dockerwithmvc:vscode .

to run the project

docker run -it --rm -p 5000:80/tcp dockerwithmvc:vscode



to run it with https

Configuring a certificate to support HTTPS in Docker
dotnet dev-certs https --check --verbose
dotnet dev-certs https --clean
dotnet dev-certs https --check --verbose

Now we’ll create a new certificate (with a password of your choosing) and check that the certificate was created successfully.

dotnet dev-certs https -ep ${HOME}/.aspnet/https/{any name.pfx} -p {your_password_here}
dotnet dev-certs https --trust
dotnet dev-certs https --check --verbose

to run
docker run --rm -it -p 8000:80 -p 8001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password={password which set earlier} -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/{name which set earlier}.pfx -v ${HOME}/.aspnet/https:/https/ dockerwithmvc:vscode