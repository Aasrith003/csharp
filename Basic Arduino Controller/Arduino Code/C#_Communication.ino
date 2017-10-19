#define ledpin 13
#define buzzerpin 12
char on;
void setup() {
  pinMode(ledpin ,OUTPUT);
  pinMode(buzzerpin , OUTPUT);
  Serial.begin(9600);

}
 
void loop() {
 on = Serial.read();
  switch(on)
  {
    case '1':
       digitalWrite(ledpin , HIGH);
       break;
       
    case '0':
       digitalWrite(ledpin, LOW);
       break;
    case '2':
        digitalWrite(buzzerpin , HIGH);
         break;
     case '3':
        digitalWrite(buzzerpin , LOW);
        break;
     case '4':
          digitalWrite(buzzerpin , HIGH);
          delay(100);
          digitalWrite(buzzerpin, LOW);
          delay(100);
          digitalWrite(buzzerpin , HIGH);    
          break;
     case '5':
    
          digitalWrite(ledpin , HIGH);
          delay(100);
          digitalWrite(ledpin, LOW);
          delay(100);
          digitalWrite(ledpin , HIGH);       
          break;
  }
  
 
}
