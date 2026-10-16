# TunnelFix

A simple mod for [Ultros](https://store.steampowered.com/app/2386310/Ultros/) that prevents changes to creature tunnels from being lost if you open the world map before saving.

## Installation
First, install [MelonLoader](https://github.com/lavagang/melonloader) onto the Ultros.  Start the game up, then quit out once it loads.  This should have created a "Mods" folder in the games's install directory.  Download [tunnelfix.dll](https://github.com/Komodo5197/tunnelfix/releases/latest) and copy it into this folder, and you should be ready to start playing!

## Building
This project was built with the Visual Studio Melonloader template.  You will need visual studio and its C# development dependancies installed.  You must also have executed Ultros with MelonLoader installed at least once.  First, update the game path in TunnelFix/Directory.Build.props to match your installation.  You can then open the project in Visual Studio and run the build, which will place the finished dll into the game's Mods folder if successfull.