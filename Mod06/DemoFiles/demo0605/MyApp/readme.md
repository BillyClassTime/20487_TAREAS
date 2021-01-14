# Module 6: Deploying and Managing Services

# Lesson 3: Continuous Delivery with Microsoft Visual Studio Team Services

### Demonstration: Continuous Delivery to Websites with Git and Visual Studio Team Services

----

Modificamos el markdown porque ya no utilizamos TEAMS..

Los pasos son crear el webapp

crear el proyecto [ y Organización ] en https://dev.azure.com/ y la Pipeline

clonamos en VSCODE 

creamos el proyecto de net

Push

y en el centro de implementacion le indicamosmos el Azure Repos Pipilne


----

Creamos una web APP con la siguiente configuración
	
![create web app](imagenes/c1.PNG)	
	
En https://dev.azure.com/ Creamos una nueva Organizacion

![create Organization](imagenes/c2.PNG)	

y un nuevo proyecto 

![create project](imagenes/c3.PNG)


una vez creado nos vamos a remos y clonamos a VsCode

![clone VS Code](imagenes/c4.PNG)

Permitimos que abra VsCode 

![Allow Open VS Code](imagenes/c5.PNG)

y elegimos la carpeta

![Allow Open VS Code](imagenes/c6.PNG)

![Save in Code](imagenes/c7.PNG)
	
	
una vez clonado nos vamos a la canalización a Pipelines 

![new Pipelines](imagenes/c8.PNG)

y creamos una nueva carpeta


![new folder](imagenes/c9.PNG)


![new folder](imagenes/c10.PNG)


Volvemos al equipo y nos creamos un proyecto dotnet new webapi -n MyProject

(no ponemos -f porque por defecto nos crea net core 5 y es lo que le dimos en el webapp)


![new folder](imagenes/c11.PNG)


y agora le damos un push por code ó por consola 

    ```bash
    dotnet sln Mod6Demo3.sln add MyProject\MyProject.csproj


    git add .


    git commit -m "my first commit"
	
	
	git push
    ```

![git commit](imagenes/c12.PNG)	

![git push](imagenes/c13.PNG)	


comprobamos 
	
![git push](imagenes/c14.PNG)	



Volvamos al portal de azure, abrimos la wev app 

y en el Deploy Center seleccionamos Azure Repos

![Deploy Center Azure Repos](imagenes/c15.PNG)	


continuamos y seleccionamos  Azure Pipelines


![Deploy Center Azure Pipelines](imagenes/c15.PNG)	
	

![Deploy Center configuracion](imagenes/c16.PNG)		

Continuamos y Finish


Al poco rato

![Deploy Center history](imagenes/c18.PNG)

y ya esta cargado en nuesto web app

![Deploy Center history](imagenes/c19.PNG)


y funcionando

![WeatherForecast](imagenes/c21.PNG)

Modificamos el controlador y gacemos de nuevo un push


![Deploy Center history2](imagenes/c20.PNG)

y modificado

![WeatherForecast Spanish](imagenes/c23.PNG)



Resumiendo a traves de Azure Git se despliega la aplicación en el mimento que hacemos un push.



	