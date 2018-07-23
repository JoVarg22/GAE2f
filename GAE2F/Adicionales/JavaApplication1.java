/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;
import java.net.*;
import java.io.*;

public class JavaApplication1 {
    public static void main(String[] args) throws IOException {

        ServerSocket serverSocket = null;
        try {
            serverSocket = new ServerSocket(4444);
            System.out.println("estoy después de crear el socket");
        } catch (IOException e) {
            System.err.println("No puedo escuchar el puerto 4444.");
            System.exit(1);
        }

        Socket clientSocket = null;
        try {
            clientSocket = serverSocket.accept();
            System.out.println("estoy después de aceptar un cliente");
        } catch (IOException e) {
            System.err.println("Accept failed.");
            System.exit(1);
        }

        PrintWriter out = new PrintWriter(clientSocket.getOutputStream(), true);
        BufferedReader in = new BufferedReader(
        new InputStreamReader(
        clientSocket.getInputStream()));
        String inputLine, outputLine;
       

       
       

        while ((inputLine = in.readLine()) != null) {
            System.out.println(inputLine);
             //out.println("");
             
               // break;
        }
        out.close();
        in.close();
        clientSocket.close();
        serverSocket.close();
    }
}

