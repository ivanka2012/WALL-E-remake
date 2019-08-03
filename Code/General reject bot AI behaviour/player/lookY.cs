using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookY : MonoBehaviour
{
    [SerializeField]
    private float _sensitivityY = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y");
        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x -= _mouseY * _sensitivityY;
        transform.localEulerAngles = newRotation;

         if (Input.GetKeyDown(KeyCode.F))
                {
                    gameObject.GetComponent<AudioSource>().Play();
                }

         if (Input.GetKeyUp(KeyCode.F))
                {
                    gameObject.GetComponent<AudioSource>().Stop();
                }
    }

   
}
