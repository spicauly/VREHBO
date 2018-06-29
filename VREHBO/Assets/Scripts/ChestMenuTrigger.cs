namespace VRTK.Examples
{
    using UnityEngine;

    public class ChestMenuTrigger : VRTK_InteractableObject
    {
        public Animator anim;
        public InjuryCounter injuryCounter;
        public bool isClicked;


        private void Start()
        {
            injuryCounter = FindObjectOfType<InjuryCounter>();
        }

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            anim.SetTrigger("hasClickedChest");

            if (injuryCounter.count == 0 && injuryCounter.countToEnd == 0)
            {
                injuryCounter.hasClickedBreathFirst = true;
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
