# GAE2f

Descripcion:

Sistema de Gestión de Alarmas y Eventos de Equipos de Fuerza:

El sistema se encargara de  recibir alarmas o alertas desde equipos de fuerza, tales como plantas de emergencias, rectificadores, o hasta inclusive puertas abiertas, con el fin de identificar de forma remota lo que sucede con los equipos y de esta forma lograr asegurar la continuidad del negocio, dichas alarmas deberan ser claras y actualizarse constantemente para asegurarse de brindar informacion real.

Prerequisitos de instalacion:

Se requiere: 

*Software de Arduino IDE 1.8.5: se debera descargar la libreria para los equipos ADAFRUIT ESP8266, la cual pueden conseguir del link: http://arduino.esp8266.com/stable/package_esp8266com_index.json

*Motor de base de datos SQL server

*Visual Basic

*Netbeans 

Instalacion: Como primer requerimiento se va a tener que adquirir la tarjeta Arduino ADAFRUIT( podrian comprar alguna otra tarjeta de arduino siempre y cuando descarguen la libreria correspondiente) , adjunto el link de la tienda virtual donde podrian adquirirla:

http://www.crcibernetica.com/arduino/ 

Ademas van a ocupar un protoboard a la cual ligar la tarjeta , para la version ADAFRUIT de este proyecto se utiliza la ESP8266 la cual tiene conexion inalambrica, este dispositivo va a simular nuestro equipo de fuerza.

Mediante el software de Arduino se debera habilitar la configuracion de la tarjeta inalambrica y ademas de los pines que se activaran para el envio de alarmas ( cada PIN simula un equipo de fuerza)

En el software de Arduino se debera in a preferencias y poner el link http://arduino.esp8266.com/stable/package_esp8266com_index.json , luego ir a gestor de tarjetas , seleccionar el modelo y descargar la version mas reciente.Luego de esto podremos comenzar a trabajar en la programacion del ADAFRUIT, conectarlo a una red inalambrica, ademas de establecer comunciacion con un puerto a elegir en la PC en que se vaya a trabajar 

Se deberan ligar los pines de forma fisica al protoboard mediante los cables al PIN de tierra correspindiente 

En Netbeans se debera habilitar un  puerto que para efectos de este proyecto es el 4444, confirmar la comunicacion entre el ADAFRUIT y la PC y mediante bucles observar como se recepcionan las alarmas dependiedo de los negativos y positivos en el arduino

Ejemplo: Al correr la aplicacion en netbeans debera mostrar un resultado asi:

SE CREA EL SOCKET...

SE ESTABLECE COMUNICACION...

LOW 
LOW 
LOW 
HIGH 
HIGH 
LOW
LOW
HIGH

Explicacion: al crear el socket se entiende que netbeans reservo el puerto en la computadora , cuando indica que establece comunicacion quiere decir que ya se ligo al ADAFRUIT, luego mediante un ciclo while((true) al quitar o poner voltaje a los pines  indica LOW= sin voltaje, HIGH= con voltage de esta forma confirmaremos la recepcion de alarmas a modo de prueba. El Texto HIGH  y LOW varian a nuestra conveniencia o sea es completamente editable a nuestro gusto.
 
Se debe establecer una comunicacion entre la base de datos y el NETBEANS mediante ese puerto , y mediante otro puerto establecerla entre Visual  Basic y el servidor , para tener la comunicacion  completa.

de esta forma la base de datos recibira la informacion de las pulsaciones que le envie el arduino y se las enviara a la aplicacion para que las muestre 
 estos codigos podran encontrarlos en los diferentes Releases de este proyecto, importante adecuarlos a sus circunstancias especificas 
 
 Nota: Una vez que el sistema este en desarrollo no sera imprescindible el uso de netbeans ya que se ha desarrollado en este proyecto con finalidad de ambiente de prueba
 
 Despliegue:
Para correr el programa basta con  contar con la base de datos que contenga las Tablas con los insert de alarmas , las tablas para los usuarios , la comunicacion activa hacia la aplicacion y que el dispositivo de hardware ya sea un arduino para ambientes de prueba o algun equipo de fuerza para ambientes de produccion se comuniquen tambien con la base de datos, se ejecuta el programa y se visualiza en el home el resultado, ademas de manipular la base de datos mediante la aplicacíon.


Autor:
Jonathan Vargas
