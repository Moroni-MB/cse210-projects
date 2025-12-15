# JARVIS – GUI Assistant

## Overview
This version of JARVIS is a graphical desktop assistant written in C# using Avalonia UI. It allows users to interact with the assistant through a text input box instead of the terminal, while still using the same logic and command system from the Terminal version.

---

## Features
- Graphical user interface (GUI)
- Text-based command input
- Modular design using classes
- Command routing system
- Easy to extend with new features
- Shared logic with terminal version

---

## How to Run
1. Open the project in Visual Studio or VS Code
2. Build and run the GUI project
3. Type commands into the input box
4. Press Enter or click the Send button

---

## Available Commands
- `help` – Shows available commands
- `exit` – Closes the application

---

## Design Overview
- Each feature is implemented as its own module class
- All modules inherit from a base class called `AssistantModule`
- `AssistantManager` controls module registration and execution
- `CommandRouter` processes user input and routes commands
- The GUI communicates with the core logic without duplicating code

---

## Author
Moroni Montoya Bernal  
CSE 210 – Programming with Classes  
BYU–Idaho
