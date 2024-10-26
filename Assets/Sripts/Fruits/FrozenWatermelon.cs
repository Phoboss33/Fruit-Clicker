using UnityEngine;

public class FrozenWatermelon : Watermelon
{
    public override void ShowEffect() {
        base.ShowEffect(); // можно оставить такой же эффект как у арбуза
        // а можно удалить base.ShowEffect(); и сделать другой эффект
    }

    protected override void DeathEffect() {
        base.DeathEffect(); // здесь точно также, можно оставить как есть
        // а можно удалить base.DeathEffect(); и реализовать другой эффект.
    }
}
