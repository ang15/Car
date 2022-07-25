using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiPanel : MonoBehaviour
{
    [SerializeField]
    private Transform car;

    public void Moving()
    {
        
        if (0 > Camera.main.ScreenToWorldPoint(Input.mousePosition).x)
        {
            StartCoroutine(OnMoveLeft());
        }
        else
        {
            StartCoroutine(OnMoveRight());
        }
    }

    IEnumerator OnMoveLeft()
    {
        yield return new WaitForSeconds(0.2f * Time.deltaTime);
        while (car.localPosition.x >-185)
        {
            car.transform.localPosition = new Vector2(car.transform.localPosition.x-10, car.transform.localPosition.y);
            yield return new WaitForSeconds(0.2f * Time.deltaTime);
        }
    }
    IEnumerator OnMoveRight()
    {
        yield return new WaitForSeconds(0.2f * Time.deltaTime);
        while (car.localPosition.x < 185)
        {
            car.transform.localPosition = new Vector2(car.transform.localPosition.x + 10, car.transform.localPosition.y);
            yield return new WaitForSeconds(0.2f * Time.deltaTime);

        }

    }
}
