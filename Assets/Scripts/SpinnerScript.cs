using Unity.VisualScripting;
using UnityEngine;

public class SpinnerScript : MonoBehaviour
{
    [SerializeField] float SpinSpeed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,SpinSpeed * Time.deltaTime);
    }
}
