using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrope : MonoBehaviour
{
    public allumer myalumer;
    Vector3 offset;
    public string destinationtag = "DropArea";
    
    private void Start()
    {
       
    }
    void OnMouseDown()
    {
        offset = transform.position - MouseWorldPosition();
        transform.GetComponent<Collider>().enabled = false;
    }
    void OnMouseDrag()
    {
      
        if(transform.tag!="cable2_1")
        transform.GetComponent<MeshRenderer>().material.color = Color.black;
        transform.position = MouseWorldPosition() + offset;
    }
    void OnMouseUp()
    {
        var rayorigine = Camera.main.transform.position;
        var raydirection = MouseWorldPosition() - Camera.main.transform.position;
        RaycastHit hitinfo;
        if (Physics.Raycast(rayorigine, raydirection, out hitinfo))
        {
            if (hitinfo.transform.tag == destinationtag)
            {
                transform.position = hitinfo.transform.position;
            }
        }
        transform.GetComponent<Collider>().enabled = true;
    }
    Vector3 MouseWorldPosition()
    {
        var mouseScreenpos = Input.mousePosition;
        mouseScreenpos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenpos);
    }

    
  private void OnTriggerEnter(Collider other)
    {
       
        transform.GetComponent<MeshRenderer>().material.color = Color.blue;
        FindObjectOfType<allumer>().augmenter();

    }

}
