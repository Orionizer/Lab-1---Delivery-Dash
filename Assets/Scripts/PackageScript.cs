using System.ComponentModel.Design.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class PackageScript : MonoBehaviour
{
    bool HasPackage = false;
    [SerializeField] private Sprite NoPackageSprite = null;
    [SerializeField] private Sprite HasPackageSprite = null;
    [SerializeField] int PackageHealth = 0;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (HasPackage == false)
        {
            if (collision.CompareTag("Package"))
            {
                HasPackage = true;
                PackageHealth = 3;
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
            if (collision.CompareTag("Obstacle"))
            {
                PackageHealth -= 1;
                if (PackageHealth == 0)
                {
                    HasPackage = false;
                    Debug.Log("Package Destroyed");
                    GetComponent<SpriteRenderer>().sprite = NoPackageSprite;
                }
            }
        }
    }
}
