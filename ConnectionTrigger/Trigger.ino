//------------------------------------------------------------------------------
//Variables to be used by photodiode sync trigger circuit
const uint8_t triggerPin1 = 13;//Digital pin to inform if the photodiode received black or white
const uint8_t triggerPin2 = 20;//Digital pin to inform if the photodiode received black or white
const uint8_t sensorPin = 1;//Photodiode analogic pin
uint16_t sensorValue = 0;//Photodiode sensor current value
uint16_t trigger_value = 420;//Value to compare sensor value (bellow is black, above is white)
//------------------------------------------------------------------------------
//Timer functions
void start_timer0() {//initialize counter and enable interruption from timer0
  TCNT0  = 0;//initialize counter value to 0
  TIMSK0 |= (1 << OCIE0A);// enable timer compare interrupt
}

void stop_timer0() {//disables the interrupt from timer0
  TIMSK0 |= (0 << OCIE0A);// disable timer compare interrupt
}

ISR(TIMER0_COMPA_vect) {//timer0 interrupt 1kHz read analog input
  sensorValue = analogRead(sensorPin);// Read ADC data.

  if (sensorValue >= trigger_value) {//compare to threshold value and set trigger pin value
    digitalWrite(triggerPin1, HIGH);
    digitalWrite(triggerPin2, HIGH);
  }
  else {
    digitalWrite(triggerPin1, LOW);
    digitalWrite(triggerPin2, LOW);
  }
}
//------------------------------------------------------------------------------
// log data
void logData() {
  Serial.println();

  delay(100);
  Serial.println(F("Logging...that will start after high pulse - type 2 to stop"));
  // Wait for Serial Idle.
  Serial.flush();
  delay(10);
  while(1) {
    sensorValue = analogRead(sensorPin);
    Serial.println(sensorValue);
    /*if (sensorValue >= trigger_value){
      Serial.println(F("Start"));
      digitalWrite(triggerPin1, HIGH);
      digitalWrite(triggerPin2, HIGH);
      start_timer0();
      break;
    }*/
    if (sensorValue >= trigger_value) {//compare to threshold value and set trigger pin value
      digitalWrite(triggerPin1, HIGH);
      digitalWrite(triggerPin2, HIGH);
    }
    else {
      digitalWrite(triggerPin1, LOW);
      digitalWrite(triggerPin2, LOW);
    }
  }
  while (1) {
    if (Serial.available()) {
      char c = tolower(Serial.read());
      if (c == '2') {
        stop_timer0();
        digitalWrite(triggerPin1, LOW);
        digitalWrite(triggerPin2, LOW);
      }
    }
  }
}
//------------------------------------------------------------------------------
void setup(void) {
  // Serial comunication
  Serial.begin(9600);
  
  // Photodiode code
  pinMode(sensorPin, INPUT);
  pinMode(triggerPin1, OUTPUT);
  pinMode(triggerPin2, OUTPUT);
  digitalWrite(triggerPin1, LOW);
  digitalWrite(triggerPin2, LOW);

  // Read the first sample pin to init the ADC.
  analogRead(sensorPin);

  //set timer interrupts
  cli();//stop interrupts

  //set timer0 interrupt at 1kHz
  TCCR0A = 0;// set entire TCCR2A register to 0
  TCCR0B = 0;// same for TCCR2B
  TCNT0  = 0;//initialize counter value to 0
  // set compare match register for 1kHz increments
  OCR0A = 249;// = (16*10^6) / (1000*64) - 1 (must be <256)
  TCCR0A |= (1 << WGM01);// turn on CTC mode
  TCCR0B |= (1 << CS01) | (1 << CS00);// Set CS01 and CS00 bits for 64 prescaler
  //TIMSK0 |= (1 << OCIE0A);// enable timer compare interrupt

  sei();//allow interrupts
}
//------------------------------------------------------------------------------
void loop(void) {
  // discard any input
  while (Serial.read() >= 0) {}

  Serial.println();
  Serial.println(F("Type 1 to start:"));
  while(!Serial.available()) {}
  char c = tolower(Serial.read());
  // Read any extra Serial data.
  do {
    delay(10);
  }
  while (Serial.read() >= 0);
  if (c == '1') {
    logData();// Start voice record
    Serial.println(F("End call of logData function in the loop function"));
  }
}
