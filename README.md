# KPMtoCSV
Tool for parsing Kaspersky Password Manager (KPM) Version 9.x text file output into something that another password manager tool can actually use.
For when you give up from the complete train wreck that is Kaspersky Password Manager but you have a problem. You can export your passwords, but they are not on a standard format. 
The csv file targets Roboform but it should probably work with many other programs. At a bare minimum import it into Roboform then export it somewhere else.

Written in C#, source code provided so you can make sure I'm not doing anything nefarious. 

Compiled EXE is in the bin directory Debug or Release doesn't matter.

Usage-
From command prompt  
KPMToCSV.exe [InputFileName] [OutputFileName]
