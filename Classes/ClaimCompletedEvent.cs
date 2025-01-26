using System;

namespace ObserverDemo.Classes
{
    public class ClaimCompletedEvent : EventArgs
    {
        public string ClaimId { get; }

        //・♫-------------------------------------------------------------------------------------------------♫・//
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="claimId"></param>
        public ClaimCompletedEvent(string claimId)
        {
            ClaimId = claimId;
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//
