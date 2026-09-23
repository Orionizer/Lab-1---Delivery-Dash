using Unity.VisualScripting;
using UnityEngine;

public class PackageScript : MonoBehaviour
{
    bool HasPackage = false;
    [SerializeField] private Sprite NoPackageSprite = null;
    [SerializeField] private Sprite HasPackageSprite = null;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (HasPackage == false)
        {
            if (collision.CompareTag("Package"))
            {
                HasPackage = true;
                Debug.Log("Package Collected");
                Destroy(collision.gameObject);
                GetComponent<SpriteRenderer>().sprite = HasPackageSprite;
            }
        }
        else
        {
            if (collision.CompareTag("Delivery"))
            {
                HasPackage = false;
                Debug.Log("Package Delivered");
                GetComponent<SpriteRenderer>().sprite = NoPackageSprite;
            }
        }
    }
}
