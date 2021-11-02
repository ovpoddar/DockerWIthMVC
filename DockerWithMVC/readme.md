# How TO DEPLOY THE APPLICATION WITH DOCKER

Download [Docker](https://www.docker.com/get-started) application from it's official website.  
Create a account on [Docker hub](https://hub.docker.com/).  
open terminal or Commend prompt on the Project's folder.  



## build the image inside the host computer:

Simplest way to build the docker image use this Commend.  
> docker build -t (preferable name for the container):(any version) .  

**Sample:**  
```console
docker build -t dockerwithmvc .
```

or

**Sample:**  
```console
docker-compose build
```

## Configure https:

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



## To deploy the app with https use this commend:  

**Sample:**  
```console
docker-compose up
```