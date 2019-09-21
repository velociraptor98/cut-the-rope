using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D ray = Physics2D.Raycast(this.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition),Vector2.zero);
            if (ray.collider != null)
            {
                if (ray.collider.tag == "Rope")
                {
                    Destroy(ray.collider.gameObject);
                }
            }
        }
    }
}
