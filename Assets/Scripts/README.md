# Gloom-and-Utter-Darkness

## Notes for me

### Proposed Namespaces

- `GloomAndUtterDarkness.Core`: This contains the essential, foundational classes or systems of your game.
    - `GloomAndUtterDarkness.Core.Utilities`: Generic helper classes, such as math helpers, color helpers, extension methods.
    - `GloomAndUtterDarkness.Core.Managers`: Core systems like scene management, game state management, resource management.
    - `GloomAndUtterDarkness.Core.Audio`: Systems for handling audio management, music, and sound effects.
    - `GloomAndUtterDarkness.Core.UI`: Base classes and systems for UI functionality.
    - `GloomAndUtterDarkness.Core.SaveLoad`: Functionality for saving and loading game data.
    - `GloomAndUtterDarkness.Core.Events`: Systems for game events and callbacks.
    - `GloomAndUtterDarkness.Core.Networking`: If your game has multiplayer functionality, networking related code will go here.

- `GloomAndUtterDarkness.Player`: Contains the scripts controlling the player character.
    - `GloomAndUtterDarkness.Player.Controllers`: Control systems for the player character.
    - `GloomAndUtterDarkness.Player.Inventory`: The player's inventory system.
    - `GloomAndUtterDarkness.Player.Abilities`: If there are special abilities, perks etc. for the player.

- `GloomAndUtterDarkness.Zombies`: Contains the scripts controlling the zombie characters.
    - `GloomAndUtterDarkness.Zombies.Controllers`: Zombie control systems.
    - `GloomAndUtterDarkness.Zombies.Behaviors`: Different behaviors or types of zombies.

- `GloomAndUtterDarkness.Environment`: For the environment-related scripts.
    - `GloomAndUtterDarkness.Environment.Levels`: Individual level-specific scripts.
    - `GloomAndUtterDarkness.Environment.Obstacles`: Interactable environment objects (like doors, traps, etc.).
    - `GloomAndUtterDarkness.Environment.Terrain`: If there are specific scripts for terrain manipulation.

- `GloomAndUtterDarkness.Projectiles`: For projectile-related scripts.
    - `GloomAndUtterDarkness.Projectiles.Types`: Different types of projectiles (like bullets, grenades, etc.).

- `GloomAndUtterDarkness.Weapons`: For weapons related scripts.
    - `GloomAndUtterDarkness.Weapons.Types`: Scripts for different types of weapons.
    - `GloomAndUtterDarkness.Weapons.Effects`: Scripts for different effects weapons can have.
   
- `GloomAndUtterDarkness.Dialogues`: Contains scripts controlling dialogues in the game.
    - `GloomAndUtterDarkness.Dialogues.PlayerDialogues`: Contains scripts controlling player dialogues.
    - `GloomAndUtterDarkness.Dialogues.ZombieDialogues`: Contains scripts controlling zombie dialogues.
    - `GloomAndUtterDarkness.Dialogues.Trees`: Contains scripts related to dialogue trees (if your game has such mechanics).
    - `GloomAndUtterDarkness.Dialogues.VoiceLines`: Contains scripts related to voiced dialogues (if your game has such mechanics).

- `GloomAndUtterDarkness.AI`: If there are non-zombie NPCs or more complex AI logic.
- `GloomAndUtterDarkness.UI`: For more specific UI systems, including menus, HUD, inventory UI, etc.
- `GloomAndUtterDarkness.Vehicles`: If your game includes any sort of vehicles.
- `GloomAndUtterDarkness.Crafting`: If your game includes crafting system.
