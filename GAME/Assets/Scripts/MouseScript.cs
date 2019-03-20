using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    Renderer color;

    void Start()
    {
        color = GetComponent<Renderer>();
    }

    
    private void OnMouseOver()
    {
        color.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

}
