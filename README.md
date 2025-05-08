# Node based Pathfinding & Shcheduling system 

Proof of concept of a node based pathfinding and scheduling system for NPC's in a 2D game, made with Unity.

The system allows NPCs to follow custom daily routines, switch between job presets, and navigate intelligently using an A* algorithm over a connected node graph.

## Features

#### Node-Based Pathfinding
- NPCs navigate the world using A* algorithm over a manually placed node graph, allowing custom movement scenarios.
#### Personal Schedule System
- Each NPC has a personalized schedule that defines their routine throughout the day (e.g. where they should be at a given time).
#### Job Schedule Presets
- Reusable job schedules (e.g. "Blacksmith", "Farmer") can be assigned to any NPC and layered on top of their own routine.
#### Time-Driven Behavior
- NPC movement and schedule logic are driven by an in-game clock using time and days.
