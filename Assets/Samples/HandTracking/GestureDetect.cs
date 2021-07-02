using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Samples.HandTracking
{
    class GestureDetect
    {
        public void DetectGesture(Vector3[] joints, Text text)
        {
            bool thumbIsBent = false;
            bool indexFingerIsBent = false;
            bool longFingerIsBent = false;
            bool ringFingerIsBent = false;
            bool pinkyFingerIsBent = false;

            Vector3 keyPoint = joints[2];
            if (joints[4].y < keyPoint.y && joints[3].y < keyPoint.y)
            {
                thumbIsBent = true;
            }

            keyPoint = joints[6];
            if (joints[8].x > keyPoint.x && joints[7].x > keyPoint.x)
            {
                indexFingerIsBent = true;
            }

            keyPoint = joints[10];
            if (joints[12].x > keyPoint.x && joints[11].x > keyPoint.x)
            {
                longFingerIsBent = true;
            }

            keyPoint = joints[14];
            if (joints[16].x > keyPoint.x && joints[15].x > keyPoint.x)
            {
                ringFingerIsBent = true;
            }

            keyPoint = joints[18];
            if (joints[20].x > keyPoint.x && joints[19].x > keyPoint.x)
            {
                pinkyFingerIsBent = true;
            }

            if (!thumbIsBent && !indexFingerIsBent && !longFingerIsBent && !ringFingerIsBent && !pinkyFingerIsBent)
            {
                text.text = "PAPER";
            } else if (thumbIsBent && indexFingerIsBent && longFingerIsBent && ringFingerIsBent && pinkyFingerIsBent)
            {
                text.text = "ROCK";
            } else if (thumbIsBent && !indexFingerIsBent && !longFingerIsBent && ringFingerIsBent && pinkyFingerIsBent)
            {
                text.text = "SCISSOR";
            }
        }
    }
}
