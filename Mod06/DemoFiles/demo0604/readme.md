## Lesson 4: Deploying to Staging and Production Environments

### Demonstration: Using Deployment Slots with Web Apps

#### Demonstration Steps

Creamos una webapp

![c1](imagenes/c1.PNG)



Vamos a congigurar para hacer deploy a traves de Ftp 


![c3](imagenes/c3.PNG)

![c3](imagenes/c4.PNG)


y esos datos lo vamos a copiar en el archivo [Properties/PublishProfiles/Azure.pubxml](SimpleServiceForDeploymentSlots/Properties/PublishProfiles/Azure.pubxml)

![c3](imagenes/c5.PNG)




Publicmaos

    ```bash
    dotnet publish /p:PublishProfile=Azure /p:Configuration=Release
    ```
	
![c3](imagenes/c6.PNG)

Probamos la aplicación

![c3](imagenes/c7.PNG)

Creamos es stating slot

![c3](imagenes/c8.PNG)

![c4](imagenes/c9.PNG)



Modificamos el Valuecontroller 

 
   ```cs
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Nueva version de value 1", "nueva Version de value 2" };
        }
   ```

Modificamos [Properties/PublishProfiles/Staging.pubxml](SimpleServiceForDeploymentSlots/Properties/PublishProfiles/Staging.pubxml)

   ```xml
	<Project>
		<PropertyGroup>
			<PublishProtocol>Kudu</PublishProtocol>
			<PublishSiteName>blueyonder-vuelos-jrdf-staging</PublishSiteName>
			<UserName>FTPMod6Lab2jrdf</UserName>
			<Password>Password99..</Password>
		</PropertyGroup>
	</Project>
   ```
6. To publish in the staging slot, at the command prompt, run the following code:
   ```bash
   dotnet publish /p:PublishProfile=Staging /p:Configuration=Release
   ```

ejectumaos la aplicación en Staging


![c4](imagenes/c10.PNG)


 Swapping the Environments


![c4](imagenes/c11.PNG)

![c4](imagenes/c12.PNG)

Probamos

![c4](imagenes/c13.PNG)


Deshacemos el Swap


Basta con volver a intercambiar

![c4](imagenes/c16.PNG).


Si vamos al web api vemos que tenemos logs (registros)

![c4](imagenes/c14.PNG).

![c4](imagenes/c15.PNG).

