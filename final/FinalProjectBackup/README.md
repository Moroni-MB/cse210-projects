# JARVIS – Terminal Assistant

## Overview
JARVIS is a terminal-based assistant written in C#. It accepts user commands and routes them to different modules using object-oriented programming principles.

---

## Features
- Command-based terminal interaction
- Modular design using classes
- Input routing system
- Animated startup and menu
- Easy to extend with new commands

---

## How to Run
1. Open the project in Visual Studio or VS Code
2. Build and run the program
3. Type commands shown in the menu
4. Type `exit` to quit

---

## Available Commands
- `help` – Shows available commands
- `exit` – Closes the program

---

## Design Overview
- Each command is its own class
- All modules inherit from a base class called `AssistantModule`
- `AssistantManager` controls module execution
- `CommandRouter` parses and routes user input

This design demonstrates encapsulation, inheritance, and polymorphism.

---

## Author
Moroni Montoya Bernal
CSE 210 – Programming with Classes  
BYU–Idaho
