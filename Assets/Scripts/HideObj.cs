using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObj : MonoBehaviour {


    public GameObject item;
    private void OnTriggerEnter(Collider other)
    {
        item.SetActive(false);
    }
}
