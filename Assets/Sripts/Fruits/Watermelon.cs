

public class Watermelon : Fruit, IShowEffects
{
    private void OnEnable() {
        AudioManager.Instance.PlaySound(_SpawnSound);
        ShowEffect();
    }
    public virtual void ShowEffect() {
        // здесь можно сделать эффект для арбуза
    }

    protected override void DeathEffect() {
        AudioManager.Instance.PlaySound(_DeathSound);
    }

}
