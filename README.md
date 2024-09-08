# NoRespawns-Plugin
**NoRespawns-Plugin** disables respawning of teams (MTF and Chaos Insurgency) in the game **SCP: Secret Laboratory**, preventing them from being revived for the entire round.

## Features
- Disables respawning of all teams.
- Easy to set up with a configuration file.
- Ability to enable debug mode to display additional messages.

## Installation
1. Download the latest version of the plugin from [Releases](https://github.com/aksueikava/NoRespawns-Plugin/releases).
2. Place the plugin file in the `Plugins` folder of your SCP: SL server.
3. Restart the server to activate the plugin.

## Configuration
After the first run of the plugin, a configuration file is created. You can modify it as you wish:
```yml
NoRespawns:
#Is the plugin enabled?
  is_enabled: true
  #Are debug messages displayed?
  debug: true
```
