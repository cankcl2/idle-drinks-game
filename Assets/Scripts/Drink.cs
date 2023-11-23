using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Drink", menuName = "Idle Game/Drinks")]
public class Drink : ScriptableObject
{
    public string drinkName;
    public float basePrice;
    public float multiplier = 1.15f;//1.07f - 1.15f
    public float baseIncome;

    public Sprite drinkImage;
    public Sprite unknownDrinkImage;

    public float CalculateCost(int amount)
    {
        float newPrice = basePrice * Mathf.Pow(multiplier, amount);
        float rounded = (float)Mathf.Round(newPrice * 100) / 100;
        return rounded;//exponential flow
    }

    public float CalculateIncome(int amount)
    {
        return baseIncome * amount;//linear flow
    }
}
