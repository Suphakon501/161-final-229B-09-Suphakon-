using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpell : Spell
{
    private void Start()
    {
        Cast();
        Cast("gonlin");
        Cast("gonlin",100);

    }
    public override void Cast()
    {
        Debug.Log($"Casting to Rock");
    }
}
