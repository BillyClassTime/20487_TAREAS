## Module 7: Implementing data storage in Azure

### Lesson 3: Working with Structured Data in Azure

#### Demonstration: Uploading an Azure SQL Database to Azure and Accessing it Locally


creamos una nueva cuenta de almacenamiento

![d1](imagenes/d1.PNG)

con la siguiente configuración

![d1](imagenes/d2.PNG)

en contenedores nos creamos un nuevo contenedor llamado bacapcontainer

![d1](imagenes/d3.PNG)

y cargamos el fichero bacpac (es un  fichero de aplicación de capa de datos (DAC de SQL SERVER))

![d1](imagenes/d4.PNG)

Ahora creamos un recurso SQL server


![d1](imagenes/d5.PNG)

con la siguiente configuración

![d1](imagenes/d6.PNG)

una vez creado el servidor  importamos la base de datos desde el contenedor bacapcontainer

![d1](imagenes/d7.PNG)

y finalmente nos acrodamos de confifurar el firewall de la base de datos para poder acceder a ella

![d1](imagenes/d8.PNG)

ya podemos acceder a dicha base de datos desde un cliente como AZURE DATA STUDIO ó SQL SERVER, etc..

![d1](imagenes/d9.PNG)