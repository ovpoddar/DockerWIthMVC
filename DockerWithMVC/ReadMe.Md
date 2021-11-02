# How TO DEPLOY THE APPLICATION WITH DOCKER

Download [Docker](https://www.docker.com/get-started) application from it's official website.  
Create a account on [Docker hub](https://hub.docker.com/).  
open terminal or Commend prompt on the Project's folder.  

## build the image inside the host computer:

Simplest way to build the docker image use this Commend.  
> docker build -t (preferable name for the container):(any version) .  

**Sample:**  
```console
docker build -t dockerwithmvc:vscode .
```  

## Deploy the app without https configured:  

After creation, To deploy the image use this Commend.  

> docker run -it --rm -p (preferable port to run):80/tcp (name for the container):(version).  
**Sample:**  
```console
docker run -it --rm -p 5000:80/tcp dockerwithmvc:vscode
```  

## Deploy the app with https configured:

Configuring a certificate to support HTTPS in Docker  

- The first step is to remove an existing self-signed certificate if there is one.  

**Sample:**  
```console
dotnet dev-certs https --clean
```  

- To verify for any existing certificate   

**Sample:**  
```console
dotnet dev-certs https --check --verbose
```  

- Now we’ll create a new certificate (with a password of your choosing) and check that the certificate was created successfully.

> dotnet dev-certs https -ep ${HOME}/.aspnet/https/{any name}.pfx -p {your_password_here}  
> dotnet dev-certs https --trust  
> dotnet dev-certs https --check --verbose  

**Sample:**  
```console
dotnet dev-certs https -ep ${HOME}/.aspnet/https/dockerwithmvc.pfx -p pa55w0rd!.
dotnet dev-certs https --trust
dotnet dev-certs https --check --verbose
```  

To deploy the app with https use this commend  
> docker run --rm -it -p 8000:80 -p 8001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password={password which set earlier} -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/{name which set earlier}.pfx -v ${HOME}/.aspnet/https:/https/ {name that you set during the build}  


**Sample:**  
```console
docker run --rm -it -p 8000:80 -p 8001:443 -e ASPNETCORE_URLS="https://+;http://+" -e ASPNETCORE_HTTPS_PORT=8001 -e ASPNETCORE_Kestrel__Certificates__Default__Password=pa55w0rd!. -e ASPNETCORE_Kestrel__Certificates__Default__Path=/https/dockerwithmvc.pfx -v ${HOME}/.aspnet/https:/https/ dockerwithmvc:vscode
```