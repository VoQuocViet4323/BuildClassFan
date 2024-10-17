using System.Drawing;

public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    public int speed;
    public bool on;
    public double radius;
    public string color;
    public Fan()
    {
        speed = SLOW;         // Mặc định tốc độ là SLOW
        on = false;           // Mặc định quạt tắt
        radius = 5;           // Mặc định bán kính là 5
        color = "blue";       // Mặc định màu là blue
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public override string ToString()
    {
        if (on)
        {
            return $"Fan is on: Speed = {speed}, Color = {color}, Radius = {radius}";
        }
        else
        {
            return $"Fan is off: Speed = {speed}, Color = {color}, Radius = {radius}";
        }
    }
}