/*
  Serial Event example

  When new serial data arrives, this sketch adds it to a String.
  When a newline is received, the loop prints the string and clears it.

  A good test for this is to try it with a GPS receiver that sends out
  NMEA 0183 sentences.

  NOTE: The serialEvent() feature is not available on the Leonardo, Micro, or
  other ATmega32U4 based boards.

  created 9 May 2011
  by Tom Igoe

  This example code is in the public domain.

  https://www.arduino.cc/en/Tutorial/BuiltInExamples/SerialEvent
*/

void setup() {
  // initialize serial:
  Serial.begin(2000000);
}

void loop() {
  for(int i=1; i < 4092; i += 2){
    int dataX = 1210000 + i;
    int dataY = 1220000 + i;
    Serial.println(dataX);
    Serial.println(dataY);
    delay(10);
  }
}
