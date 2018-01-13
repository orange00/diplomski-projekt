using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts {
    class CheckSfxCondition : MonoBehaviour {

        private KeepAlive keepAliveReference;

        private AudioSource buttonSfx;

        private void Start() {
            keepAliveReference = GameObject.Find("AudioManager").GetComponent<KeepAlive>();
            buttonSfx = GetComponent<AudioSource>();
            if (keepAliveReference.Sfx) {
                buttonSfx.enabled = true;
            } else {
                buttonSfx.enabled = false;
            }
        }
    }
}
