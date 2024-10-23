using UnityEngine;

public class Banana : Fruit
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void DeathEffect() {
        print("Death");
    }
}
