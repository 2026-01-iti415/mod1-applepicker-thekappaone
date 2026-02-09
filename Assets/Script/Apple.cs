
using UnityEngine;

public class Apple : MonoBehaviour
{                                   // a
    public static float bottomY = -20f;                             // b

    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

             // Get a reference to the ApplePicker component of Main Camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();           // b
             // Call the public AppleMissed() method of apScript
            apScript.AppleMissed();      // c
        }
    }
}