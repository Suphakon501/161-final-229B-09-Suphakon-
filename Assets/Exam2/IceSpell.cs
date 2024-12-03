using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("boy");
        Cast("boy",6);

    }
    public override void Cast()
    {
        Debug.Log($"Casting to Ice");
    }

}
