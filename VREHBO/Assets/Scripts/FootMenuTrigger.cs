namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.UI;

    public class FootMenuTrigger : VRTK_InteractableObject
    {
        public Animator anim;
        public Image warningImage;
        public bool isClicked;
        public AudioClip soundClip;
        AudioSource audioSource;

        public InjuryCounter injuryCounter;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            anim.SetTrigger("hasClickedFoot");

            if (injuryCounter.count <= 0 && injuryCounter.hasChosenChestOption == false)
            {
                warningImage.gameObject.SetActive(true);
                audioSource.PlayOneShot(soundClip);
                injuryCounter.hasClickedBreathFirst = false;
            }

            isClicked = true;

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
