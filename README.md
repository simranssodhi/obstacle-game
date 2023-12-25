# Obstacle Course Game

Objective

 Player should be able to reach final destination B(top right), starting at the initial point A(bottom left), dodging obstacles on the path.

 Different Aspects of game
  * Players
 It is a single player game and input from the same is taken into account throughout the game session. Arrow keys are used to control the player movement

  * Gameplay
 It is narrated by the computer with different obstacles which are of various types
     * Stationary: Obstacles including various shapes like cubes, spheres, prisms, trees, buildings etc
     * Moving: Obstacles shown spinning down ramps and rolling across the gameboard
     * Falling: After about 15 seconds of game play, objects start falling, shown using the
 particle effect of shadows and lighting.

  * Score: Increase the score for each obstacle the player manages to avoid. For Stationary objects, score increments by 10, for moving objects it gets incremented by 20 and 50 for the falling objects. If the player successfully reaches destination B without dying ( health reducing to 0), increment the score by 100.

  * Health: It starts at 100 and with every obstacle hit, it shall go down by 50 for stationary obstacles hit, by 20 for moving obstacles and 10 for falling obstacles. As soon as health reaches 0, the game terminates and the player's final score is flashed on screen

  * Background Music : Pink Panther Theme song.

  * Particle effect: Shadows used for depicting falling objects realistically.
 Whenever the player bumps into an obstacle, its colour changes momentarily. The collision also creates a noise.

  * Constraining Measures
     * Requires one player for the game to be played
     * At any point, players health reduces to 0, player will die and game exits.
     * Each obstacles has a fixed score which will be subtracted from the score if he collides
 with the same.
