[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog

In the breakdown image of my plan, I specified four GameObjects: Player, Coin, GameController, and Tilemap.

### How I Implemented My Plan

To execute the plan, I create the 4 GameObjects. However, I find that the Tilemap was unnecessary(because I only needed to create a 2D Square object and I don't need any code support). For this reason, the Tilemap GameObject was removed from my plan as a revision.

To implement the rest of the plan, I created three scripts: Player, Coin, and GameControl. These scripts use to implement action in my plan of their respective GameObjects, such as jumping and updating the UI.

Additionally, my MG2 project includes some actions not outlined in the original plan. For example: coins are destroyed when they move off-screen, coins automatically move toward the left side of the screen, and the spawn delay time for coins is randomized.

### plan connect to the code

For all the attributes defined in the plan, I attached corresponding components to  GameObjects(player and coin)including Collider2D, Renderer, and Rigidbody2D.

Next there are connection between action in plan and code.

1. Jumping Mechanic: The jump function was coded using velocity in the Update() method. To prevent double jumps, I used the OnTriggerEnter() method, in the method i write code when the GameObject collides with the ground, the isGround boolean switches from false to true.

2.	Point Collection: This function also use the OnTriggerEnter() method. When the Player collides with a Coin, the Coin GameObject is destroyed and the point count add 1

3.	UI Update: I write a method called UpdatePoint() that converts the int point into Text used by Tostring

4.	Coin Spawning: I used the Instantiate() method to generate coins. A timer was implemented with an if statement to control the spawning frequency.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites