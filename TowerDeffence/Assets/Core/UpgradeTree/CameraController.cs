using UnityEngine;


public class CameraController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _lastMousePosition;


    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);            
        }
    }


    private void FixedUpdate() => transform.position = Vector3.Lerp(transform.position, _lastMousePosition, _speed * Time.fixedDeltaTime);        
}
