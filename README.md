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

Se debe establecer una comunicacion entre la base de datos y el NETBEANS mediante ese puerto , y mediante otro puerto establecerla entre Visual  Basic y el servidor , para tener la comunicacion  completa.

de esta forma la base de datos recibira la informacion de las pulsaciones que le envie el arduino y se las enviara a la aplicacion para que las muestre 
 estos codigos podran encontrarlos en los diferentes Releases de este proyecto, importante adecuarlos a sus circunstancias especificas 
 
Autor:
Jonathan Vargas
