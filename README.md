# 💰 Rock Band 2 Money Editor (2025)

---

## What Is This?

**Rock Band 2 Money Editor** is a simple Windows application that allows you to edit the **money value** in your **Rock Band 2 save game file**.

The project was inspired by an obscure executable discovered by Discord user **Bubbles**, dating back to **2012**, created by an unknown author. Unfortunately, the original executable refuses to run — even under compatibility mode — and it is unclear whether it ever actually worked as advertised.

After thoroughly decompiling and analyzing the heavily obfuscated source code, it is my opinion that the original tool **would not have functioned correctly**.

---

## Project Background

I created this version in **June 2025** as a **proof of concept**, following extensive effort reversing and studying the original application.

Progress only truly began once I abandoned the idea of recreating the original behavior and instead chose to **rebuild the project from scratch**, using modern tooling and a clean approach.

This project would not have been possible without the **DTB decryption code** from **StackOverflow0x’s Rock Band 3 Save Game Scores Editor**.

As always, I put my own spin on it — enjoy!

---

## Supported Save Files

The application currently supports:

- **Xbox 360** Rock Band 2 *band* save game files
- **PlayStation 3 (RPCS3)** save files (`RB2.SAV`)

❌ **Wii is not supported at this time**

> If you are a Wii player and want to collaborate on adding support, feel free to reach out.

---

## How to Use

1. Obtain your **Rock Band 2 save game file**  
   (Xbox 360 or PS3 / RPCS3)

2. Open the application and:
   - Click **Open File**, **or**
   - Drag and drop the save file onto the window

3. The application will display:
   - Player name
   - Band name
   - Offset where the money value is stored  
     *(this varies between save files)*
   - Current money value

4. Choose how to edit your money:
   - Enter a custom value manually, **or**
   - Click **Max Money** to set the value to:
     - `0xFFFFFF`  
     - `2,147,483,647`

5. Click **Save Changes**

6. Transfer the edited save file back to:
   - Your Xbox 360, or
   - RPCS3

7. **Profit**

---

## It’s Not Working for Me!

If you’re having issues:

- Find me (**Nemo**) on Discord  
- I run a server called **“Nemo’s Nautilus”**, where I provide support for my tools

When reaching out, please include:
- Your save game file
- Your player name
- The amount of money you believe you should have in the Rock Shop

I’ll take a look and see what I can find.

---

## ⚠️ Important — Backup Your Save File

The application automatically creates a **`.bak` backup** of your original save file before making any changes.

That said:

- **Always make your own backup as well**
- I **cannot restore corrupted save files**

Use at your own risk — backups are your safety net.

---
