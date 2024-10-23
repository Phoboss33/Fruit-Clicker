

public class FruitBomb : Fruit, IShowEffects, IExploadeable
{
    public void ExplosionEffect() {
        print("Exposion");
    }

    public void ShowEffect() {
        throw new System.NotImplementedException();
    }

    protected override void DeathEffect() {
        ExplosionEffect();
    }
}
