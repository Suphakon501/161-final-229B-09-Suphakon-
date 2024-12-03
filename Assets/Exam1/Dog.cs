using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;
    private void Start()
    {
        dailyFoodConsumption = 2;
        activityLevel = 3;
        Init("Dog");
        MakeSound();
        DisplayName();
        CalcuateFoodRequirement();
    }
    public override float CalcuateFoodRequirement()
    {
        float FoodRequirement = (dailyFoodConsumption) * activityLevel * 7;
        Debug.Log($"{animalName} weekly food Requirement{FoodRequirement}");
        return FoodRequirement;
    }

    public override void MakeSound()
    {
        Debug.Log($"{animalName} Baek: woof ");
    }
    public override void DisplayName()
    {
        Debug.Log($"{animalName} eats {dailyFoodConsumption}Kg of food daily and activity level {activityLevel} Kg");
    }

}
