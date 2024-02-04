---
layout: page
title: Describe Compiler API - Compiler - Log Handlers
permalink: /technical/api/compiler/log-handlers/
exclude: true
---
**_The logging handlers are generic Action delegates that take in a single string argument - the text to be logged. The logging handlers are of type void - that is, they do not return a value. The idea here is that the user can assign his/her own logging methods that will be called every time the parser logs something._**

<span style="color:blue">```Action<string> LogText```</span><br>
Add your method for logging text here. LogText is the universal data logging method - when something does not fit any other category, then it is text.<br>

<span style="color:blue">```Action<string> LogInfo```</span><br>
Add your method for logging text here. LogInfo is the data logging method that is used to log more technical and detailed information.<br>

<span style="color:blue">```Action<string> LogError```</span><br>
Add your method for logging text here. LogError is the data logging method that is used to log errors that often in the compilation process Often methods are assigned to this handler that log text in red.<br>

<span style="color:blue">```Action<string> LogParserInfo```</span><br>
Add your method for logging text here. LogParserInfo is the data logging method that is used to log the most detailed and technical information about the parsing process. It is used with high verbosity settings.<br>

<span style="color:orange">```void log(string text)```</span><br>
This private method is assigned to all of the event handlers above. It simply appends data to the Log property.<br>