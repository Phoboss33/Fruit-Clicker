using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public abstract class Fruit : MonoBehaviour
{
    public string fruitName;
    public int points;

    [SerializeField] protected float lifeTime;

    private void Start() {
        
        Destroy(gameObject, lifeTime);
    }

    private void OnMouseDown() {
        GameManager.instance.AddPoints(points);
        DeathEffect();
        Destroy(gameObject);
    }

    protected abstract void DeathEffect();
}
