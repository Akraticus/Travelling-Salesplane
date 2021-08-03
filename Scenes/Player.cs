using Godot;
using System;

public class Player : Node2D
{
    [Export] public int Speed = 200;
    [Export] public int RotationSpeed = 200;
    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Console.WriteLine("Actions: " +  InputMap.GetActions());
    }

  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
      var rotation = 0f;
      var forwardMovement = 0f; 

      if (Input.IsActionPressed("ui_left"))
      {
          rotation -= 1f;
      }

      if (Input.IsActionPressed("ui_right"))
      {
          rotation += 1f;
      }

      Rotation += rotation * RotationSpeed * delta;
      
      if (Input.IsActionPressed("ui_up"))
      {
          // GAS GAS GAS
          forwardMovement += 1f;
      }
      
      if (Input.IsActionPressed("ui_down"))
      {
          // BRAKE BRAKE BRAKE
          forwardMovement -= 1f;
      }

      Position += new Vector2(Mathf.Cos(Rotation), Mathf.Sin(Rotation)) * forwardMovement * Speed * delta;
      // apply all that shit
      // Position = 
  }
}
