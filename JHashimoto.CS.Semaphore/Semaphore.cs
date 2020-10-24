using System;

namespace JHashimoto.CS.Semaphore {
    public class Semaphore {
        private int semaphoreVariable = 1;

        public int SemaphoreVariable {
            get {
                return semaphoreVariable;
            }
        }

        public void POperation() {
            semaphoreVariable = semaphoreVariable - 1;
        }

        public void VOperation() {

        }
    }
}