#include <MPU6050_tockn.h>
#include <Wire.h>

MPU6050 mpu6050(Wire);

const int motorspeed_pin=2;
const int DIRA=3;
const int DIRB=4;
int position_to_be;
int actual_position;
int x;
const int echoPin = 7;
const int trigPin = 6;
boolean Response=false;

void setup() {
Wire.begin();
mpu6050.begin();
pinMode(trigPin, OUTPUT);
pinMode(echoPin, INPUT);
pinMode(motorspeed_pin, OUTPUT);
pinMode(DIRA, OUTPUT);
pinMode(DIRB, OUTPUT);
}
void getUserResponse() {
 if(Response==false)
  {Serial.begin(9600);
   if(Serial.available()) 
   {position_to_be = Serial.parseInt();
    Response=true;
    }
   }
}
    
void actualPosition()
{if(Response==true){
  digitalWrite(trigPin, HIGH);
  digitalWrite(trigPin, LOW);
  x=pulseIn(echoPin, HIGH);
  actual_position= x*0.34/2;//distanta in mm
  Serial.println(actual_position);Serial.println();
  Serial.print(mpu6050.getAccX());Serial.println();
  if(actual_position<position_to_be)
  {digitalWrite(motorspeed_pin, HIGH);
   digitalWrite(DIRA, HIGH);
   digitalWrite(DIRB, LOW);
   delay(20);
   turnOff();}
 if(actual_position>position_to_be)
  {digitalWrite(motorspeed_pin, HIGH);
   digitalWrite(DIRA, LOW);
   digitalWrite(DIRB, HIGH);
   delay(20);
  turnOff();}
  if(position_to_be==actual_position)
  {Serial.end();
   Response=false;
   }
  }
}
void turnOff()
{digitalWrite(motorspeed_pin, LOW);
 digitalWrite(DIRA, LOW);
 digitalWrite(DIRB, LOW);
 }
void loop() {
getUserResponse(); 
actualPosition();
delay(300);
}
