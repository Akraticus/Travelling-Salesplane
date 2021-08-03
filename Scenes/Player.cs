using Godot;

public class Player : Node2D
{
    [Export] public int SlowSpeed = 75;
    [Export] public int DefaultSpeed = 150;
    [Export] public int FastSpeed = 300;
    [Export] public int TurnSpeed = 10;
    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
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

      Rotation += rotation * TurnSpeed * delta;
      
      if (Input.IsActionPressed("ui_up"))
      {
          // GAS GAS GAS
          forwardMovement = FastSpeed;
      }
      else if (Input.IsActionPressed("ui_down"))
      {
          // BRAKE BRAKE BRAKE
          forwardMovement = SlowSpeed;
      }
      else
      {
          forwardMovement = DefaultSpeed;
      }

      Position += new Vector2(Mathf.Cos(Rotation), Mathf.Sin(Rotation)) * forwardMovement * delta;
  }
}
