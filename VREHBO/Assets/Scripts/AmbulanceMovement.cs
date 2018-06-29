using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulanceMovement : MonoBehaviour
{

    public InjuryCounter injuryCounter;
    public float speed;
    public Transform target;
    public AudioClip sirenSound;
    private AudioSource _audioSource;
    private bool _soundPlayed = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {

        if (injuryCounter.countToEnd == 3 && injuryCounter.calledAmbulance == true)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            float step = speed * Time.deltaTime;
            gameObject.transform.GetChild(0).transform.position = Vector3.MoveTowards(gameObject.transform.GetChild(0).transform.position, target.position, step);
            if (!_soundPlayed)
            {
                _audioSource.PlayOneShot(sirenSound);
                _soundPlayed = true;
            }
        }
    }
}
