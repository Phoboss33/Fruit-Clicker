using UnityEngine;

public class Cherries : Fruit
{
    private void OnEnable() {
        AudioManager.Instance.PlaySound(_SpawnSound);
    }
    protected override void DeathEffect() {
        AudioManager.Instance.PlaySound(_DeathSound);
    }
}
