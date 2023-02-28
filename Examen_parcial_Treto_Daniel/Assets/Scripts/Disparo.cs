using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
   
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 halfScreen = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(halfScreen);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                StartCoroutine(MarkBullet(hit.point));
            }
        }
    }
    private IEnumerator MarkBullet(Vector3 point)
    {
        GameObject bullet = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        bullet.transform.position = point;
        yield return new WaitForSeconds(0.5f);
        Destroy(bullet);
    }
}
