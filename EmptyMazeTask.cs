namespace Mazes;

public static class EmptyMazeTask
{
	public static void MoveOut(Robot robot, int width, int height)
	{
		while (robot.X != width-2)
			robot.MoveTo(Direction.Right);
		while (robot.Y != height - 2)
            robot.MoveTo(Direction.Down);
    }
}