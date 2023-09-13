# dino-run

## General Information
1. Full unity projects are difficult to push to github due to file size constraints, so this repository contains the C# scripts for the game objects in a simple pong game.
2. When the game starts, press space to make the dino jump and avoid the cacti.
3. If the dino hits one of the cacti, the game ends. The player is prompted to try again.
4. Each cactus that the dino successfully evades grants 1 score.
5. Once the cactus and cloud gameobjects leave the screen, they are destroyed to maintain memory.

## Script Information
1. cactusScript.cs handles the movement and collision behavior of the cacti (the dino remains stationary throughout the game, only the cacti move toward it thus creating the illusion of movement).
2. cloudScript.cs handles the movement of the cloud game objects above the dino. These do not have any significant gameplay involvement.
3. spawnerScript.cs creates cactus gameobjects in groups of one or two based on a set timer (the cacti may be spaced apart randomly within a given range).
4. cloudSpawner.cs, similarly to spawnerScript, spawns the clouds based on a set timer and randomly spaced apart within a given range.
5. dinoScript.cs handles the jumping behavior of the dino.
6. logicScript.cs handles the rules of the game and the scoreboard management. It will also prompt the player to reset the game upon collision with a cactus.
7. midScript.cs handles the trigger that is placed in the middle of each cactus or between a joined pair of cacti. This trigger is used to track when the dino jumps over a cactus and updates the scoreboard accordingly.

## Images
1. When the game is first started, it will look something like this.
![gamestart](https://github.com/ngolp/dino-run/assets/144621445/33d9983b-3b15-4029-9a7d-6ba7b097725c)

2. When the player scores, the scoreboard will update accordingly. When the dino collides with a cactus, the following screen will appear.
![gameOver](https://github.com/ngolp/dino-run/assets/144621445/822aca08-e351-4eca-b425-286565baef5f)

## Authors
 - Nicholas Golparvar
