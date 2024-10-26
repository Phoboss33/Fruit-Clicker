using UnityEngine;

public class FrozenWatermelon : Watermelon
{
    public override void ShowEffect() {
        base.ShowEffect(); // ����� �������� ����� �� ������ ��� � ������
        // � ����� ������� base.ShowEffect(); � ������� ������ ������
    }

    protected override void DeathEffect() {
        base.DeathEffect(); // ����� ����� �����, ����� �������� ��� ����
        // � ����� ������� base.DeathEffect(); � ����������� ������ ������.
    }
}
