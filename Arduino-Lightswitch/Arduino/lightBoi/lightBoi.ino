// make sure arduino is on COM3
// designed for use with accompanying C# windows program

String serialData;

void setup() {
  pinMode(2, OUTPUT); // connect relay to digital pin 2
  Serial.begin(9600); // set baudrate 9600
  
  Serial.setTimeout(10); // set timeout to 10ms vs 1s just in case
  
  digitalWrite(2, LOW); // sets relay to "off" on setup just in case
  
}

void loop() {

  serialData = Serial.readString();
  if (serialData == "ON") {
    digitalWrite(2, HIGH); // powers on relay
  } else if (serialData == "OFF") {
    digitalWrite(2, LOW); // powers off relay
  }

  delay(10); // avoid overloading the arduino with unnecessary infinite loop
  
}
