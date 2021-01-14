## Module 5: Hosting Services On-Premises and in Azure

### Lesson 4: Implementing Serverless Services

#### Demonstration: HTTP-triggered Azure Function



en azure nos creamos una app function

![c1](imagenes/c1.PNG)

con la siguiente configuración

![c1](imagenes/c2.PNG)


una vez creada la app funcion (que es un contenedor de funciones) le agregamos una nueva funcion plantilla HTTPtigger

![c1](imagenes/c3.PNG)


y ya estaría creada

![c1](imagenes/c4.PNG)


Podemos obtener su url

![c1](imagenes/c5.PNG)

y probarla

https://aapfuncion0505.azurewebsites.net/api/HttpTrigger1?code=vP1mgB8LYYgwBsXyxe8Akg8a1YQwvlrC/maAmoRtVDwDvmt1M8AUDw==&name=juan

![c1](imagenes/c6.PNG)


![c1](imagenes/c7.PNG)


----

####  Demostración: desarrollo, prueba y publicación de una función de Azure desde la CLI


creamos un nuevo app function

![c1](imagenes/c8.PNG)


ahora vamos a utilizar las azure functions

https://www.npmjs.com/package/azure-functions-core-tools


ejecutamos func init MyAzureFunctionProj -n --worker-runtime dotnet para crear el proyecto

![c1](imagenes/c9.PNG)


con func new --language C# --template "HttpTrigger" --name MyAzureFunc creamos una nueva funcion


![c1](imagenes/c10.PNG)


nos crea una funcion similar a la creada en azure functions

![c1](imagenes/c11.PNG)


Para ejecutarla en local ejecutamos func host start --build


![c1](imagenes/c12.PNG)


y tenemos una salida similar a la que teniamos en azure functions pero en local.
![c1](imagenes/c13.PNG)


Hemos creado una funcion en local hemos visto que funciona....Ahora vamos a desplegar en azure, en este caso con AZURE CLI


![c14](imagenes/c14.PNG)


![c14](imagenes/c15.PNG)
