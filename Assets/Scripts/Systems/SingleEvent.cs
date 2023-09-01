using System;


public  static class SingleEvent 
{
    public static Action Score;
    public static Action Timer;

    public static void ActionScore() => Score?.Invoke();
    public static void ActionTimer() => Timer?.Invoke();
}
