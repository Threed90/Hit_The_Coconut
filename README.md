# **"Hit The Coconut" Game**

[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2022-brightgreen)](https://visualstudio.microsoft.com/)
[![.NET](https://img.shields.io/badge/.NET-5.0-brightgreen)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-9.0-green)](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9)
[![WFAC#](https://img.shields.io/badge/Windows%20Form%20App-C%23-yellowgreen)](https://docs.microsoft.com/en-us/visualstudio/ide/create-csharp-winform-visual-studio?view=vs-2022)

---
<div align="center">
    <a href="#game-intro">Game Intro</a> |
    <a href="#game-ui">Game UI</a> |
    <a href="#game-controllers">Game Controllers</a> |
    <a href="#software-infrastructure">Software Infrastructure</a> |
    <a href="#the-wfa-project">The WFA projectt</a> |
    <a href="#the-class-library-project">The class library project</a> |
    <a href="#interfaces">Interfaces</a> |
    <a href="#class-hierarchy">Class-hierarchy</a> |
    <a href="#game-rules">Game rules</a> |
    <a href="#fruits-and-their-points">Fruits and their points</a>
</div>

---

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

#### Interfaces
-----

![interfaces](/descriptionResources/interfaces.png)

#### Class hierarchy
-----

1. Class hierarchy of fruits:
   
    ![class hierarchy of fruits](/descriptionResources/fruitClassHierarhy.png)

2. A single class for game score:
   
    ![score class](/descriptionResources/scoreClass.png)

3. A single class FruitFactory:

    ![factory class](/descriptionResources/fruitFactoryClass.png)

4. A single class FruitNamesRepository:

    ![repository class](/descriptionResources/FruitNamesRepository.png)

## Game rules

There are few rules that has to be followed:
1. Every single click on fruit will make this fruit to dissapear and will increase or descrease your score.
   
   ![gather points](/descriptionResources/gatherPoints.gif) 

2. If you **miss to hit fruit** and just click somewhere on the game screen, you will decrease your score with five points (-5).
   
   ![hitting screen](/descriptionResources/hitScreen.gif)

3. If score goes over **negative hundred points** (-100) - the game is lost (game over).
   
   ![game over with max negative score](/descriptionResources/gameOverNegativeScore.gif)

4. If **the number of fruits is greater than 60** - the game is lost (game over).

    ![game over with max fruit number](/descriptionResources/gameOverMaxFruits.gif)

5. **Every fruit brings you one point** (1), expect the Coconut.
   
   ![fruits expect coconuts hitting](/descriptionResources/fitFruits.gif)

6. Every hitted **coconut will decrease your score with ten points** (-10).

    ![hitting coconuts](/descriptionResources/hitCoconuts.gif)

## Fruits and their points
---

| Fruit name | Fruit icon | Points |
|------------|------------|--------|
| Coconut | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/coconut.png" width="100"> | negative ten points (-10) |
| Apricot | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/apricot.png" width="100"> | one point (1) |
| Blueberry | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/blueberry.png" width="100"> | one point (1) |
| Green Apple | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/greenApple.png" width="100"> | one point (1) |
| Mango | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/mango.png" width="100"> | one point (1) |
| Melon | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/melon.png" width="100"> | one point (1) |
| Peach | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/peach.png" width="100"> | one point (1) |
| Pomegranate | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/pomegranate.png" width="100"> | one point (1) |
| Raspberry | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/raspberry.png" width="100"> | one point (1) |
| Red Apple | <img src="https://github.com/Threed90/Hit_The_Coconut/blob/main/HitTheCoconutGameSolution/HitTheCoconut/img/redApple.png" width="100"> | one point (1)|

---
