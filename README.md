Here is a simple REST Client talking to a stand along Server API all
written in DotNet Core 3.1.

It is loosely based on creating a simple REST Client, an tutorial from
Microsoft can give you the very basic features in DotNet Core\
\
[https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/console-webapiclient)

I created a simple Server API with one end point to return a password
with the version number and which machine it was generated on.

Initial Source can be found here under this tag:

[https://github.com/BryanAvery/REST-Client-Server-API/releases/tag/BasicClientServerAPI](https://github.com/BryanAvery/REST-Client-Server-API/releases/tag/BasicClientServerAPI)

Docker
------

Next stage is to containerise both applications

To build the ServerApi:

``` {.wp-block-code}
docker build -t password-api -f Docker/ServerApi/Dockerfile .
```

To run the ServerApi:

``` {.wp-block-code}
docker run -p 5001:5001 password-api
```

Like wise with the Web Api Client just replace the name with
web-api-client

docker-compose
--------------

Next I’ve generated the docker-compose.yml file to allow for a single
build to the environment.

It is as simple as running the single line to build everything for you

``` {.wp-block-code}
docker-compose -f Docker/docker-compose.yml up -d --build
```


