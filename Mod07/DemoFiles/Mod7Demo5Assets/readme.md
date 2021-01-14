## Module 7: Implementing data storage in Azure

### Lesson 4: Geographically Distributing Data with Azure CDN

#### Demonstration: Configuring a CDN Endpoint for a Static Website


Lo primero de todo es verificar si tenemos el servicio de CDN registrado para nuestra suscripción y si no lo registramos (subscripcion + Proveedores de recursos)

![Registrar CDN](imagenes/h2.PNG)


creamos una cuenta de almacenamiento con la siguiente configuracion

![h1](imagenes/h3.PNG)

Una vez creada vamos al recurso y habilitamos el sitio web estático

![h1](imagenes/h5.PNG)

Al guaradar verás que ha creado un contenedor $web, puedes acceder a él desde allí o directamente a través de contenedores

![h1](imagenes/h6.PNG)

Cargamos las imagenes y la página index.html que tenemos en C:\20487_TAREAS\Mod07\DemoFiles\Mod7Demo5Assets

y lo probamos desde el punto de conexíon princial que la pantalla de sitio web estatico

![h1](imagenes/h7.PNG)

![h1](imagenes/h8.PNG)


Bueno pues ahora creamos el CDN

![h1](imagenes/h9.PNG)

Con la siguiente configuración

![h10](imagenes/h10.PNG)

y ya tenemos cargado el CDN

![c1](imagenes/c1.PNG)

Puedes comprobar , despues de cargarla, el valor del atributo x-cache: TCP_HIT

![c2](imagenes/c2.PNG)

