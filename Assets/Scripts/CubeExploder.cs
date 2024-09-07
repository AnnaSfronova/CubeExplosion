using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CubeExploder : MonoBehaviour
{
    [SerializeField] private ParticleSystem _effect;
    [SerializeField] private float _radius;
    [SerializeField] private float _forse;

    public void ExplodeSplittedCube(List<Cube> cubes, Vector3 position)
    {
        foreach (Rigidbody cube in cubes.Select(cube => cube.Rigidbody))
        {
            Instantiate(_effect, cube.transform.position, cube.transform.rotation);
            cube.AddExplosionForce(_forse, position, _radius);
        }
    }

    public void ExplodeUnsplittedCube(Cube cube)
    {
        Collider[] colliders = Physics.OverlapSphere(cube.transform.position, _radius);

        Instantiate(_effect, cube.transform.position, cube.transform.rotation);

        foreach (Rigidbody rigidbody in colliders.Select(collider => collider.attachedRigidbody))
        {
            if (rigidbody)
                rigidbody.AddExplosionForce(_forse, transform.position, _radius);
        }
    }
}
