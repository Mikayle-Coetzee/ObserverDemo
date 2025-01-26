using System;

namespace ObserverDemo.Classes
{
    public class WorkerClass
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public WorkerClass() { }

        /// <summary>
        /// Runs the demonstration of the observer pattern implementation.
        /// </summary>
        public void Run()
        {
            // Creating policies and claims
            var policy1 = new PolicyClass("Policy-1");
            var policy2 = new PolicyClass("Policy-2");
            var claim1 = new ClaimClass("Claim-1");
            var claim2 = new ClaimClass("Claim-2");

            // Subscribing policies to claims
            policy1.Subscribe(claim1);
            policy2.Subscribe(claim2);

            // Completing claims
            claim1.Complete();
            claim2.Complete();

            // Unsubscribing policies from claims
            policy1.Unsubscribe(claim1);
            policy2.Unsubscribe(claim2);

            // Completing claims after unsubscribing
            claim1.Complete();
            claim2.Complete();

            Console.ReadLine();
        }
    }
}//★---♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫---★・。。END OF FILE 。。・★---♫ ♬:;;;:♬ ♫:;;;: ♫ ♬:;;;:♬ ♫:;;;: ♫---★//
