
public class Avocado : Fruit {
    private void OnEnable() {
        AudioManager.Instance.PlaySound(_SpawnSound);
    }
    protected override void DeathEffect() {
        AudioManager.Instance.PlaySound(_DeathSound);
    }
}
