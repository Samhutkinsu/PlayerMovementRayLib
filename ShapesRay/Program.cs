using Raylib_cs;
namespace ShapesRay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.SetTargetFPS(60); //Sets Max FPS
            int recX = 0;
            int recY = 0;
            int screenWidth = 800;
            int screenHeight = 400;
            Raylib.InitWindow(screenWidth, screenHeight, "ShapesRay"); // Intilizes window


            Image image = Raylib.LoadImage("C:\\Users\\25YasinS\\Documents\\Other\\ShapesRay\\assets\\PlayerIcon.png"); //Loads Image from Computer
            Texture2D playerTexture = Raylib.LoadTextureFromImage(image); //Turns image into texture
            Raylib.UnloadImage(image); //Unloads image from texture

            recX = screenWidth / 2 - playerTexture.Width/2; // Player's Starting X
            recY = screenHeight / 2 - playerTexture.Height/2; //Player's Starting Y





            while (!Raylib.WindowShouldClose()) // Game Loop
            {
                Raylib.BeginDrawing(); // Begin Drawing
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) { recX += 3; } //Controls
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) { recX -= 3; }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_W)) { recY -= 3; }
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) { recY += 3; }
                    Raylib.ClearBackground(Color.RAYWHITE); // Draws Background
                    Raylib.DrawRectangle(recX, recY, 30, 30, Color.BLUE); // Draws rectangle in place of sprite
                    Raylib.DrawTexture(playerTexture, recX, recY, Color.WHITE); // Draws Players Sprite
                    Raylib.DrawText("RPG Movement Program", 285, 12, 20, Color.LIGHTGRAY); // Draws text on top of the screen
                    Raylib.DrawText($"Players X Position: {recX}, Players Y Position: {recY}", screenWidth/5, 350, 20, Color.LIGHTGRAY); // Debug
                Raylib.EndDrawing(); // ends drawing
            }
            Raylib.UnloadTexture(playerTexture);
            Raylib.CloseWindow(); // Closes Window
        }
    }
}