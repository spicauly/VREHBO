using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.Examples;

public class InjuryCounter : MonoBehaviour
{
    public float count = 0;
    public float countToEnd = 0;
    public PhoneScript phone;
    public GameObject endResult;
    public GameObject truck;
    public GameObject car;
    public bool hasClickedBreathFirst;
    public bool hasChosenChestOption;
    public GameObject checkboxBreathFirst;
    public GameObject checkBoxAmbulance;
    public GameObject checkBoxHeadInjury;
    public GameObject checkBoxChest;
    public GameObject checkBoxFootInjury;
    public bool calledAmbulance;

    private bool _correctHead;
    private bool _correctChest;
    private bool _correctFoot;

    public void ButtonClicked()
    {
        countToEnd++;
    }

    public void BreathCheckRight()
    {
        hasChosenChestOption = true;
        count++;
    }

    public void BreathCheckWrong()
    {
        count--;
    }

    public void CorrectAnswerHead()
    {
        _correctHead = true;
    }

    public void CorrectAnswerChest()
    {
        _correctChest = true;
    }

    public void CorrectAnswerFoot()
    {
        _correctFoot = true;
    }

    void Update()
    {
        if (count == 1)
        {
            checkboxBreathFirst.SetActive(true);
        }

        if (phone.ambulanceIsCalled == true)
        {
            checkBoxAmbulance.SetActive(true);
            calledAmbulance = true;
        }

        if (_correctHead == true)
        {
            checkBoxHeadInjury.SetActive(true);
        }

        if (_correctChest == true)
        {
            checkBoxChest.SetActive(true);
        }

        if (_correctFoot == true)
        {
            checkBoxFootInjury.SetActive(true);
        }

        if (countToEnd == 3)
        {
            endResult.SetActive(true);
            phone.enabled = false;
            truck.SetActive(false);
            car.SetActive(false);
        }
    }
}
