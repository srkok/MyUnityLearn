using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delay = 0.5f;
    private bool flag = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && flag)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            flag = false;
            Invoke("ResetFlag", delay);
        }
    }

    private void ResetFlag()
    {
        flag = true;
    }
}
