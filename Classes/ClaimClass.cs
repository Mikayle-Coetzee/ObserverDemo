using System;

namespace ObserverDemo.Classes
{
    public class ClaimClass
    {
        public string ClaimId { get; }

        /// <summary>
        ///  Event to be raised when the claim is completed
        /// </summary>
        public event EventHandler<ClaimCompletedEvent> ClaimCompleted;

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="claimId"></param>
        public ClaimClass(string claimId)
        {
            ClaimId = claimId;
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Method to mark the claim as completed
        /// </summary>
        public void Complete()
        {
            Console.WriteLine($"Claim {ClaimId} has been completed.");
            OnClaimCompleted();
        }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Method to raise the claim completed event
        /// </summary>
        protected virtual void OnClaimCompleted()
        {
            ClaimCompleted?.Invoke(this, new ClaimCompletedEvent(ClaimId));
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//

