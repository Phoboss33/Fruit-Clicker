

public class Watermelon : Fruit, IShowEffects
{
    public virtual void ShowEffect() {
        throw new System.NotImplementedException();
    }

    protected override void DeathEffect() {
        print("Death");
    }

}
