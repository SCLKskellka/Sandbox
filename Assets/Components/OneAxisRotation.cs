using System;
using UnityEngine;

namespace GameLoopEtHierarchie.Components {
    public class OneAxisRotation : MonoBehaviour {

        public enum Axe {
            X,
            Y,
            Z
        }
        
        [Header("Space Fields")]
        public Axe RotationAxe;
        public Space Space;
        
        [Header("Speed Fields")]
        [Range(-100, 100)] public float CurrentSpeed;
        [Range(0, 100)] public int InputMultiplicator;

        private void FixedUpdate() {
            switch (RotationAxe) {
                case Axe.X:
                    transform.Rotate(CurrentSpeed * Time.deltaTime, 0, 0, Space);
                    break;
                case Axe.Y:
                    transform.Rotate(0, CurrentSpeed * Time.deltaTime, 0, Space);
                    break;
                case Axe.Z:
                    transform.Rotate(0, 0, CurrentSpeed * Time.deltaTime, Space);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void SetSpeed(float speed) {
            CurrentSpeed = speed * InputMultiplicator;
        }
        
    }
}
