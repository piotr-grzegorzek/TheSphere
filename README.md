# TheSphere Project

TheSphere is a Unity project that utilizes various assets and modules to create an immersive experience.

## Project Structure

Crucial folders and files are located in [Assets/TheSphere/Scripts](Assets/TheSphere/Scripts) folder.

- [Assets/TheSphere/Scripts/Constant/](Assets/TheSphere/Scripts/Constant) contains constant values used in the project.
- [Assets/TheSphere/Scripts/Player/](Assets/TheSphere/Scripts/Player) contains scripts attached to the player object:
  - [`Movement.cs`](Assets/TheSphere/Scripts/Player/Movement.cs)
  - [`Score.cs`](Assets/TheSphere/Scripts/Player/Score.cs)
  - [`Time.cs`](Assets/TheSphere/Scripts/Player/Time.cs)
- [Assets/TheSphere/Scripts/Point/](Assets/TheSphere/Scripts/Point) contains scripts attached to the collectible point object:
  - [`Movement.cs`](Assets/TheSphere/Scripts/Point/Movement.cs)
  - [`Trigger.cs`](Assets/TheSphere/Scripts/Point/Trigger.cs)
- [Assets/TheSphere/Scripts/CameraMovement.cs](Assets/TheSphere/Scripts/CameraMovement.cs) contains the camera script that follows the player.
- [Assets/TheSphere/Scripts/KillBoxTrigger.cs](Assets/TheSphere/Scripts/KillBoxTrigger.cs) handles the kill box trigger.
- [Assets/TheSphere/Scripts/MenuClick.cs](Assets/TheSphere/Scripts/MenuClick.cs) manages the menu click events.
- [Assets/TheSphere/Scripts/SceneController.cs](Assets/TheSphere/Scripts/SceneController.cs) controls the scene transitions.
- [Assets/TheSphere/Scripts/TextHighScores.cs](Assets/TheSphere/Scripts/TextHighScores.cs) manages the high scores text.
- [Assets/TheSphere/Scripts/TextScoreController.cs](Assets/TheSphere/Scripts/TextScoreController.cs) controls the score text.
- [Assets/TheSphere/Scripts/TextTimeController.cs](Assets/TheSphere/Scripts/TextTimeController.cs) controls the time text.
- [Assets/TheSphere/Scripts/ThemeController.cs](Assets/TheSphere/Scripts/ThemeController.cs) manages the background music of the game.

## Assets

The project uses several assets which include:

- [Asteroids Pack](Assets/Asteroids%20Pack)
- [MilkyWay](Assets/MilkyWay)
- [Planet Earth Free](Assets/Planet%20Earth%20Free)
- [Stylized Lava Materials](Assets/Stylized%20Lava%20Materials)
- [TextMesh Pro](Assets/TextMesh%20Pro)

## External Resources

The project also uses external resources as listed in the [external.txt](external.txt) file.