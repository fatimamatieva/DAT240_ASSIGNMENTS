# Image guessing game

## Background 

Recent advances in computational capabilities of machines along side advances in algorithmic intelligence, have surpassed expectations and resulted in stagg
ering feats such as 'AlphaGo' defeating a world champion in the game of Go using deep neural networks. With all the
perceived superiority of machines in decision making using Deep Learning we are interested in the question -- Do machines think like humans?



## The game

There are some games which are designed to be fun but also achieve something useful. Such games are called [games with a purpose (GWAP)](https://en.wikipedia.org/wiki/Human-based_computation_game) 
In this game, you will attempt to do this by making a single or two-player game on recognizing images.
In single player mode you will be playing against an oracle.
In two player mode, two players are paired in the beginning of the game -- The Proposer and the Guesser. 

### Rules of the game

The proposer get to see the entire image and the label
that he has to help the guesser guess the label. The sooner the Guesser succeeds, the more points both the Guesser and the Proposer get.
Example of Image and label : The proposer is shown this image and wants the guesser to guess: GoKart




### Oracle mode

  * User should be able to register and log in. 
  * User should be able to create a new game
  * Single Player: 
    - An Oracle service selects an image for the game
    - The oracle randomly selects a tile
    - The tile is shown to the user
    - The user makes a guess
    - The Oracle verifies the guess.
    - If the Oracle decides to pick another tile, the various tiles can be combined with a library like ImageSharp before showing it to the client.
    - If the user get's it right, the app should display the complete image. 
  * The app could keep track of a leaderboard. 
  * The app should show a list of recent games
  * All of this can be done with a regular webpage and GET/POSTs 

### Two player mode
