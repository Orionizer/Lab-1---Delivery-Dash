using UnityEngine;

public class PackageScript : MonoBehaviour
{
    bool HasPackage = false;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (HasPackage == false)
        {
            if (collision.CompareTag("Package"))
            {
                HasPackage = true;
                Debug.Log("Package Collected");
                Destroy(collision.gameObject);
                GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }
        else
        {
            if (collision.CompareTag("Delivery"))
            {
                HasPackage = false;
                Debug.Log("Package Delivered");
                GetComponent<SpriteRenderer>().color = Color.white;
            }
        }
    }
}
