# Aiming
Aiming asset extends the Movement asset with the function of rotating the character in a given direction, regardless of the direction of movement.

## About
Asset uses the input from the Virtual Joystick to rotate the character in a given direction while blending movement animations with aiming animations.

The AimController component is responsible for reading the angle input from the Virtual Joystick in order to rotate the character in a given direction. It provides only one parameter:
- Virtual Joystick - reference to the VirtualJoystick component.

Unity version:
- 2021.2.7f1.

Assets used:
- [Movement](https://github.com/Feralnex/Unity-Movement).

## Usage
The method of using an asset is the same as for the Movement asset. Additionally, the Player prefab has been extended with the AimController component, to which you should assign a Virtual Joystick responsible for the rotation of the character in a given direction, regardless of the direction of the character's movement.

An "Example" scene is prepared, which shows how an asset can be used.