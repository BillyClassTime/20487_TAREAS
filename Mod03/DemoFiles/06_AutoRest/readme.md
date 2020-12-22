## Module 3: Creating and Consuming ASP.NET Core Web APIs

### Lesson 5: Automatically Generating HTTP Requests and Responses

#### Demonstration: Testing HTTP requests with Swagger


Primero instalamos en la carpeta AutoRest.Host la útlima versión de autorest. __OJO cambia con respecto al marckdown!!!!!__  

__EJECUTA ESTO y no la VERSION DEL MARKDOWN__

Por eso ejecutamos estos dos comandos desde PowerShell  (no hace falta abrir como Administrador)
```bash
npm install -g autorest 

autorest --rest
``` 

![c1](imagenes/c1.PNG)



una vez instalado hacemos dotnet run para ver que funcione

![c2](imagenes/c2.PNG)


Para no ver temas de ssl ponemos en el navegador http://localhost:5000

Carga el Swagger  

![c3](imagenes/c3.PNG)


y tambien la api  

![c4](imagenes/c4.PNG)

y el json del swagger 

![c3b.PNG](imagenes/c3b.PNG)



bien dejamos el http://localhost:5000 funcionando y abrimos otro terminal y nos vamos al proyecto AutoRest.SDK y le ejecutamos un dotnet restore  


![c5](imagenes/c5.PNG)

Este proyecto no tiene nada más que AutoRest.Sdk.csproj

Bueno aqui tendremos dos opciones la larga y la corta, vamos a por la corta.


Verificamos que siga corriendo el server (http://localhost:5000) pues desde el Powershell ejecutamos el siguiete comando 

```bash
autorest --input-file="http://localhost:5000/swagger/v1/swagger.json" --csharp --namespace=AutoRest.Sdk
```


![c6](imagenes/c6.PNG)

El comando anterior genera la carpeta generated

![c7](imagenes/c7.PNG)

![c8](imagenes/c8.PNG)


Bien pues ahora sólo nos toca ir al AutoRest.Client

El contenido de estos ficheros es 

![c9](imagenes/c9.PNG)

Por lo que no debemos añadir nada,sólo ejecutar

![c10](imagenes/c10.PNG)


En caso de que tengamos errores por certificados bastaría con cerrar los exploradores y ejecutar

```bash
dotnet dev-certs https --trust
```

y añadir el siguiente Program del cliente en el Cliente 



```c#

..........

using System.Net.Http;

namespace AutoRest.Client
{
    class Program
    {
        static void Main(string[] args)
        {
    
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback =
            (sender, ClientCertificateOption, ContextMarshalException, sslPolicyErrors) =>{return true;};


            MyAPI client = new MyAPI(new Uri("http://localhost:5000"), clientHandler );
			
			..........


```




Con esto la práctica terminaría pero vamos a contar la larga....


Esta consite en generar el Yal a partir del json

1.- generar el json
Ejecutar desde el PowerShel el comando siguiente (ojo cmd no encuentra este comando , debe ser powershell)

```bash
iwr http://localhost:5000/swagger/v1/swagger.json -o webapi.json   
```


Esto nos crea el archivo webapi.json    desde http://localhost:5000/swagger/v1/swagger.json 

![c11](imagenes/c11.PNG)


Para convertir este fichero en Yal 

Abrimos la página https://editor.swagger.io/

![c12](imagenes/c12.PNG)

Cargariamos el fichero json


![c13](imagenes/c13.PNG)

![c14](imagenes/c14.PNG)


Salvariamos el fichero como Yaml 


![c15](imagenes/c15.PNG)




Lo baja en descargas por lo que copiaríamos a nuestra carpeta

![c16](imagenes/c16.PNG)


![c17](imagenes/c17.PNG)

y ejecutaríamos 

```bash
autorest --input-file="http://localhost:5000/swagger/v1/swagger.json" --csharp --namespace=AutoRest.Sdk
```

para llegar al mismo sitio.

( lo pongo para recordar el comando irw y la página https://editor.swagger.io/ que no las conociía)






