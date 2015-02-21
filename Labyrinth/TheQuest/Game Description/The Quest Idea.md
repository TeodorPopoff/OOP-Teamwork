Game Title: The Quest

Main Idea: implement an RPG based on the recently released movie trilogy - The Hobit. The main character will be Torin Oakenshield. His objective will be get accross the playing field and reach the treasure on the other side. The playing field will be a labirinth-like rectangle with many possible routes and directions to go. At random places on the playing field there will be enemies (orks, evil magicians and other monsters), friends (elves, good magicians, eagles, men) and other dwarves (12 dwarves in total - Torin's team). Torin's task will be to avoid and / or defeat the enemies with the help of his fellow dwarves and friends.

The playing field:
- a rectangle with a constant size, for example 30 x 60
- upper left corner is Torin's start position.
- lower right corner is the destination - the location of the treasure.
- on random locations are placed random number (in a certain range, e.g. 1...3 evil magicians) and types of enemies and friends
- on random locations are placed the other members of Torin's crew - 12 dwarves
- the location of all enemies, friends and dwarves is hidden from Torin

The Game logic:
- on each turn Torin has to choose in which direction to go. The user makes the choice by typing a command: right, left, up or down
	- before making the move Torin gets hints from the game in the form of messages such as:
		- "A large bands of orks is nearby, beware!"
		- "Help is nearby, Gandalf is comming to join you."
		- "Hey Torin, Bombur is nearby - go and join him to your team."
		- "Small band of wargs is close. Beware!"
- when Torin makes his choice he moves in the choosen direction and what is hidden there is revealed:
	- if it is empty space, Torin has to make another move
	- if there is an enemy a battle is fought
			- if Torin's team wins the battle, they move forward
			- if they loose the battle, it is Game Over
	- if there is a friend there, he/she joins forces with Torin's team
- the game is played until Torin reaches the lower right corner of the field or he is defeated by the enemies.

Characters:

Dwarves:
- Torin - main player
- Dwarves - 12 in total. Dwarves are loyal friends. Once they join the team they stay with Torin until the end fight with him side by side.

Friends:
- Elves - they are powerful friends but fairly unpredictable. You never know for how long they will stay with you or if they will flee just before a battle.
	- Legolas
	- Tauriel
	- Thranduil
- Good Wizzards - also powerful friends, but very busy. They stay with Torin for only 1...3 moves and then they go to take care of other business.
	- Gandalf the Grey
	- Galadriel
	- Elrond
	- Radagast The Brown
	- Saruman The White
- Animals:
	- Eagles
	- Beorn

Enemies:
- Orks
- Goblins
- Evil wizzards:
	- The Necromancer
	- The Witch King of Angmar
	- Sauron
- Wargs
- Trolls

All characters have properties:
- Strength - different value for every type of character
- Symbol - a Unicode character, used to draw them on the playing field
- Magicians may not have a strength property because they will not fight directly in battles.
	- they can have spell powers:
		- when good magicians join our team they increase our strength with X%
		- when bad magicians meet us they decrease battle strength with Y%

Game commands:
- arrow keys - used for moving Torin up, down, left or right
- team - prints info about the team - strength and number
- friends - prints info about the remaining friends on the playing field
- enemies - prints info about the remaining enemies on the playing field

Moves:
- if we meet a dwarf - we join him to ThorinTeam; we increase the power of the team
- If we meet a friend Magician:
	- we join him to ThorinTeam for a number of moves == Magician.Presence
	- we increase the strength of the team with Magician.SpellPower coefficient
- if we meet enemy Magician:
	- we decrease the strength of the team with Magician.SpellPower coefficient
- if we meet an IFriend, not a Magician:
	- we join him to the team
	- we increase the strength of the team
- if we meet an IEnemy, not a Magician:
	- we fight a battle
	- the team with bigger strength winns
	- if the enemy has bigger power than ThorinTeam, we are given options:
		- if we have eagles - to fly away to a new location
		- if we have horses - to run away to a new location
		- if we take either option, we remove the eagles / horses from the team (we can take advantage of them only once)
- if we meet food:
	- we increase our strength with X
- if we meet weapons:
	- we increase our strength with Y
- if we meet eagles:
	- we increase our flying range
- if we meet horses:
	- we increase our riding range
- when the team moves:
	- all members move together in the same direction
	- for all Magicians on the team we do Magiciansns.Presence--
		- when the Precense of a Magician == 0, we remove him/her from the team and we decrease the team's strength with Magician.SpellPower coefficient
		- when we remove a Magician from the team, we relocate it to a Random new location
	- the game prints info on allocation of nearby characters
- when the team strength <= 0:
	- we print Game Over Message
	- we give options: Exit / New Game
- when we select the command Fly Away:
	- depending on the available flying range, the whole team is moved to another random and free location - but not closer to the destination
- - when we select the command Ride Away:
	- depending on the available riding range, the whole team is moved to another random and free location - but not closer to the destination


Events in Thorin's Team class:

- When we join a Character to the team the class fires the CharacterJoinedTheTeam(Character character, string message)
	- the event is fired from the AddMember () method
- When a Magician leaves the team because its presence has finished the class fires: CharacterLeftTheTeam(Character character, string message)
	- the event is fired from the Move() method
	- the event is fired after we call the method RemoveMember(Character member)
- During a battle the class fires the event CharacterDiedInBattle(Character character, string message)
	- we start the battle first by initializing a variable with the starting strength of the team
		- we use this variable to decrement it during the course of the battle
	- we check if our strength is less than that of the enemy
		- if yes, we loose the battle and the game is over: we set this.IsAlive = false
	- we create a loop:
		while (enemy strength > 0) {
			currentFighter = companions[last companion]
			begining battle strength = currentFighter.BattleStrength
			currentFighter.BattleStrength -= enemy.BattleStrength;
			if(currentFighter is dead) {
				enemy.BattleStrength -= beginning battle strength
				this.Remove(currentFighter)
				fire event CharacterDiedInBattle(Character currentFighter, "e.g. Bombur died cheroicaly in battle...")
			}
		}









































