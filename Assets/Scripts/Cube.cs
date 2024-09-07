using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _chanseSpawn;

    private Material _material;

    public Rigidbody Rigidbody { get; private set; }

    public float ChanseSpawn => _chanseSpawn;

    public void Init(Color color, float chanseSpawn)
    {
        int divider = 2;

        Rigidbody = GetComponent<Rigidbody>();
        _material = GetComponent<Renderer>().material;

        _chanseSpawn = chanseSpawn / divider;
        transform.localScale /= divider;
        _material.color = color;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
