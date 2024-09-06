using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;
    [SerializeField] private Camera _camera;
    [SerializeField] private CubeSpawner _cubeSpawner;

    private Ray _ray;
    private float _maxDistance = 100f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(_ray, out RaycastHit hit, _maxDistance, _mask))
            {
                if (hit.collider.TryGetComponent(out Cube cube))
                    _cubeSpawner.Spawn(cube);
            }
        }
    }
}
