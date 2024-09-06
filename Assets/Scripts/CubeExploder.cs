using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CubeExploder : MonoBehaviour
{
    [SerializeField] private ParticleSystem _effect;
    [SerializeField] private float _radius;
    [SerializeField] private float _forse;

    public void Explode(List<Cube> cubes, Vector3 position)
    {
        foreach (Rigidbody cube in cubes.Select(cube => cube.Rigidbody))
        {
            Instantiate(_effect, cube.transform.position, cube.transform.rotation);
            cube.AddExplosionForce(_forse, position, _radius);
        }
    }
}
