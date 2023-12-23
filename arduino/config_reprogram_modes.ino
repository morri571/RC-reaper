/***********************CONFIG MODE***************************
1. Plug motor red to ESC red, motor black to ESC black,
and motor yellow to ESC blue
2. Plug two pins of ESC BEC into arduino: ESC black to
arduin GND, and ESC white to PWM pin 9
3. Push arduino code
4. Plug ESC into battery
5. Immediately after hearing beeps, send min throttle 
command (-1_1000_256)
6. Wait for two confirmation beeps
7. Unplug ESC
8. Ready to use
*************************************************************/

/***********************REPROGRAM MODE************************
1. Plug motor red to ESC red, motor black to ESC black,
and motor yellow to ESC blue
2. Plug two pins of ESC BEC into arduino: ESC black to
arduino GND, and ESC white to PWM pin 9
3. Push arduino code
4. Plug ESC into battery
5. Reference ESC documentation for which sound corresponds
to which setting, then send minimum throttle (-1_1000_256) to
select setting
6. Wait for two confirmation beeps
7. Unplug ESC
8. Rinse and repeat for other settings
*************************************************************/

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
  delay(500);
  esc.attach(ESC_PIN);
  delay(500);
  esc.writeMicroseconds(MAX_THROTTLE);
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

      delay(250);
      esc.writeMicroseconds(throttle);

    }
}
