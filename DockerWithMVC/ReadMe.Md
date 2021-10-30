To build the image

docker build -t dockerwithmvc:dev .

to run the project

docker run -it --rm -p 5000:80/tcp dockerwithmvc:dev