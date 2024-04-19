using System;
using System.Collections;
using UnityEngine;

public class MoveFrogger : MonoBehaviour
{
    private static readonly float COOLDOWN = 0.25f;
    private bool _isCoolingDown = false;
    public GameObject frogSprite;

    void Update()
    {
        if (_isCoolingDown)
        {
            return;
        }

        var horiz = Input.GetAxis("Horizontal");
        var vert = Input.GetAxis("Vertical");

        if (Mathf.Abs(vert) > 0 || Mathf.Abs(horiz) > 0)
        {
            Vector3 movementDirection = new Vector3(horiz, 0, vert).normalized;

            if (movementDirection != Vector3.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
                frogSprite.transform.rotation = Quaternion.RotateTowards(frogSprite.transform.rotation, toRotation, 360f);
            }

            StartCoroutine(Move(movementDirection));
        }
    }

    IEnumerator Move(Vector3 direction)
    {
        _isCoolingDown = true;
        transform.Translate(direction * 1f, Space.World);
        yield return new WaitForSeconds(COOLDOWN);
        _isCoolingDown = false;
    }
}
