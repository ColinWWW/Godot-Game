using Godot;
using System;

public partial class player : CharacterBody2D
{
	const float speed = 100f;
	public override void _PhysicsProcess(double delta) {
		Vector2 velocity = Velocity;

		Vector2 directionInput = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");

		velocity = directionInput * speed;

		Velocity = velocity;
		MoveAndSlide();
	}

}
