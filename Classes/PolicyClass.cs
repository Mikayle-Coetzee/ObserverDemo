using System;

namespace ObserverDemo.Classes
{
    public class PolicyClass
    {
        public string PolicyNumber { get; }
        public int NumberOfClaims { get; private set; }

        /// <summary>
        /// Event to be raised when a claim is completed
        /// </summary>
        public event EventHandler<ClaimCompletedEvent> ClaimCompleted;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="policyNumber"></param>
        public PolicyClass(string policyNumber)
        {
            PolicyNumber = policyNumber;
            NumberOfClaims = 0;
        }

        /// <summary>
        /// Method to handle claim completion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void HandleClaimCompleted(object sender, ClaimCompletedEvent e)
        {
            Console.WriteLine($"Policy {PolicyNumber}: Claim {e.ClaimId} has been completed.");
            Console.WriteLine();
            NumberOfClaims--;
        }

        /// <summary>
        /// Method to subscribe to claim completion event
        /// </summary>
        /// <param name="claim"></param>
        public void Subscribe(ClaimClass claim)
        {
            claim.ClaimCompleted += HandleClaimCompleted;
        }

        /// <summary>
        /// Method to unsubscribe from claim completion event
        /// </summary>
        /// <param name="claim"></param>
        public void Unsubscribe(ClaimClass claim)
        {
            claim.ClaimCompleted -= HandleClaimCompleted;
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//
