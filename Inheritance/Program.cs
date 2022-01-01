using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Inheritance.Radio radio = new Inheritance.Radio(false, "Sanyo");

radio.ListenRadio();
radio.SwitchOn();
radio.ListenRadio();

