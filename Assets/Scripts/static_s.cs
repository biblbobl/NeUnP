using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class static_s
{
    public static GameObject door;
    public static int carrot;
    public static int max_carrot = 7;
    public static void restart()
    {
        carrot = 0;
    }
public static void kost()
{
    if (carrot >= max_carrot)
{
door.GetComponent<SpriteRenderer>().enabled = true;
}
}
    
}

