using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FireSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("Slime");
        Cast("Slime",10);

    }
    public override void Cast()
    {
        Debug.Log($"Casting to Fire");
    }
}
