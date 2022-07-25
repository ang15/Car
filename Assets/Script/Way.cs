using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way : MonoBehaviour
{
    public bool move;

    void Update()
    { 
        if (move == false)
        {
          move = true;
          StartCoroutine(Moving()); 
            
        }

        if (transform.localPosition.y <= -3134)
        {
            transform.localPosition = new Vector2(transform.localPosition.x,16);
        }
      
    }
    IEnumerator Moving()
    {
        yield return new WaitForSeconds(1.5f*Time.deltaTime);
        transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y-10);
        move = false;
    }

}
