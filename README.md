# **"Hit The Coconut" Game**

[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-brightgreen)](https://visualstudio.microsoft.com/)
[![.NET](https://img.shields.io/badge/.NET-5.0-brightgreen)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-9.0-green)](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9)
[![WFAC#](https://img.shields.io/badge/Windows%20Form%20App-C%23-yellowgreen)](https://docs.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022)


## Game Intro
---

A simple and funny game, implemented via Windows Form App with C#. [Hit The Coconut](https://github.com/Threed90/Hit_The_Coconut) is a single player game. The player have to collect as many as possible points, following few rules.

## Game UI
---

The [Hit The Coconut](https://github.com/Threed90/Hit_The_Coconut) game UI design is just a system window without form border. 
There are no options for minimazing or maximazing of it. When the game is started, its display will pop up in the middle of your computer screen.

<img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/descriptionResources/gameEntrySkin.png" width="600">

## Game Controllers
---

There are *four buttons*, which actually have functionality to start, pause, restart and exit from the game. Also there are the number of displayed fruits counter and total score counter.

![controllers](/descriptionResources/controllers.gif)

## Software Infrastructure
---

The solution of the game contains two projects. The first one is class library and the second - windows form app (WFA).

![Solution infrastructure](/descriptionResources/SolutionInfrastructure.png)

### The WFA project
----

The WFA project respond for the UI of the game and contains the buisness logic of the application as buttons functionality. There is also implemented the game logic.

![WFA project](/descriptionResources/WFA_Project.png)

### The class library project
----

It contains all objects of the game as interfaces, the fruit class hierarchy, score class. Also there are implemented repository class and fruit factory class.

![class library project](/descriptionResources/classLibraryProject.png)
