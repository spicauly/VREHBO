namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.UI;

    public class HeadMenuTrigger : VRTK_InteractableObject
    {
        public Animator anim;
        public Image warningImage;
        public bool isClicked;
        public InjuryCounter injuryCounter;


        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            anim.SetTrigger("hasEntered");

            if (injuryCounter.count <= 0 && injuryCounter.hasChosenChestOption == false)
            {
                warningImage.gameObject.SetActive(true);
                injuryCounter.hasClickedBreathFirst = false;
            }

            isClicked = true;
        }

        public override void StopUsing(VRTK_InteractUse usingObject)
        {
            base.StopUsing(usingObject);

        }
    }
}




