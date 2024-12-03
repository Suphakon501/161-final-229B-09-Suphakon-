using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    string target;
    int power;
    private void Start()
    {
        Cast();
    }
    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Slimulation Started!");
    }
    public void Cast(string newTarget) 
    {
        target= newTarget;
        Debug.Log($"Casting to {target}");
    }
    public void Cast(string newTarget, int newPower)
    {
        target = newTarget;
        power = newPower;
        Debug.Log($"Casting to {newTarget} with power level {power}");
    }

}
