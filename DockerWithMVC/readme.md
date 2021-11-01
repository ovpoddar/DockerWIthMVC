to build the image 

docker-compose build

or

docker build -t {some name} .

to generate the certificate

dotnet dev-certs https --clean

dotnet dev-certs https -ep ${HOME}/.aspnet/https/DockerWithMVC.pfx -p pa55w0rd!     

dotnet dev-certs https --trust


to run the image 

docker-compose up