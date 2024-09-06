using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;
    [SerializeField] private Camera _camera;
    [SerializeField] private CubeSpawner _cubeSpawner;
    [SerializeField] private CubeExploder _cubeExploder;

    private float _maxDistance = 100f;
    private int _mouseButton = 0;

    private void Update()
    {
        if (Input.GetMouseButtonDown(_mouseButton))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, _maxDistance, _mask))
            {
                if (hit.collider.TryGetComponent(out Cube cube))
                {
                    List<Cube> cubes = _cubeSpawner.Spawn(cube);

                    if (cubes.Count > 0)
                        _cubeExploder.Explode(cubes, cube.transform.position);

                    cube.Destroy();
                }
            }
        }
    }
}
