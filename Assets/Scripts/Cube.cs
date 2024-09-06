using UnityEngine;

public class Cube : MonoBehaviour
{
    private Material _material;

    public Rigidbody Rigidbody { get; private set; }
    public float ChanseSpawn { get; private set; }

    private void Awake()
    {
        ChanseSpawn = 100f;
        Rigidbody = GetComponent<Rigidbody>();
        _material = GetComponent<Renderer>().material;
    }

    public void Init(Color color, float chanseSpawn)
    {
        int divider = 2;

        ChanseSpawn = chanseSpawn / divider;
        transform.localScale /= divider;
        _material.color = color;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
