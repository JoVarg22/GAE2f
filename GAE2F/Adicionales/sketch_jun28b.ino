#include <ESP8266WiFi.h>
 
const char* ssid     = "Familia vargas";
const char* password = "Eliana11";
 
const char* host = "192.168.0.11";
int inPin = 14;
void setup() {
  Serial.begin(115200);
  delay(100);
 
  // We start by connecting to a WiFi network
 
  Serial.println();
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);
  
  WiFi.begin(ssid, password);
  
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
 
  Serial.println("");
  Serial.println("WiFi connected");  
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
  pinMode(inPin, INPUT);
  
}
 
void loop() {
  int val = 0;
  String text = "LOW";
  delay(5000);
 
  
  // Use WiFiClient class to create TCP connections
  WiFiClient client;
  const int port = 4444;
  if (!client.connect(host, port)) {
    Serial.println("connection failed");
    return;
  }
  
  // We now create a URI for the request
  //String url = "/testwifi/index.html";
  //Serial.print("Requesting URL: ");
 // Serial.println(url);
  
  // This will send the request to the server
  for(int x = 0; x < 10; x++){
    
    val = digitalRead(inPin);
    if(val > 0){
      text = "HIGH";
    }else{
      text = "LOW";
    }
    client.println(text);
    delay(1200);
  }
  
  // Read all the lines of the reply from server and print them to Serial
  //while(client.available()){
    //String line = client.readStringUntil('\r');
    //Serial.print(line);
  //}
  
  //Serial.println();
  //Serial.println("closing connection");
}
