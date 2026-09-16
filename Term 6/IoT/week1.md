# Class 1 - Sept 9, 2026
## Examples:
### Consumer IoT 
Smart Home devices, wearables

#### Commercial IoT
Connected devices used in retail, health care and logistics

#### Industrial IoT 
Machines, sensors, and robots used for manufacturing, agriculture, oil and gas production, and other industrial applications

#### Infrastructure IoT
Large-scale systems that support smart cities: energy grids/metering, traffic control, environmental monitoring

#### Military IoT 
Drones, sensors for intelligence gathering, soldier health monitoring

## Embedded systems
An embedded system is a computer-controlled device that has a dedicated purpose or function. Example, microwave oven

## Microcontroller vs Microprocessor
A microcontroller is a special kind of microprocessor
designed for embedded systems: 
- Has extra input & output capabilities, additional pins
- Has on-chip flash memory to store programs

Often smaller and simpler than modern general-purpose
microprocessors

May be a low-power device for portable electronics
- Battery powered, and of course we want long battery life
- Simpler (fewer transistors), lower clock speeds, low-energy
wireless, energy harvesting... can help reduce power use

## RAM vs Flash
**RAM** stores temporary data like the values of variables in a running program

**Flash** permanently stores your program’s executable code right on the processor chip (if using a microcontroller, until you change it)

Most microcontrollers also have some EEPROM where your program can save persistent data like settings or user preferences

## Microcontrollers for IoT
### ESP32
- A small and very inexpensive micro-controller board (~$5)
- Features
    - Has both WiFi and Bluetooth (Bluetooth Low Energy – BLE)
    - Many digital inputs & outputs, analog inputs, analog outputs 
    - A fairly fast multi-core processor 
    - A good amount of RAM and flash 
    - (The microcontroller chip is under the metal shield)

### Arduino Nano
- The Arduino Nano is also small and inexpensive
- Not as powerful as ESP32, but still very popular 
  - Simpler, a bit easier to use 
  - Does NOT have WiFi or Bluetooth, but can be used together with ESP if desired 
  - Limited amount of RAM and flash (2 kB of RAM, 32 kB program flash)
  - Slower processor than ESP32

### Raspberry Pi
- First version came out in 2012 and was immediately popular 
  - Many versions have appeared since then, we are up to Raspberry Pi 5
  - More RAM, Flash, and processing power than Arduino and ESP32 
  - More expensive than Arduino & ESP

- Features 
  - Runs a customized version of the Linux operating system 
  - Has WiFi, Bluetooth (BLE), 4 x USB, wired gigabit ethernet 
  - HDMI connection(s) for display screen(s) 
  - Develop code using compilers and IDEs right on the Pi