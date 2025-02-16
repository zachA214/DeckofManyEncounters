# DeckofManyEncounters
GitHub repo for CrimsonCode 2025 for team I Cast 400 Bugs <br><br>
## Developers: 
- [Christian Estlund](https://github.com/christianestlund)<br>
- Willow Zuvich [[1]](https://github.com/WillowZuvich) [[2]](https://github.com/IcyMarty)<br>
- [Zachary Adelson](https://github.com/zachA214)<br>
- [Sarah Carley](https://github.com/Stellarone60)<br>

## Information Log:

#### D&D Encounter Generator/Builder
Purpose
> Tool for generating creatures/lists of creatures and ideas for a given set of encounter parameters

Parameters
> Difficulty: List of options (easy, medium, hard, etc.) <br>
> Creature Count: Total creatures in the encounter <br>
> Party level: Average party level <br>
> Party size: Total party count <br>
> Realm: Where the encounter will take place <br>
> Swim: Togglable value <br>
> Fly: Togglable value <br>

Challenge rating Calculation
0.25 * Average Party Level * Party Size + Difficulty = Recommended CR <br>

Utilizing multiple algorithms for determining output, returning many outputs for each prompt so that there are variety of encounters that can be chosen from

## Usage:

Clone the github repo, and move the image folder, monsterimage folder, and dataset.csv to the /bin/debug folder in order to properly run
