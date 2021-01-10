## Module 1: Overview of Service and Cloud Technologies

### Lesson 4: Cloud Computing

#### Demonstration: Exploring the Microsoft Azure Portal


Practica 01

subir una aplicacion a un appService


 

Creamos la aplicacion web 

![c1](imagenes/c1.PNG)

ejecutamos

![c1](imagenes/c2.PNG)

Ok en local !

![c1](imagenes/c3.PNG)


Bien pues la vamos a subir con az  
Para ello nos logamos con az login

![c1](imagenes/c4.PNG)

y la subimos he utilizado las siguientes opciones  

```
az webapp update --resource-group MyRG --plan MyPlanWin --os-type Windows --location francecentral --subscription "Pase para Azure: patrocinio" --sku F1 --name appHelloWorld 
```

![c1](imagenes/c5.PNG)

Vemos que me ha creado el grupo de recursos (porque no existía)

![c1](imagenes/c6.PNG)

ha creado el app plan service (porque no existía)

![c1](imagenes/c7.PNG)

y la app web

![c1](imagenes/c8.PNG)

La abrimos

![c1](imagenes/c9.PNG)

Bien ahora la vamos a modificar y atualizar

![c1](imagenes/c10.PNG)

el comando utilizado es (le tengo que indicar en mi caso la subscription porque no es la de por defecto

Unable to retrieve details of the existing app 'appHelloWorld'. Please check that the app is a part of the current subscription

```
az webapp up  --subscription "Pase para Azure: patrocinio" --name appHelloWorld
```

![c1](imagenes/c11.PNG)

ejecutamos y ok

![c1](imagenes/c12.PNG)


