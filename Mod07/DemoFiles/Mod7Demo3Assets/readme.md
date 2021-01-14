## Module 7: Implementing data storage in Azure

### Lesson 3: Working with Structured Data in Azure

#### Demonstration: Using Microsoft Azure Cosmos DB with the MongoDB AP


Creamos un nuevo recurso COSMOS DB

![f1](imagenes/f1.PNG)

con la siguiente configuración (importante la APi de MongoDB) ;)

![f2](imagenes/f2.PNG)

Nos vamos al Explorador de datos y creamos una nueva coleccion

![f3](imagenes/f3.PNG)

les metemos las colecciones  customer y orders 

![f4](imagenes/f10.PNG)

(ojo con los nombres de campos y colleciones pues son CASESENSITIVE

![f4](imagenes/f11.PNG)

Para añadirle datos podemos coger el fichero CustomersCollectionData.json, abrirlo y copiar su contenido.
Abrimos un nuevo shell en la coleccione customer, pegamos el contenido del fichero y pulsamos intro

![f5](imagenes/f12.PNG)

Lo mismo para orders

![f5](imagenes/f13.PNG)

finalmente podemos ver los datos ejecutando un query de Mongo

![f6](imagenes/f14.PNG)
