using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

namespace FoldTheWay.UI
{
    public class GameWindow : Window
    {
        public override bool IsPopup => false;

        protected override void OnEnable()
        {
            base.OnEnable();

            UIJoystick.DragBeginned += UIJoystick_DragBeginned;
        }

        protected override void OnDisable()
        {
            base.OnDisable();

            UIJoystick.DragBeginned -= UIJoystick_DragBeginned;
        }

        public override void OnShow()
        {
            base.OnShow();
        }

        private void UIJoystick_DragBeginned()
        {
            //if (LocalConfig.BasicTutorialNeeded)
            //{
            //    LocalConfig.BasicTutorialNeeded = false;
            //}
        }
    }
}