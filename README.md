# HW4
## Devlog
If I'm understanding the MVC pattern correctly, the Controller would be the Player, and the View is the Audio, GameController, and UI scripts. 


The Player script contains the way the player interacts with the game (pressing the space bar and hopping up). All the other scripts are for the feed back of the gameplay. The Audio emphasizes when the player is getting a point, the UI tracks it and shows it on screen, and the GameController is spawning the obstacles. When the player dies, all the other elements will react appropriately. The GameController stops spawning obstacles and destroys the remaining ones, the UIHandler switches on a Game Over screen that'll tally up the final score, and the audioHandler plays a sad trombone. 


The GameController is a singleton, and acts as the locator for the Player so all the other scripts can subscribe to the Player's events.

Player has 2 main events- scoring a point and the game over/hitting an obstacle. By using the GameController a singleton and locator for the Player, it decouples the View systems and the Control systems. The player doesn't need to have references to any of the other scripts, all it has to do is provide the info of what's happening in the game. All the View systems can easily subscribe to the event through the GameController and react appropriately for either event. 

There's also one event that belongs to the GameController- for when the player hits the "reset" button on the game over and restarts the game. I probably could've also put this in the player script, but in the moment I ended up giving it to the GameController. 



## Open-Source Assets
- [Simple Bird Sprites](https://hredbird.itch.io/simple-bird-sprites) - Bird sprites
- [Industrial Pipe Platformer Tileset](https://wwolf-w.itch.io/industrial-pipe-platformer-tileset) - Pipe and Ground sprites
- [Double Exclamation Mark Emoji](https://emojiterra.com/double-exclamation-mark/) - Bang bang emoji, Google Noto Color Emoji 16.0
- [Classic Game Action Positive 5](https://pixabay.com/sound-effects/film-special-effects-classic-game-action-positive-5-224402/) - Score sfx
- [wah wah sad trombone](https://pixabay.com/sound-effects/film-special-effects-wah-wah-sad-trombone-6347/) - Game over sfx
