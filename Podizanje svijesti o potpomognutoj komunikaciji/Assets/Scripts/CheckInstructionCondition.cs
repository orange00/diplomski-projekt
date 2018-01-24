using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts {
    public class CheckInstructionCondition : MonoBehaviour {
        private KeepAlive keepAliveReference;

        public GameObject instructionCanvas;

        private void Start() {
            keepAliveReference = GameObject.Find("AudioManager").GetComponent<KeepAlive>();
            Debug.Log(keepAliveReference.Instructions);
            if (keepAliveReference.Instructions) {
                instructionCanvas.SetActive(true);
            } else {
                instructionCanvas.SetActive(false);
            }
        }
    }
}
