using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    public void Init(string newAnimalName)
    {
        animalName = newAnimalName;
        Debug.Log($"This is a {animalName}");
    }
    public abstract float CalcuateFoodRequirement();
    public virtual void MakeSound()
    {
        Debug.Log("The animal makes a sound");
    }
    public virtual void DisplayName()
    {
        
    }
}
