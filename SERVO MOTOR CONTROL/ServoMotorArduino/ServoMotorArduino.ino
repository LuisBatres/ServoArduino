#include <Servo.h>

Servo myServo;

void setup() {
  myServo.attach(3);
  Serial.begin(9600);
}

void loop() {
  if (Serial.available() > 0) {
    int angle = Serial.parseInt();
    if(angle > 0) {
      Serial.print("Recibido: ");
      Serial.println(angle);

      if (angle >= 0 && angle <= 180) {
        myServo.write(angle);
        Serial.print("Movido a: ");
        Serial.println(angle);
      }
    }
  }
}
