#include <Arduino.h>
#include <Servo.h>

const int escPin = 9;

String combinedData;
int start;
int throttle;
int end;
int values[3];

void setup()
{
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600);
}

void loop() 
{
    if (Serial.available() > 0) 
    {
      combinedData = Serial.readStringUntil('\n');

      int messagesIndex = 0;
      int startSubString = 0;

    // Split combinedData using underscore as delimiter
    for (int i = 0; i <= combinedData.length(); i++) 
    {
      if (i == combinedData.length() || combinedData.charAt(i) == '_') 
      {
        values[messagesIndex++] = combinedData.substring(startSubString, i).toInt();
        startSubString = i + 1;
      }
    }
      start = values[0];
      throttle = values[1] * 5; //multiplied by 5 because input is 0-51, ESC PWM accepts 0-255
      end = values[2];

    /*
      if(throttle % 2 == 0)
      {
        digitalWrite(LED_BUILTIN, HIGH);
      }
      if(throttle % 2 != 0)
      {
        digitalWrite(LED_BUILTIN, LOW);
      }
      
      //digitalWrite(escPin,throttle);
    */
   
    Serial.print(throttle); //send data back to indicate arduino has finished executing

    }
}
