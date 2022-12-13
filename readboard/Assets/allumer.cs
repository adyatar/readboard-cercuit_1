using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allumer : MonoBehaviour
{
    public Light mylight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public int cpt = 0;
    public void augmenter()
    {
        cpt++;
        Debug.Log("numero :" + cpt);
        if(cpt==8)
        mylight.enabled = true;
    }
}
