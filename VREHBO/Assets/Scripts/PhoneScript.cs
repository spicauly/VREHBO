using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VRTK.Examples
{
    public class PhoneScript : VRTK_InteractableObject
    {
        [HideInInspector]
        public bool ambulanceIsCalled;
        public Renderer phoneRenderer;
        public Image warningImage;
        private AudioSource _audioSource;
        public AudioClip correct;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            warningImage.gameObject.SetActive(true);
            ambulanceIsCalled = true;
            _audioSource.PlayOneShot(correct);
            phoneRenderer.enabled = false;
            

        }

        public override void StopUsing(VRTK_InteractUse usingObject)
        {
            base.StopUsing(usingObject);

        }

        protected override void Update()
        {
            base.Update();

        }
    }
}
