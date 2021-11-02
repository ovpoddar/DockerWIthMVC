# How TO DEPLOY THE APPLICATION WITH DOCKER

Download [Docker](https://www.docker.com/get-started) application from it's official website.  
Create a account on [Docker hub](https://hub.docker.com/).  
open terminal or Commend prompt on the Project's folder.  



## build the image inside the host computer:

Simplest way to build the docker image use this Commend.  
> docker build -t (preferable name for the container):(any version) .  

**Sample:**  
```console
docker build -t {some name} .
```

or

**Sample:**  
```console
docker-compose build
```

to generate the certificate

dotnet dev-certs https --clean

dotnet dev-certs https -ep ${HOME}/.aspnet/https/DockerWithMVC.pfx -p pa55w0rd!     

dotnet dev-certs https --trust


To deploy the app with https use this commend  

**Sample:**  
```console
docker-compose up
```