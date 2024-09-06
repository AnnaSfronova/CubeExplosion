using UnityEngine;

public class Cube : MonoBehaviour
{
    private float _chanseSpawn = 100f;
    private Material _material;

    public Rigidbody Rigidbody { get; private set; }

    public float ChanseSpawn => _chanseSpawn;

    private void Start()
    {
    }

    private void Awake()
    {
        _material = GetComponent<Renderer>().material;
        Rigidbody = GetComponent<Rigidbody>();
    }

    public void Init(Color color)
    {
        int divider = 2;

        _chanseSpawn /= divider;
        transform.localScale /= divider;
        _material.color = color;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
