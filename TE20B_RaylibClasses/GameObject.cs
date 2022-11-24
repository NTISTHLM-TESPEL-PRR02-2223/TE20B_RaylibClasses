public class GameObject
{
  protected Rectangle rect;

  protected Color color;

  public GameObject()
  {
    rect = new Rectangle(0, 0, 32, 32);
  }

  public void Draw()
  {
    Raylib.DrawRectangleRec(rect, color);
  }

  public virtual void Update()
  {

  }
}
