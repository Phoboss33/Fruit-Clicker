using Unity.VisualScripting;
using UnityEngine;


public class FruitBomb : Fruit, IShowEffects, IExploadeable
{
    [SerializeField] private GameObject _sfx;
    public void ExplosionEffect() {
        Instantiate(_sfx, transform.position, Quaternion.identity);
    }

    private void OnEnable() {
        AudioManager.Instance.PlaySound(_SpawnSound);
    }

    public void ShowEffect() {
        
    }

    protected override void DeathEffect() {
        AudioManager.Instance.PlaySound(_DeathSound);
        ExplosionEffect();
    }
}
