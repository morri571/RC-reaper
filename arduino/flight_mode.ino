/***********************FLIGHT MODE************************
1. Plug motor red to ESC red, motor black to ESC black,
and motor yellow to ESC blue
2. Plug two pins of ESC BEC into arduino: ESC black to
arduino GND, and ESC white to pwm pin 9
3. Push arduino code
4. Unplug arduino from usb
5. Plug final red pin of ESC BEC into 5v of arduino
6. Plug in ESC to battery
7. Wait for 6 battery beeps and two confirmation beeps
8. Replug arduino - motor will spin up and down to adjust
to voltage
9. Ready to send commands
**********************************************************/

//DO NOT PUSH NEW ARDUINO CODE IF SOMETHING IS ALREADY RUNNING!!!

#include <Servo.h>

#define MAX_THROTTLE 2000
#define MIN_THROTTLE 1000
#define ESC_PIN 9

Servo esc;
String combinedData;
int start;
int throttle;
int end;
int values[3];

void setup() 
{
  Serial.begin(9600);
  delay(100);
  esc.attach(ESC_PIN);
  delay(100);
  esc.writeMicroseconds(MIN_THROTTLE);
}

void loop() {

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
      throttle = values[1];
      end = values[2];

      //int mappedThrottle = map(throttle, 0, 1023, 1000, 2000);

      esc.writeMicroseconds(throttle);
      Serial.print(throttle);

      delay(10);
    }
}
