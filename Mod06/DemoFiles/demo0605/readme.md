## Module 6: Deploying and Managing Services

### Lesson 5: Defining Service Interfaces with Azure API Management

#### Demonstration: Importing and Testing an OpenAPI Specification & Limiting Call Rates Using API Management


Creamos un aP Management con la siguiente configuración


![c1](imagenes/c1.PNG)


una vez creado nos vamos a Apis + Api y le añadimos una api OpenAPI

![c1](imagenes/c3.PNG)

con la siguiente cofiguración

![c1](imagenes/c2.PNG)


vemos que nos la ha añadido y nos expone todos sus metodos y podeos testearlos

![c1](imagenes/c4.PNG)

vemos lo que nos devuelve

![c1](imagenes/c5.PNG)


Pero ahora vamos a añadirlo una politica a la Gestion

lo podemos hacer a traves del icono "</>" o através de Add Policy

![c1](imagenes/c6.PNG)


vamos añadir una politica Limit call rate

![c1](imagenes/c9.PNG)

que sólo pueda hacer 2 llamadas cada 60 segundo

![c1](imagenes/c10.PNG)

![c1](imagenes/c11.PNG)

A través de  "</>" nos abre el xml y lo podríamos teclear directamente 


![c1](imagenes/c12.PNG)


Bueno pues vamos a probarla ejecutando 3 veces e menos de 60 segundos


![c1](imagenes/c13.PNG)


![c1](imagenes/c14.PNG)

Error 429 Too Many Request!!

![c1](imagenes/c115.PNG)







