# About

Hot-reload-enabled modification of the https://github.com/cadfoot/unity-ecs-bubble-shooter.

The purpose of this fork is to proof that [leohot-classic](https://github.com/kkolyan/leohot/tree/classic) (Unity hot-reload extension for [LeoECS Classic](https://github.com/Leopotam/ecs)) works.

# Modifications

Slight refactoring that at most allow to use hot-reload extension properly: pipeline (EcsSystem) split into two,
because with hot-reload there are two "init" phases - one that initializes game state and run only once,
and one that initializes miscellaneous things and should be run after each hot-reload.

