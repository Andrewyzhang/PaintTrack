using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColorPlatform : MonoBehaviour
{
    SpriteRenderer sprite;
    public int timeBetweenColorChange;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
{
    yield return new WaitForSeconds(timeBetweenColorChange);

    sprite.color = new Color (1, 0, 0, 1);
    yield return new WaitForSeconds(.3f);
    sprite.color = new Color (0, 0, 1, 1);
    yield return new WaitForSeconds(.3f);
    sprite.color = new Color (1, 0, 0, 1);
    yield return new WaitForSeconds(.3f);
    sprite.color = new Color (0, 0, 1, 1);
    yield return new WaitForSeconds(.3f);
    sprite.color = new Color (0, 0, 1, 1);
    yield return new WaitForSeconds(.3f);

    //turns red
    sprite.color = new Color (1, 0, 0, 1);
    gameObject.layer = LayerMask.NameToLayer("Red Platforms");

    yield return new WaitForSeconds(timeBetweenColorChange);

    sprite.color = new Color (0, 0, 1, 1);
    yield return new WaitForSeconds(.3f);
    sprite.color = new Color (1, 0, 0, 1);
    yield return new WaitForSeconds(.3f);
    sprite.color = new Color (0, 0, 1, 1);
    yield return new WaitForSeconds(.3f);
    sprite.color = new Color (1, 0, 0, 1);
    yield return new WaitForSeconds(.3f);
    sprite.color = new Color (1, 0, 0, 1);
    yield return new WaitForSeconds(.3f);


    //turns blue
    sprite.color = new Color (0, 0, 1, 1);
    gameObject.layer = LayerMask.NameToLayer("Blue Platforms");

    StartCoroutine(waiter());
}
}
