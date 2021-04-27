# Swingin--Good-Time
 
This is a game about getting to the end of level in the shortest amount of time without touching the lava.

## Table of Contents

1. Installation Instructions

2. Activity Flow Chart

3. Usage Instructions

4. Requirement Analysis

5. Gameplay

6. Test Plan Excel Sheet

7. In line Code

8. Liscense

## 1. Installation Instructions
 
When you download the files from github, unzip it. Use Unity Hub to open the files in Unity. When it asks you if you want to fix anything say "Ignore". Continue this until you get to the regular Unity screen. Go to Build Settings and click "Build and Run". This should start to build the project into a playable executable that can be started. The downloader will need to have *1.37 GB* space free in order to download it.

## 2. Activity Flow Chart

This is a PDF of the activity flow chart that is meant to show how the project works as you play through the game. [Capstone Activity Diagram](https://github.com/NicholasKing76/Swingin-Good-Time/files/6305773/Capstone.Activity.Diagram.pdf) You can download it here or you can view it below.![Capstone Activity Diagram](https://user-images.githubusercontent.com/54336920/114599957-68405100-9c59-11eb-872c-befcbd8c8801.jpeg)

## 3. Usage Instructions

### Title Screen 

When the game starts you will be taken to the title screen where you can click anywhere and you will be taken to the main menu. 

### Main Menu

Then you will have three options: quit game, how to play, and play game. Clicking quit game will close the application, clicking how to play will take you to a screen that shows the basic controls and tells you what the objective is, and play game will take you to the level select screen. 

### Level Select Screen

On the level select screen the player can pick from any of three levels. They also have an option to reset the times on the levels if they wish to and they can return to the main menu.

### How to Play Screen

This is the screen with the controls displayed for the player and it tells the player the objective. There is a button to go back to the main menu of the game.

## 4. Requirement Analysis

I have been playing games for a vast majority of my life. Throughout my time playing video games, I have always appreciated games that have made moving through the game fun to do. As opposed to a way to get from point A to point B. This is primary the reason I made this game.

These are some things I wanted to ensure my game had before it was finished:

1. Must have a grappling hook that uses momentum to throw the player through the level
2. Must have a working timer.
3. Must have a "How to Play" screen for new players.
4. Must have music play so the game is not audibley boring.
5. The best time must be displayed on the level select screen and replace the old time.
6. Must have an object in the game that the player must avoid.
7. Have an object that signifies hte end of the level.
8. Have a title screen.
9. Have sound effects for objects to make them feel better as part of the level.
10. Have at least 3 levels.

## 5. Test Plan Excel Sheet

[Test Plan for the Capstone](https://github.com/NicholasKing76/Swingin-Good-Time/files/6346450/TestPlan.xlsx)

![TestPlan](https://user-images.githubusercontent.com/54336920/115762165-c7dce180-a368-11eb-9f72-7002a540b5a2.png)


## 6. Gameplay

https://user-images.githubusercontent.com/54336920/114916240-314d7500-9dea-11eb-9467-1a1d1b4150be.mp4

## 7. In line Code

public void PauseGame()
{
        Time.timeScale = 0f;
        isPaused = !isPaused;
        menu.SetActive(isPaused);
        print("Game Paused");
        Cursor.lockState = CursorLockMode.Confined;
        GameObject.Find("Player").GetComponent<MovementPlayer>().enabled = false;
        Cursor.visible = true;
}
 
## 8. Liscense

MIT
