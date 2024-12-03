using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private float dailyFoodConsumption;
    private float weight;

    private void Start()
    {
        dailyFoodConsumption = 1;
        weight = 2;
        Init("Bird");
        MakeSound();
        DisplayName();
        CalcuateFoodRequirement();
    }
    public override float CalcuateFoodRequirement()
    {
        float FoodRequirement = (dailyFoodConsumption) * weight * 7;
        Debug.Log($"{animalName} weekly food Requirement{FoodRequirement}");
        return FoodRequirement;
       
    }
    public override void MakeSound()
    {
        Debug.Log($"{animalName}chirps: tweet");
    }
    public override void DisplayName()
    {
        Debug.Log($"{animalName} eats {dailyFoodConsumption}Kg of food daily and weight {weight} Kg");

    }
}
