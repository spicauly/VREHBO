using System.Collections;
using UnityEngine;
using VRTK.Examples;

public class ShowMenu : MonoBehaviour
{
    public HeadMenuTrigger headMenu;
    public ChestMenuTrigger chestMenu;
    public FootMenuTrigger footMenu;
    public PhoneScript phoneMenu;

    private void Update()
    {
        if (headMenu.isClicked == true)
        {
            StartCoroutine(ActivationRoutine());
        }

        if (chestMenu.isClicked == true)
        {
            StartCoroutine(ActivationRoutine());
        }

        if (footMenu.isClicked == true)
        {
            StartCoroutine(ActivationRoutine());
        }

        if (phoneMenu.ambulanceIsCalled == true)
        {
            StartCoroutine(ActivationRoutine());
        }

    }

    private IEnumerator ActivationRoutine()
    {
        yield return new WaitForSeconds(5);

        gameObject.SetActive(false);
    }

}
