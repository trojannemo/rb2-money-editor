**Rock Band 2 Money Editor (2025)**

**WHAT IS IT**

Inspired by an obscure executable found by Discord user Bubbles dating back to 2012 by an unknown creator, it is a simple Windows application to edit the money value in your Rock Band 2 save game file

The original executable refuses to run even under compatibity mode so it is unknown if it actually worked at what it purported to do - based on thorough decompilation of the heavily obfuscated source code, it is my opinion that it would not actually work as intended


I created this version in June of 2025 as a proof of concept after much effort decompiling and reversing the source code of the original

It wasn't until I gave up on trying to recreate the original and instead decided to tackle the project from scratch that I started to make progress


This wouldn't be possible without the DTB decryption code taken from StackOverflow0x's Rock Band 3 Save Game Scores Editor


As always, I put my own spin on it - enjoy!


**HOW TO USE IT**

The program will only accept an Xbox 360 "band" save game file - it will choke if it's not from Rock Band 2 so do not try another Rock Band game's save game file!

Transfer your band file from your Xbox 360 to your computer

You can either click on the Open File button or (how I do it), drag and drop the file to the form

It will display your player name, the offset where the money value is stored in your save file (it varies from file to file), and it will display your current money value

You can manually enter a money value amount or click Max Money if you just want to go straight to the max value (0xFFFFFF or 2,147,483,647)

Click save

Transfer the band file back to your Xbox 360

Profit


**IT'S NOT WORKING FOR ME!**

Find me (Nemo) on Discord - I have my own server called Nemo's Nautilus where I provide support for all my little applications

Send me your band file and tell me 1) is your Xbox 360 retail or RGH/JTAG? 2) are you running "vanilla" Xbox 360 or RB2 Deluxe? 3) what is your player name and how much money *should* you have in the Rock Shop?

I will take a look at your file and see what I can find


**BACK UP YOUR FILE BEFORE TRYING TO EDIT IT**

The application will automatically create a .bak file to backup your original before it does any editing, but I always recommend you do your own redundant backup. ***I can NOT restore a corrupted file.***
