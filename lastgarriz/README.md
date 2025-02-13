# <img src="https://i.imgur.com/deyzsBF.png" width="30" height="30"> Lastgarriz

[![Release](https://img.shields.io/github/release/maxensas/lastgarriz.svg)](https://github.com/maxensas/lastgarriz/releases/) 

### What is Lastgarriz?
Lastgarriz is a third-party tool that offers useful features for Hell Let Loose without interacting with it while playing.

### Project is now archived.
Use of the tool is now contradictory with the updated game's terms of use (2.1d)  
EULA : https://store.steampowered.com/eula/686810_eula_0?eulaLang=english  

### Important and please note:  
The tool in his state does not contain any countermeasures related to methods taking desktop screenshots allowing the detection of active overlay with a good sample and image analysis after. 
Use it at your own risk.

## Features provided :
* Quick access to settings in order to modify hotkeys.
* A feature that allows you to automatically join the server queue when full.
* A feature that allows you to record map activity of your team by taking snapshots when you open in-game map : for post-match analysis.
* An overlay to enable fast conversions for in-game artillery usage : distance meters to elevation milliradians.
* An overlay to enable a rocket crosshair based on approximate in-game measurements.
* An in-game taskbar to show active features.

### Define and use your own shortcuts :
* To configure or close the program, use right click on system tray icon.
* All features have a deep explain on themselves, just leave the mouse hover until a tooltip appears.

### Third party tool usage :
* In order to work correctly, you need to run your game in borderless full screen.
* This tool should not be used in competitive matches outside the map history recorder as they disallow all kind of overlay usage.
* Rocket crosshair feature provide a training tool very useful for finding landmarks, it will never provide skill.
* This tool allocates 90MB of memory in normal use and never more than 200MB, it does not negatively affect in-game FPS.

## How to use Lastgarriz
The application will no longer be avaiable as downloadable release. Instead, you need to download the app code and build it yourself.

### In three easy steps for ordinary users
* Download/Install Microsoft .NET7 SDK (Windows x64) at :  
https://dotnet.microsoft.com/en-us/download/dotnet/7.0
* Download the latest Lastgarriz code and unzip it into the install folder of your choice :  
https://github.com/maxensas/lastgarriz/archive/refs/heads/main.zip
* Execute `Build_Application.bat` script to build the full app, done.

### Why you need to build your own app
New game studio have taken the lead in the HLL project with some lack of awareness on overlay apps and this has unfortunately resulted in game bans in March 2023. Those bans have mostly been removed as far as I know, full details here : https://github.com/maxensas/lastgarriz/issues/1  
Previous releases were reachable as downloadable binaries in order to be usable by everyone without requiring development knowledge or enforce a burdensome installation beforehand but the unique hash ID of these public binaries has been used by Team17 to generate EAC bans with the free service provided by Epic Games. You need to build the app yourself to avoid this, each binary built generates unique ID.

## For further informations :
This program is free, open-source, licenced under BSD-3-Clause License  

### Privacy policy for Lastgarriz
Lastgarriz isn't affiliated with or endorsed by Black matter or Team17 in any way. 
Lastgarriz does not use any APM service to collect telemetry or metrics.
Lastgarriz has no database and does not collect personal data or identifier for Lastgarriz or 3rd party tool outside the features provided.

## Screenshots made in v1.0.0
* In-game task bar icons (top right corner) :
<img src="https://user-images.githubusercontent.com/62154281/205946351-2a775885-5f15-4d94-9ab1-d017dee5cd7c.png" width="60%" height="60%"> 

* Auto queue, will try to join when queue shrinks (works in all languages) :
<img src="https://user-images.githubusercontent.com/62154281/205950336-9e0d2de3-237c-4dd7-9caf-d95f72410841.png" width="30%" height="30%"> 

* Artillery metric converter :
<img src="https://user-images.githubusercontent.com/62154281/162469233-b14671fd-c856-4b33-b3bf-6c35a09c0630.png" width="20%" height="20%">

* Rocket crosshair by using FPS ping, align each indicator with the middle of the ping's triangle :
<img src="https://user-images.githubusercontent.com/62154281/205952052-112da791-9b21-448b-882f-6d88f1c2fec3.png" width="10%" height="10%">

* Rocket crosshair by using officer marker, align each indicator with the bottom edge of the marker's rectangle :
<img src="https://user-images.githubusercontent.com/62154281/205952238-286437b7-d28c-440d-9796-ab724e1aa6d4.png" width="10%" height="10%">
