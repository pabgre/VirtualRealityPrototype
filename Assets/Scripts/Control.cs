using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public Transform scan1 = null;
    public Transform scan2 = null;
    public Transform scan3 = null;

    public ObjectPlacer objPlacer = null;
    
    // Start is called before the first frame update
    void Start()
    {
        scan1.gameObject.SetActive(true);
        scan2.gameObject.SetActive(false);
        scan3.gameObject.SetActive(false);
        objPlacer.scan = scan1.Find("Gizmos").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (Transform child in scan1.Find("Gizmos").transform) {
                GameObject.Destroy(child.gameObject);
            }
            scan1.gameObject.SetActive(true);
            scan2.gameObject.SetActive(false);
            scan3.gameObject.SetActive(false);
            objPlacer.scan = scan1.Find("Gizmos").transform;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            foreach (Transform child in scan2.Find("Gizmos").transform) {
                GameObject.Destroy(child.gameObject);
            }
            scan1.gameObject.SetActive(false);
            scan2.gameObject.SetActive(true);
            scan3.gameObject.SetActive(false);
            objPlacer.scan = scan2.Find("Gizmos").transform;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (Transform child in scan3.Find("Gizmos").transform) {
                GameObject.Destroy(child.gameObject);
            }
            scan1.gameObject.SetActive(false);
            scan2.gameObject.SetActive(false);
            scan3.gameObject.SetActive(true);
            objPlacer.scan = scan3.Find("Gizmos").transform;
        }
    }
}
