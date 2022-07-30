using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField]
    private Transform car;

    public void Moving()
    {
        
        if (car.position.x > Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
        {
            StartCoroutine(OnMoveLeft());
        }
        else
        {
            StartCoroutine(OnMoveRight());
        }
    }

    private IEnumerator OnMoveLeft()
    {
        yield return new WaitForSeconds(0.2f * Time.deltaTime);
        car.transform.localPosition = new Vector2(car.transform.localPosition.x +10, car.transform.localPosition.y);
        while (car.localPosition.x >-220 || car.localPosition.x==0)
        {
            car.transform.localPosition = new Vector2(car.transform.localPosition.x-10, car.transform.localPosition.y);
            yield return new WaitForSeconds(0.2f * Time.deltaTime);
        }
    }
    private IEnumerator OnMoveRight()
    {
        yield return new WaitForSeconds(0.2f * Time.deltaTime);
        car.transform.localPosition = new Vector2(car.transform.localPosition.x + 10, car.transform.localPosition.y);
        while (car.localPosition.x < 220 || car.localPosition.x == 0)
        {
            car.transform.localPosition = new Vector2(car.transform.localPosition.x + 10, car.transform.localPosition.y);
            yield return new WaitForSeconds(0.2f * Time.deltaTime);

        }

    }
}
