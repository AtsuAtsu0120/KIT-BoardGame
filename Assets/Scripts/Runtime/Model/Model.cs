using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Model
{
    public static GameMaster GameMaster { get; private set; }
    static Model()
    {
        GameMaster = new();
    }
}
