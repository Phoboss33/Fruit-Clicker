using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public abstract class Fruit : MonoBehaviour
{
    public string fruitName;
    public int points;

    [SerializeField] protected float lifeTime;
    [SerializeField] protected AudioClip _DeathSound;
    [SerializeField] protected AudioClip _SpawnSound;

    protected AudioSource _audioSource;

    private void Awake() {
        _audioSource = GetComponent<AudioSource>();
    }

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
