

public class Watermelon : Fruit, IShowEffects
{
    private void OnEnable() {
        AudioManager.Instance.PlaySound(_SpawnSound);
        ShowEffect();
    }
    public virtual void ShowEffect() {
        // ����� ����� ������� ������ ��� ������
    }

    protected override void DeathEffect() {
        AudioManager.Instance.PlaySound(_DeathSound);
    }

}
