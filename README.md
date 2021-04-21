# Stride FileSystem Preview

This program allows you to list all files inside your Stride `ObjectDatabase` (i.e. compressed files in the `/data/db` folder). It opens the `default` bundle. Requires .NET 6 SDK to compile into a single file which you would then copy into the folder next to your game's exe and execute in the command line.

Example output from a default Stride project:

```
Opening database at '~Documents\Stride Projects\EmptyGame\Bin\Windows\Debug\data\db'
.... (some unnamed files and compiled shader cache)
 600KB  fonts/Courier New Bold.ttf
  167B  StrideDefaultFont
   2KB  StrideUIDesigns__ATLAS_TEXTURE__0
  309B  StrideUIDesigns
  230B  StrideUIDesigns/gen/Sprite_1
  233B  StrideUIDesigns/gen/Sprite_2
  230B  StrideUIDesigns/gen/Sprite_3
  233B  StrideUIDesigns/gen/Sprite_4
  236B  StrideUIDesigns/gen/Sprite_5
  237B  StrideUIDesigns/gen/Sprite_6
  238B  StrideUIDesigns/gen/Sprite_7
  229B  StrideUIDesigns/gen/Sprite_8
  226B  StrideUIDesigns/gen/Sprite_9
  240B  StrideUIDesigns/gen/Sprite_10
  236B  StrideUIDesigns/gen/Sprite_11
  237B  StrideUIDesigns/gen/Sprite_12
  243B  StrideUIDesigns/gen/Sprite_13
  239B  StrideUIDesigns/gen/Sprite_14
   2KB  StrideUILibrary
   1MB  StrideDefaultSplashScreen
   7KB  StrideDebugSpriteFont
.... (a bunch of shader files)
  419B  GameSettings
   2KB  GraphicsCompositor
   1KB  MainScene
  11KB  Skybox texture
  224B  Ground
  623B  Ground Material
  215B  Sphere
  623B  Sphere Material
   8KB  StrideEnvironmentLightingDFGLUT16
   5KB  StrideEnvironmentLightingDFGLUT8
   1MB  Skybox texture_Data
```
